namespace StockTrackingSystem
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.checkButtonPersonnel = new DevExpress.XtraEditors.CheckButton();
            this.checkButtonAdmin = new DevExpress.XtraEditors.CheckButton();
            this.lblPassword = new DevExpress.XtraEditors.LabelControl();
            this.lblUserID = new DevExpress.XtraEditors.LabelControl();
            this.lblLogIn = new DevExpress.XtraEditors.LabelControl();
            this.lblPersonnel = new System.Windows.Forms.Label();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.btnSignIn = new DevExpress.XtraEditors.SimpleButton();
            this.txtBoxUserID = new System.Windows.Forms.TextBox();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // checkButtonPersonnel
            // 
            this.checkButtonPersonnel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.checkButtonPersonnel.ImageOptions.Image = global::StockTrackingSystem.Properties.Resources.personnelIcon70x70;
            this.checkButtonPersonnel.Location = new System.Drawing.Point(288, 61);
            this.checkButtonPersonnel.Name = "checkButtonPersonnel";
            this.checkButtonPersonnel.Size = new System.Drawing.Size(72, 70);
            this.checkButtonPersonnel.TabIndex = 1;
            this.checkButtonPersonnel.CheckedChanged += new System.EventHandler(this.checkButtonPersonnel_CheckedChanged);
            // 
            // checkButtonAdmin
            // 
            this.checkButtonAdmin.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.checkButtonAdmin.ImageOptions.Image = global::StockTrackingSystem.Properties.Resources.adminIcon70x70;
            this.checkButtonAdmin.Location = new System.Drawing.Point(146, 61);
            this.checkButtonAdmin.Name = "checkButtonAdmin";
            this.checkButtonAdmin.Size = new System.Drawing.Size(72, 70);
            this.checkButtonAdmin.TabIndex = 0;
            this.checkButtonAdmin.CheckedChanged += new System.EventHandler(this.checkButtonAdmin_CheckedChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.lblPassword.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPassword.Appearance.Options.UseFont = true;
            this.lblPassword.Appearance.Options.UseForeColor = true;
            this.lblPassword.Location = new System.Drawing.Point(154, 288);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(97, 24);
            this.lblPassword.TabIndex = 16;
            this.lblPassword.Text = "Password";
            // 
            // lblUserID
            // 
            this.lblUserID.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
            this.lblUserID.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblUserID.Appearance.Options.UseFont = true;
            this.lblUserID.Appearance.Options.UseForeColor = true;
            this.lblUserID.Location = new System.Drawing.Point(154, 196);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(77, 24);
            this.lblUserID.TabIndex = 15;
            this.lblUserID.Text = "User ID";
            // 
            // lblLogIn
            // 
            this.lblLogIn.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.lblLogIn.Appearance.ForeColor = System.Drawing.Color.Yellow;
            this.lblLogIn.Appearance.Options.UseFont = true;
            this.lblLogIn.Appearance.Options.UseForeColor = true;
            this.lblLogIn.Location = new System.Drawing.Point(209, 146);
            this.lblLogIn.Name = "lblLogIn";
            this.lblLogIn.Size = new System.Drawing.Size(88, 29);
            this.lblLogIn.TabIndex = 14;
            this.lblLogIn.Text = "LOG IN";
            // 
            // lblPersonnel
            // 
            this.lblPersonnel.AutoSize = true;
            this.lblPersonnel.BackColor = System.Drawing.Color.Transparent;
            this.lblPersonnel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblPersonnel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPersonnel.Location = new System.Drawing.Point(262, 196);
            this.lblPersonnel.Name = "lblPersonnel";
            this.lblPersonnel.Size = new System.Drawing.Size(124, 13);
            this.lblPersonnel.TabIndex = 20;
            this.lblPersonnel.Text = "PERSONNEL ACCOUNT";
            this.lblPersonnel.Visible = false;
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.BackColor = System.Drawing.Color.Transparent;
            this.lblAdmin.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblAdmin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblAdmin.Location = new System.Drawing.Point(274, 196);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(100, 13);
            this.lblAdmin.TabIndex = 21;
            this.lblAdmin.Text = "ADMIN ACCOUNT";
            this.lblAdmin.Visible = false;
            // 
            // btnSignIn
            // 
            this.btnSignIn.Appearance.BackColor = System.Drawing.Color.Yellow;
            this.btnSignIn.Appearance.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSignIn.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnSignIn.Appearance.Options.UseBackColor = true;
            this.btnSignIn.Appearance.Options.UseFont = true;
            this.btnSignIn.Appearance.Options.UseForeColor = true;
            this.btnSignIn.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnSignIn.Location = new System.Drawing.Point(154, 381);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(200, 28);
            this.btnSignIn.TabIndex = 22;
            this.btnSignIn.Text = "SIGN IN";
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // txtBoxUserID
            // 
            this.txtBoxUserID.AccessibleDescription = "";
            this.txtBoxUserID.AccessibleName = "";
            this.txtBoxUserID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBoxUserID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxUserID.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtBoxUserID.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtBoxUserID.ForeColor = System.Drawing.Color.Silver;
            this.txtBoxUserID.Location = new System.Drawing.Point(154, 235);
            this.txtBoxUserID.MinimumSize = new System.Drawing.Size(200, 28);
            this.txtBoxUserID.Name = "txtBoxUserID";
            this.txtBoxUserID.Size = new System.Drawing.Size(200, 25);
            this.txtBoxUserID.TabIndex = 24;
            this.txtBoxUserID.Tag = "";
            this.txtBoxUserID.Text = "enter user id";
            this.txtBoxUserID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.blockWhiteSpace_KeyPress);
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBoxPassword.Font = new System.Drawing.Font("Tahoma", 15F);
            this.txtBoxPassword.ForeColor = System.Drawing.Color.Silver;
            this.txtBoxPassword.Location = new System.Drawing.Point(154, 327);
            this.txtBoxPassword.MaxLength = 16;
            this.txtBoxPassword.MinimumSize = new System.Drawing.Size(200, 28);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.PasswordChar = '•';
            this.txtBoxPassword.Size = new System.Drawing.Size(200, 25);
            this.txtBoxPassword.TabIndex = 25;
            this.txtBoxPassword.Text = "password";
            this.txtBoxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.blockWhiteSpace_KeyPress);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btnSignIn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = global::StockTrackingSystem.Properties.Resources.login1099x541;
            this.ClientSize = new System.Drawing.Size(1095, 538);
            this.Controls.Add(this.txtBoxPassword);
            this.Controls.Add(this.txtBoxUserID);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.lblAdmin);
            this.Controls.Add(this.lblPersonnel);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.lblLogIn);
            this.Controls.Add(this.checkButtonPersonnel);
            this.Controls.Add(this.checkButtonAdmin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1105, 570);
            this.MinimumSize = new System.Drawing.Size(1105, 570);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Tracking System";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.CheckButton checkButtonAdmin;
        private DevExpress.XtraEditors.CheckButton checkButtonPersonnel;
        private DevExpress.XtraEditors.LabelControl lblPassword;
        private DevExpress.XtraEditors.LabelControl lblUserID;
        private DevExpress.XtraEditors.LabelControl lblLogIn;
        private System.Windows.Forms.Label lblPersonnel;
        private System.Windows.Forms.Label lblAdmin;
        private DevExpress.XtraEditors.SimpleButton btnSignIn;
        private System.Windows.Forms.TextBox txtBoxUserID;
        private System.Windows.Forms.TextBox txtBoxPassword;
    }
}

