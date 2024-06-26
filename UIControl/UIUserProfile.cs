﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DeployKeeper_AdminConsole
{
    public partial class UIUserProfile : UserControl
    {
        private JObject m_user;
        private List<JObject> m_policy;
        private List<JObject> m_policy_after;

        private int m_nIdUser;
        private int m_nIdProduct;


        public UIUserProfile()
        {
            InitializeComponent();
        }

        private void UserProfile_Load(object sender, EventArgs e)
        {

        }

        private void CreateModifyPolicy()
        {
            RestoreUserPolicy();
        }

        private void RestoreUserPolicy()
        {
            if (m_policy_after == null)
            {
                m_policy_after = new List<JObject>();
            }
            else
            {
                m_policy_after.Clear(); // 기존에 있던 내용 삭제
            }

            m_policy_after.AddRange(m_policy.Select(item => (JObject)item.DeepClone()));

            UpdatePolicyView();
        }


        private void GetUserPolicy(int nUserId, int nProductId)
        {
            JObject obj = APIConnect.Instance.GetUserPolicy(nUserId, nProductId);

            int nResultCode = Convert.ToInt32(obj["code"]);
            switch (nResultCode)
            {
                case 0:
                    m_policy = ((JArray)obj["data"]).ToObject<List<JObject>>();
                    break;

                default:
                    m_policy = new List<JObject>();
                    break;
            }

        }

        public void SetUserDate(string start, string end, string alias)
        {
            dtStart.Text = start;
            dtEnd.Text = end;
            tbAlias.Text = alias;
        }

        public void SetUser(JObject user)
        {
            m_user = user;

            m_nIdUser = Convert.ToInt32(m_user["user_id"]);
            m_nIdProduct = Convert.ToInt32(m_user["product_id"]);

            tbReadOnlyUserId.Text = m_user["username"].ToString();
            tbReadOnlyUserPasswd.Text = m_user["passwd"].ToString();
            tbReadOnlyProductId.Text = m_user["product_id"].ToString();
            tbReadOnlyProductName.Text = m_user["product_name"].ToString();

            // 정책 가져오기
            GetUserPolicy(m_nIdUser, m_nIdProduct);
            CreateModifyPolicy();

            // 리스트뷰 채우기
            UpdatePolicyView();

        }

        private void UpdatePolicyView()
        {
            lvCustomPolicy.Items.Clear();

            foreach (var policy in m_policy_after)
            {
                ListViewItem item = new ListViewItem();
                item.Text = "";
                item.SubItems.Add(policy["policy_name"].ToString());
                item.SubItems.Add("");
                item.SubItems.Add(policy["policy_value"].ToString());

                lvCustomPolicy.Items.Add(item);
            }
        }

        // 모든 UI 컨트롤들의 내용을 초기화 시킨다.
        public void Clear()
        {
            // 사용자 계정 정보
            tbReadOnlyUserId.Text = string.Empty;
            tbReadOnlyUserPasswd.Text = string.Empty;
            tbReadOnlyProductId.Text = string.Empty;
            tbReadOnlyProductName.Text = string.Empty;

            // 사용자 정책
            lvCustomPolicy.Items.Clear();
        }

        private void lvCustomPolicy_DoubleClick(object sender, EventArgs e)
        {
            if (lvCustomPolicy.SelectedItems.Count == 1)
            {
                FrmCustomPolicyModify form = new FrmCustomPolicyModify();

                int index = lvCustomPolicy.SelectedIndices[0];
                JObject obj = m_policy[index];
                form.SetData(obj);

                if (DialogResult.OK == form.ShowDialog())
                {
                    m_policy_after[index]["policy_value"] = form.GetPolicyValue();
                    UpdatePolicyView();

                    // 한번이라도 정책이 수정된 경우 취소 버튼을 활성화 시킨다.
                    if (false == btnCancel.Enabled)
                    {
                        btnCancel.Enabled = true;
                    }
                }
            }
        }

        private void lvCustomPolicy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            // 적용 버튼을 누른 경우, 정책정보를 서버로 전달한다.
            APIConnect.Instance.SetUserPolicy(m_nIdUser, m_nIdProduct, m_policy_after);


            string start = dtStart.Value.ToShortDateString();
            string end = dtEnd.Value.ToShortDateString();
            string alias = tbAlias.Text;
            List<string> list = new List<string>();
            list.Add(start);
            list.Add(end);

            APIConnect.Instance.SetUserExpirationDate(m_nIdUser, m_nIdProduct, list, alias);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // 취소 버튼을 누른 경우 정책을 원상복구 시키고 취소 버튼을 비활성화한다.
            RestoreUserPolicy();
            btnCancel.Enabled = false;
        }

        private void btnExportUserPolicy_Click(object sender, EventArgs e)
        {
            // List<JObject>를 JArray로 변환
            JArray jArray = new JArray(m_policy_after);

            // SaveFileDialog 생성 및 설정
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*",
                Title = "Save JSON File"
            };

            // 파일 저장 대화상자를 표시
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // 선택된 경로에 JArray를 JSON 파일로 저장
                string filePath = saveFileDialog.FileName;
                File.WriteAllText(filePath, jArray.ToString());

                // 저장 완료 메시지 출력 (optional)
                Console.WriteLine($"JArray가 {filePath}에 저장되었습니다.");
            }
            else
            {
                // 저장 취소 메시지 출력 (optional)
                Console.WriteLine("파일 저장이 취소되었습니다.");
            }

        }

        private void btnLoadUserPolicy_Click(object sender, EventArgs e)
        {

            // JSON 파일을 불러오기 위해 OpenFileDialog 사용
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*",
                Title = "Open JSON File"
            };


            // 파일 열기 대화상자를 표시
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // 선택된 파일 경로
                string filePath = openFileDialog.FileName;

                try
                {
                    // 파일 내용을 읽어 JArray로 변환
                    string fileContent = File.ReadAllText(filePath);
                    JArray jArray = JArray.Parse(fileContent);

                    // 불러온 JArray 출력 (optional)
                    Console.WriteLine("JArray 불러오기 성공:");
                    Console.WriteLine(jArray.ToString());

                    // === Validate 로직 필요 === // 

                    m_policy = jArray.ToObject<List<JObject>>();
                    RestoreUserPolicy();
                    // ========================== //
                }
                catch (Exception ex)
                {
                    // 오류 발생 시 메시지 출력
                    Console.WriteLine("파일을 불러오는 중 오류가 발생했습니다:");
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                // 불러오기 취소 메시지 출력 (optional)
                Console.WriteLine("파일 불러오기가 취소되었습니다.");
            }
        }
    }
}
