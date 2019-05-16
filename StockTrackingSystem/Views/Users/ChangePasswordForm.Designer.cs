namespace StockTrackingSystem.Views.Users
{
    partial class ChangePasswordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordForm));
            this.groupControlPasswordChangeSection = new DevExpress.XtraEditors.GroupControl();
            this.checkBtnSuccessfulOrFailNew = new DevExpress.XtraEditors.CheckButton();
            this.checkBtnSuccessfulOrFailCurrent = new DevExpress.XtraEditors.CheckButton();
            this.btnChange = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.txtBoxNewPasswordAgain = new DevExpress.XtraEditors.TextEdit();
            this.txtBoxNewPassword = new DevExpress.XtraEditors.TextEdit();
            this.txtBoxCurrentPassword = new DevExpress.XtraEditors.TextEdit();
            this.lblNewPasswordAgain = new System.Windows.Forms.Label();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.lblCurrentPassword = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlPasswordChangeSection)).BeginInit();
            this.groupControlPasswordChangeSection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxNewPasswordAgain.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxNewPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxCurrentPassword.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControlPasswordChangeSection
            // 
            this.groupControlPasswordChangeSection.Controls.Add(this.checkBtnSuccessfulOrFailNew);
            this.groupControlPasswordChangeSection.Controls.Add(this.checkBtnSuccessfulOrFailCurrent);
            this.groupControlPasswordChangeSection.Controls.Add(this.btnChange);
            this.groupControlPasswordChangeSection.Controls.Add(this.btnCancel);
            this.groupControlPasswordChangeSection.Controls.Add(this.txtBoxNewPasswordAgain);
            this.groupControlPasswordChangeSection.Controls.Add(this.txtBoxNewPassword);
            this.groupControlPasswordChangeSection.Controls.Add(this.txtBoxCurrentPassword);
            this.groupControlPasswordChangeSection.Controls.Add(this.lblNewPasswordAgain);
            this.groupControlPasswordChangeSection.Controls.Add(this.lblNewPassword);
            this.groupControlPasswordChangeSection.Controls.Add(this.lblCurrentPassword);
            this.groupControlPasswordChangeSection.Location = new System.Drawing.Point(12, 12);
            this.groupControlPasswordChangeSection.Name = "groupControlPasswordChangeSection";
            this.groupControlPasswordChangeSection.Size = new System.Drawing.Size(295, 296);
            this.groupControlPasswordChangeSection.TabIndex = 1;
            this.groupControlPasswordChangeSection.Text = "Password Change Section";
            // 
            // checkBtnSuccessfulOrFailNew
            // 
            this.checkBtnSuccessfulOrFailNew.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.checkBtnSuccessfulOrFailNew.ImageOptions.Image = global::StockTrackingSystem.Properties.Resources.failIcon32x32;
            this.checkBtnSuccessfulOrFailNew.Location = new System.Drawing.Point(240, 190);
            this.checkBtnSuccessfulOrFailNew.Name = "checkBtnSuccessfulOrFailNew";
            this.checkBtnSuccessfulOrFailNew.Size = new System.Drawing.Size(34, 32);
            this.checkBtnSuccessfulOrFailNew.TabIndex = 27;
            // 
            // checkBtnSuccessfulOrFailCurrent
            // 
            this.checkBtnSuccessfulOrFailCurrent.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.checkBtnSuccessfulOrFailCurrent.ImageOptions.Image = global::StockTrackingSystem.Properties.Resources.failIcon32x32;
            this.checkBtnSuccessfulOrFailCurrent.Location = new System.Drawing.Point(240, 52);
            this.checkBtnSuccessfulOrFailCurrent.Name = "checkBtnSuccessfulOrFailCurrent";
            this.checkBtnSuccessfulOrFailCurrent.Size = new System.Drawing.Size(34, 32);
            this.checkBtnSuccessfulOrFailCurrent.TabIndex = 26;
            // 
            // btnChange
            // 
            this.btnChange.Appearance.BackColor = System.Drawing.Color.Yellow;
            this.btnChange.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btnChange.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnChange.Appearance.Options.UseBackColor = true;
            this.btnChange.Appearance.Options.UseFont = true;
            this.btnChange.Appearance.Options.UseForeColor = true;
            this.btnChange.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnChange.Location = new System.Drawing.Point(34, 246);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(98, 27);
            this.btnChange.TabIndex = 25;
            this.btnChange.Text = "Change";
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.BackColor = System.Drawing.Color.Yellow;
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Appearance.Options.UseBackColor = true;
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.Appearance.Options.UseForeColor = true;
            this.btnCancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnCancel.Location = new System.Drawing.Point(136, 246);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(98, 27);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtBoxNewPasswordAgain
            // 
            this.txtBoxNewPasswordAgain.Location = new System.Drawing.Point(34, 199);
            this.txtBoxNewPasswordAgain.Name = "txtBoxNewPasswordAgain";
            this.txtBoxNewPasswordAgain.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtBoxNewPasswordAgain.Properties.Appearance.Options.UseFont = true;
            this.txtBoxNewPasswordAgain.Properties.UseSystemPasswordChar = true;
            this.txtBoxNewPasswordAgain.Size = new System.Drawing.Size(200, 22);
            this.txtBoxNewPasswordAgain.TabIndex = 7;
            this.txtBoxNewPasswordAgain.EditValueChanged += new System.EventHandler(this.txtBoxNewPasswordAgain_EditValueChanged);
            // 
            // txtBoxNewPassword
            // 
            this.txtBoxNewPassword.Location = new System.Drawing.Point(34, 130);
            this.txtBoxNewPassword.Name = "txtBoxNewPassword";
            this.txtBoxNewPassword.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtBoxNewPassword.Properties.Appearance.Options.UseFont = true;
            this.txtBoxNewPassword.Properties.UseSystemPasswordChar = true;
            this.txtBoxNewPassword.Size = new System.Drawing.Size(200, 22);
            this.txtBoxNewPassword.TabIndex = 6;
            this.txtBoxNewPassword.EditValueChanged += new System.EventHandler(this.txtBoxNewPassword_EditValueChanged);
            // 
            // txtBoxCurrentPassword
            // 
            this.txtBoxCurrentPassword.Location = new System.Drawing.Point(34, 61);
            this.txtBoxCurrentPassword.Name = "txtBoxCurrentPassword";
            this.txtBoxCurrentPassword.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtBoxCurrentPassword.Properties.Appearance.Options.UseFont = true;
            this.txtBoxCurrentPassword.Properties.UseSystemPasswordChar = true;
            this.txtBoxCurrentPassword.Size = new System.Drawing.Size(200, 22);
            this.txtBoxCurrentPassword.TabIndex = 5;
            this.txtBoxCurrentPassword.EditValueChanged += new System.EventHandler(this.txtBoxCurrentPassword_EditValueChanged);
            // 
            // lblNewPasswordAgain
            // 
            this.lblNewPasswordAgain.AutoSize = true;
            this.lblNewPasswordAgain.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblNewPasswordAgain.Location = new System.Drawing.Point(31, 174);
            this.lblNewPasswordAgain.Name = "lblNewPasswordAgain";
            this.lblNewPasswordAgain.Size = new System.Drawing.Size(165, 17);
            this.lblNewPasswordAgain.TabIndex = 2;
            this.lblNewPasswordAgain.Text = "New Password (Again)";
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblNewPassword.Location = new System.Drawing.Point(31, 105);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(110, 17);
            this.lblNewPassword.TabIndex = 1;
            this.lblNewPassword.Text = "New Password";
            // 
            // lblCurrentPassword
            // 
            this.lblCurrentPassword.AutoSize = true;
            this.lblCurrentPassword.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblCurrentPassword.Location = new System.Drawing.Point(31, 36);
            this.lblCurrentPassword.Name = "lblCurrentPassword";
            this.lblCurrentPassword.Size = new System.Drawing.Size(133, 17);
            this.lblCurrentPassword.TabIndex = 0;
            this.lblCurrentPassword.Text = "Current Password";
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 320);
            this.Controls.Add(this.groupControlPasswordChangeSection);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangePasswordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account Settings Page";
            this.Load += new System.EventHandler(this.ChangePasswordForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlPasswordChangeSection)).EndInit();
            this.groupControlPasswordChangeSection.ResumeLayout(false);
            this.groupControlPasswordChangeSection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxNewPasswordAgain.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxNewPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBoxCurrentPassword.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControlPasswordChangeSection;
        private DevExpress.XtraEditors.TextEdit txtBoxNewPasswordAgain;
        private DevExpress.XtraEditors.TextEdit txtBoxNewPassword;
        private DevExpress.XtraEditors.TextEdit txtBoxCurrentPassword;
        private System.Windows.Forms.Label lblNewPasswordAgain;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Label lblCurrentPassword;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnChange;
        private DevExpress.XtraEditors.CheckButton checkBtnSuccessfulOrFailNew;
        private DevExpress.XtraEditors.CheckButton checkBtnSuccessfulOrFailCurrent;
    }
}