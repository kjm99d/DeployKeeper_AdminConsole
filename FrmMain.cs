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
            profileManager.Update();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
