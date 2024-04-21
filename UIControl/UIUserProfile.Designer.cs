namespace DeployKeeper_AdminConsole
{
    partial class UIUserProfile
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
            gbUserInfo = new GroupBox();
            dtEnd = new DateTimePicker();
            dtStart = new DateTimePicker();
            tbReadOnlyProductId = new TextBox();
            tbReadOnlyProductName = new TextBox();
            tbReadOnlyUserPasswd = new TextBox();
            tbReadOnlyUserId = new TextBox();
            lvCustomPolicy = new ListView();
            chPolicyId = new ColumnHeader();
            chPolicyName = new ColumnHeader();
            chPolicyUse = new ColumnHeader();
            chPolicyValue = new ColumnHeader();
            gbPolicy = new GroupBox();
            btnApply = new Button();
            btnCancel = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            gbUserInfo.SuspendLayout();
            gbPolicy.SuspendLayout();
            SuspendLayout();
            // 
            // gbUserInfo
            // 
            gbUserInfo.Controls.Add(label5);
            gbUserInfo.Controls.Add(label6);
            gbUserInfo.Controls.Add(label4);
            gbUserInfo.Controls.Add(label3);
            gbUserInfo.Controls.Add(label2);
            gbUserInfo.Controls.Add(label1);
            gbUserInfo.Controls.Add(dtEnd);
            gbUserInfo.Controls.Add(dtStart);
            gbUserInfo.Controls.Add(tbReadOnlyProductId);
            gbUserInfo.Controls.Add(tbReadOnlyProductName);
            gbUserInfo.Controls.Add(tbReadOnlyUserPasswd);
            gbUserInfo.Controls.Add(tbReadOnlyUserId);
            gbUserInfo.Location = new Point(3, 3);
            gbUserInfo.Name = "gbUserInfo";
            gbUserInfo.Size = new Size(347, 210);
            gbUserInfo.TabIndex = 0;
            gbUserInfo.TabStop = false;
            gbUserInfo.Text = "사용자 계정 정보";
            // 
            // dtEnd
            // 
            dtEnd.Format = DateTimePickerFormat.Short;
            dtEnd.Location = new Point(166, 169);
            dtEnd.MaxDate = new DateTime(2054, 12, 31, 0, 0, 0, 0);
            dtEnd.MinDate = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            dtEnd.Name = "dtEnd";
            dtEnd.Size = new Size(136, 23);
            dtEnd.TabIndex = 5;
            dtEnd.Value = new DateTime(2024, 4, 18, 0, 0, 0, 0);
            // 
            // dtStart
            // 
            dtStart.Format = DateTimePickerFormat.Short;
            dtStart.Location = new Point(6, 169);
            dtStart.MaxDate = new DateTime(2054, 12, 31, 0, 0, 0, 0);
            dtStart.MinDate = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            dtStart.Name = "dtStart";
            dtStart.Size = new Size(136, 23);
            dtStart.TabIndex = 4;
            dtStart.Value = new DateTime(2024, 4, 18, 0, 0, 0, 0);
            // 
            // tbReadOnlyProductId
            // 
            tbReadOnlyProductId.Location = new Point(6, 125);
            tbReadOnlyProductId.Name = "tbReadOnlyProductId";
            tbReadOnlyProductId.PlaceholderText = "제품 ID";
            tbReadOnlyProductId.ReadOnly = true;
            tbReadOnlyProductId.Size = new Size(136, 23);
            tbReadOnlyProductId.TabIndex = 3;
            tbReadOnlyProductId.TextAlign = HorizontalAlignment.Center;
            // 
            // tbReadOnlyProductName
            // 
            tbReadOnlyProductName.Location = new Point(166, 125);
            tbReadOnlyProductName.Name = "tbReadOnlyProductName";
            tbReadOnlyProductName.PlaceholderText = "제품명";
            tbReadOnlyProductName.ReadOnly = true;
            tbReadOnlyProductName.Size = new Size(136, 23);
            tbReadOnlyProductName.TabIndex = 2;
            tbReadOnlyProductName.TextAlign = HorizontalAlignment.Center;
            // 
            // tbReadOnlyUserPasswd
            // 
            tbReadOnlyUserPasswd.Location = new Point(6, 81);
            tbReadOnlyUserPasswd.Name = "tbReadOnlyUserPasswd";
            tbReadOnlyUserPasswd.PlaceholderText = "비밀번호";
            tbReadOnlyUserPasswd.ReadOnly = true;
            tbReadOnlyUserPasswd.Size = new Size(296, 23);
            tbReadOnlyUserPasswd.TabIndex = 1;
            tbReadOnlyUserPasswd.TextAlign = HorizontalAlignment.Center;
            // 
            // tbReadOnlyUserId
            // 
            tbReadOnlyUserId.Location = new Point(6, 37);
            tbReadOnlyUserId.Name = "tbReadOnlyUserId";
            tbReadOnlyUserId.PlaceholderText = "아이디";
            tbReadOnlyUserId.ReadOnly = true;
            tbReadOnlyUserId.Size = new Size(296, 23);
            tbReadOnlyUserId.TabIndex = 0;
            tbReadOnlyUserId.TextAlign = HorizontalAlignment.Center;
            // 
            // lvCustomPolicy
            // 
            lvCustomPolicy.Columns.AddRange(new ColumnHeader[] { chPolicyId, chPolicyName, chPolicyUse, chPolicyValue });
            lvCustomPolicy.FullRowSelect = true;
            lvCustomPolicy.GridLines = true;
            lvCustomPolicy.Location = new Point(6, 22);
            lvCustomPolicy.MultiSelect = false;
            lvCustomPolicy.Name = "lvCustomPolicy";
            lvCustomPolicy.Size = new Size(702, 264);
            lvCustomPolicy.TabIndex = 1;
            lvCustomPolicy.UseCompatibleStateImageBehavior = false;
            lvCustomPolicy.View = View.Details;
            lvCustomPolicy.SelectedIndexChanged += lvCustomPolicy_SelectedIndexChanged;
            lvCustomPolicy.DoubleClick += lvCustomPolicy_DoubleClick;
            // 
            // chPolicyId
            // 
            chPolicyId.Width = 0;
            // 
            // chPolicyName
            // 
            chPolicyName.Text = "정책명";
            chPolicyName.Width = 150;
            // 
            // chPolicyUse
            // 
            chPolicyUse.Text = "사용여부";
            // 
            // chPolicyValue
            // 
            chPolicyValue.Text = "정책값";
            chPolicyValue.Width = 300;
            // 
            // gbPolicy
            // 
            gbPolicy.Controls.Add(lvCustomPolicy);
            gbPolicy.Location = new Point(3, 262);
            gbPolicy.Name = "gbPolicy";
            gbPolicy.Size = new Size(714, 301);
            gbPolicy.TabIndex = 2;
            gbPolicy.TabStop = false;
            gbPolicy.Text = "사용자 정책";
            // 
            // btnApply
            // 
            btnApply.Location = new Point(555, 569);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(75, 23);
            btnApply.TabIndex = 3;
            btnApply.Text = "확인";
            btnApply.UseVisualStyleBackColor = true;
            btnApply.Click += btnApply_Click;
            // 
            // btnCancel
            // 
            btnCancel.Enabled = false;
            btnCancel.Location = new Point(636, 569);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "취소";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 6;
            label1.Text = "아이디";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 63);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 7;
            label2.Text = "비밀번호";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 107);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 8;
            label3.Text = "제품 ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(166, 107);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 9;
            label4.Text = "제품명";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(166, 151);
            label5.Name = "label5";
            label5.Size = new Size(83, 15);
            label5.TabIndex = 11;
            label5.Text = "사용종료 일자";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 151);
            label6.Name = "label6";
            label6.Size = new Size(83, 15);
            label6.TabIndex = 10;
            label6.Text = "사용시작 일자";
            // 
            // UIUserProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            Controls.Add(btnCancel);
            Controls.Add(btnApply);
            Controls.Add(gbPolicy);
            Controls.Add(gbUserInfo);
            Name = "UIUserProfile";
            Size = new Size(720, 600);
            Load += UserProfile_Load;
            gbUserInfo.ResumeLayout(false);
            gbUserInfo.PerformLayout();
            gbPolicy.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbUserInfo;
        private TextBox tbReadOnlyProductName;
        private TextBox tbReadOnlyUserPasswd;
        private TextBox tbReadOnlyUserId;
        private TextBox tbReadOnlyProductId;
        private ListView lvCustomPolicy;
        private GroupBox gbPolicy;
        private ColumnHeader chPolicyName;
        private ColumnHeader chPolicyUse;
        private ColumnHeader chPolicyValue;
        private ColumnHeader chPolicyId;
        private DateTimePicker dtEnd;
        private DateTimePicker dtStart;
        private Button btnApply;
        private Button btnCancel;
        private Label label5;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
