namespace StockTrackingSystem.Views.Products
{
    partial class ProductDeletionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductDeletionForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barBtnBack = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnAddProduct = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnAddStock = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnEditProduct = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnProductDeletion = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnListProduct = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.groupControlProductDeletion = new DevExpress.XtraEditors.GroupControl();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.separatorControl2 = new DevExpress.XtraEditors.SeparatorControl();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.lblUserID = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlProductDeletion)).BeginInit();
            this.groupControlProductDeletion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barBtnBack,
            this.barBtnAddProduct,
            this.barBtnAddStock,
            this.barBtnEditProduct,
            this.barBtnProductDeletion,
            this.barBtnListProduct});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 7;
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
            // barBtnAddProduct
            // 
            this.barBtnAddProduct.Caption = "Add Product";
            this.barBtnAddProduct.Id = 2;
            this.barBtnAddProduct.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnAddProduct.ImageOptions.Image")));
            this.barBtnAddProduct.Name = "barBtnAddProduct";
            this.barBtnAddProduct.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnAddProduct.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnAddProduct_ItemClick);
            // 
            // barBtnAddStock
            // 
            this.barBtnAddStock.Caption = "Add Stock";
            this.barBtnAddStock.Id = 3;
            this.barBtnAddStock.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnAddStock.ImageOptions.Image")));
            this.barBtnAddStock.Name = "barBtnAddStock";
            this.barBtnAddStock.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnAddStock.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnAddStock_ItemClick);
            // 
            // barBtnEditProduct
            // 
            this.barBtnEditProduct.Caption = "Edit Product";
            this.barBtnEditProduct.Id = 4;
            this.barBtnEditProduct.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnEditProduct.ImageOptions.Image")));
            this.barBtnEditProduct.Name = "barBtnEditProduct";
            this.barBtnEditProduct.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnEditProduct.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnEditProduct_ItemClick);
            // 
            // barBtnProductDeletion
            // 
            this.barBtnProductDeletion.Caption = "Product Deletion";
            this.barBtnProductDeletion.Enabled = false;
            this.barBtnProductDeletion.Id = 5;
            this.barBtnProductDeletion.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnProductDeletion.ImageOptions.Image")));
            this.barBtnProductDeletion.Name = "barBtnProductDeletion";
            this.barBtnProductDeletion.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnProductDeletion.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnProductDeletion_ItemClick);
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
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 537);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(822, 31);
            // 
            // groupControlProductDeletion
            // 
            this.groupControlProductDeletion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupControlProductDeletion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupControlProductDeletion.Controls.Add(this.lblUserID);
            this.groupControlProductDeletion.Controls.Add(this.dataGridView);
            this.groupControlProductDeletion.Controls.Add(this.separatorControl2);
            this.groupControlProductDeletion.Controls.Add(this.btnDelete);
            this.groupControlProductDeletion.Location = new System.Drawing.Point(12, 149);
            this.groupControlProductDeletion.Name = "groupControlProductDeletion";
            this.groupControlProductDeletion.Size = new System.Drawing.Size(798, 378);
            this.groupControlProductDeletion.TabIndex = 15;
            this.groupControlProductDeletion.Text = "Product Deletion";
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
            this.dataGridView.Size = new System.Drawing.Size(768, 244);
            this.dataGridView.TabIndex = 34;
            // 
            // separatorControl2
            // 
            this.separatorControl2.Location = new System.Drawing.Point(15, 304);
            this.separatorControl2.Name = "separatorControl2";
            this.separatorControl2.Size = new System.Drawing.Size(768, 23);
            this.separatorControl2.TabIndex = 33;
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.BackColor = System.Drawing.Color.Yellow;
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Appearance.Options.UseBackColor = true;
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.Appearance.Options.UseForeColor = true;
            this.btnDelete.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnDelete.Location = new System.Drawing.Point(299, 334);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(200, 27);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            // ProductDeletionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 568);
            this.Controls.Add(this.groupControlProductDeletion);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProductDeletionForm";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Product Deletion Page";
            this.Load += new System.EventHandler(this.ProductDeletionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlProductDeletion)).EndInit();
            this.groupControlProductDeletion.ResumeLayout(false);
            this.groupControlProductDeletion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem barBtnBack;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barBtnAddProduct;
        private DevExpress.XtraBars.BarButtonItem barBtnAddStock;
        private DevExpress.XtraBars.BarButtonItem barBtnEditProduct;
        private DevExpress.XtraBars.BarButtonItem barBtnProductDeletion;
        private DevExpress.XtraBars.BarButtonItem barBtnListProduct;
        private DevExpress.XtraEditors.GroupControl groupControlProductDeletion;
        private System.Windows.Forms.DataGridView dataGridView;
        private DevExpress.XtraEditors.SeparatorControl separatorControl2;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.LabelControl lblUserID;
    }
}