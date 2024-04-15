using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DeployKeeper_AdminConsole
{
    public partial class FrmMain : Form
    {
        private UserProfileManager profileManager;
        private UserProfile profile;



        public FrmMain()
        {
            InitializeComponent();
            profileManager = new UserProfileManager(tvUserProfile);
            profile = new UserProfile();
            
        }


        private void FrmMain_Load(object sender, EventArgs e)
        {
            profileManager.SetUserProfile(userProfile1);
            profileManager.Update();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
