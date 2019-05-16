namespace StockTrackingSystem.Views.Products
{
    partial class EditProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditProductForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnBack = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnAddProduct = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnAddStock = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnEditProduct = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnProductDeletion = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnListProduct = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.groupControlEditProduct = new DevExpress.XtraEditors.GroupControl();
            this.lblUserID = new DevExpress.XtraEditors.LabelControl();
            this.txtBoxPurchasedCompany = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.separatorControl4 = new DevExpress.XtraEditors.SeparatorControl();
            this.separatorControl3 = new DevExpress.XtraEditors.SeparatorControl();
            this.dateEditPuchasedDate = new DevExpress.XtraEditors.DateEdit();
            this.comboBoxType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtBoxPrice = new System.Windows.Forms.TextBox();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.separatorControl7 = new DevExpress.XtraEditors.SeparatorControl();
            this.separatorControl6 = new DevExpress.XtraEditors.SeparatorControl();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.separatorControl5 = new DevExpress.XtraEditors.SeparatorControl();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.separatorControl2 = new DevExpress.XtraEditors.SeparatorControl();
            this.btnSaveChanges = new DevExpress.XtraEditors.SimpleButton();
            this.txtBoxQuantity = new System.Windows.Forms.TextBox();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlEditProduct)).BeginInit();
            this.groupControlEditProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditPuchasedDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditPuchasedDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barButtonItem1,
            this.barBtnBack,
            this.barBtnAddProduct,
            this.barBtnAddStock,
            this.barBtnEditProduct,
            this.barBtnProductDeletion,
            this.barBtnListProduct});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 8;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(822, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Back";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barBtnBack
            // 
            this.barBtnBack.Caption = "Back";
            this.barBtnBack.Id = 2;
            this.barBtnBack.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnBack.ImageOptions.SvgImage")));
            this.barBtnBack.Name = "barBtnBack";
            this.barBtnBack.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnBack.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnBack_ItemClick);
            // 
            // barBtnAddProduct
            // 
            this.barBtnAddProduct.Caption = "Add Product";
            this.barBtnAddProduct.Id = 3;
            this.barBtnAddProduct.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnAddProduct.ImageOptions.Image")));
            this.barBtnAddProduct.Name = "barBtnAddProduct";
            this.barBtnAddProduct.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnAddProduct.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnAddProduct_ItemClick);
            // 
            // barBtnAddStock
            // 
            this.barBtnAddStock.Caption = "Add Stock";
            this.barBtnAddStock.Id = 4;
            this.barBtnAddStock.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnAddStock.ImageOptions.Image")));
            this.barBtnAddStock.Name = "barBtnAddStock";
            this.barBtnAddStock.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnAddStock.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnAddStock_ItemClick);
            // 
            // barBtnEditProduct
            // 
            this.barBtnEditProduct.Caption = "Edit Product";
            this.barBtnEditProduct.Enabled = false;
            this.barBtnEditProduct.Id = 5;
            this.barBtnEditProduct.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnEditProduct.ImageOptions.Image")));
            this.barBtnEditProduct.Name = "barBtnEditProduct";
            this.barBtnEditProduct.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnEditProduct.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnEditProduct_ItemClick);
            // 
            // barBtnProductDeletion
            // 
            this.barBtnProductDeletion.Caption = "Product Deletion";
            this.barBtnProductDeletion.Id = 6;
            this.barBtnProductDeletion.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnProductDeletion.ImageOptions.Image")));
            this.barBtnProductDeletion.Name = "barBtnProductDeletion";
            this.barBtnProductDeletion.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnProductDeletion.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnProductDeletion_ItemClick);
            // 
            // barBtnListProduct
            // 
            this.barBtnListProduct.Caption = "List Product";
            this.barBtnListProduct.Id = 7;
            this.barBtnListProduct.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnListProduct.ImageOptions.Image")));
            this.barBtnListProduct.Name = "barBtnListProduct";
            this.barBtnListProduct.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnListProduct.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnListProduct_ItemClick);
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
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtnAddProduct);
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtnAddStock);
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtnEditProduct);
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtnProductDeletion);
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtnListProduct);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.State = DevExpress.XtraBars.Ribbon.RibbonPageGroupState.Expanded;
            this.ribbonPageGroup2.Text = "Product Operations";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 780);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(822, 31);
            // 
            // groupControlEditProduct
            // 
            this.groupControlEditProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupControlEditProduct.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupControlEditProduct.Controls.Add(this.lblUserID);
            this.groupControlEditProduct.Controls.Add(this.txtBoxPurchasedCompany);
            this.groupControlEditProduct.Controls.Add(this.label6);
            this.groupControlEditProduct.Controls.Add(this.separatorControl4);
            this.groupControlEditProduct.Controls.Add(this.separatorControl3);
            this.groupControlEditProduct.Controls.Add(this.dateEditPuchasedDate);
            this.groupControlEditProduct.Controls.Add(this.comboBoxType);
            this.groupControlEditProduct.Controls.Add(this.txtBoxPrice);
            this.groupControlEditProduct.Controls.Add(this.txtBoxName);
            this.groupControlEditProduct.Controls.Add(this.separatorControl7);
            this.groupControlEditProduct.Controls.Add(this.separatorControl6);
            this.groupControlEditProduct.Controls.Add(this.label3);
            this.groupControlEditProduct.Controls.Add(this.label2);
            this.groupControlEditProduct.Controls.Add(this.separatorControl5);
            this.groupControlEditProduct.Controls.Add(this.label1);
            this.groupControlEditProduct.Controls.Add(this.label5);
            this.groupControlEditProduct.Controls.Add(this.dataGridView);
            this.groupControlEditProduct.Controls.Add(this.separatorControl2);
            this.groupControlEditProduct.Controls.Add(this.btnSaveChanges);
            this.groupControlEditProduct.Controls.Add(this.txtBoxQuantity);
            this.groupControlEditProduct.Controls.Add(this.separatorControl1);
            this.groupControlEditProduct.Controls.Add(this.label4);
            this.groupControlEditProduct.Location = new System.Drawing.Point(12, 153);
            this.groupControlEditProduct.Name = "groupControlEditProduct";
            this.groupControlEditProduct.Size = new System.Drawing.Size(798, 621);
            this.groupControlEditProduct.TabIndex = 15;
            this.groupControlEditProduct.Text = "Edit Product";
            this.groupControlEditProduct.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControlAddStock_Paint);
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
            this.lblUserID.TabIndex = 65;
            this.lblUserID.Text = "Choose A Product";
            // 
            // txtBoxPurchasedCompany
            // 
            this.txtBoxPurchasedCompany.AccessibleDescription = "";
            this.txtBoxPurchasedCompany.AccessibleName = "";
            this.txtBoxPurchasedCompany.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.txtBoxPurchasedCompany.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxPurchasedCompany.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.txtBoxPurchasedCompany.ForeColor = System.Drawing.Color.Silver;
            this.txtBoxPurchasedCompany.Location = new System.Drawing.Point(398, 517);
            this.txtBoxPurchasedCompany.MaxLength = 50;
            this.txtBoxPurchasedCompany.Name = "txtBoxPurchasedCompany";
            this.txtBoxPurchasedCompany.Size = new System.Drawing.Size(200, 25);
            this.txtBoxPurchasedCompany.TabIndex = 49;
            this.txtBoxPurchasedCompany.Tag = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(191, 521);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 17);
            this.label6.TabIndex = 48;
            this.label6.Text = "Purchased Company";
            // 
            // separatorControl4
            // 
            this.separatorControl4.Location = new System.Drawing.Point(141, 542);
            this.separatorControl4.Name = "separatorControl4";
            this.separatorControl4.Size = new System.Drawing.Size(516, 23);
            this.separatorControl4.TabIndex = 47;
            // 
            // separatorControl3
            // 
            this.separatorControl3.Location = new System.Drawing.Point(15, 257);
            this.separatorControl3.Name = "separatorControl3";
            this.separatorControl3.Size = new System.Drawing.Size(768, 23);
            this.separatorControl3.TabIndex = 46;
            // 
            // dateEditPuchasedDate
            // 
            this.dateEditPuchasedDate.EditValue = null;
            this.dateEditPuchasedDate.Location = new System.Drawing.Point(398, 376);
            this.dateEditPuchasedDate.MenuManager = this.ribbon;
            this.dateEditPuchasedDate.Name = "dateEditPuchasedDate";
            this.dateEditPuchasedDate.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.dateEditPuchasedDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.dateEditPuchasedDate.Properties.Appearance.Options.UseBackColor = true;
            this.dateEditPuchasedDate.Properties.Appearance.Options.UseFont = true;
            this.dateEditPuchasedDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.dateEditPuchasedDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditPuchasedDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditPuchasedDate.Size = new System.Drawing.Size(200, 24);
            this.dateEditPuchasedDate.TabIndex = 39;
            // 
            // comboBoxType
            // 
            this.comboBoxType.EditValue = "Select Type";
            this.comboBoxType.Location = new System.Drawing.Point(398, 423);
            this.comboBoxType.MenuManager = this.ribbon;
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.comboBoxType.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.comboBoxType.Properties.Appearance.Options.UseBackColor = true;
            this.comboBoxType.Properties.Appearance.Options.UseFont = true;
            this.comboBoxType.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.comboBoxType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxType.Properties.Items.AddRange(new object[] {
            "Computer Tower",
            "Graphic Card",
            "HDD",
            "Keyboard",
            "Laptop",
            "Mainboard",
            "Memory",
            "Monitor",
            "Mouse",
            "Processor (CPU)",
            "SSD"});
            this.comboBoxType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxType.Size = new System.Drawing.Size(200, 24);
            this.comboBoxType.TabIndex = 40;
            // 
            // txtBoxPrice
            // 
            this.txtBoxPrice.AccessibleDescription = "";
            this.txtBoxPrice.AccessibleName = "";
            this.txtBoxPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.txtBoxPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxPrice.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.txtBoxPrice.ForeColor = System.Drawing.Color.Silver;
            this.txtBoxPrice.Location = new System.Drawing.Point(398, 329);
            this.txtBoxPrice.Name = "txtBoxPrice";
            this.txtBoxPrice.Size = new System.Drawing.Size(200, 25);
            this.txtBoxPrice.TabIndex = 45;
            this.txtBoxPrice.Tag = "";
            this.txtBoxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.justNumber_KeyPress);
            // 
            // txtBoxName
            // 
            this.txtBoxName.AccessibleDescription = "";
            this.txtBoxName.AccessibleName = "";
            this.txtBoxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.txtBoxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxName.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.txtBoxName.ForeColor = System.Drawing.Color.Silver;
            this.txtBoxName.Location = new System.Drawing.Point(398, 282);
            this.txtBoxName.MaxLength = 50;
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(200, 25);
            this.txtBoxName.TabIndex = 44;
            this.txtBoxName.Tag = "";
            // 
            // separatorControl7
            // 
            this.separatorControl7.Location = new System.Drawing.Point(141, 401);
            this.separatorControl7.Name = "separatorControl7";
            this.separatorControl7.Size = new System.Drawing.Size(516, 23);
            this.separatorControl7.TabIndex = 43;
            // 
            // separatorControl6
            // 
            this.separatorControl6.Location = new System.Drawing.Point(141, 354);
            this.separatorControl6.Name = "separatorControl6";
            this.separatorControl6.Size = new System.Drawing.Size(516, 23);
            this.separatorControl6.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(191, 428);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 37;
            this.label3.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(191, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 36;
            this.label2.Text = "Purchased Date";
            // 
            // separatorControl5
            // 
            this.separatorControl5.Location = new System.Drawing.Point(141, 307);
            this.separatorControl5.Name = "separatorControl5";
            this.separatorControl5.Size = new System.Drawing.Size(516, 23);
            this.separatorControl5.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(191, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(191, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 38;
            this.label5.Text = "Price";
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
            this.dataGridView.Size = new System.Drawing.Size(768, 197);
            this.dataGridView.TabIndex = 34;
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            // 
            // separatorControl2
            // 
            this.separatorControl2.Location = new System.Drawing.Point(141, 495);
            this.separatorControl2.Name = "separatorControl2";
            this.separatorControl2.Size = new System.Drawing.Size(516, 23);
            this.separatorControl2.TabIndex = 33;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Appearance.BackColor = System.Drawing.Color.Yellow;
            this.btnSaveChanges.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btnSaveChanges.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnSaveChanges.Appearance.Options.UseBackColor = true;
            this.btnSaveChanges.Appearance.Options.UseFont = true;
            this.btnSaveChanges.Appearance.Options.UseForeColor = true;
            this.btnSaveChanges.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnSaveChanges.Location = new System.Drawing.Point(299, 572);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(200, 27);
            this.btnSaveChanges.TabIndex = 23;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // txtBoxQuantity
            // 
            this.txtBoxQuantity.AccessibleDescription = "";
            this.txtBoxQuantity.AccessibleName = "";
            this.txtBoxQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.txtBoxQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxQuantity.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.txtBoxQuantity.ForeColor = System.Drawing.Color.Silver;
            this.txtBoxQuantity.Location = new System.Drawing.Point(399, 470);
            this.txtBoxQuantity.MaxLength = 8;
            this.txtBoxQuantity.Name = "txtBoxQuantity";
            this.txtBoxQuantity.Size = new System.Drawing.Size(200, 25);
            this.txtBoxQuantity.TabIndex = 32;
            this.txtBoxQuantity.Tag = "";
            this.txtBoxQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.justNumber_KeyPress);
            // 
            // separatorControl1
            // 
            this.separatorControl1.Location = new System.Drawing.Point(141, 448);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(516, 23);
            this.separatorControl1.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(191, 474);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "Quantity";
            // 
            // EditProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 811);
            this.Controls.Add(this.groupControlEditProduct);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditProductForm";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Edit Product Page";
            this.Load += new System.EventHandler(this.EditProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlEditProduct)).EndInit();
            this.groupControlEditProduct.ResumeLayout(false);
            this.groupControlEditProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditPuchasedDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditPuchasedDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barBtnBack;
        private DevExpress.XtraBars.BarButtonItem barBtnAddProduct;
        private DevExpress.XtraBars.BarButtonItem barBtnAddStock;
        private DevExpress.XtraBars.BarButtonItem barBtnEditProduct;
        private DevExpress.XtraBars.BarButtonItem barBtnProductDeletion;
        private DevExpress.XtraBars.BarButtonItem barBtnListProduct;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraEditors.GroupControl groupControlEditProduct;
        private System.Windows.Forms.DataGridView dataGridView;
        private DevExpress.XtraEditors.SeparatorControl separatorControl2;
        private DevExpress.XtraEditors.SimpleButton btnSaveChanges;
        private System.Windows.Forms.TextBox txtBoxQuantity;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SeparatorControl separatorControl3;
        private DevExpress.XtraEditors.DateEdit dateEditPuchasedDate;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxType;
        private System.Windows.Forms.TextBox txtBoxPrice;
        private System.Windows.Forms.TextBox txtBoxName;
        private DevExpress.XtraEditors.SeparatorControl separatorControl7;
        private DevExpress.XtraEditors.SeparatorControl separatorControl6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SeparatorControl separatorControl5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SeparatorControl separatorControl4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxPurchasedCompany;
        private DevExpress.XtraEditors.LabelControl lblUserID;
    }
}