namespace DeployKeeper_AdminConsole
{
    partial class FrmCustomPolicyModify
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
            tbPolicyName = new TextBox();
            tbPolicyValue = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnApply = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // tbPolicyName
            // 
            tbPolicyName.Location = new Point(22, 38);
            tbPolicyName.Name = "tbPolicyName";
            tbPolicyName.ReadOnly = true;
            tbPolicyName.Size = new Size(482, 23);
            tbPolicyName.TabIndex = 0;
            // 
            // tbPolicyValue
            // 
            tbPolicyValue.Location = new Point(22, 106);
            tbPolicyValue.Multiline = true;
            tbPolicyValue.Name = "tbPolicyValue";
            tbPolicyValue.Size = new Size(482, 255);
            tbPolicyValue.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 20);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 2;
            label1.Text = "정책명";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 88);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 3;
            label2.Text = "정책값";
            // 
            // btnApply
            // 
            btnApply.DialogResult = DialogResult.OK;
            btnApply.Location = new Point(327, 388);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(75, 23);
            btnApply.TabIndex = 4;
            btnApply.Text = "적용";
            btnApply.UseVisualStyleBackColor = true;
            btnApply.Click += btnApply_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(429, 388);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "취소";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // FrmCustomPolicyModify
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(529, 428);
            Controls.Add(btnCancel);
            Controls.Add(btnApply);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbPolicyValue);
            Controls.Add(tbPolicyName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmCustomPolicyModify";
            Text = "DeployKeeper AdminConsole - 정책 수정";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbPolicyName;
        private TextBox tbPolicyValue;
        private Label label1;
        private Label label2;
        private Button btnApply;
        private Button btnCancel;
    }
}