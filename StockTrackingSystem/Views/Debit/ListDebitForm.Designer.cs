namespace StockTrackingSystem.Views.Debit
{
    partial class ListDebitForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListDebitForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barBtnBack = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnAddDebit = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnDebitDeletion = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnEditDebit = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnListDebit = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.groupControlListProduct = new DevExpress.XtraEditors.GroupControl();
            this.btnListMyDebitsForPersonnel = new DevExpress.XtraEditors.SimpleButton();
            this.lblUserID = new DevExpress.XtraEditors.LabelControl();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnListAllDebits = new DevExpress.XtraEditors.SimpleButton();
            this.btnListMyDebits = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlListProduct)).BeginInit();
            this.groupControlListProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
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
            this.barButtonItem5,
            this.barButtonItem6,
            this.barBtnListDebit});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 8;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(985, 143);
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
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "barButtonItem5";
            this.barButtonItem5.Id = 5;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "barButtonItem6";
            this.barButtonItem6.Id = 6;
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // barBtnListDebit
            // 
            this.barBtnListDebit.Caption = "List Debit";
            this.barBtnListDebit.Enabled = false;
            this.barBtnListDebit.Id = 7;
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
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 571);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(985, 31);
            // 
            // groupControlListProduct
            // 
            this.groupControlListProduct.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupControlListProduct.Controls.Add(this.btnListMyDebitsForPersonnel);
            this.groupControlListProduct.Controls.Add(this.lblUserID);
            this.groupControlListProduct.Controls.Add(this.dataGridView);
            this.groupControlListProduct.Location = new System.Drawing.Point(12, 151);
            this.groupControlListProduct.Name = "groupControlListProduct";
            this.groupControlListProduct.Size = new System.Drawing.Size(961, 412);
            this.groupControlListProduct.TabIndex = 19;
            this.groupControlListProduct.Text = "Debit List";
            // 
            // btnListMyDebitsForPersonnel
            // 
            this.btnListMyDebitsForPersonnel.Appearance.BackColor = System.Drawing.Color.Yellow;
            this.btnListMyDebitsForPersonnel.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btnListMyDebitsForPersonnel.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnListMyDebitsForPersonnel.Appearance.Options.UseBackColor = true;
            this.btnListMyDebitsForPersonnel.Appearance.Options.UseFont = true;
            this.btnListMyDebitsForPersonnel.Appearance.Options.UseForeColor = true;
            this.btnListMyDebitsForPersonnel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnListMyDebitsForPersonnel.Location = new System.Drawing.Point(380, 369);
            this.btnListMyDebitsForPersonnel.Name = "btnListMyDebitsForPersonnel";
            this.btnListMyDebitsForPersonnel.Size = new System.Drawing.Size(200, 27);
            this.btnListMyDebitsForPersonnel.TabIndex = 51;
            this.btnListMyDebitsForPersonnel.Text = "List My Debits";
            this.btnListMyDebitsForPersonnel.Click += new System.EventHandler(this.btnListMyDebitsForPersonnel_Click);
            // 
            // lblUserID
            // 
            this.lblUserID.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblUserID.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblUserID.Appearance.Options.UseFont = true;
            this.lblUserID.Appearance.Options.UseForeColor = true;
            this.lblUserID.Location = new System.Drawing.Point(15, 30);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(78, 19);
            this.lblUserID.TabIndex = 64;
            this.lblUserID.Text = "Debit List";
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
            this.dataGridView.Size = new System.Drawing.Size(931, 300);
            this.dataGridView.TabIndex = 34;
            // 
            // btnListAllDebits
            // 
            this.btnListAllDebits.Appearance.BackColor = System.Drawing.Color.Yellow;
            this.btnListAllDebits.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btnListAllDebits.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnListAllDebits.Appearance.Options.UseBackColor = true;
            this.btnListAllDebits.Appearance.Options.UseFont = true;
            this.btnListAllDebits.Appearance.Options.UseForeColor = true;
            this.btnListAllDebits.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnListAllDebits.Location = new System.Drawing.Point(598, 520);
            this.btnListAllDebits.Name = "btnListAllDebits";
            this.btnListAllDebits.Size = new System.Drawing.Size(200, 27);
            this.btnListAllDebits.TabIndex = 50;
            this.btnListAllDebits.Text = "List All Debits";
            this.btnListAllDebits.Click += new System.EventHandler(this.btnListAllDebits_Click);
            // 
            // btnListMyDebits
            // 
            this.btnListMyDebits.Appearance.BackColor = System.Drawing.Color.Yellow;
            this.btnListMyDebits.Appearance.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.btnListMyDebits.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnListMyDebits.Appearance.Options.UseBackColor = true;
            this.btnListMyDebits.Appearance.Options.UseFont = true;
            this.btnListMyDebits.Appearance.Options.UseForeColor = true;
            this.btnListMyDebits.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.btnListMyDebits.Location = new System.Drawing.Point(186, 520);
            this.btnListMyDebits.Name = "btnListMyDebits";
            this.btnListMyDebits.Size = new System.Drawing.Size(200, 27);
            this.btnListMyDebits.TabIndex = 49;
            this.btnListMyDebits.Text = "List My Debits";
            this.btnListMyDebits.Click += new System.EventHandler(this.btnListMyDebits_Click);
            // 
            // ListDebitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 602);
            this.Controls.Add(this.btnListAllDebits);
            this.Controls.Add(this.btnListMyDebits);
            this.Controls.Add(this.groupControlListProduct);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListDebitForm";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "List Debit Page";
            this.Load += new System.EventHandler(this.ListDebitForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlListProduct)).EndInit();
            this.groupControlListProduct.ResumeLayout(false);
            this.groupControlListProduct.PerformLayout();
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
        private DevExpress.XtraBars.BarButtonItem barBtnAddDebit;
        private DevExpress.XtraBars.BarButtonItem barBtnDebitDeletion;
        private DevExpress.XtraBars.BarButtonItem barBtnEditDebit;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem barBtnListDebit;
        private DevExpress.XtraEditors.GroupControl groupControlListProduct;
        private DevExpress.XtraEditors.LabelControl lblUserID;
        private System.Windows.Forms.DataGridView dataGridView;
        private DevExpress.XtraEditors.SimpleButton btnListMyDebitsForPersonnel;
        private DevExpress.XtraEditors.SimpleButton btnListAllDebits;
        private DevExpress.XtraEditors.SimpleButton btnListMyDebits;
    }
}