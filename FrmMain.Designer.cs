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
            pnUserProfile = new Panel();
            btnAddProduct = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // tvUserProfile
            // 
            tvUserProfile.Location = new Point(12, 12);
            tvUserProfile.Name = "tvUserProfile";
            tvUserProfile.Size = new Size(312, 569);
            tvUserProfile.TabIndex = 3;
            tvUserProfile.AfterSelect += treeView1_AfterSelect;
            // 
            // pnUserProfile
            // 
            pnUserProfile.BorderStyle = BorderStyle.FixedSingle;
            pnUserProfile.Location = new Point(330, 12);
            pnUserProfile.Name = "pnUserProfile";
            pnUserProfile.Size = new Size(725, 611);
            pnUserProfile.TabIndex = 5;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(12, 587);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(128, 32);
            btnAddProduct.TabIndex = 6;
            btnAddProduct.Text = "제품추가";
            btnAddProduct.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(196, 587);
            button2.Name = "button2";
            button2.Size = new Size(128, 32);
            button2.TabIndex = 7;
            button2.Text = "선택제품 삭제";
            button2.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1074, 638);
            Controls.Add(button2);
            Controls.Add(btnAddProduct);
            Controls.Add(tvUserProfile);
            Controls.Add(pnUserProfile);
            Name = "FrmMain";
            Text = "DeployKeeper AdminConsole - 제어판";
            Load += FrmMain_Load;
            ResumeLayout(false);
        }

        #endregion
        private TreeView tvUserProfile;
        private Panel pnUserProfile;
        private Button btnAddProduct;
        private Button button2;
    }
}