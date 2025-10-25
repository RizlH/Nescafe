namespace Nescafe.Forms.AdminMenus
{
    partial class MemberPage
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label labelMemberId;
        private System.Windows.Forms.Label labelCardId;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.Label labelJoinDate;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelPhoneAlt;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ComboBox comboStatus;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.DataGridView dataGridViewMember;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            labelMemberId = new Label();
            labelCardId = new Label();
            labelFullName = new Label();
            labelJoinDate = new Label();
            labelEmail = new Label();
            labelPhone = new Label();
            labelPhoneAlt = new Label();
            labelAddress = new Label();
            labelStatus = new Label();
            comboStatus = new ComboBox();
            buttonUpdate = new Button();
            dataGridViewMember = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMember).BeginInit();
            SuspendLayout();
            // 
            // labelMemberId
            // 
            labelMemberId.AutoEllipsis = true;
            labelMemberId.AutoSize = true;
            labelMemberId.Location = new Point(10, 10);
            labelMemberId.Name = "labelMemberId";
            labelMemberId.Size = new Size(65, 15);
            labelMemberId.TabIndex = 0;
            labelMemberId.Text = "Member Id";
            // 
            // labelCardId
            // 
            labelCardId.AutoSize = true;
            labelCardId.Location = new Point(10, 40);
            labelCardId.Name = "labelCardId";
            labelCardId.Size = new Size(77, 15);
            labelCardId.TabIndex = 1;
            labelCardId.Text = "Card Id (KTP)";
            // 
            // labelFullName
            // 
            labelFullName.AutoSize = true;
            labelFullName.Location = new Point(10, 70);
            labelFullName.Name = "labelFullName";
            labelFullName.Size = new Size(61, 15);
            labelFullName.TabIndex = 2;
            labelFullName.Text = "Full Name";
            // 
            // labelJoinDate
            // 
            labelJoinDate.AutoSize = true;
            labelJoinDate.Location = new Point(10, 100);
            labelJoinDate.Name = "labelJoinDate";
            labelJoinDate.Size = new Size(55, 15);
            labelJoinDate.TabIndex = 3;
            labelJoinDate.Text = "Join Date";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(10, 130);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(36, 15);
            labelEmail.TabIndex = 4;
            labelEmail.Text = "Email";
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.Location = new Point(10, 160);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(41, 15);
            labelPhone.TabIndex = 5;
            labelPhone.Text = "Phone";
            // 
            // labelPhoneAlt
            // 
            labelPhoneAlt.AutoSize = true;
            labelPhoneAlt.Location = new Point(10, 190);
            labelPhoneAlt.Name = "labelPhoneAlt";
            labelPhoneAlt.Size = new Size(59, 15);
            labelPhoneAlt.TabIndex = 6;
            labelPhoneAlt.Text = "Phone Alt";
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Location = new Point(10, 220);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(49, 15);
            labelAddress.TabIndex = 7;
            labelAddress.Text = "Address";
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Location = new Point(10, 250);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(39, 15);
            labelStatus.TabIndex = 8;
            labelStatus.Text = "Status";
            // 
            // comboStatus
            // 
            comboStatus.FormattingEnabled = true;
            comboStatus.Location = new Point(10, 265);
            comboStatus.Name = "comboStatus";
            comboStatus.Size = new Size(150, 23);
            comboStatus.TabIndex = 9;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(10, 300);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(75, 25);
            buttonUpdate.TabIndex = 10;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // dataGridViewMember
            // 
            dataGridViewMember.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMember.Location = new Point(182, 10);
            dataGridViewMember.Name = "dataGridViewMember";
            dataGridViewMember.Size = new Size(500, 315);
            dataGridViewMember.TabIndex = 11;
            // 
            // MemberPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelMemberId);
            Controls.Add(labelCardId);
            Controls.Add(labelFullName);
            Controls.Add(labelJoinDate);
            Controls.Add(labelEmail);
            Controls.Add(labelPhone);
            Controls.Add(labelPhoneAlt);
            Controls.Add(labelAddress);
            Controls.Add(labelStatus);
            Controls.Add(comboStatus);
            Controls.Add(buttonUpdate);
            Controls.Add(dataGridViewMember);
            Name = "MemberPage";
            Size = new Size(695, 335);
            ((System.ComponentModel.ISupportInitialize)dataGridViewMember).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
    }
}
