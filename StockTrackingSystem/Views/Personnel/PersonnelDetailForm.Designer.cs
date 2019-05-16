namespace StockTrackingSystem.Views.Personnel
{
    partial class PersonnelDetailForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonnelDetailForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barBtnBack = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnListPesonnel = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnPersonnelDetail = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.groupControlPersonnelDetail = new DevExpress.XtraEditors.GroupControl();
            this.dateEditDateOfStart = new DevExpress.XtraEditors.DateEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.separatorControl4 = new DevExpress.XtraEditors.SeparatorControl();
            this.dateEditBirthDate = new DevExpress.XtraEditors.DateEdit();
            this.comboBoxDepartment = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtBoxLastName = new System.Windows.Forms.TextBox();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.separatorControl7 = new DevExpress.XtraEditors.SeparatorControl();
            this.separatorControl6 = new DevExpress.XtraEditors.SeparatorControl();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.separatorControl5 = new DevExpress.XtraEditors.SeparatorControl();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.separatorControl2 = new DevExpress.XtraEditors.SeparatorControl();
            this.txtBoxActivityStatus = new System.Windows.Forms.TextBox();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.label4 = new System.Windows.Forms.Label();
            this.separatorControl3 = new DevExpress.XtraEditors.SeparatorControl();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.lblUserID = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlPersonnelDetail)).BeginInit();
            this.groupControlPersonnelDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDateOfStart.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDateOfStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditBirthDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditBirthDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxDepartment.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barBtnBack,
            this.barBtnListPesonnel,
            this.barBtnPersonnelDetail});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 4;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(622, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // barBtnBack
            // 
            this.barBtnBack.Caption = "Back";
            this.barBtnBack.Id = 1;
            this.barBtnBack.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnBack.ImageOptions.SvgImage")));
            this.barBtnBack.Name = "barBtnBack";
            this.barBtnBack.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnBack.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnBack_ItemClick);
            // 
            // barBtnListPesonnel
            // 
            this.barBtnListPesonnel.Caption = "List Personnel";
            this.barBtnListPesonnel.Id = 2;
            this.barBtnListPesonnel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnListPesonnel.ImageOptions.Image")));
            this.barBtnListPesonnel.Name = "barBtnListPesonnel";
            this.barBtnListPesonnel.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnListPesonnel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnListPesonnel_ItemClick);
            // 
            // barBtnPersonnelDetail
            // 
            this.barBtnPersonnelDetail.Caption = "Personnel Detail";
            this.barBtnPersonnelDetail.Enabled = false;
            this.barBtnPersonnelDetail.Id = 3;
            this.barBtnPersonnelDetail.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnPersonnelDetail.ImageOptions.Image")));
            this.barBtnPersonnelDetail.Name = "barBtnPersonnelDetail";
            this.barBtnPersonnelDetail.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnPersonnelDetail.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnPersonnelDetail_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Operations";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnBack);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.Text = "Folder Operations";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtnListPesonnel);
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtnPersonnelDetail);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.State = DevExpress.XtraBars.Ribbon.RibbonPageGroupState.Expanded;
            this.ribbonPageGroup2.Text = "Personnel Operations";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 833);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(622, 31);
            // 
            // groupControlPersonnelDetail
            // 
            this.groupControlPersonnelDetail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupControlPersonnelDetail.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupControlPersonnelDetail.Controls.Add(this.lblUserID);
            this.groupControlPersonnelDetail.Controls.Add(this.dateEditDateOfStart);
            this.groupControlPersonnelDetail.Controls.Add(this.label6);
            this.groupControlPersonnelDetail.Controls.Add(this.separatorControl4);
            this.groupControlPersonnelDetail.Controls.Add(this.dateEditBirthDate);
            this.groupControlPersonnelDetail.Controls.Add(this.comboBoxDepartment);
            this.groupControlPersonnelDetail.Controls.Add(this.txtBoxLastName);
            this.groupControlPersonnelDetail.Controls.Add(this.txtBoxName);
            this.groupControlPersonnelDetail.Controls.Add(this.separatorControl7);
            this.groupControlPersonnelDetail.Controls.Add(this.separatorControl6);
            this.groupControlPersonnelDetail.Controls.Add(this.label3);
            this.groupControlPersonnelDetail.Controls.Add(this.label2);
            this.groupControlPersonnelDetail.Controls.Add(this.separatorControl5);
            this.groupControlPersonnelDetail.Controls.Add(this.label1);
            this.groupControlPersonnelDetail.Controls.Add(this.label5);
            this.groupControlPersonnelDetail.Controls.Add(this.separatorControl2);
            this.groupControlPersonnelDetail.Controls.Add(this.txtBoxActivityStatus);
            this.groupControlPersonnelDetail.Controls.Add(this.separatorControl1);
            this.groupControlPersonnelDetail.Controls.Add(this.label4);
            this.groupControlPersonnelDetail.Controls.Add(this.separatorControl3);
            this.groupControlPersonnelDetail.Controls.Add(this.dataGridView);
            this.groupControlPersonnelDetail.Location = new System.Drawing.Point(12, 149);
            this.groupControlPersonnelDetail.Name = "groupControlPersonnelDetail";
            this.groupControlPersonnelDetail.Size = new System.Drawing.Size(598, 676);
            this.groupControlPersonnelDetail.TabIndex = 17;
            this.groupControlPersonnelDetail.Text = "Personnel Detail";
            // 
            // dateEditDateOfStart
            // 
            this.dateEditDateOfStart.EditValue = null;
            this.dateEditDateOfStart.Location = new System.Drawing.Point(295, 529);
            this.dateEditDateOfStart.MenuManager = this.ribbon;
            this.dateEditDateOfStart.Name = "dateEditDateOfStart";
            this.dateEditDateOfStart.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.dateEditDateOfStart.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.dateEditDateOfStart.Properties.Appearance.Options.UseBackColor = true;
            this.dateEditDateOfStart.Properties.Appearance.Options.UseFont = true;
            this.dateEditDateOfStart.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.dateEditDateOfStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditDateOfStart.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditDateOfStart.Properties.ReadOnly = true;
            this.dateEditDateOfStart.Size = new System.Drawing.Size(200, 24);
            this.dateEditDateOfStart.TabIndex = 68;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(99, 627);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 66;
            this.label6.Text = "Department";
            // 
            // separatorControl4
            // 
            this.separatorControl4.Location = new System.Drawing.Point(102, 648);
            this.separatorControl4.Name = "separatorControl4";
            this.separatorControl4.Size = new System.Drawing.Size(394, 23);
            this.separatorControl4.TabIndex = 65;
            // 
            // dateEditBirthDate
            // 
            this.dateEditBirthDate.EditValue = null;
            this.dateEditBirthDate.Location = new System.Drawing.Point(295, 482);
            this.dateEditBirthDate.MenuManager = this.ribbon;
            this.dateEditBirthDate.Name = "dateEditBirthDate";
            this.dateEditBirthDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.dateEditBirthDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.dateEditBirthDate.Properties.Appearance.Options.UseBackColor = true;
            this.dateEditBirthDate.Properties.Appearance.Options.UseFont = true;
            this.dateEditBirthDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.dateEditBirthDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditBirthDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditBirthDate.Properties.ReadOnly = true;
            this.dateEditBirthDate.Size = new System.Drawing.Size(200, 24);
            this.dateEditBirthDate.TabIndex = 58;
            // 
            // comboBoxDepartment
            // 
            this.comboBoxDepartment.EditValue = "Select Department";
            this.comboBoxDepartment.Location = new System.Drawing.Point(295, 624);
            this.comboBoxDepartment.MenuManager = this.ribbon;
            this.comboBoxDepartment.Name = "comboBoxDepartment";
            this.comboBoxDepartment.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.comboBoxDepartment.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.comboBoxDepartment.Properties.Appearance.Options.UseBackColor = true;
            this.comboBoxDepartment.Properties.Appearance.Options.UseFont = true;
            this.comboBoxDepartment.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.comboBoxDepartment.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxDepartment.Properties.Items.AddRange(new object[] {
            "Management",
            "Software",
            "AR-GE",
            "Production",
            "Marketing"});
            this.comboBoxDepartment.Properties.ReadOnly = true;
            this.comboBoxDepartment.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxDepartment.Size = new System.Drawing.Size(200, 24);
            this.comboBoxDepartment.TabIndex = 59;
            // 
            // txtBoxLastName
            // 
            this.txtBoxLastName.AccessibleDescription = "";
            this.txtBoxLastName.AccessibleName = "";
            this.txtBoxLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.txtBoxLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxLastName.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.txtBoxLastName.ForeColor = System.Drawing.Color.Silver;
            this.txtBoxLastName.Location = new System.Drawing.Point(295, 435);
            this.txtBoxLastName.Name = "txtBoxLastName";
            this.txtBoxLastName.ReadOnly = true;
            this.txtBoxLastName.Size = new System.Drawing.Size(200, 25);
            this.txtBoxLastName.TabIndex = 64;
            this.txtBoxLastName.Tag = "";
            // 
            // txtBoxName
            // 
            this.txtBoxName.AccessibleDescription = "";
            this.txtBoxName.AccessibleName = "";
            this.txtBoxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.txtBoxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxName.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.txtBoxName.ForeColor = System.Drawing.Color.Silver;
            this.txtBoxName.Location = new System.Drawing.Point(295, 388);
            this.txtBoxName.MaxLength = 50;
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.ReadOnly = true;
            this.txtBoxName.Size = new System.Drawing.Size(200, 25);
            this.txtBoxName.TabIndex = 63;
            this.txtBoxName.Tag = "";
            // 
            // separatorControl7
            // 
            this.separatorControl7.Location = new System.Drawing.Point(102, 507);
            this.separatorControl7.Name = "separatorControl7";
            this.separatorControl7.Size = new System.Drawing.Size(394, 23);
            this.separatorControl7.TabIndex = 62;
            // 
            // separatorControl6
            // 
            this.separatorControl6.Location = new System.Drawing.Point(102, 460);
            this.separatorControl6.Name = "separatorControl6";
            this.separatorControl6.Size = new System.Drawing.Size(394, 23);
            this.separatorControl6.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(99, 534);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 56;
            this.label3.Text = "Date Of Start";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(99, 487);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 55;
            this.label2.Text = "Birth Date";
            // 
            // separatorControl5
            // 
            this.separatorControl5.Location = new System.Drawing.Point(102, 413);
            this.separatorControl5.Name = "separatorControl5";
            this.separatorControl5.Size = new System.Drawing.Size(394, 23);
            this.separatorControl5.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(99, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 54;
            this.label1.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(99, 439);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 57;
            this.label5.Text = "Last Name";
            // 
            // separatorControl2
            // 
            this.separatorControl2.Location = new System.Drawing.Point(102, 601);
            this.separatorControl2.Name = "separatorControl2";
            this.separatorControl2.Size = new System.Drawing.Size(394, 23);
            this.separatorControl2.TabIndex = 53;
            // 
            // txtBoxActivityStatus
            // 
            this.txtBoxActivityStatus.AccessibleDescription = "";
            this.txtBoxActivityStatus.AccessibleName = "";
            this.txtBoxActivityStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.txtBoxActivityStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxActivityStatus.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.txtBoxActivityStatus.ForeColor = System.Drawing.Color.Silver;
            this.txtBoxActivityStatus.Location = new System.Drawing.Point(295, 576);
            this.txtBoxActivityStatus.MaxLength = 50;
            this.txtBoxActivityStatus.Name = "txtBoxActivityStatus";
            this.txtBoxActivityStatus.ReadOnly = true;
            this.txtBoxActivityStatus.Size = new System.Drawing.Size(200, 25);
            this.txtBoxActivityStatus.TabIndex = 52;
            this.txtBoxActivityStatus.Tag = "";
            // 
            // separatorControl1
            // 
            this.separatorControl1.Location = new System.Drawing.Point(102, 554);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(394, 23);
            this.separatorControl1.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(99, 580);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 50;
            this.label4.Text = "Activity Status";
            // 
            // separatorControl3
            // 
            this.separatorControl3.Location = new System.Drawing.Point(15, 366);
            this.separatorControl3.Name = "separatorControl3";
            this.separatorControl3.Size = new System.Drawing.Size(567, 23);
            this.separatorControl3.TabIndex = 46;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.Location = new System.Drawing.Point(15, 55);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.dataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
            this.dataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(567, 305);
            this.dataGridView.TabIndex = 34;
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            // 
            // lblUserID
            // 
            this.lblUserID.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblUserID.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblUserID.Appearance.Options.UseFont = true;
            this.lblUserID.Appearance.Options.UseForeColor = true;
            this.lblUserID.Location = new System.Drawing.Point(15, 30);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(137, 19);
            this.lblUserID.TabIndex = 69;
            this.lblUserID.Text = "Choose A Person";
            // 
            // PersonnelDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 864);
            this.Controls.Add(this.groupControlPersonnelDetail);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PersonnelDetailForm";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Personnel Detail Page";
            this.Load += new System.EventHandler(this.PersonnelDetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlPersonnelDetail)).EndInit();
            this.groupControlPersonnelDetail.ResumeLayout(false);
            this.groupControlPersonnelDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDateOfStart.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditDateOfStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditBirthDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditBirthDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxDepartment.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem barBtnBack;
        private DevExpress.XtraBars.BarButtonItem barBtnListPesonnel;
        private DevExpress.XtraBars.BarButtonItem barBtnPersonnelDetail;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraEditors.GroupControl groupControlPersonnelDetail;
        private DevExpress.XtraEditors.SeparatorControl separatorControl3;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.SeparatorControl separatorControl4;
        private DevExpress.XtraEditors.DateEdit dateEditBirthDate;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxDepartment;
        private System.Windows.Forms.TextBox txtBoxLastName;
        private System.Windows.Forms.TextBox txtBoxName;
        private DevExpress.XtraEditors.SeparatorControl separatorControl7;
        private DevExpress.XtraEditors.SeparatorControl separatorControl6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SeparatorControl separatorControl5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SeparatorControl separatorControl2;
        private System.Windows.Forms.TextBox txtBoxActivityStatus;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.DateEdit dateEditDateOfStart;
        private DevExpress.XtraEditors.LabelControl lblUserID;
    }
}