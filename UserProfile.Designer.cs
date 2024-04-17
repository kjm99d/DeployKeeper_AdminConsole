namespace DeployKeeper_AdminConsole
{
    partial class UserProfile
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
            gbUserInfo.SuspendLayout();
            gbPolicy.SuspendLayout();
            SuspendLayout();
            // 
            // gbUserInfo
            // 
            gbUserInfo.Controls.Add(tbReadOnlyProductId);
            gbUserInfo.Controls.Add(tbReadOnlyProductName);
            gbUserInfo.Controls.Add(tbReadOnlyUserPasswd);
            gbUserInfo.Controls.Add(tbReadOnlyUserId);
            gbUserInfo.Location = new Point(3, 3);
            gbUserInfo.Name = "gbUserInfo";
            gbUserInfo.Size = new Size(317, 276);
            gbUserInfo.TabIndex = 0;
            gbUserInfo.TabStop = false;
            gbUserInfo.Text = "사용자 계정 정보";
            // 
            // tbReadOnlyProductId
            // 
            tbReadOnlyProductId.Location = new Point(6, 80);
            tbReadOnlyProductId.Name = "tbReadOnlyProductId";
            tbReadOnlyProductId.PlaceholderText = "제품 ID";
            tbReadOnlyProductId.ReadOnly = true;
            tbReadOnlyProductId.Size = new Size(136, 23);
            tbReadOnlyProductId.TabIndex = 3;
            tbReadOnlyProductId.TextAlign = HorizontalAlignment.Center;
            // 
            // tbReadOnlyProductName
            // 
            tbReadOnlyProductName.Location = new Point(166, 80);
            tbReadOnlyProductName.Name = "tbReadOnlyProductName";
            tbReadOnlyProductName.PlaceholderText = "제품명";
            tbReadOnlyProductName.ReadOnly = true;
            tbReadOnlyProductName.Size = new Size(136, 23);
            tbReadOnlyProductName.TabIndex = 2;
            tbReadOnlyProductName.TextAlign = HorizontalAlignment.Center;
            // 
            // tbReadOnlyUserPasswd
            // 
            tbReadOnlyUserPasswd.Location = new Point(6, 51);
            tbReadOnlyUserPasswd.Name = "tbReadOnlyUserPasswd";
            tbReadOnlyUserPasswd.PlaceholderText = "비밀번호";
            tbReadOnlyUserPasswd.ReadOnly = true;
            tbReadOnlyUserPasswd.Size = new Size(296, 23);
            tbReadOnlyUserPasswd.TabIndex = 1;
            tbReadOnlyUserPasswd.TextAlign = HorizontalAlignment.Center;
            // 
            // tbReadOnlyUserId
            // 
            tbReadOnlyUserId.Location = new Point(6, 22);
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
            lvCustomPolicy.Size = new Size(702, 267);
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
            gbPolicy.Location = new Point(3, 285);
            gbPolicy.Name = "gbPolicy";
            gbPolicy.Size = new Size(714, 301);
            gbPolicy.TabIndex = 2;
            gbPolicy.TabStop = false;
            gbPolicy.Text = "사용자 정책";
            // 
            // UserProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            Controls.Add(gbPolicy);
            Controls.Add(gbUserInfo);
            Name = "UserProfile";
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
    }
}
