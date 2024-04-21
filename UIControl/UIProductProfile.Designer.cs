namespace DeployKeeper_AdminConsole
{
    partial class UIProductProfile
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            listView1 = new ListView();
            chProductPolicyId = new ColumnHeader();
            chProductPolicyName = new ColumnHeader();
            btnAddPolicy = new Button();
            btnDeletePolicy = new Button();
            tbPolicyName = new TextBox();
            label1 = new Label();
            tbReadOnlyProductName = new TextBox();
            tbReadOnlyProductID = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { chProductPolicyId, chProductPolicyName });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(3, 119);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(712, 248);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // chProductPolicyId
            // 
            chProductPolicyId.Width = 0;
            // 
            // chProductPolicyName
            // 
            chProductPolicyName.Text = "정책명";
            chProductPolicyName.TextAlign = HorizontalAlignment.Center;
            chProductPolicyName.Width = 700;
            // 
            // btnAddPolicy
            // 
            btnAddPolicy.Location = new Point(505, 373);
            btnAddPolicy.Name = "btnAddPolicy";
            btnAddPolicy.Size = new Size(103, 23);
            btnAddPolicy.TabIndex = 1;
            btnAddPolicy.Text = "정책 추가";
            btnAddPolicy.UseVisualStyleBackColor = true;
            btnAddPolicy.Click += btnAddPolicy_Click;
            // 
            // btnDeletePolicy
            // 
            btnDeletePolicy.Location = new Point(614, 373);
            btnDeletePolicy.Name = "btnDeletePolicy";
            btnDeletePolicy.Size = new Size(103, 23);
            btnDeletePolicy.TabIndex = 2;
            btnDeletePolicy.Text = "선택정책 삭제";
            btnDeletePolicy.UseVisualStyleBackColor = true;
            btnDeletePolicy.Click += btnDeletePolicy_Click;
            // 
            // tbPolicyName
            // 
            tbPolicyName.BorderStyle = BorderStyle.FixedSingle;
            tbPolicyName.Font = new Font("맑은 고딕", 9F, FontStyle.Regular, GraphicsUnit.Point, 129);
            tbPolicyName.Location = new Point(3, 373);
            tbPolicyName.Name = "tbPolicyName";
            tbPolicyName.PlaceholderText = "정책명";
            tbPolicyName.Size = new Size(496, 23);
            tbPolicyName.TabIndex = 3;
            tbPolicyName.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 11);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 4;
            label1.Text = "제품명";
            // 
            // tbReadOnlyProductName
            // 
            tbReadOnlyProductName.Location = new Point(3, 29);
            tbReadOnlyProductName.Name = "tbReadOnlyProductName";
            tbReadOnlyProductName.ReadOnly = true;
            tbReadOnlyProductName.Size = new Size(150, 23);
            tbReadOnlyProductName.TabIndex = 5;
            // 
            // tbReadOnlyProductID
            // 
            tbReadOnlyProductID.Location = new Point(3, 73);
            tbReadOnlyProductID.Name = "tbReadOnlyProductID";
            tbReadOnlyProductID.ReadOnly = true;
            tbReadOnlyProductID.Size = new Size(150, 23);
            tbReadOnlyProductID.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 55);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 6;
            label2.Text = "제품 ID";
            // 
            // UIProductProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            Controls.Add(tbReadOnlyProductID);
            Controls.Add(label2);
            Controls.Add(tbReadOnlyProductName);
            Controls.Add(label1);
            Controls.Add(tbPolicyName);
            Controls.Add(btnDeletePolicy);
            Controls.Add(btnAddPolicy);
            Controls.Add(listView1);
            Name = "UIProductProfile";
            Size = new Size(720, 600);
            Load += UIProductProfile_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private ColumnHeader chProductPolicyId;
        private ColumnHeader chProductPolicyName;
        private Button btnAddPolicy;
        private Button btnDeletePolicy;
        private TextBox tbPolicyName;
        private Label label1;
        private TextBox tbReadOnlyProductName;
        private TextBox tbReadOnlyProductID;
        private Label label2;
    }
}
