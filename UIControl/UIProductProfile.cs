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

        public UIProductProfile()
        {
            InitializeComponent();
        }

        private void UIProductProfile_Load(object sender, EventArgs e)
        {

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
            JArray? policies = null;


            JObject resp = APIConnect.Instance.GetProductPolicy(nIdProduct);
            if (0 == Convert.ToInt32(resp["code"]))
            {
                policies = (JArray)resp["data"];
            }


            if (null != policies)
            {
                foreach (var policy in policies)
                {
                    ListViewItem item = new ListViewItem(policy["id"].ToString());
                    item.SubItems.Add(policy["policy_name"].ToString());

                    listView1.Items.Add(item);
                }
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
                MessageBox.Show("정책이 추가에 실패하였습니다.");
        }
    }
}
