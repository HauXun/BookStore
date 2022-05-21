namespace BookStore.ChildForm
{
	partial class AddToBill
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			this.pnlDgv = new Guna.UI2.WinForms.Guna2ShadowPanel();
			this.dgvData = new System.Windows.Forms.DataGridView();
			this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ThuongHieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SoLuongTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Cancellation = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.flpFilter = new System.Windows.Forms.FlowLayoutPanel();
			this.btnFilter = new FontAwesome.Sharp.IconButton();
			this.tbSearch = new Guna.UI2.WinForms.Guna2TextBox();
			this.pnlBoxDetail = new Guna.UI2.WinForms.Guna2ShadowPanel();
			this.btnAddToBill = new FontAwesome.Sharp.IconButton();
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
			this.lbGia = new System.Windows.Forms.Label();
			this.lbGiaDetail = new System.Windows.Forms.Label();
			this.lbBack = new System.Windows.Forms.LinkLabel();
			this.Content.SuspendLayout();
			this.pnlDgv.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
			this.pnlBoxDetail.SuspendLayout();
			this.flpDetailProduct.SuspendLayout();
			this.SuspendLayout();
			// 
			// Content
			// 
			this.Content.Controls.Add(this.lbBack);
			this.Content.Controls.Add(this.pnlBoxDetail);
			this.Content.Controls.Add(this.pnlDgv);
			this.Content.Margin = new System.Windows.Forms.Padding(0);
			this.Content.MinimumSize = new System.Drawing.Size(1000, 600);
			this.Content.Padding = new System.Windows.Forms.Padding(50);
			this.Content.Size = new System.Drawing.Size(1330, 600);
			// 
			// pnlDgv
			// 
			this.pnlDgv.BackColor = System.Drawing.Color.Transparent;
			this.pnlDgv.Controls.Add(this.dgvData);
			this.pnlDgv.Controls.Add(this.flpFilter);
			this.pnlDgv.Controls.Add(this.btnFilter);
			this.pnlDgv.Controls.Add(this.tbSearch);
			this.pnlDgv.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
			this.pnlDgv.Location = new System.Drawing.Point(50, 50);
			this.pnlDgv.Margin = new System.Windows.Forms.Padding(0);
			this.pnlDgv.Name = "pnlDgv";
			this.pnlDgv.Padding = new System.Windows.Forms.Padding(20);
			this.pnlDgv.Radius = 5;
			this.pnlDgv.ShadowColor = System.Drawing.Color.Black;
			this.pnlDgv.ShadowDepth = 150;
			this.pnlDgv.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
			this.pnlDgv.Size = new System.Drawing.Size(775, 500);
			this.pnlDgv.TabIndex = 45;
			// 
			// dgvData
			// 
			this.dgvData.AllowUserToAddRows = false;
			this.dgvData.AllowUserToDeleteRows = false;
			this.dgvData.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			this.dgvData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvData.BackgroundColor = System.Drawing.Color.White;
			this.dgvData.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gray;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DimGray;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvData.ColumnHeadersHeight = 40;
			this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.TenSP,
            this.ThuongHieu,
            this.SoLuongTon,
            this.DVT,
            this.Gia,
            this.Cancellation});
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Gray;
			dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
			dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.DimGray;
			dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvData.DefaultCellStyle = dataGridViewCellStyle9;
			this.dgvData.EnableHeadersVisualStyles = false;
			this.dgvData.Location = new System.Drawing.Point(20, 116);
			this.dgvData.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
			this.dgvData.Name = "dgvData";
			this.dgvData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvData.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
			this.dgvData.RowHeadersVisible = false;
			this.dgvData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvData.RowTemplate.Height = 50;
			this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvData.Size = new System.Drawing.Size(735, 364);
			this.dgvData.TabIndex = 65;
			this.dgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellClick);
			// 
			// MaSP
			// 
			this.MaSP.DataPropertyName = "MaSP";
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.MaSP.DefaultCellStyle = dataGridViewCellStyle3;
			this.MaSP.FillWeight = 250F;
			this.MaSP.HeaderText = "Mã sản phẩm";
			this.MaSP.Name = "MaSP";
			this.MaSP.ReadOnly = true;
			this.MaSP.Visible = false;
			// 
			// TenSP
			// 
			this.TenSP.DataPropertyName = "TenSP";
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.TenSP.DefaultCellStyle = dataGridViewCellStyle4;
			this.TenSP.FillWeight = 450F;
			this.TenSP.HeaderText = "Tên sản phẩm";
			this.TenSP.Name = "TenSP";
			this.TenSP.ReadOnly = true;
			// 
			// ThuongHieu
			// 
			this.ThuongHieu.DataPropertyName = "ThuongHieu";
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.ThuongHieu.DefaultCellStyle = dataGridViewCellStyle5;
			this.ThuongHieu.FillWeight = 200F;
			this.ThuongHieu.HeaderText = "Thương hiệu";
			this.ThuongHieu.Name = "ThuongHieu";
			this.ThuongHieu.ReadOnly = true;
			// 
			// SoLuongTon
			// 
			this.SoLuongTon.DataPropertyName = "SoLuongTon";
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.SoLuongTon.DefaultCellStyle = dataGridViewCellStyle6;
			this.SoLuongTon.FillWeight = 200F;
			this.SoLuongTon.HeaderText = "Số lượng tồn";
			this.SoLuongTon.Name = "SoLuongTon";
			this.SoLuongTon.ReadOnly = true;
			// 
			// DVT
			// 
			this.DVT.DataPropertyName = "DVT";
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.DVT.DefaultCellStyle = dataGridViewCellStyle7;
			this.DVT.HeaderText = "DVT";
			this.DVT.Name = "DVT";
			this.DVT.ReadOnly = true;
			// 
			// Gia
			// 
			this.Gia.DataPropertyName = "Gia";
			this.Gia.HeaderText = "Giá";
			this.Gia.Name = "Gia";
			this.Gia.ReadOnly = true;
			// 
			// Cancellation
			// 
			this.Cancellation.DataPropertyName = "Cancellation";
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.Cancellation.DefaultCellStyle = dataGridViewCellStyle8;
			this.Cancellation.HeaderText = "Cancellation";
			this.Cancellation.Name = "Cancellation";
			this.Cancellation.ReadOnly = true;
			this.Cancellation.Visible = false;
			// 
			// flpFilter
			// 
			this.flpFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.flpFilter.AutoScroll = true;
			this.flpFilter.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flpFilter.Location = new System.Drawing.Point(60, 63);
			this.flpFilter.Margin = new System.Windows.Forms.Padding(40, 0, 40, 0);
			this.flpFilter.Name = "flpFilter";
			this.flpFilter.Size = new System.Drawing.Size(655, 48);
			this.flpFilter.TabIndex = 64;
			// 
			// btnFilter
			// 
			this.btnFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnFilter.BackColor = System.Drawing.Color.Transparent;
			this.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnFilter.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
			this.btnFilter.FlatAppearance.BorderSize = 0;
			this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFilter.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
			this.btnFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnFilter.IconChar = FontAwesome.Sharp.IconChar.Filter;
			this.btnFilter.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnFilter.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnFilter.IconSize = 25;
			this.btnFilter.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnFilter.Location = new System.Drawing.Point(600, 23);
			this.btnFilter.Margin = new System.Windows.Forms.Padding(3, 3, 40, 5);
			this.btnFilter.Name = "btnFilter";
			this.btnFilter.Size = new System.Drawing.Size(115, 35);
			this.btnFilter.TabIndex = 62;
			this.btnFilter.TabStop = false;
			this.btnFilter.Text = "Add Filter";
			this.btnFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnFilter.UseVisualStyleBackColor = false;
			// 
			// tbSearch
			// 
			this.tbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.tbSearch.BorderColor = System.Drawing.Color.Gray;
			this.tbSearch.BorderRadius = 5;
			this.tbSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbSearch.DefaultText = "";
			this.tbSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbSearch.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbSearch.ForeColor = System.Drawing.Color.Black;
			this.tbSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbSearch.IconRight = global::BookStore.Properties.Resources.searchIcon;
			this.tbSearch.IconRightCursor = System.Windows.Forms.Cursors.Hand;
			this.tbSearch.Location = new System.Drawing.Point(314, 23);
			this.tbSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 5);
			this.tbSearch.Name = "tbSearch";
			this.tbSearch.PasswordChar = '\0';
			this.tbSearch.PlaceholderText = "Nhập từ khóa ...";
			this.tbSearch.SelectedText = "";
			this.tbSearch.Size = new System.Drawing.Size(281, 35);
			this.tbSearch.TabIndex = 63;
			this.tbSearch.TabStop = false;
			this.tbSearch.IconRightClick += new System.EventHandler(this.tbSearch_IconRightClick);
			this.tbSearch.Enter += new System.EventHandler(this.tbSearch_Enter);
			this.tbSearch.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tbSearch_MouseDoubleClick);
			this.tbSearch.MouseLeave += new System.EventHandler(this.tbSearch_MouseLeave);
			// 
			// pnlBoxDetail
			// 
			this.pnlBoxDetail.BackColor = System.Drawing.Color.Transparent;
			this.pnlBoxDetail.Controls.Add(this.btnAddToBill);
			this.pnlBoxDetail.Controls.Add(this.flpDetailProduct);
			this.pnlBoxDetail.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
			this.pnlBoxDetail.Location = new System.Drawing.Point(839, 50);
			this.pnlBoxDetail.Margin = new System.Windows.Forms.Padding(0);
			this.pnlBoxDetail.Name = "pnlBoxDetail";
			this.pnlBoxDetail.Padding = new System.Windows.Forms.Padding(20);
			this.pnlBoxDetail.Radius = 5;
			this.pnlBoxDetail.ShadowColor = System.Drawing.Color.Black;
			this.pnlBoxDetail.ShadowDepth = 150;
			this.pnlBoxDetail.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
			this.pnlBoxDetail.Size = new System.Drawing.Size(441, 500);
			this.pnlBoxDetail.TabIndex = 46;
			// 
			// btnAddToBill
			// 
			this.btnAddToBill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAddToBill.BackColor = System.Drawing.Color.Transparent;
			this.btnAddToBill.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAddToBill.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
			this.btnAddToBill.FlatAppearance.BorderSize = 0;
			this.btnAddToBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAddToBill.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
			this.btnAddToBill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(229)))));
			this.btnAddToBill.IconChar = FontAwesome.Sharp.IconChar.Plus;
			this.btnAddToBill.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(229)))));
			this.btnAddToBill.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnAddToBill.IconSize = 25;
			this.btnAddToBill.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnAddToBill.Location = new System.Drawing.Point(258, 23);
			this.btnAddToBill.Margin = new System.Windows.Forms.Padding(3, 3, 20, 5);
			this.btnAddToBill.Name = "btnAddToBill";
			this.btnAddToBill.Size = new System.Drawing.Size(159, 35);
			this.btnAddToBill.TabIndex = 64;
			this.btnAddToBill.TabStop = false;
			this.btnAddToBill.Text = "Thêm vào hóa đơn";
			this.btnAddToBill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnAddToBill.UseVisualStyleBackColor = false;
			this.btnAddToBill.Click += new System.EventHandler(this.btnAddToBill_Click);
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
			this.flpDetailProduct.Controls.Add(this.lbGia);
			this.flpDetailProduct.Controls.Add(this.lbGiaDetail);
			this.flpDetailProduct.Controls.Add(this.lbInitProduct);
			this.flpDetailProduct.Controls.Add(this.lbInitProductDetail);
			this.flpDetailProduct.Location = new System.Drawing.Point(23, 66);
			this.flpDetailProduct.Name = "flpDetailProduct";
			this.flpDetailProduct.Size = new System.Drawing.Size(394, 411);
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
			this.lbInitProduct.Location = new System.Drawing.Point(0, 217);
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
			this.lbInitProductDetail.Location = new System.Drawing.Point(0, 241);
			this.lbInitProductDetail.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
			this.lbInitProductDetail.Name = "lbInitProductDetail";
			this.lbInitProductDetail.Size = new System.Drawing.Size(370, 19);
			this.lbInitProductDetail.TabIndex = 83;
			this.lbInitProductDetail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbGia
			// 
			this.lbGia.BackColor = System.Drawing.Color.Transparent;
			this.lbGia.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.lbGia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(85)))));
			this.lbGia.Location = new System.Drawing.Point(0, 169);
			this.lbGia.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
			this.lbGia.Name = "lbGia";
			this.lbGia.Size = new System.Drawing.Size(370, 19);
			this.lbGia.TabIndex = 84;
			this.lbGia.Text = "Giá:";
			// 
			// lbGiaDetail
			// 
			this.lbGiaDetail.BackColor = System.Drawing.Color.Transparent;
			this.lbGiaDetail.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.lbGiaDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(85)))));
			this.lbGiaDetail.Location = new System.Drawing.Point(0, 193);
			this.lbGiaDetail.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
			this.lbGiaDetail.Name = "lbGiaDetail";
			this.lbGiaDetail.Size = new System.Drawing.Size(370, 19);
			this.lbGiaDetail.TabIndex = 85;
			this.lbGiaDetail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbBack
			// 
			this.lbBack.AutoSize = true;
			this.lbBack.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.lbBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(85)))));
			this.lbBack.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
			this.lbBack.LinkColor = System.Drawing.Color.Navy;
			this.lbBack.Location = new System.Drawing.Point(1174, 20);
			this.lbBack.Margin = new System.Windows.Forms.Padding(50, 20, 50, 0);
			this.lbBack.Name = "lbBack";
			this.lbBack.Size = new System.Drawing.Size(82, 21);
			this.lbBack.TabIndex = 47;
			this.lbBack.TabStop = true;
			this.lbBack.Text = "< Quay lại";
			this.lbBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbBack_LinkClicked);
			this.lbBack.MouseEnter += new System.EventHandler(this.lbBack_MouseEnter);
			this.lbBack.MouseLeave += new System.EventHandler(this.lbBack_MouseLeave);
			// 
			// AddToBill
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.MinimumSize = new System.Drawing.Size(1000, 600);
			this.Name = "AddToBill";
			this.Size = new System.Drawing.Size(1330, 600);
			this.Load += new System.EventHandler(this.AddToBill_Load);
			this.Content.ResumeLayout(false);
			this.Content.PerformLayout();
			this.pnlDgv.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
			this.pnlBoxDetail.ResumeLayout(false);
			this.flpDetailProduct.ResumeLayout(false);
			this.flpDetailProduct.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2ShadowPanel pnlDgv;
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
		private System.Windows.Forms.Label lbInitProduct;
		private System.Windows.Forms.Label lbInitProductDetail;
		private FontAwesome.Sharp.IconButton btnAddToBill;
		private System.Windows.Forms.LinkLabel lbBack;
		private System.Windows.Forms.FlowLayoutPanel flpFilter;
		private Guna.UI2.WinForms.Guna2TextBox tbSearch;
		public System.Windows.Forms.DataGridView dgvData;
		public FontAwesome.Sharp.IconButton btnFilter;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
		private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
		private System.Windows.Forms.DataGridViewTextBoxColumn ThuongHieu;
		private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongTon;
		private System.Windows.Forms.DataGridViewTextBoxColumn DVT;
		private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cancellation;
		private System.Windows.Forms.Label lbGia;
		private System.Windows.Forms.Label lbGiaDetail;
	}
}
