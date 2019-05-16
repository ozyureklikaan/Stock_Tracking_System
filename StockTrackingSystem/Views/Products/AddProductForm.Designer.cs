namespace StockTrackingSystem.Views.Products
{
    partial class AddProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barBtnAddProduct = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnAddStock = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnEditProduct = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnProductDeletion = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnListProduct = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnBack = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.groupControlAddProduct = new DevExpress.XtraEditors.GroupControl();
            this.separatorControl2 = new DevExpress.XtraEditors.SeparatorControl();
            this.btnAddProduct = new DevExpress.XtraEditors.SimpleButton();
            this.dateEditPuchasedDate = new DevExpress.XtraEditors.DateEdit();
            this.comboBoxType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtBoxPurchasedCompany = new System.Windows.Forms.TextBox();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxQuantity = new System.Windows.Forms.TextBox();
            this.txtBoxPrice = new System.Windows.Forms.TextBox();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.separatorControl8 = new DevExpress.XtraEditors.SeparatorControl();
            this.separatorControl7 = new DevExpress.XtraEditors.SeparatorControl();
            this.label6 = new System.Windows.Forms.Label();
            this.separatorControl6 = new DevExpress.XtraEditors.SeparatorControl();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.separatorControl5 = new DevExpress.XtraEditors.SeparatorControl();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlAddProduct)).BeginInit();
            this.groupControlAddProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditPuchasedDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditPuchasedDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl5)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barBtnAddProduct,
            this.barBtnAddStock,
            this.barBtnEditProduct,
            this.barBtnProductDeletion,
            this.barButtonItem5,
            this.barBtnListProduct,
            this.barBtnBack});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 8;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(550, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // barBtnAddProduct
            // 
            this.barBtnAddProduct.Caption = "Add Product";
            this.barBtnAddProduct.Enabled = false;
            this.barBtnAddProduct.Id = 1;
            this.barBtnAddProduct.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnAddProduct.ImageOptions.Image")));
            this.barBtnAddProduct.Name = "barBtnAddProduct";
            this.barBtnAddProduct.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnAddProduct.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnAddProduct_ItemClick);
            // 
            // barBtnAddStock
            // 
            this.barBtnAddStock.Caption = "Add Stock";
            this.barBtnAddStock.Id = 2;
            this.barBtnAddStock.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnAddStock.ImageOptions.Image")));
            this.barBtnAddStock.Name = "barBtnAddStock";
            this.barBtnAddStock.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnAddStock.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnAddStock_ItemClick);
            // 
            // barBtnEditProduct
            // 
            this.barBtnEditProduct.Caption = "Edit Product";
            this.barBtnEditProduct.Id = 3;
            this.barBtnEditProduct.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnEditProduct.ImageOptions.Image")));
            this.barBtnEditProduct.Name = "barBtnEditProduct";
            this.barBtnEditProduct.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnEditProduct.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnEditProduct_ItemClick);
            // 
            // barBtnProductDeletion
            // 
            this.barBtnProductDeletion.Caption = "Product Deletion";
            this.barBtnProductDeletion.Id = 4;
            this.barBtnProductDeletion.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnProductDeletion.ImageOptions.Image")));
            this.barBtnProductDeletion.Name = "barBtnProductDeletion";
            this.barBtnProductDeletion.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnProductDeletion.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnProductDeletion_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "List Product";
            this.barButtonItem5.Id = 5;
            this.barButtonItem5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.Image")));
            this.barButtonItem5.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem5.ImageOptions.SvgImage")));
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barBtnListProduct
            // 
            this.barBtnListProduct.Caption = "List Product";
            this.barBtnListProduct.Id = 6;
            this.barBtnListProduct.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnListProduct.ImageOptions.Image")));
            this.barBtnListProduct.Name = "barBtnListProduct";
            this.barBtnListProduct.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnListProduct.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnListProduct_ItemClick);
            // 
            // barBtnBack
            // 
            this.barBtnBack.Caption = "Back";
            this.barBtnBack.Id = 7;
            this.barBtnBack.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barBtnBack.ImageOptions.SvgImage")));
            this.barBtnBack.Name = "barBtnBack";
            this.barBtnBack.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnBack.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnBack_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Operations";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.AllowTextClipping = false;
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtnBack);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            this.ribbonPageGroup2.Text = "Folder Operations";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnAddProduct);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnAddStock);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnEditProduct);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnProductDeletion);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtnListProduct);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            this.ribbonPageGroup1.State = DevExpress.XtraBars.Ribbon.RibbonPageGroupState.Expanded;
            this.ribbonPageGroup1.Text = "Product Operations";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 518);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(550, 31);
            // 
            // groupControlAddProduct
            // 
            this.groupControlAddProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupControlAddProduct.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupControlAddProduct.Controls.Add(this.separatorControl2);
            this.groupControlAddProduct.Controls.Add(this.btnAddProduct);
            this.groupControlAddProduct.Controls.Add(this.dateEditPuchasedDate);
            this.groupControlAddProduct.Controls.Add(this.comboBoxType);
            this.groupControlAddProduct.Controls.Add(this.txtBoxPurchasedCompany);
            this.groupControlAddProduct.Controls.Add(this.separatorControl1);
            this.groupControlAddProduct.Controls.Add(this.label4);
            this.groupControlAddProduct.Controls.Add(this.txtBoxQuantity);
            this.groupControlAddProduct.Controls.Add(this.txtBoxPrice);
            this.groupControlAddProduct.Controls.Add(this.txtBoxName);
            this.groupControlAddProduct.Controls.Add(this.separatorControl8);
            this.groupControlAddProduct.Controls.Add(this.separatorControl7);
            this.groupControlAddProduct.Controls.Add(this.label6);
            this.groupControlAddProduct.Controls.Add(this.separatorControl6);
            this.groupControlAddProduct.Controls.Add(this.label3);
            this.groupControlAddProduct.Controls.Add(this.label2);
            this.groupControlAddProduct.Controls.Add(this.separatorControl5);
            this.groupControlAddProduct.Controls.Add(this.label1);
            this.groupControlAddProduct.Controls.Add(this.label5);
            this.groupControlAddProduct.Location = new System.Drawing.Point(12, 149);
            this.groupControlAddProduct.Name = "groupControlAddProduct";
            this.groupControlAddProduct.Size = new System.Drawing.Size(526, 360);
            this.groupControlAddProduct.TabIndex = 13;
            this.groupControlAddProduct.Text = "Add Product";
            // 
            // separatorControl2
            // 
            this.separatorControl2.Location = new System.Drawing.Point(5, 287);
            this.separatorControl2.Name = "separatorControl2";
            this.separatorControl2.Size = new System.Drawing.Size(516, 23);
            this.separatorControl2.TabIndex = 33;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Appearance.BackColor = System.Drawing.Color.Yellow;
            this.btnAddProduct.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btnAddProduct.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnAddProduct.Appearance.Options.UseBackColor = true;
            this.btnAddProduct.Appearance.Options.UseFont = true;
            this.btnAddProduct.Appearance.Options.UseForeColor = true;
            this.btnAddProduct.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnAddProduct.Location = new System.Drawing.Point(213, 316);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(100, 27);
            this.btnAddProduct.TabIndex = 23;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // dateEditPuchasedDate
            // 
            this.dateEditPuchasedDate.EditValue = null;
            this.dateEditPuchasedDate.Location = new System.Drawing.Point(262, 122);
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
            this.dateEditPuchasedDate.TabIndex = 15;
            // 
            // comboBoxType
            // 
            this.comboBoxType.EditValue = "Select Type";
            this.comboBoxType.Location = new System.Drawing.Point(262, 168);
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
            this.comboBoxType.TabIndex = 15;
            // 
            // txtBoxPurchasedCompany
            // 
            this.txtBoxPurchasedCompany.AccessibleDescription = "";
            this.txtBoxPurchasedCompany.AccessibleName = "";
            this.txtBoxPurchasedCompany.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.txtBoxPurchasedCompany.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxPurchasedCompany.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.txtBoxPurchasedCompany.ForeColor = System.Drawing.Color.Silver;
            this.txtBoxPurchasedCompany.Location = new System.Drawing.Point(262, 261);
            this.txtBoxPurchasedCompany.MaxLength = 50;
            this.txtBoxPurchasedCompany.Name = "txtBoxPurchasedCompany";
            this.txtBoxPurchasedCompany.Size = new System.Drawing.Size(200, 25);
            this.txtBoxPurchasedCompany.TabIndex = 32;
            this.txtBoxPurchasedCompany.Tag = "";
            // 
            // separatorControl1
            // 
            this.separatorControl1.Location = new System.Drawing.Point(5, 240);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(516, 23);
            this.separatorControl1.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(54, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "Purchased Company";
            // 
            // txtBoxQuantity
            // 
            this.txtBoxQuantity.AccessibleDescription = "";
            this.txtBoxQuantity.AccessibleName = "";
            this.txtBoxQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.txtBoxQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxQuantity.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.txtBoxQuantity.ForeColor = System.Drawing.Color.Silver;
            this.txtBoxQuantity.Location = new System.Drawing.Point(262, 215);
            this.txtBoxQuantity.MaxLength = 8;
            this.txtBoxQuantity.Name = "txtBoxQuantity";
            this.txtBoxQuantity.Size = new System.Drawing.Size(200, 25);
            this.txtBoxQuantity.TabIndex = 29;
            this.txtBoxQuantity.Tag = "";
            this.txtBoxQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.justNumber_KeyPress);
            // 
            // txtBoxPrice
            // 
            this.txtBoxPrice.AccessibleDescription = "";
            this.txtBoxPrice.AccessibleName = "";
            this.txtBoxPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.txtBoxPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxPrice.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.txtBoxPrice.ForeColor = System.Drawing.Color.Silver;
            this.txtBoxPrice.Location = new System.Drawing.Point(262, 77);
            this.txtBoxPrice.Name = "txtBoxPrice";
            this.txtBoxPrice.Size = new System.Drawing.Size(200, 25);
            this.txtBoxPrice.TabIndex = 26;
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
            this.txtBoxName.Location = new System.Drawing.Point(262, 31);
            this.txtBoxName.MaxLength = 50;
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(200, 25);
            this.txtBoxName.TabIndex = 25;
            this.txtBoxName.Tag = "";
            // 
            // separatorControl8
            // 
            this.separatorControl8.Location = new System.Drawing.Point(5, 193);
            this.separatorControl8.Name = "separatorControl8";
            this.separatorControl8.Size = new System.Drawing.Size(516, 23);
            this.separatorControl8.TabIndex = 20;
            // 
            // separatorControl7
            // 
            this.separatorControl7.Location = new System.Drawing.Point(5, 147);
            this.separatorControl7.Name = "separatorControl7";
            this.separatorControl7.Size = new System.Drawing.Size(516, 23);
            this.separatorControl7.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(54, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Quantity";
            // 
            // separatorControl6
            // 
            this.separatorControl6.Location = new System.Drawing.Point(5, 101);
            this.separatorControl6.Name = "separatorControl6";
            this.separatorControl6.Size = new System.Drawing.Size(516, 23);
            this.separatorControl6.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(54, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(54, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Purchased Date";
            // 
            // separatorControl5
            // 
            this.separatorControl5.Location = new System.Drawing.Point(5, 55);
            this.separatorControl5.Name = "separatorControl5";
            this.separatorControl5.Size = new System.Drawing.Size(516, 23);
            this.separatorControl5.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(55, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(55, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Price";
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 549);
            this.Controls.Add(this.groupControlAddProduct);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddProductForm";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Add Product Page";
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlAddProduct)).EndInit();
            this.groupControlAddProduct.ResumeLayout(false);
            this.groupControlAddProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditPuchasedDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditPuchasedDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem barBtnAddProduct;
        private DevExpress.XtraBars.BarButtonItem barBtnAddStock;
        private DevExpress.XtraBars.BarButtonItem barBtnEditProduct;
        private DevExpress.XtraBars.BarButtonItem barBtnProductDeletion;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barBtnListProduct;
        private DevExpress.XtraBars.BarButtonItem barBtnBack;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraEditors.GroupControl groupControlAddProduct;
        private DevExpress.XtraEditors.SeparatorControl separatorControl8;
        private DevExpress.XtraEditors.SeparatorControl separatorControl7;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.SeparatorControl separatorControl6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SeparatorControl separatorControl5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxName;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxType;
        private System.Windows.Forms.TextBox txtBoxPurchasedCompany;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxQuantity;
        private System.Windows.Forms.TextBox txtBoxPrice;
        private DevExpress.XtraEditors.DateEdit dateEditPuchasedDate;
        private DevExpress.XtraEditors.SeparatorControl separatorControl2;
        private DevExpress.XtraEditors.SimpleButton btnAddProduct;
    }
}