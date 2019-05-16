namespace StockTrackingSystem.Views.Products
{
    partial class ListProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListProductForm));
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
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.groupControlListProduct = new DevExpress.XtraEditors.GroupControl();
            this.btnListAllProducts = new DevExpress.XtraEditors.SimpleButton();
            this.btnListMyProducts = new DevExpress.XtraEditors.SimpleButton();
            this.separatorControl3 = new DevExpress.XtraEditors.SeparatorControl();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnRefreshMyList = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlListProduct)).BeginInit();
            this.groupControlListProduct.SuspendLayout();
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
            this.ribbon.Size = new System.Drawing.Size(862, 143);
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
            this.barBtnProductDeletion.Id = 5;
            this.barBtnProductDeletion.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnProductDeletion.ImageOptions.Image")));
            this.barBtnProductDeletion.Name = "barBtnProductDeletion";
            this.barBtnProductDeletion.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtnProductDeletion.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnProductDeletion_ItemClick);
            // 
            // barBtnListProduct
            // 
            this.barBtnListProduct.Caption = "List Product";
            this.barBtnListProduct.Enabled = false;
            this.barBtnListProduct.Id = 6;
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
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 579);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(862, 31);
            // 
            // groupControlListProduct
            // 
            this.groupControlListProduct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupControlListProduct.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupControlListProduct.Controls.Add(this.btnListAllProducts);
            this.groupControlListProduct.Controls.Add(this.btnListMyProducts);
            this.groupControlListProduct.Controls.Add(this.separatorControl3);
            this.groupControlListProduct.Controls.Add(this.dataGridView);
            this.groupControlListProduct.Controls.Add(this.btnRefreshMyList);
            this.groupControlListProduct.Location = new System.Drawing.Point(12, 149);
            this.groupControlListProduct.Name = "groupControlListProduct";
            this.groupControlListProduct.Size = new System.Drawing.Size(838, 424);
            this.groupControlListProduct.TabIndex = 16;
            this.groupControlListProduct.Text = "List Product";
            // 
            // btnListAllProducts
            // 
            this.btnListAllProducts.Appearance.BackColor = System.Drawing.Color.Yellow;
            this.btnListAllProducts.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btnListAllProducts.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnListAllProducts.Appearance.Options.UseBackColor = true;
            this.btnListAllProducts.Appearance.Options.UseFont = true;
            this.btnListAllProducts.Appearance.Options.UseForeColor = true;
            this.btnListAllProducts.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnListAllProducts.Location = new System.Drawing.Point(525, 378);
            this.btnListAllProducts.Name = "btnListAllProducts";
            this.btnListAllProducts.Size = new System.Drawing.Size(200, 27);
            this.btnListAllProducts.TabIndex = 48;
            this.btnListAllProducts.Text = "List All Products";
            this.btnListAllProducts.Click += new System.EventHandler(this.btnListAllProducts_Click);
            // 
            // btnListMyProducts
            // 
            this.btnListMyProducts.Appearance.BackColor = System.Drawing.Color.Yellow;
            this.btnListMyProducts.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btnListMyProducts.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnListMyProducts.Appearance.Options.UseBackColor = true;
            this.btnListMyProducts.Appearance.Options.UseFont = true;
            this.btnListMyProducts.Appearance.Options.UseForeColor = true;
            this.btnListMyProducts.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnListMyProducts.Location = new System.Drawing.Point(113, 378);
            this.btnListMyProducts.Name = "btnListMyProducts";
            this.btnListMyProducts.Size = new System.Drawing.Size(200, 27);
            this.btnListMyProducts.TabIndex = 47;
            this.btnListMyProducts.Text = "List My Products";
            this.btnListMyProducts.Click += new System.EventHandler(this.btnListMyProducts_Click);
            // 
            // separatorControl3
            // 
            this.separatorControl3.Location = new System.Drawing.Point(15, 348);
            this.separatorControl3.Name = "separatorControl3";
            this.separatorControl3.Size = new System.Drawing.Size(808, 23);
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
            this.dataGridView.Location = new System.Drawing.Point(15, 32);
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
            this.dataGridView.Size = new System.Drawing.Size(808, 310);
            this.dataGridView.TabIndex = 34;
            // 
            // btnRefreshMyList
            // 
            this.btnRefreshMyList.Appearance.BackColor = System.Drawing.Color.Yellow;
            this.btnRefreshMyList.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btnRefreshMyList.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnRefreshMyList.Appearance.Options.UseBackColor = true;
            this.btnRefreshMyList.Appearance.Options.UseFont = true;
            this.btnRefreshMyList.Appearance.Options.UseForeColor = true;
            this.btnRefreshMyList.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnRefreshMyList.Location = new System.Drawing.Point(319, 378);
            this.btnRefreshMyList.Name = "btnRefreshMyList";
            this.btnRefreshMyList.Size = new System.Drawing.Size(200, 27);
            this.btnRefreshMyList.TabIndex = 23;
            this.btnRefreshMyList.Text = "Refresh My List";
            this.btnRefreshMyList.Click += new System.EventHandler(this.btnRefreshMyList_Click);
            // 
            // ListProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 610);
            this.Controls.Add(this.groupControlListProduct);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListProductForm";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "List Product Page";
            this.Load += new System.EventHandler(this.ListProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlListProduct)).EndInit();
            this.groupControlListProduct.ResumeLayout(false);
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
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem barBtnAddProduct;
        private DevExpress.XtraBars.BarButtonItem barBtnAddStock;
        private DevExpress.XtraBars.BarButtonItem barBtnEditProduct;
        private DevExpress.XtraBars.BarButtonItem barBtnProductDeletion;
        private DevExpress.XtraBars.BarButtonItem barBtnListProduct;
        private DevExpress.XtraEditors.GroupControl groupControlListProduct;
        private DevExpress.XtraEditors.SeparatorControl separatorControl3;
        private System.Windows.Forms.DataGridView dataGridView;
        private DevExpress.XtraEditors.SimpleButton btnRefreshMyList;
        private DevExpress.XtraEditors.SimpleButton btnListAllProducts;
        private DevExpress.XtraEditors.SimpleButton btnListMyProducts;
    }
}