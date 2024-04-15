using Newtonsoft.Json.Linq;
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

namespace DeployKeeper_AdminConsole
{
    public partial class UserProfile : UserControl
    {
        private JObject m_user;
        private List<JObject> m_policy;
        

        public UserProfile()
        {
            InitializeComponent();
        }

        private void UserProfile_Load(object sender, EventArgs e)
        {

        }

        private void GetUserPolicy(int nUserId, int nProductId)
        {
            JObject obj = APIConnect.Instance.GetUserPolicy(nUserId, nProductId);
            if (0 == Convert.ToInt32(obj["code"]))
            {
                m_policy = ((JArray)obj["data"]).ToObject<List<JObject>>();
            }

        }

        public void SetUser(JObject user)
        {
            m_user = user;

            tbReadOnlyUserId.Text = m_user["username"].ToString();
            tbReadOnlyUserPasswd.Text = m_user["passwd"].ToString();
            tbReadOnlyProductId.Text = m_user["product_id"].ToString();
            tbReadOnlyProductName.Text = m_user["product_name"].ToString();

            // 정책 가져오기
            GetUserPolicy(Convert.ToInt32(m_user["nId"]), Convert.ToInt32(m_user["product_id"]));

            foreach (var policy in m_policy)
            {
                ListViewItem item = new ListViewItem();
                item.Text = policy["policy_name"].ToString();
                item.SubItems.Add(policy["policy_name"].ToString());
                item.SubItems.Add(policy["policy_value"].ToString());

                lvCustomPolicy.Items.Add(item);
            }

        }

        // 모든 UI 컨트롤들의 내용을 초기화 시킨다.
        public void Clear()
        {
            // 사용자 계정 정보
            tbReadOnlyUserId.Text      = string.Empty;
            tbReadOnlyUserPasswd.Text  = string.Empty;
            tbReadOnlyProductId.Text   = string.Empty;
            tbReadOnlyProductName.Text = string.Empty;

            // 사용자 정책
            lvCustomPolicy.Items.Clear();
        }
    }
}
