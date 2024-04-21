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
            int nIdProduct = Convert.ToInt32(strProductID);
            GetProductPolicy(nIdProduct);

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

    }
}
