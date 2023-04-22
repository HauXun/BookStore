
namespace BookStore.Pages
{
	partial class Product
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
			this.components = new System.ComponentModel.Container();
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product));
			this.pnlDgv = new Guna.UI2.WinForms.Guna2ShadowPanel();
			this.btnNewProduct = new FontAwesome.Sharp.IconButton();
			this.dgvData = new System.Windows.Forms.DataGridView();
			this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ThuongHieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SoLuongTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Cancellation = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cmsCancelProduct = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
			this.cancelProductCMS = new System.Windows.Forms.ToolStripMenuItem();
			this.detailProductCMS = new System.Windows.Forms.ToolStripMenuItem();
			this.flpFilter = new System.Windows.Forms.FlowLayoutPanel();
			this.btnFilter = new FontAwesome.Sharp.IconButton();
			this.tbSearch = new Guna.UI2.WinForms.Guna2TextBox();
			this.paneBottomLineTitleBar = new System.Windows.Forms.Panel();
			this.BottomLineTitleBar = new System.Windows.Forms.Panel();
			this.doughnutChartStock = new Bunifu.Charts.WinForms.ChartTypes.BunifuDoughnutChart(this.components);
			this.chartStock = new Bunifu.Charts.WinForms.BunifuChartCanvas();
			this.lbHeaderBox2Title = new System.Windows.Forms.Label();
			this.lbHeaderBox2Detail = new System.Windows.Forms.Label();
			this.tlpHeader = new System.Windows.Forms.TableLayoutPanel();
			this.pnlHeaderBox2 = new Guna.UI2.WinForms.Guna2GradientPanel();
			this.pnlHeaderBox1 = new Guna.UI2.WinForms.Guna2GradientPanel();
			this.lbHeaderBox1Title = new System.Windows.Forms.Label();
			this.lbHeaderBox1Detail = new System.Windows.Forms.Label();
			this.chartPieConsume = new Bunifu.Charts.WinForms.ChartTypes.BunifuPieChart(this.components);
			this.chartBarBestSellerProduct = new Bunifu.Charts.WinForms.ChartTypes.BunifuBarChart(this.components);
			this.chartHorizontalBestsellterProduct = new Bunifu.Charts.WinForms.ChartTypes.BunifuHorizontalBarChart(this.components);
			this.chartBestsellerProduct = new Bunifu.Charts.WinForms.BunifuChartCanvas();
			this.pnlChartBestsellterBox = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
			this.pnlDgv.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
			this.cmsCancelProduct.SuspendLayout();
			this.paneBottomLineTitleBar.SuspendLayout();
			this.tlpHeader.SuspendLayout();
			this.pnlHeaderBox2.SuspendLayout();
			this.pnlHeaderBox1.SuspendLayout();
			this.pnlChartBestsellterBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlDgv
			// 
			this.pnlDgv.BackColor = System.Drawing.Color.Transparent;
			this.pnlDgv.Controls.Add(this.btnNewProduct);
			this.pnlDgv.Controls.Add(this.dgvData);
			this.pnlDgv.Controls.Add(this.flpFilter);
			this.pnlDgv.Controls.Add(this.btnFilter);
			this.pnlDgv.Controls.Add(this.tbSearch);
			this.pnlDgv.FillColor = System.Drawing.Color.White;
			this.pnlDgv.Location = new System.Drawing.Point(53, 400);
			this.pnlDgv.Margin = new System.Windows.Forms.Padding(0, 3, 30, 30);
			this.pnlDgv.Name = "pnlDgv";
			this.pnlDgv.Radius = 5;
			this.pnlDgv.ShadowColor = System.Drawing.Color.Black;
			this.pnlDgv.ShadowDepth = 0;
			this.pnlDgv.ShadowShift = 0;
			this.pnlDgv.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
			this.pnlDgv.Size = new System.Drawing.Size(1206, 397);
			this.pnlDgv.TabIndex = 44;
			// 
			// btnNewProduct
			// 
			this.btnNewProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnNewProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(85)))));
			this.btnNewProduct.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNewProduct.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
			this.btnNewProduct.FlatAppearance.BorderSize = 0;
			this.btnNewProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNewProduct.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
			this.btnNewProduct.ForeColor = System.Drawing.Color.White;
			this.btnNewProduct.IconChar = FontAwesome.Sharp.IconChar.Plus;
			this.btnNewProduct.IconColor = System.Drawing.Color.White;
			this.btnNewProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnNewProduct.IconSize = 25;
			this.btnNewProduct.Location = new System.Drawing.Point(72, 10);
			this.btnNewProduct.Margin = new System.Windows.Forms.Padding(3, 3, 20, 5);
			this.btnNewProduct.Name = "btnNewProduct";
			this.btnNewProduct.Padding = new System.Windows.Forms.Padding(1, 2, 0, 0);
			this.btnNewProduct.Size = new System.Drawing.Size(35, 35);
			this.btnNewProduct.TabIndex = 62;
			this.btnNewProduct.TabStop = false;
			this.btnNewProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnNewProduct.UseVisualStyleBackColor = false;
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
            this.Cancellation});
			this.dgvData.ContextMenuStrip = this.cmsCancelProduct;
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Gray;
			dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
			dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.DimGray;
			dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvData.DefaultCellStyle = dataGridViewCellStyle9;
			this.dgvData.EnableHeadersVisualStyles = false;
			this.dgvData.Location = new System.Drawing.Point(0, 101);
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
			this.dgvData.Size = new System.Drawing.Size(1206, 296);
			this.dgvData.TabIndex = 61;
			this.dgvData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvData_CellDoubleClick);
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
			// Cancellation
			// 
			this.Cancellation.DataPropertyName = "Cancellation";
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.Cancellation.DefaultCellStyle = dataGridViewCellStyle8;
			this.Cancellation.HeaderText = "Cancellation";
			this.Cancellation.Name = "Cancellation";
			this.Cancellation.ReadOnly = true;
			// 
			// cmsCancelProduct
			// 
			this.cmsCancelProduct.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cancelProductCMS,
            this.detailProductCMS});
			this.cmsCancelProduct.Name = "cmsCancelProduct";
			this.cmsCancelProduct.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
			this.cmsCancelProduct.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
			this.cmsCancelProduct.RenderStyle.ColorTable = null;
			this.cmsCancelProduct.RenderStyle.RoundedEdges = true;
			this.cmsCancelProduct.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
			this.cmsCancelProduct.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.cmsCancelProduct.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
			this.cmsCancelProduct.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
			this.cmsCancelProduct.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
			this.cmsCancelProduct.Size = new System.Drawing.Size(168, 48);
			// 
			// cancelProductCMS
			// 
			this.cancelProductCMS.Name = "cancelProductCMS";
			this.cancelProductCMS.Size = new System.Drawing.Size(167, 22);
			this.cancelProductCMS.Text = "Hủy sản phẩm";
			this.cancelProductCMS.Click += new System.EventHandler(this.cancelProductCMS_Click);
			// 
			// detailProductCMS
			// 
			this.detailProductCMS.Name = "detailProductCMS";
			this.detailProductCMS.Size = new System.Drawing.Size(167, 22);
			this.detailProductCMS.Text = "Chi tiết sản phẩm";
			this.detailProductCMS.Click += new System.EventHandler(this.detailProductCMS_Click);
			// 
			// flpFilter
			// 
			this.flpFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.flpFilter.AutoScroll = true;
			this.flpFilter.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flpFilter.Location = new System.Drawing.Point(40, 48);
			this.flpFilter.Margin = new System.Windows.Forms.Padding(40, 0, 40, 0);
			this.flpFilter.Name = "flpFilter";
			this.flpFilter.Size = new System.Drawing.Size(1126, 48);
			this.flpFilter.TabIndex = 19;
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
			this.btnFilter.Location = new System.Drawing.Point(1025, 8);
			this.btnFilter.Margin = new System.Windows.Forms.Padding(3, 3, 20, 5);
			this.btnFilter.Name = "btnFilter";
			this.btnFilter.Size = new System.Drawing.Size(115, 35);
			this.btnFilter.TabIndex = 0;
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
			this.tbSearch.Location = new System.Drawing.Point(739, 8);
			this.tbSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 5);
			this.tbSearch.Name = "tbSearch";
			this.tbSearch.PasswordChar = '\0';
			this.tbSearch.PlaceholderText = "Nhập từ khóa ...";
			this.tbSearch.SelectedText = "";
			this.tbSearch.Size = new System.Drawing.Size(281, 35);
			this.tbSearch.TabIndex = 15;
			this.tbSearch.TabStop = false;
			this.tbSearch.IconRightClick += new System.EventHandler(this.tbSearch_IconRightClick);
			this.tbSearch.Enter += new System.EventHandler(this.tbSearch_Enter);
			this.tbSearch.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tbSearch_MouseDoubleClick);
			this.tbSearch.MouseLeave += new System.EventHandler(this.tbSearch_MouseLeave);
			// 
			// paneBottomLineTitleBar
			// 
			this.paneBottomLineTitleBar.Controls.Add(this.BottomLineTitleBar);
			this.paneBottomLineTitleBar.Location = new System.Drawing.Point(125, 389);
			this.paneBottomLineTitleBar.Name = "paneBottomLineTitleBar";
			this.paneBottomLineTitleBar.Size = new System.Drawing.Size(1000, 5);
			this.paneBottomLineTitleBar.TabIndex = 48;
			// 
			// BottomLineTitleBar
			// 
			this.BottomLineTitleBar.BackColor = System.Drawing.Color.Black;
			this.BottomLineTitleBar.Location = new System.Drawing.Point(0, 4);
			this.BottomLineTitleBar.Name = "BottomLineTitleBar";
			this.BottomLineTitleBar.Size = new System.Drawing.Size(1600, 1);
			this.BottomLineTitleBar.TabIndex = 0;
			// 
			// doughnutChartStock
			// 
			this.doughnutChartStock.BackgroundColor = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("doughnutChartStock.BackgroundColor")));
			this.doughnutChartStock.BorderColor = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("doughnutChartStock.BorderColor")));
			this.doughnutChartStock.BorderWidth = 0;
			this.doughnutChartStock.Data = ((System.Collections.Generic.List<double>)(resources.GetObject("doughnutChartStock.Data")));
			this.doughnutChartStock.HoverBackgroundColor = System.Drawing.Color.Empty;
			this.doughnutChartStock.HoverBorderColor = System.Drawing.Color.Empty;
			this.doughnutChartStock.HoverBorderWidth = 0;
			this.doughnutChartStock.Label = "label here";
			this.doughnutChartStock.TargetCanvas = this.chartStock;
			// 
			// chartStock
			// 
			this.chartStock.AnimationDuration = 1000;
			this.chartStock.AnimationType = Bunifu.Charts.WinForms.BunifuChartCanvas.AnimationOptions.easeOutQuart;
			this.chartStock.BackColor = System.Drawing.Color.White;
			this.chartStock.CanvasPadding = new System.Windows.Forms.Padding(0);
			this.chartStock.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.chartStock.Font = new System.Drawing.Font("Microsoft YaHei", 8F);
			this.chartStock.Labels = new string[] {
        "Sách",
        "Thiết bị điện tử",
        "Văn phòng phẩm khác"};
			this.chartStock.LegendAlignment = Bunifu.Charts.WinForms.BunifuChartCanvas.LegendAlignmentOptions.center;
			this.chartStock.LegendDisplay = true;
			this.chartStock.LegendFont = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
			this.chartStock.LegendForeColor = System.Drawing.Color.DimGray;
			this.chartStock.LegendFullWidth = true;
			this.chartStock.LegendPosition = Bunifu.Charts.WinForms.BunifuChartCanvas.PositionOptions.bottom;
			this.chartStock.LegendRevese = false;
			this.chartStock.LegendRTL = false;
			this.chartStock.Location = new System.Drawing.Point(0, 45);
			this.chartStock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.chartStock.Name = "chartStock";
			this.chartStock.ShowXAxis = false;
			this.chartStock.ShowYAxis = false;
			this.chartStock.Size = new System.Drawing.Size(316, 279);
			this.chartStock.TabIndex = 47;
			this.chartStock.Title = "";
			this.chartStock.TitleLineHeight = 1.2D;
			this.chartStock.TitlePadding = 10;
			this.chartStock.TitlePosition = Bunifu.Charts.WinForms.BunifuChartCanvas.PositionOptions.top;
			this.chartStock.TooltipBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.chartStock.TooltipFont = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chartStock.TooltipForeColor = System.Drawing.Color.WhiteSmoke;
			this.chartStock.TooltipMode = Bunifu.Charts.WinForms.BunifuChartCanvas.TooltipModeOptions.nearest;
			this.chartStock.TooltipsEnabled = true;
			this.chartStock.XAxesBeginAtZero = true;
			this.chartStock.XAxesDrawTicks = true;
			this.chartStock.XAxesFont = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chartStock.XAxesForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
			this.chartStock.XAxesGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.chartStock.XAxesGridLines = false;
			this.chartStock.XAxesLabel = "";
			this.chartStock.XAxesLabelFont = new System.Drawing.Font("Microsoft YaHei", 12F);
			this.chartStock.XAxesLabelForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
			this.chartStock.XAxesLineWidth = 0;
			this.chartStock.XAxesStacked = false;
			this.chartStock.XAxesZeroLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
			this.chartStock.XAxesZeroLineWidth = 1;
			this.chartStock.YAxesBeginAtZero = true;
			this.chartStock.YAxesDrawTicks = true;
			this.chartStock.YAxesFont = new System.Drawing.Font("Microsoft YaHei", 12F);
			this.chartStock.YAxesForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
			this.chartStock.YAxesGridColor = System.Drawing.Color.Gainsboro;
			this.chartStock.YAxesGridLines = false;
			this.chartStock.YAxesLabel = "";
			this.chartStock.YAxesLabelFont = new System.Drawing.Font("Microsoft YaHei", 12F);
			this.chartStock.YAxesLabelForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
			this.chartStock.YAxesLineWidth = 1;
			this.chartStock.YAxesStacked = false;
			this.chartStock.YAxesZeroLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
			this.chartStock.YAxesZeroLineWidth = 1;
			// 
			// lbHeaderBox2Title
			// 
			this.lbHeaderBox2Title.AutoSize = true;
			this.lbHeaderBox2Title.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
			this.lbHeaderBox2Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.lbHeaderBox2Title.Location = new System.Drawing.Point(3, 0);
			this.lbHeaderBox2Title.Name = "lbHeaderBox2Title";
			this.lbHeaderBox2Title.Size = new System.Drawing.Size(203, 24);
			this.lbHeaderBox2Title.TabIndex = 56;
			this.lbHeaderBox2Title.Text = "Số lượng sản phẩm";
			// 
			// lbHeaderBox2Detail
			// 
			this.lbHeaderBox2Detail.AutoSize = true;
			this.lbHeaderBox2Detail.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
			this.lbHeaderBox2Detail.ForeColor = System.Drawing.Color.DimGray;
			this.lbHeaderBox2Detail.Location = new System.Drawing.Point(4, 24);
			this.lbHeaderBox2Detail.Name = "lbHeaderBox2Detail";
			this.lbHeaderBox2Detail.Size = new System.Drawing.Size(127, 17);
			this.lbHeaderBox2Detail.TabIndex = 57;
			this.lbHeaderBox2Detail.Text = "Tổng cộng: 0 pcs";
			// 
			// tlpHeader
			// 
			this.tlpHeader.ColumnCount = 2;
			this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73F));
			this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27F));
			this.tlpHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tlpHeader.Controls.Add(this.pnlHeaderBox2, 1, 0);
			this.tlpHeader.Controls.Add(this.pnlHeaderBox1, 0, 0);
			this.tlpHeader.Location = new System.Drawing.Point(53, 53);
			this.tlpHeader.Name = "tlpHeader";
			this.tlpHeader.RowCount = 1;
			this.tlpHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tlpHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tlpHeader.Size = new System.Drawing.Size(1206, 330);
			this.tlpHeader.TabIndex = 60;
			// 
			// pnlHeaderBox2
			// 
			this.pnlHeaderBox2.Controls.Add(this.chartStock);
			this.pnlHeaderBox2.Controls.Add(this.lbHeaderBox2Title);
			this.pnlHeaderBox2.Controls.Add(this.lbHeaderBox2Detail);
			this.pnlHeaderBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlHeaderBox2.Location = new System.Drawing.Point(890, 3);
			this.pnlHeaderBox2.Margin = new System.Windows.Forms.Padding(10, 3, 0, 3);
			this.pnlHeaderBox2.Name = "pnlHeaderBox2";
			this.pnlHeaderBox2.Size = new System.Drawing.Size(316, 324);
			this.pnlHeaderBox2.TabIndex = 2;
			// 
			// pnlHeaderBox1
			// 
			this.pnlHeaderBox1.Controls.Add(this.lbHeaderBox1Title);
			this.pnlHeaderBox1.Controls.Add(this.lbHeaderBox1Detail);
			this.pnlHeaderBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlHeaderBox1.Location = new System.Drawing.Point(0, 0);
			this.pnlHeaderBox1.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
			this.pnlHeaderBox1.Name = "pnlHeaderBox1";
			this.pnlHeaderBox1.Size = new System.Drawing.Size(870, 330);
			this.pnlHeaderBox1.TabIndex = 3;
			// 
			// lbHeaderBox1Title
			// 
			this.lbHeaderBox1Title.AutoSize = true;
			this.lbHeaderBox1Title.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold);
			this.lbHeaderBox1Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.lbHeaderBox1Title.Location = new System.Drawing.Point(3, 3);
			this.lbHeaderBox1Title.Name = "lbHeaderBox1Title";
			this.lbHeaderBox1Title.Size = new System.Drawing.Size(155, 24);
			this.lbHeaderBox1Title.TabIndex = 71;
			this.lbHeaderBox1Title.Text = "Bán chạy nhất";
			// 
			// lbHeaderBox1Detail
			// 
			this.lbHeaderBox1Detail.AutoSize = true;
			this.lbHeaderBox1Detail.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
			this.lbHeaderBox1Detail.ForeColor = System.Drawing.Color.DimGray;
			this.lbHeaderBox1Detail.Location = new System.Drawing.Point(4, 27);
			this.lbHeaderBox1Detail.Name = "lbHeaderBox1Detail";
			this.lbHeaderBox1Detail.Size = new System.Drawing.Size(244, 17);
			this.lbHeaderBox1Detail.TabIndex = 72;
			this.lbHeaderBox1Detail.Text = "Nhiều nhất: 0 pcs kể từ đầu tháng";
			// 
			// chartPieConsume
			// 
			this.chartPieConsume.BackgroundColor = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("chartPieConsume.BackgroundColor")));
			this.chartPieConsume.BorderColor = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("chartPieConsume.BorderColor")));
			this.chartPieConsume.BorderWidth = 0;
			this.chartPieConsume.Data = ((System.Collections.Generic.List<double>)(resources.GetObject("chartPieConsume.Data")));
			this.chartPieConsume.HoverBackgroundColor = System.Drawing.Color.Empty;
			this.chartPieConsume.HoverBorderColor = System.Drawing.Color.Empty;
			this.chartPieConsume.HoverBorderWidth = 0;
			this.chartPieConsume.Label = "Label here";
			this.chartPieConsume.TargetCanvas = null;
			// 
			// chartBarBestSellerProduct
			// 
			this.chartBarBestSellerProduct.BackgroundColor = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("chartBarBestSellerProduct.BackgroundColor")));
			this.chartBarBestSellerProduct.BorderColor = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("chartBarBestSellerProduct.BorderColor")));
			this.chartBarBestSellerProduct.BorderSkipped = null;
			this.chartBarBestSellerProduct.BorderWidth = 0;
			this.chartBarBestSellerProduct.Data = ((System.Collections.Generic.List<double>)(resources.GetObject("chartBarBestSellerProduct.Data")));
			this.chartBarBestSellerProduct.HoverBackgroundColor = System.Drawing.Color.Empty;
			this.chartBarBestSellerProduct.HoverBorderColor = System.Drawing.Color.Empty;
			this.chartBarBestSellerProduct.HoverBorderWidth = 0;
			this.chartBarBestSellerProduct.Label = "";
			this.chartBarBestSellerProduct.TargetCanvas = null;
			// 
			// chartHorizontalBestsellterProduct
			// 
			this.chartHorizontalBestsellterProduct.BackgroundColor = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("chartHorizontalBestsellterProduct.BackgroundColor")));
			this.chartHorizontalBestsellterProduct.BorderColor = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("chartHorizontalBestsellterProduct.BorderColor")));
			this.chartHorizontalBestsellterProduct.BorderSkipped = null;
			this.chartHorizontalBestsellterProduct.BorderWidth = 0;
			this.chartHorizontalBestsellterProduct.Data = ((System.Collections.Generic.List<double>)(resources.GetObject("chartHorizontalBestsellterProduct.Data")));
			this.chartHorizontalBestsellterProduct.HoverBackgroundColor = System.Drawing.Color.Empty;
			this.chartHorizontalBestsellterProduct.HoverBorderColor = System.Drawing.Color.Empty;
			this.chartHorizontalBestsellterProduct.HoverBorderWidth = 0;
			this.chartHorizontalBestsellterProduct.Label = "Quantity sold";
			this.chartHorizontalBestsellterProduct.TargetCanvas = this.chartBestsellerProduct;
			// 
			// chartBestsellerProduct
			// 
			this.chartBestsellerProduct.AnimationDuration = 1000;
			this.chartBestsellerProduct.AnimationType = Bunifu.Charts.WinForms.BunifuChartCanvas.AnimationOptions.easeOutQuart;
			this.chartBestsellerProduct.BackColor = System.Drawing.Color.White;
			this.chartBestsellerProduct.CanvasPadding = new System.Windows.Forms.Padding(0);
			this.chartBestsellerProduct.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.chartBestsellerProduct.Font = new System.Drawing.Font("Microsoft YaHei", 8F);
			this.chartBestsellerProduct.Labels = new string[] {
        "Unk",
        "Unk",
        "Unk",
        "Unk",
        "Unk",
        "Unk",
        "Unk",
        "Unk",
        "Unk"};
			this.chartBestsellerProduct.LegendAlignment = Bunifu.Charts.WinForms.BunifuChartCanvas.LegendAlignmentOptions.center;
			this.chartBestsellerProduct.LegendDisplay = false;
			this.chartBestsellerProduct.LegendFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chartBestsellerProduct.LegendForeColor = System.Drawing.Color.DarkGray;
			this.chartBestsellerProduct.LegendFullWidth = true;
			this.chartBestsellerProduct.LegendPosition = Bunifu.Charts.WinForms.BunifuChartCanvas.PositionOptions.top;
			this.chartBestsellerProduct.LegendRevese = false;
			this.chartBestsellerProduct.LegendRTL = false;
			this.chartBestsellerProduct.Location = new System.Drawing.Point(0, 0);
			this.chartBestsellerProduct.Margin = new System.Windows.Forms.Padding(0);
			this.chartBestsellerProduct.Name = "chartBestsellerProduct";
			this.chartBestsellerProduct.ShowXAxis = true;
			this.chartBestsellerProduct.ShowYAxis = true;
			this.chartBestsellerProduct.Size = new System.Drawing.Size(870, 279);
			this.chartBestsellerProduct.TabIndex = 79;
			this.chartBestsellerProduct.Title = "";
			this.chartBestsellerProduct.TitleLineHeight = 1.2D;
			this.chartBestsellerProduct.TitlePadding = 10;
			this.chartBestsellerProduct.TitlePosition = Bunifu.Charts.WinForms.BunifuChartCanvas.PositionOptions.top;
			this.chartBestsellerProduct.TooltipBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.chartBestsellerProduct.TooltipFont = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chartBestsellerProduct.TooltipForeColor = System.Drawing.Color.WhiteSmoke;
			this.chartBestsellerProduct.TooltipMode = Bunifu.Charts.WinForms.BunifuChartCanvas.TooltipModeOptions.nearest;
			this.chartBestsellerProduct.TooltipsEnabled = true;
			this.chartBestsellerProduct.XAxesBeginAtZero = true;
			this.chartBestsellerProduct.XAxesDrawTicks = true;
			this.chartBestsellerProduct.XAxesFont = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chartBestsellerProduct.XAxesForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
			this.chartBestsellerProduct.XAxesGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.chartBestsellerProduct.XAxesGridLines = true;
			this.chartBestsellerProduct.XAxesLabel = "";
			this.chartBestsellerProduct.XAxesLabelFont = new System.Drawing.Font("Microsoft YaHei", 12F);
			this.chartBestsellerProduct.XAxesLabelForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
			this.chartBestsellerProduct.XAxesLineWidth = 1;
			this.chartBestsellerProduct.XAxesStacked = false;
			this.chartBestsellerProduct.XAxesZeroLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
			this.chartBestsellerProduct.XAxesZeroLineWidth = 1;
			this.chartBestsellerProduct.YAxesBeginAtZero = true;
			this.chartBestsellerProduct.YAxesDrawTicks = true;
			this.chartBestsellerProduct.YAxesFont = new System.Drawing.Font("Microsoft YaHei", 12F);
			this.chartBestsellerProduct.YAxesForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
			this.chartBestsellerProduct.YAxesGridColor = System.Drawing.Color.Gainsboro;
			this.chartBestsellerProduct.YAxesGridLines = true;
			this.chartBestsellerProduct.YAxesLabel = "";
			this.chartBestsellerProduct.YAxesLabelFont = new System.Drawing.Font("Microsoft YaHei", 12F);
			this.chartBestsellerProduct.YAxesLabelForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(63)))), ((int)(((byte)(75)))));
			this.chartBestsellerProduct.YAxesLineWidth = 0;
			this.chartBestsellerProduct.YAxesStacked = false;
			this.chartBestsellerProduct.YAxesZeroLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
			this.chartBestsellerProduct.YAxesZeroLineWidth = 1;
			// 
			// pnlChartBestsellterBox
			// 
			this.pnlChartBestsellterBox.Controls.Add(this.chartBestsellerProduct);
			this.pnlChartBestsellterBox.Location = new System.Drawing.Point(53, 101);
			this.pnlChartBestsellterBox.Name = "pnlChartBestsellterBox";
			this.pnlChartBestsellterBox.Size = new System.Drawing.Size(870, 279);
			this.pnlChartBestsellterBox.TabIndex = 73;
			// 
			// Product
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.pnlChartBestsellterBox);
			this.Controls.Add(this.tlpHeader);
			this.Controls.Add(this.paneBottomLineTitleBar);
			this.Controls.Add(this.pnlDgv);
			this.Name = "Product";
			this.Size = new System.Drawing.Size(1306, 849);
			this.Load += new System.EventHandler(this.Product_Load);
			this.pnlDgv.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
			this.cmsCancelProduct.ResumeLayout(false);
			this.paneBottomLineTitleBar.ResumeLayout(false);
			this.tlpHeader.ResumeLayout(false);
			this.pnlHeaderBox2.ResumeLayout(false);
			this.pnlHeaderBox2.PerformLayout();
			this.pnlHeaderBox1.ResumeLayout(false);
			this.pnlHeaderBox1.PerformLayout();
			this.pnlChartBestsellterBox.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion
		private Guna.UI2.WinForms.Guna2ShadowPanel pnlDgv;
		private Guna.UI2.WinForms.Guna2TextBox tbSearch;
		private System.Windows.Forms.Panel paneBottomLineTitleBar;
		private System.Windows.Forms.Panel BottomLineTitleBar;
		private System.Windows.Forms.FlowLayoutPanel flpFilter;
		private Bunifu.Charts.WinForms.ChartTypes.BunifuDoughnutChart doughnutChartStock;
		private System.Windows.Forms.Label lbHeaderBox2Title;
		private System.Windows.Forms.Label lbHeaderBox2Detail;
		private System.Windows.Forms.TableLayoutPanel tlpHeader;
		private Guna.UI2.WinForms.Guna2GradientPanel pnlHeaderBox2;
		private Bunifu.Charts.WinForms.ChartTypes.BunifuPieChart chartPieConsume;
		private Bunifu.Charts.WinForms.ChartTypes.BunifuBarChart chartBarBestSellerProduct;
		private Bunifu.Charts.WinForms.BunifuChartCanvas chartStock;
		private Bunifu.Charts.WinForms.ChartTypes.BunifuHorizontalBarChart chartHorizontalBestsellterProduct;
		private System.Windows.Forms.Label lbHeaderBox1Title;
		private System.Windows.Forms.Label lbHeaderBox1Detail;
		private Guna.UI2.WinForms.Guna2GradientPanel pnlHeaderBox1;
		private Bunifu.Charts.WinForms.BunifuChartCanvas chartBestsellerProduct;
		private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlChartBestsellterBox;
		public System.Windows.Forms.DataGridView dgvData;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
		private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
		private System.Windows.Forms.DataGridViewTextBoxColumn ThuongHieu;
		private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongTon;
		private System.Windows.Forms.DataGridViewTextBoxColumn DVT;
		private System.Windows.Forms.DataGridViewTextBoxColumn Cancellation;
		public FontAwesome.Sharp.IconButton btnFilter;
		public FontAwesome.Sharp.IconButton btnNewProduct;
		private Guna.UI2.WinForms.Guna2ContextMenuStrip cmsCancelProduct;
		private System.Windows.Forms.ToolStripMenuItem cancelProductCMS;
		private System.Windows.Forms.ToolStripMenuItem detailProductCMS;
	}
}
