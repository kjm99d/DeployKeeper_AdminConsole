using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IdentityModel.Tokens.Jwt;

namespace DeployKeeper_AdminConsole
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            APIConnect handler = APIConnect.Instance;

            if (true == handler.Login(tbUserId.Text, tbUserPw.Text))
            {

                MessageBox.Show("관리자입니다.", "알림");
                Form frmMain = new FrmMain();
                Hide();
                frmMain.ShowDialog();

                Environment.Exit(0); // 프로세스 종료
            }

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

            APIConnect handler = APIConnect.Instance;

            if (true == handler.Login("adminUser", "adminpassword1234!@#$qwer"))
            {

                // MessageBox.Show("관리자입니다.", "알림");
                Form frmMain = new FrmMain();
                Hide();
                frmMain.ShowDialog();

                Environment.Exit(0); // 프로세스 종료
            }

        }
    }
}
