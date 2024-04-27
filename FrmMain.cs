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
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DeployKeeper_AdminConsole
{
    public partial class FrmMain : Form
    {
        private UserProfileManager profileManager;
        private UIUserProfile userProfile;
        private UIProductProfile productProfile;



        public FrmMain()
        {
            InitializeComponent();
            profileManager = new UserProfileManager(tvUserProfile);
            userProfile = new UIUserProfile();
            pnUserProfile.Controls.Add(userProfile);

            productProfile = new UIProductProfile();
            pnUserProfile.Controls.Add(productProfile);

        }


        private void FrmMain_Load(object sender, EventArgs e)
        {
            profileManager.SetUserProfile(userProfile);
            profileManager.SetProductProfile(productProfile);
            profileManager.SetRemoveProductButton(btnRemoveProduct);
            profileManager.Update();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            string strProductName = tbNewProductName.Text;
            JObject result = APIConnect.Instance.AddProduct(strProductName);
            int nResultCode = Convert.ToInt32(result["code"]);
            switch (nResultCode)
            {
                case 0:
                    MessageBox.Show("제품추가에 성공하였습니다.");
                    profileManager.Update();
                    break;
                case 301:
                    MessageBox.Show("이미 존재하는 제품명입니다.");
                    break;
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            profileManager.Update();
        }
    }
}
