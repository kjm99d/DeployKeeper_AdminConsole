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

                MessageBox.Show("�������Դϴ�.", "�˸�");
                Form frmMain = new FrmMain();
                Hide();
                frmMain.ShowDialog();

                Environment.Exit(0); // ���μ��� ����
            }

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

            APIConnect handler = APIConnect.Instance;

            if (true == handler.Login("adminUser", "adminpassword1234!@#$qwer"))
            {

                // MessageBox.Show("�������Դϴ�.", "�˸�");
                Form frmMain = new FrmMain();
                Hide();
                frmMain.ShowDialog();

                Environment.Exit(0); // ���μ��� ����
            }

        }
    }
}
