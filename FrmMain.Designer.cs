namespace DeployKeeper_AdminConsole
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tvUserProfile = new TreeView();
            button1 = new Button();
            pnUserProfile = new Panel();
            userProfile1 = new UserProfile();
            pnUserProfile.SuspendLayout();
            SuspendLayout();
            // 
            // tvUserProfile
            // 
            tvUserProfile.Location = new Point(12, 12);
            tvUserProfile.Name = "tvUserProfile";
            tvUserProfile.Size = new Size(312, 611);
            tvUserProfile.TabIndex = 3;
            tvUserProfile.AfterSelect += treeView1_AfterSelect;
            // 
            // button1
            // 
            button1.Location = new Point(1061, 12);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pnUserProfile
            // 
            pnUserProfile.BorderStyle = BorderStyle.FixedSingle;
            pnUserProfile.Controls.Add(userProfile1);
            pnUserProfile.Location = new Point(330, 12);
            pnUserProfile.Name = "pnUserProfile";
            pnUserProfile.Size = new Size(725, 611);
            pnUserProfile.TabIndex = 5;
            // 
            // userProfile1
            // 
            userProfile1.BackColor = SystemColors.Window;
            userProfile1.Location = new Point(3, 3);
            userProfile1.Name = "userProfile1";
            userProfile1.Size = new Size(717, 603);
            userProfile1.TabIndex = 0;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1208, 638);
            Controls.Add(pnUserProfile);
            Controls.Add(button1);
            Controls.Add(tvUserProfile);
            Name = "FrmMain";
            Text = "DeployKeeper AdminConsole - 제어판";
            Load += FrmMain_Load;
            pnUserProfile.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TreeView tvUserProfile;
        private Button button1;
        private Panel pnUserProfile;
        private UserProfile userProfile1;
    }
}