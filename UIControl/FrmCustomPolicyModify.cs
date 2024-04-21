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
    public partial class FrmCustomPolicyModify : Form
    {

        public FrmCustomPolicyModify()
        {
            InitializeComponent();
        }

        public void SetData(JObject obj)
        {
            tbPolicyName.Text = obj["policy_name"].ToString();
            tbPolicyValue.Text = obj["policy_value"].ToString();
        }


        public string GetPolicyValue()
        {
            return tbPolicyValue.Text;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {

        }
    }
}
