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
            tbNewProductName = new TextBox();
            btnRemoveProduct = new Button();
            btnRefresh = new Button();
            SuspendLayout();
            // 
            // tvUserProfile
            // 
            tvUserProfile.Location = new Point(12, 41);
            tvUserProfile.Name = "tvUserProfile";
            tvUserProfile.Size = new Size(312, 524);
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
            btnAddProduct.Location = new Point(196, 571);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(128, 23);
            btnAddProduct.TabIndex = 6;
            btnAddProduct.Text = "제품추가";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // tbNewProductName
            // 
            tbNewProductName.Location = new Point(12, 571);
            tbNewProductName.Name = "tbNewProductName";
            tbNewProductName.PlaceholderText = "새로 추가할 제품명";
            tbNewProductName.Size = new Size(178, 23);
            tbNewProductName.TabIndex = 8;
            tbNewProductName.TextAlign = HorizontalAlignment.Center;
            // 
            // btnRemoveProduct
            // 
            btnRemoveProduct.Enabled = false;
            btnRemoveProduct.Location = new Point(196, 600);
            btnRemoveProduct.Name = "btnRemoveProduct";
            btnRemoveProduct.Size = new Size(128, 23);
            btnRemoveProduct.TabIndex = 7;
            btnRemoveProduct.Text = "선택제품 삭제";
            btnRemoveProduct.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(12, 12);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(312, 23);
            btnRefresh.TabIndex = 9;
            btnRefresh.Text = "새로고침";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(1074, 638);
            Controls.Add(btnRefresh);
            Controls.Add(tbNewProductName);
            Controls.Add(btnRemoveProduct);
            Controls.Add(btnAddProduct);
            Controls.Add(tvUserProfile);
            Controls.Add(pnUserProfile);
            Name = "FrmMain";
            Text = "DeployKeeper AdminConsole - 제어판";
            Load += FrmMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TreeView tvUserProfile;
        private Panel pnUserProfile;
        private Button btnAddProduct;
        private TextBox tbNewProductName;
        private Button btnRemoveProduct;
        private Button btnRefresh;
    }
}