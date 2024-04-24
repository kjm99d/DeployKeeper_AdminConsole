using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeployKeeper_AdminConsole
{
    public partial class UIProductProfile : UserControl
    {
        private int m_nIdProduct;
        private List<JObject> m_productPolicy;

        public UIProductProfile()
        {
            InitializeComponent();
        }

        private void UIProductProfile_Load(object sender, EventArgs e)
        {
            if (null ==  m_productPolicy)
                m_productPolicy = new List<JObject>();
        }

        public void SetProductInfo(string strProductName, string strProductID)
        {
            tbReadOnlyProductName.Text = strProductName;
            tbReadOnlyProductID.Text = strProductID;

            // 정책을 가져온 후 UI에 반영한다.
            m_nIdProduct = Convert.ToInt32(strProductID);
            GetProductPolicy(m_nIdProduct);

        }

        private void GetProductPolicy(int nIdProduct)
        {
            listView1.Items.Clear();
            m_productPolicy.Clear();

            JObject resp = APIConnect.Instance.GetProductPolicy(nIdProduct);
            if (0 == Convert.ToInt32(resp["code"]))
            {
                m_productPolicy = ((JArray)resp["data"]).ToObject<List<JObject>>();
            }

            foreach (var policy in m_productPolicy)
            {
                ListViewItem item = new ListViewItem(policy["id"].ToString());
                item.SubItems.Add(policy["policy_name"].ToString());

                listView1.Items.Add(item);
            }

        }

        private void btnAddPolicy_Click(object sender, EventArgs e)
        {
            string strPolicyName = tbPolicyName.Text;
            if (strPolicyName.Length == 0)
            {
                MessageBox.Show("정책명이 유효하지 않습니다.");
                return;
            }

            JObject result = APIConnect.Instance.AddProductPolicy(m_nIdProduct, strPolicyName);
            int nResultCode = Convert.ToInt32(result["code"]);
            if (0 == nResultCode)
            {
                GetProductPolicy(m_nIdProduct);
                tbPolicyName.Text = string.Empty;
                MessageBox.Show("정책이 성공적으로 추가되었습니다.");
            }
            else
                MessageBox.Show("정책추가에 실패하였습니다.");
        }

        private void btnDeletePolicy_Click(object sender, EventArgs e)
        {
            var indicies = listView1.SelectedIndices;
            if (indicies.Count > 0)
            {
                int nIndex = indicies[0];
                
                JObject obj = m_productPolicy[nIndex];
                int nIdPolicy = Convert.ToInt32(obj["id"]);

                JObject result = APIConnect.Instance.DeleteProductPolicy(m_nIdProduct, nIdPolicy);
                int nResultCode = Convert.ToInt32(result["code"]);
                if (0 == nResultCode)
                {
                    GetProductPolicy(m_nIdProduct);
                    MessageBox.Show("정책이 성공적으로 삭제되었습니다.");
                }
                else
                {
                    MessageBox.Show("정책삭제에 실패하였습니다.");
                }
            }
        }
    }
}
