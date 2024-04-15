namespace DeployKeeper_AdminConsole
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnLogin = new Button();
            tbUserPw = new TextBox();
            tbUserId = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnLogin);
            groupBox1.Controls.Add(tbUserPw);
            groupBox1.Controls.Add(tbUserId);
            groupBox1.Location = new Point(12, 156);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(343, 119);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "로그인 정보";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(6, 80);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(320, 23);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "로그인";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // tbUserPw
            // 
            tbUserPw.Location = new Point(6, 51);
            tbUserPw.Name = "tbUserPw";
            tbUserPw.PasswordChar = '*';
            tbUserPw.PlaceholderText = "관리자 PW";
            tbUserPw.Size = new Size(320, 23);
            tbUserPw.TabIndex = 1;
            tbUserPw.TextAlign = HorizontalAlignment.Center;
            // 
            // tbUserId
            // 
            tbUserId.Location = new Point(6, 22);
            tbUserId.Name = "tbUserId";
            tbUserId.PlaceholderText = "관리자 ID";
            tbUserId.Size = new Size(320, 23);
            tbUserId.TabIndex = 0;
            tbUserId.TextAlign = HorizontalAlignment.Center;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 287);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DeployKeeper AdminConsole - 로그인";
            Load += FrmLogin_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnLogin;
        private TextBox tbUserPw;
        private TextBox tbUserId;
    }
}
