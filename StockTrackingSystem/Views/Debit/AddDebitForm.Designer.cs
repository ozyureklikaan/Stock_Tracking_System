namespace StockTrackingSystem.Views.Debit
{
    partial class AddDebitForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDebitForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barBtnBack = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnAddDebit = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnDebitDeletion = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnEditDebit = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnListDebit = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.groupControlListProduct = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lblUserID = new DevExpress.XtraEditors.LabelControl();
            this.txtBoxQuantity = new System.Windows.Forms.TextBox();
            this.btnAddDebit = new DevExpress.XtraEditors.SimpleButton();
            this.txtBoxProductName = new System.Windows.Forms.TextBox();
            this.txtBoxPersonnelName = new System.Windows.Forms.TextBox();
            this.separatorControl7 = new DevExpress.XtraEditors.SeparatorControl();
            this.separatorControl6 = new DevExpress.XtraEditors.SeparatorControl();
            this.label2 = new System.Windows.Forms.Label();
            this.separatorControl5 = new DevExpress.XtraEditors.SeparatorControl();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.dataGridViewPersonnel = new System.Windows.Forms.DataGridView();
            this.separatorControl3 = new DevExpress.XtraEditors.SeparatorControl();
            this.dataGridViewProduct = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlListProduct)).BeginInit();
            this.groupControlListProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonnel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barBtnBack,
            this.barBtnAddDebit,
            this.barBtnDebitDeletion,
            this.barBtnEditDebit,
            this.barBtnListDebit});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 6;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(822, 143);
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
            // barBtnAddDebit
            // 
            this.barBtnAddDebit.Caption = "Add Debit";
            this.barBtnAddDebit.Enabled = false;
            this.barBtnAddDebit.Id = 2;
            this.barBtnAddDebit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnAddDebit.ImageOptions.Image")));
            this.barBtnAddDebit.Name = "barBtnAddDebit";
            this.barBtnAddDebit.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnAddDebit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnAddDebit_ItemClick);
            // 
            // barBtnDebitDeletion
            // 
            this.barBtnDebitDeletion.Caption = "Debit Deletion";
            this.barBtnDebitDeletion.Id = 3;
            this.barBtnDebitDeletion.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnDebitDeletion.ImageOptions.Image")));
            this.barBtnDebitDeletion.Name = "barBtnDebitDeletion";
            this.barBtnDebitDeletion.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnDebitDeletion.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnDebitDeletion_ItemClick);
            // 
            // barBtnEditDebit
            // 
            this.barBtnEditDebit.Caption = "Edit Debit";
            this.barBtnEditDebit.Id = 4;
            this.barBtnEditDebit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnEditDebit.ImageOptions.Image")));
            this.barBtnEditDebit.Name = "barBtnEditDebit";
            this.barBtnEditDebit.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnEditDebit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnEditDebit_ItemClick);
            // 
            // barBtnListDebit
            // 
            this.barBtnListDebit.Caption = "List Debit";
            this.barBtnListDebit.Id = 5;
            this.barBtnListDebit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnListDebit.ImageOptions.Image")));
            this.barBtnListDebit.Name = "barBtnListDebit";
            this.barBtnListDebit.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnListDebit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnListDebit_ItemClick);
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
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtnAddDebit);
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtnDebitDeletion);
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtnEditDebit);
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtnListDebit);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.State = DevExpress.XtraBars.Ribbon.RibbonPageGroupState.Expanded;
            this.ribbonPageGroup2.Text = "Debit Operations";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 896);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(822, 31);
            // 
            // groupControlListProduct
            // 
            this.groupControlListProduct.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupControlListProduct.Controls.Add(this.labelControl1);
            this.groupControlListProduct.Controls.Add(this.lblUserID);
            this.groupControlListProduct.Controls.Add(this.txtBoxQuantity);
            this.groupControlListProduct.Controls.Add(this.btnAddDebit);
            this.groupControlListProduct.Controls.Add(this.txtBoxProductName);
            this.groupControlListProduct.Controls.Add(this.txtBoxPersonnelName);
            this.groupControlListProduct.Controls.Add(this.separatorControl7);
            this.groupControlListProduct.Controls.Add(this.separatorControl6);
            this.groupControlListProduct.Controls.Add(this.label2);
            this.groupControlListProduct.Controls.Add(this.separatorControl5);
            this.groupControlListProduct.Controls.Add(this.label1);
            this.groupControlListProduct.Controls.Add(this.label5);
            this.groupControlListProduct.Controls.Add(this.separatorControl1);
            this.groupControlListProduct.Controls.Add(this.dataGridViewPersonnel);
            this.groupControlListProduct.Controls.Add(this.separatorControl3);
            this.groupControlListProduct.Controls.Add(this.dataGridViewProduct);
            this.groupControlListProduct.Location = new System.Drawing.Point(12, 149);
            this.groupControlListProduct.Name = "groupControlListProduct";
            this.groupControlListProduct.Size = new System.Drawing.Size(798, 739);
            this.groupControlListProduct.TabIndex = 17;
            this.groupControlListProduct.Text = "Add Debit";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(116, 292);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(162, 19);
            this.labelControl1.TabIndex = 66;
            this.labelControl1.Text = "Choose A Personnel";
            // 
            // lblUserID
            // 
            this.lblUserID.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblUserID.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblUserID.Appearance.Options.UseFont = true;
            this.lblUserID.Appearance.Options.UseForeColor = true;
            this.lblUserID.Location = new System.Drawing.Point(15, 30);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(144, 19);
            this.lblUserID.TabIndex = 64;
            this.lblUserID.Text = "Choose A Product";
            // 
            // txtBoxQuantity
            // 
            this.txtBoxQuantity.AccessibleDescription = "";
            this.txtBoxQuantity.AccessibleName = "";
            this.txtBoxQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.txtBoxQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxQuantity.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.txtBoxQuantity.ForeColor = System.Drawing.Color.Silver;
            this.txtBoxQuantity.Location = new System.Drawing.Point(398, 640);
            this.txtBoxQuantity.MaxLength = 8;
            this.txtBoxQuantity.Name = "txtBoxQuantity";
            this.txtBoxQuantity.Size = new System.Drawing.Size(200, 25);
            this.txtBoxQuantity.TabIndex = 63;
            this.txtBoxQuantity.Tag = "";
            this.txtBoxQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.justNumber_KeyPress);
            // 
            // btnAddDebit
            // 
            this.btnAddDebit.Appearance.BackColor = System.Drawing.Color.Yellow;
            this.btnAddDebit.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btnAddDebit.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnAddDebit.Appearance.Options.UseBackColor = true;
            this.btnAddDebit.Appearance.Options.UseFont = true;
            this.btnAddDebit.Appearance.Options.UseForeColor = true;
            this.btnAddDebit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnAddDebit.Location = new System.Drawing.Point(299, 694);
            this.btnAddDebit.Name = "btnAddDebit";
            this.btnAddDebit.Size = new System.Drawing.Size(200, 27);
            this.btnAddDebit.TabIndex = 60;
            this.btnAddDebit.Text = "Add Debit";
            this.btnAddDebit.Click += new System.EventHandler(this.btnDebiting_Click);
            // 
            // txtBoxProductName
            // 
            this.txtBoxProductName.AccessibleDescription = "";
            this.txtBoxProductName.AccessibleName = "";
            this.txtBoxProductName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.txtBoxProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxProductName.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.txtBoxProductName.ForeColor = System.Drawing.Color.Silver;
            this.txtBoxProductName.Location = new System.Drawing.Point(398, 595);
            this.txtBoxProductName.Name = "txtBoxProductName";
            this.txtBoxProductName.ReadOnly = true;
            this.txtBoxProductName.Size = new System.Drawing.Size(200, 25);
            this.txtBoxProductName.TabIndex = 62;
            this.txtBoxProductName.Tag = "";
            // 
            // txtBoxPersonnelName
            // 
            this.txtBoxPersonnelName.AccessibleDescription = "";
            this.txtBoxPersonnelName.AccessibleName = "";
            this.txtBoxPersonnelName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.txtBoxPersonnelName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxPersonnelName.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.txtBoxPersonnelName.ForeColor = System.Drawing.Color.Silver;
            this.txtBoxPersonnelName.Location = new System.Drawing.Point(398, 549);
            this.txtBoxPersonnelName.MaxLength = 50;
            this.txtBoxPersonnelName.Name = "txtBoxPersonnelName";
            this.txtBoxPersonnelName.ReadOnly = true;
            this.txtBoxPersonnelName.Size = new System.Drawing.Size(200, 25);
            this.txtBoxPersonnelName.TabIndex = 61;
            this.txtBoxPersonnelName.Tag = "";
            // 
            // separatorControl7
            // 
            this.separatorControl7.Location = new System.Drawing.Point(141, 665);
            this.separatorControl7.Name = "separatorControl7";
            this.separatorControl7.Size = new System.Drawing.Size(516, 23);
            this.separatorControl7.TabIndex = 58;
            // 
            // separatorControl6
            // 
            this.separatorControl6.Location = new System.Drawing.Point(141, 619);
            this.separatorControl6.Name = "separatorControl6";
            this.separatorControl6.Size = new System.Drawing.Size(516, 23);
            this.separatorControl6.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(190, 645);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 50;
            this.label2.Text = "Quantity";
            // 
            // separatorControl5
            // 
            this.separatorControl5.Location = new System.Drawing.Point(141, 573);
            this.separatorControl5.Name = "separatorControl5";
            this.separatorControl5.Size = new System.Drawing.Size(516, 23);
            this.separatorControl5.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(191, 553);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 49;
            this.label1.Text = "Personnel Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(191, 599);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 17);
            this.label5.TabIndex = 52;
            this.label5.Text = "Product Name";
            // 
            // separatorControl1
            // 
            this.separatorControl1.Location = new System.Drawing.Point(116, 523);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(567, 23);
            this.separatorControl1.TabIndex = 48;
            // 
            // dataGridViewPersonnel
            // 
            this.dataGridViewPersonnel.AllowUserToAddRows = false;
            this.dataGridViewPersonnel.AllowUserToDeleteRows = false;
            this.dataGridViewPersonnel.AllowUserToResizeColumns = false;
            this.dataGridViewPersonnel.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewPersonnel.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewPersonnel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewPersonnel.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewPersonnel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPersonnel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewPersonnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPersonnel.DefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewPersonnel.Location = new System.Drawing.Point(116, 317);
            this.dataGridViewPersonnel.MultiSelect = false;
            this.dataGridViewPersonnel.Name = "dataGridViewPersonnel";
            this.dataGridViewPersonnel.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPersonnel.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewPersonnel.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewPersonnel.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewPersonnel.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.dataGridViewPersonnel.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dataGridViewPersonnel.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewPersonnel.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
            this.dataGridViewPersonnel.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewPersonnel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPersonnel.Size = new System.Drawing.Size(567, 200);
            this.dataGridViewPersonnel.TabIndex = 47;
            this.dataGridViewPersonnel.SelectionChanged += new System.EventHandler(this.dataGridViewPersonnel_SelectionChanged);
            // 
            // separatorControl3
            // 
            this.separatorControl3.Location = new System.Drawing.Point(15, 261);
            this.separatorControl3.Name = "separatorControl3";
            this.separatorControl3.Size = new System.Drawing.Size(768, 23);
            this.separatorControl3.TabIndex = 46;
            // 
            // dataGridViewProduct
            // 
            this.dataGridViewProduct.AllowUserToAddRows = false;
            this.dataGridViewProduct.AllowUserToDeleteRows = false;
            this.dataGridViewProduct.AllowUserToResizeColumns = false;
            this.dataGridViewProduct.AllowUserToResizeRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewProduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridViewProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewProduct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewProduct.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProduct.DefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridViewProduct.Location = new System.Drawing.Point(15, 55);
            this.dataGridViewProduct.MultiSelect = false;
            this.dataGridViewProduct.Name = "dataGridViewProduct";
            this.dataGridViewProduct.ReadOnly = true;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridViewProduct.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewProduct.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridViewProduct.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.dataGridViewProduct.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dataGridViewProduct.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridViewProduct.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
            this.dataGridViewProduct.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProduct.Size = new System.Drawing.Size(768, 200);
            this.dataGridViewProduct.TabIndex = 34;
            this.dataGridViewProduct.SelectionChanged += new System.EventHandler(this.dataGridViewProduct_SelectionChanged);
            // 
            // AddDebitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 927);
            this.Controls.Add(this.groupControlListProduct);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddDebitForm";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Add Debit Page";
            this.Load += new System.EventHandler(this.AddDebitForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlListProduct)).EndInit();
            this.groupControlListProduct.ResumeLayout(false);
            this.groupControlListProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonnel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem barBtnBack;
        private DevExpress.XtraBars.BarButtonItem barBtnAddDebit;
        private DevExpress.XtraBars.BarButtonItem barBtnDebitDeletion;
        private DevExpress.XtraBars.BarButtonItem barBtnEditDebit;
        private DevExpress.XtraBars.BarButtonItem barBtnListDebit;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraEditors.GroupControl groupControlListProduct;
        private DevExpress.XtraEditors.SeparatorControl separatorControl3;
        private System.Windows.Forms.DataGridView dataGridViewProduct;
        private System.Windows.Forms.DataGridView dataGridViewPersonnel;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.XtraEditors.SimpleButton btnAddDebit;
        private System.Windows.Forms.TextBox txtBoxProductName;
        private System.Windows.Forms.TextBox txtBoxPersonnelName;
        private DevExpress.XtraEditors.SeparatorControl separatorControl7;
        private DevExpress.XtraEditors.SeparatorControl separatorControl6;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SeparatorControl separatorControl5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxQuantity;
        private DevExpress.XtraEditors.LabelControl lblUserID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}