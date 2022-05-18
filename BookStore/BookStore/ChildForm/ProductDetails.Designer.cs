namespace BookStore.ChildForm
{
	partial class ProductDetails
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.pnlContent = new System.Windows.Forms.Panel();
			this.btnDeleteProduct = new FontAwesome.Sharp.IconButton();
			this.lbDpkHeader = new System.Windows.Forms.Label();
			this.dpkHeader1 = new Bunifu.Framework.UI.BunifuDatepicker();
			this.dpkHeader2 = new Bunifu.Framework.UI.BunifuDatepicker();
			this.pnlBoxDetail = new Guna.UI2.WinForms.Guna2ShadowPanel();
			this.flpDetailProduct = new System.Windows.Forms.FlowLayoutPanel();
			this.lbIDProduct = new System.Windows.Forms.Label();
			this.lbIDProductDetail = new System.Windows.Forms.Label();
			this.lbProductName = new System.Windows.Forms.Label();
			this.lbProductNameDetail = new System.Windows.Forms.Label();
			this.lbProductBrand = new System.Windows.Forms.Label();
			this.lbProductBrandDetail = new System.Windows.Forms.Label();
			this.lbProductStock = new System.Windows.Forms.Label();
			this.lbProductStockDetail = new System.Windows.Forms.Label();
			this.lbInitProduct = new System.Windows.Forms.Label();
			this.lbInitProductDetail = new System.Windows.Forms.Label();
			this.lbDetailTitle = new System.Windows.Forms.Label();
			this.pnlBillsBox = new Guna.UI2.WinForms.Guna2ShadowPanel();
			this.flpBillsBoxDetails = new System.Windows.Forms.FlowLayoutPanel();
			this.lbBillsBoxTitle = new System.Windows.Forms.Label();
			this.lbBack = new System.Windows.Forms.LinkLabel();
			this.Content.SuspendLayout();
			this.pnlContent.SuspendLayout();
			this.pnlBoxDetail.SuspendLayout();
			this.flpDetailProduct.SuspendLayout();
			this.pnlBillsBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// Content
			// 
			this.Content.Controls.Add(this.lbBack);
			this.Content.Controls.Add(this.pnlContent);
			this.Content.Padding = new System.Windows.Forms.Padding(50);
			this.Content.Size = new System.Drawing.Size(1000, 600);
			// 
			// pnlContent
			// 
			this.pnlContent.Controls.Add(this.btnDeleteProduct);
			this.pnlContent.Controls.Add(this.lbDpkHeader);
			this.pnlContent.Controls.Add(this.dpkHeader1);
			this.pnlContent.Controls.Add(this.dpkHeader2);
			this.pnlContent.Controls.Add(this.pnlBoxDetail);
			this.pnlContent.Controls.Add(this.pnlBillsBox);
			this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlContent.Location = new System.Drawing.Point(50, 50);
			this.pnlContent.Margin = new System.Windows.Forms.Padding(0);
			this.pnlContent.Name = "pnlContent";
			this.pnlContent.Size = new System.Drawing.Size(900, 500);
			this.pnlContent.TabIndex = 1;
			// 
			// btnDeleteProduct
			// 
			this.btnDeleteProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDeleteProduct.BackColor = System.Drawing.Color.Transparent;
			this.btnDeleteProduct.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDeleteProduct.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
			this.btnDeleteProduct.FlatAppearance.BorderSize = 0;
			this.btnDeleteProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDeleteProduct.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
			this.btnDeleteProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnDeleteProduct.IconChar = FontAwesome.Sharp.IconChar.Times;
			this.btnDeleteProduct.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnDeleteProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnDeleteProduct.IconSize = 25;
			this.btnDeleteProduct.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnDeleteProduct.Location = new System.Drawing.Point(4, 3);
			this.btnDeleteProduct.Margin = new System.Windows.Forms.Padding(3, 3, 20, 5);
			this.btnDeleteProduct.Name = "btnDeleteProduct";
			this.btnDeleteProduct.Size = new System.Drawing.Size(171, 36);
			this.btnDeleteProduct.TabIndex = 10;
			this.btnDeleteProduct.TabStop = false;
			this.btnDeleteProduct.Text = "Hủy sản phẩm này";
			this.btnDeleteProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnDeleteProduct.UseVisualStyleBackColor = false;
			this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
			// 
			// lbDpkHeader
			// 
			this.lbDpkHeader.AutoSize = true;
			this.lbDpkHeader.Font = new System.Drawing.Font("Tahoma", 12F);
			this.lbDpkHeader.ForeColor = System.Drawing.Color.DimGray;
			this.lbDpkHeader.Location = new System.Drawing.Point(666, 13);
			this.lbDpkHeader.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
			this.lbDpkHeader.Name = "lbDpkHeader";
			this.lbDpkHeader.Size = new System.Drawing.Size(28, 19);
			this.lbDpkHeader.TabIndex = 8;
			this.lbDpkHeader.Text = "To";
			// 
			// dpkHeader1
			// 
			this.dpkHeader1.BackColor = System.Drawing.Color.White;
			this.dpkHeader1.BorderRadius = 0;
			this.dpkHeader1.ForeColor = System.Drawing.Color.DimGray;
			this.dpkHeader1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpkHeader1.FormatCustom = "MMM/dd/yyyy";
			this.dpkHeader1.Location = new System.Drawing.Point(460, 3);
			this.dpkHeader1.Name = "dpkHeader1";
			this.dpkHeader1.Size = new System.Drawing.Size(200, 36);
			this.dpkHeader1.TabIndex = 7;
			this.dpkHeader1.Value = new System.DateTime(2022, 4, 13, 0, 0, 0, 0);
			this.dpkHeader1.onValueChanged += new System.EventHandler(this.dpkHeader1_onValueChanged);
			// 
			// dpkHeader2
			// 
			this.dpkHeader2.BackColor = System.Drawing.Color.White;
			this.dpkHeader2.BorderRadius = 0;
			this.dpkHeader2.ForeColor = System.Drawing.Color.DimGray;
			this.dpkHeader2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpkHeader2.FormatCustom = "MMM/dd/yyyy";
			this.dpkHeader2.Location = new System.Drawing.Point(700, 3);
			this.dpkHeader2.Margin = new System.Windows.Forms.Padding(3, 3, 60, 3);
			this.dpkHeader2.Name = "dpkHeader2";
			this.dpkHeader2.Size = new System.Drawing.Size(200, 36);
			this.dpkHeader2.TabIndex = 6;
			this.dpkHeader2.Value = new System.DateTime(2022, 4, 13, 0, 0, 0, 0);
			this.dpkHeader2.onValueChanged += new System.EventHandler(this.dpkHeader1_onValueChanged);
			// 
			// pnlBoxDetail
			// 
			this.pnlBoxDetail.BackColor = System.Drawing.Color.Transparent;
			this.pnlBoxDetail.Controls.Add(this.flpDetailProduct);
			this.pnlBoxDetail.Controls.Add(this.lbDetailTitle);
			this.pnlBoxDetail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
			this.pnlBoxDetail.Location = new System.Drawing.Point(0, 42);
			this.pnlBoxDetail.Margin = new System.Windows.Forms.Padding(0);
			this.pnlBoxDetail.Name = "pnlBoxDetail";
			this.pnlBoxDetail.Padding = new System.Windows.Forms.Padding(20);
			this.pnlBoxDetail.Radius = 5;
			this.pnlBoxDetail.ShadowColor = System.Drawing.Color.Black;
			this.pnlBoxDetail.ShadowDepth = 150;
			this.pnlBoxDetail.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
			this.pnlBoxDetail.Size = new System.Drawing.Size(441, 458);
			this.pnlBoxDetail.TabIndex = 3;
			// 
			// flpDetailProduct
			// 
			this.flpDetailProduct.AutoScroll = true;
			this.flpDetailProduct.Controls.Add(this.lbIDProduct);
			this.flpDetailProduct.Controls.Add(this.lbIDProductDetail);
			this.flpDetailProduct.Controls.Add(this.lbProductName);
			this.flpDetailProduct.Controls.Add(this.lbProductNameDetail);
			this.flpDetailProduct.Controls.Add(this.lbProductBrand);
			this.flpDetailProduct.Controls.Add(this.lbProductBrandDetail);
			this.flpDetailProduct.Controls.Add(this.lbProductStock);
			this.flpDetailProduct.Controls.Add(this.lbProductStockDetail);
			this.flpDetailProduct.Controls.Add(this.lbInitProduct);
			this.flpDetailProduct.Controls.Add(this.lbInitProductDetail);
			this.flpDetailProduct.Location = new System.Drawing.Point(23, 53);
			this.flpDetailProduct.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
			this.flpDetailProduct.Name = "flpDetailProduct";
			this.flpDetailProduct.Size = new System.Drawing.Size(394, 382);
			this.flpDetailProduct.TabIndex = 13;
			// 
			// lbIDProduct
			// 
			this.lbIDProduct.BackColor = System.Drawing.Color.Transparent;
			this.lbIDProduct.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.lbIDProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(85)))));
			this.lbIDProduct.Location = new System.Drawing.Point(0, 0);
			this.lbIDProduct.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
			this.lbIDProduct.Name = "lbIDProduct";
			this.lbIDProduct.Size = new System.Drawing.Size(370, 19);
			this.lbIDProduct.TabIndex = 71;
			this.lbIDProduct.Text = "Mã sản phẩm:";
			// 
			// lbIDProductDetail
			// 
			this.lbIDProductDetail.BackColor = System.Drawing.Color.Transparent;
			this.lbIDProductDetail.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.lbIDProductDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(85)))));
			this.lbIDProductDetail.Location = new System.Drawing.Point(0, 24);
			this.lbIDProductDetail.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
			this.lbIDProductDetail.Name = "lbIDProductDetail";
			this.lbIDProductDetail.Size = new System.Drawing.Size(370, 19);
			this.lbIDProductDetail.TabIndex = 75;
			this.lbIDProductDetail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbProductName
			// 
			this.lbProductName.BackColor = System.Drawing.Color.Transparent;
			this.lbProductName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.lbProductName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(85)))));
			this.lbProductName.Location = new System.Drawing.Point(0, 48);
			this.lbProductName.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
			this.lbProductName.Name = "lbProductName";
			this.lbProductName.Size = new System.Drawing.Size(370, 19);
			this.lbProductName.TabIndex = 76;
			this.lbProductName.Text = "Tên sản phẩm:";
			// 
			// lbProductNameDetail
			// 
			this.lbProductNameDetail.AutoSize = true;
			this.lbProductNameDetail.BackColor = System.Drawing.Color.Transparent;
			this.lbProductNameDetail.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.lbProductNameDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(85)))));
			this.lbProductNameDetail.Location = new System.Drawing.Point(370, 48);
			this.lbProductNameDetail.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
			this.lbProductNameDetail.Name = "lbProductNameDetail";
			this.lbProductNameDetail.Size = new System.Drawing.Size(0, 20);
			this.lbProductNameDetail.TabIndex = 77;
			this.lbProductNameDetail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbProductBrand
			// 
			this.lbProductBrand.BackColor = System.Drawing.Color.Transparent;
			this.lbProductBrand.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.lbProductBrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(85)))));
			this.lbProductBrand.Location = new System.Drawing.Point(0, 73);
			this.lbProductBrand.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
			this.lbProductBrand.Name = "lbProductBrand";
			this.lbProductBrand.Size = new System.Drawing.Size(370, 19);
			this.lbProductBrand.TabIndex = 78;
			this.lbProductBrand.Text = "Thương hiệu:";
			// 
			// lbProductBrandDetail
			// 
			this.lbProductBrandDetail.BackColor = System.Drawing.Color.Transparent;
			this.lbProductBrandDetail.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.lbProductBrandDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(85)))));
			this.lbProductBrandDetail.Location = new System.Drawing.Point(0, 97);
			this.lbProductBrandDetail.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
			this.lbProductBrandDetail.Name = "lbProductBrandDetail";
			this.lbProductBrandDetail.Size = new System.Drawing.Size(370, 19);
			this.lbProductBrandDetail.TabIndex = 79;
			this.lbProductBrandDetail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbProductStock
			// 
			this.lbProductStock.BackColor = System.Drawing.Color.Transparent;
			this.lbProductStock.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.lbProductStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(85)))));
			this.lbProductStock.Location = new System.Drawing.Point(0, 121);
			this.lbProductStock.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
			this.lbProductStock.Name = "lbProductStock";
			this.lbProductStock.Size = new System.Drawing.Size(370, 19);
			this.lbProductStock.TabIndex = 80;
			this.lbProductStock.Text = "Số lượng tồn:";
			// 
			// lbProductStockDetail
			// 
			this.lbProductStockDetail.BackColor = System.Drawing.Color.Transparent;
			this.lbProductStockDetail.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.lbProductStockDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(85)))));
			this.lbProductStockDetail.Location = new System.Drawing.Point(0, 145);
			this.lbProductStockDetail.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
			this.lbProductStockDetail.Name = "lbProductStockDetail";
			this.lbProductStockDetail.Size = new System.Drawing.Size(370, 19);
			this.lbProductStockDetail.TabIndex = 81;
			this.lbProductStockDetail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbInitProduct
			// 
			this.lbInitProduct.BackColor = System.Drawing.Color.Transparent;
			this.lbInitProduct.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.lbInitProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(85)))));
			this.lbInitProduct.Location = new System.Drawing.Point(0, 169);
			this.lbInitProduct.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
			this.lbInitProduct.Name = "lbInitProduct";
			this.lbInitProduct.Size = new System.Drawing.Size(370, 19);
			this.lbInitProduct.TabIndex = 82;
			this.lbInitProduct.Text = "Đơn vị tính:";
			// 
			// lbInitProductDetail
			// 
			this.lbInitProductDetail.BackColor = System.Drawing.Color.Transparent;
			this.lbInitProductDetail.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.lbInitProductDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(85)))));
			this.lbInitProductDetail.Location = new System.Drawing.Point(0, 193);
			this.lbInitProductDetail.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
			this.lbInitProductDetail.Name = "lbInitProductDetail";
			this.lbInitProductDetail.Size = new System.Drawing.Size(370, 19);
			this.lbInitProductDetail.TabIndex = 83;
			this.lbInitProductDetail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbDetailTitle
			// 
			this.lbDetailTitle.AutoSize = true;
			this.lbDetailTitle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.lbDetailTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(69)))));
			this.lbDetailTitle.Location = new System.Drawing.Point(23, 24);
			this.lbDetailTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
			this.lbDetailTitle.Name = "lbDetailTitle";
			this.lbDetailTitle.Size = new System.Drawing.Size(152, 19);
			this.lbDetailTitle.TabIndex = 7;
			this.lbDetailTitle.Text = "Chi tiết sản phẩm";
			// 
			// pnlBillsBox
			// 
			this.pnlBillsBox.BackColor = System.Drawing.Color.Transparent;
			this.pnlBillsBox.Controls.Add(this.flpBillsBoxDetails);
			this.pnlBillsBox.Controls.Add(this.lbBillsBoxTitle);
			this.pnlBillsBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
			this.pnlBillsBox.Location = new System.Drawing.Point(459, 42);
			this.pnlBillsBox.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.pnlBillsBox.Name = "pnlBillsBox";
			this.pnlBillsBox.Padding = new System.Windows.Forms.Padding(20);
			this.pnlBillsBox.Radius = 5;
			this.pnlBillsBox.ShadowColor = System.Drawing.Color.Black;
			this.pnlBillsBox.ShadowDepth = 150;
			this.pnlBillsBox.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
			this.pnlBillsBox.Size = new System.Drawing.Size(441, 458);
			this.pnlBillsBox.TabIndex = 2;
			// 
			// flpBillsBoxDetails
			// 
			this.flpBillsBoxDetails.AutoScroll = true;
			this.flpBillsBoxDetails.Location = new System.Drawing.Point(23, 53);
			this.flpBillsBoxDetails.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
			this.flpBillsBoxDetails.Name = "flpBillsBoxDetails";
			this.flpBillsBoxDetails.Size = new System.Drawing.Size(394, 382);
			this.flpBillsBoxDetails.TabIndex = 13;
			// 
			// lbBillsBoxTitle
			// 
			this.lbBillsBoxTitle.AutoSize = true;
			this.lbBillsBoxTitle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.lbBillsBoxTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(69)))));
			this.lbBillsBoxTitle.Location = new System.Drawing.Point(23, 24);
			this.lbBillsBoxTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
			this.lbBillsBoxTitle.Name = "lbBillsBoxTitle";
			this.lbBillsBoxTitle.Size = new System.Drawing.Size(293, 19);
			this.lbBillsBoxTitle.TabIndex = 7;
			this.lbBillsBoxTitle.Text = "Các hóa đơn gần đây của sản phẩm";
			// 
			// lbBack
			// 
			this.lbBack.AutoSize = true;
			this.lbBack.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.lbBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(85)))));
			this.lbBack.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
			this.lbBack.LinkColor = System.Drawing.Color.Navy;
			this.lbBack.Location = new System.Drawing.Point(868, 20);
			this.lbBack.Margin = new System.Windows.Forms.Padding(50, 20, 50, 0);
			this.lbBack.Name = "lbBack";
			this.lbBack.Size = new System.Drawing.Size(82, 21);
			this.lbBack.TabIndex = 27;
			this.lbBack.TabStop = true;
			this.lbBack.Text = "< Quay lại";
			this.lbBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbBack_LinkClicked);
			this.lbBack.MouseEnter += new System.EventHandler(this.lbBack_MouseEnter);
			this.lbBack.MouseLeave += new System.EventHandler(this.lbBack_MouseLeave);
			// 
			// ProductDetails
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.White;
			this.Margin = new System.Windows.Forms.Padding(0);
			this.Name = "ProductDetails";
			this.Size = new System.Drawing.Size(1000, 600);
			this.Load += new System.EventHandler(this.ProductDetails_Load);
			this.Content.ResumeLayout(false);
			this.Content.PerformLayout();
			this.pnlContent.ResumeLayout(false);
			this.pnlContent.PerformLayout();
			this.pnlBoxDetail.ResumeLayout(false);
			this.pnlBoxDetail.PerformLayout();
			this.flpDetailProduct.ResumeLayout(false);
			this.flpDetailProduct.PerformLayout();
			this.pnlBillsBox.ResumeLayout(false);
			this.pnlBillsBox.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.LinkLabel lbBack;
		private System.Windows.Forms.Panel pnlContent;
		private System.Windows.Forms.Label lbDpkHeader;
		private Bunifu.Framework.UI.BunifuDatepicker dpkHeader1;
		private Bunifu.Framework.UI.BunifuDatepicker dpkHeader2;
		private Guna.UI2.WinForms.Guna2ShadowPanel pnlBoxDetail;
		private System.Windows.Forms.FlowLayoutPanel flpDetailProduct;
		private System.Windows.Forms.Label lbIDProduct;
		private System.Windows.Forms.Label lbIDProductDetail;
		private System.Windows.Forms.Label lbProductName;
		private System.Windows.Forms.Label lbProductNameDetail;
		private System.Windows.Forms.Label lbProductBrand;
		private System.Windows.Forms.Label lbProductBrandDetail;
		private System.Windows.Forms.Label lbProductStock;
		private System.Windows.Forms.Label lbProductStockDetail;
		private System.Windows.Forms.Label lbDetailTitle;
		private Guna.UI2.WinForms.Guna2ShadowPanel pnlBillsBox;
		private System.Windows.Forms.FlowLayoutPanel flpBillsBoxDetails;
		private System.Windows.Forms.Label lbBillsBoxTitle;
		private FontAwesome.Sharp.IconButton btnDeleteProduct;
		private System.Windows.Forms.Label lbInitProduct;
		private System.Windows.Forms.Label lbInitProductDetail;
	}
}
