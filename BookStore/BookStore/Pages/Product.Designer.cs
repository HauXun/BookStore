
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle64 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle65 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle69 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle70 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle66 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle67 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle68 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product));
			this.imageList = new System.Windows.Forms.ImageList(this.components);
			this.pnlDgv = new Guna.UI2.WinForms.Guna2ShadowPanel();
			this.dgvData = new System.Windows.Forms.DataGridView();
			this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.BrandName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.flpFilter = new System.Windows.Forms.FlowLayoutPanel();
			this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Button6 = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Button7 = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Button8 = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Button9 = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
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
			this.pnlDataDetails = new Guna.UI2.WinForms.Guna2Panel();
			this.lbProductStockDetail = new System.Windows.Forms.Label();
			this.lbProductBrandDetail = new System.Windows.Forms.Label();
			this.lbProductNameDetail = new System.Windows.Forms.Label();
			this.lbIDProductDetail = new System.Windows.Forms.Label();
			this.lbProductStock = new System.Windows.Forms.Label();
			this.lbProductBrand = new System.Windows.Forms.Label();
			this.lbProductName = new System.Windows.Forms.Label();
			this.lbIDProduct = new System.Windows.Forms.Label();
			this.pnlChartBestsellterBox = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
			this.pnlDgv.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
			this.flpFilter.SuspendLayout();
			this.paneBottomLineTitleBar.SuspendLayout();
			this.tlpHeader.SuspendLayout();
			this.pnlHeaderBox2.SuspendLayout();
			this.pnlHeaderBox1.SuspendLayout();
			this.pnlDataDetails.SuspendLayout();
			this.pnlChartBestsellterBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// imageList
			// 
			this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageList.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// pnlDgv
			// 
			this.pnlDgv.BackColor = System.Drawing.Color.Transparent;
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
			this.pnlDgv.Size = new System.Drawing.Size(870, 397);
			this.pnlDgv.TabIndex = 44;
			// 
			// dgvData
			// 
			this.dgvData.AllowUserToAddRows = false;
			this.dgvData.AllowUserToDeleteRows = false;
			this.dgvData.AllowUserToResizeRows = false;
			dataGridViewCellStyle64.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(86)))));
			this.dgvData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle64;
			this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvData.BackgroundColor = System.Drawing.Color.White;
			this.dgvData.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dgvData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dgvData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle65.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle65.BackColor = System.Drawing.Color.WhiteSmoke;
			dataGridViewCellStyle65.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle65.ForeColor = System.Drawing.Color.Gray;
			dataGridViewCellStyle65.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			dataGridViewCellStyle65.SelectionForeColor = System.Drawing.Color.DimGray;
			dataGridViewCellStyle65.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle65;
			this.dgvData.ColumnHeadersHeight = 40;
			this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductName,
            this.BrandName,
            this.Stock,
            this.DVT});
			dataGridViewCellStyle69.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle69.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(76)))));
			dataGridViewCellStyle69.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle69.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			dataGridViewCellStyle69.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(160)))), ((int)(((byte)(104)))));
			dataGridViewCellStyle69.SelectionForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle69.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgvData.DefaultCellStyle = dataGridViewCellStyle69;
			this.dgvData.EnableHeadersVisualStyles = false;
			this.dgvData.Location = new System.Drawing.Point(0, 101);
			this.dgvData.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
			this.dgvData.Name = "dgvData";
			this.dgvData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle70.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle70.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle70.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle70.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle70.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle70.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle70.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvData.RowHeadersDefaultCellStyle = dataGridViewCellStyle70;
			this.dgvData.RowHeadersVisible = false;
			this.dgvData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvData.RowTemplate.Height = 50;
			this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvData.Size = new System.Drawing.Size(870, 296);
			this.dgvData.TabIndex = 61;
			// 
			// ProductName
			// 
			this.ProductName.DataPropertyName = "ProductName";
			this.ProductName.FillWeight = 400F;
			this.ProductName.HeaderText = "Tên sản phẩm";
			this.ProductName.Name = "ProductName";
			this.ProductName.ReadOnly = true;
			// 
			// BrandName
			// 
			this.BrandName.DataPropertyName = "BrandName";
			dataGridViewCellStyle66.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.BrandName.DefaultCellStyle = dataGridViewCellStyle66;
			this.BrandName.FillWeight = 200F;
			this.BrandName.HeaderText = "Thương hiệu";
			this.BrandName.Name = "BrandName";
			this.BrandName.ReadOnly = true;
			// 
			// Stock
			// 
			this.Stock.DataPropertyName = "Stock";
			dataGridViewCellStyle67.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.Stock.DefaultCellStyle = dataGridViewCellStyle67;
			this.Stock.HeaderText = "Số lượng tồn";
			this.Stock.Name = "Stock";
			this.Stock.ReadOnly = true;
			// 
			// DVT
			// 
			this.DVT.DataPropertyName = "DVT";
			dataGridViewCellStyle68.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.DVT.DefaultCellStyle = dataGridViewCellStyle68;
			this.DVT.HeaderText = "DVT";
			this.DVT.Name = "DVT";
			this.DVT.ReadOnly = true;
			// 
			// flpFilter
			// 
			this.flpFilter.AutoScroll = true;
			this.flpFilter.Controls.Add(this.guna2Button3);
			this.flpFilter.Controls.Add(this.guna2Button4);
			this.flpFilter.Controls.Add(this.guna2Button5);
			this.flpFilter.Controls.Add(this.guna2Button6);
			this.flpFilter.Controls.Add(this.guna2Button7);
			this.flpFilter.Controls.Add(this.guna2Button8);
			this.flpFilter.Controls.Add(this.guna2Button9);
			this.flpFilter.Controls.Add(this.guna2Button1);
			this.flpFilter.Controls.Add(this.guna2Button2);
			this.flpFilter.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flpFilter.Location = new System.Drawing.Point(40, 48);
			this.flpFilter.Margin = new System.Windows.Forms.Padding(40, 0, 40, 0);
			this.flpFilter.Name = "flpFilter";
			this.flpFilter.Size = new System.Drawing.Size(790, 48);
			this.flpFilter.TabIndex = 19;
			// 
			// guna2Button3
			// 
			this.guna2Button3.BorderRadius = 5;
			this.guna2Button3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.guna2Button3.DefaultAutoSize = true;
			this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.guna2Button3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.guna2Button3.Font = new System.Drawing.Font("Tahoma", 10F);
			this.guna2Button3.ForeColor = System.Drawing.Color.DimGray;
			this.guna2Button3.Location = new System.Drawing.Point(0, 0);
			this.guna2Button3.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
			this.guna2Button3.Name = "guna2Button3";
			this.guna2Button3.Size = new System.Drawing.Size(88, 27);
			this.guna2Button3.TabIndex = 20;
			this.guna2Button3.Text = "Book     x";
			// 
			// guna2Button4
			// 
			this.guna2Button4.BorderRadius = 5;
			this.guna2Button4.Cursor = System.Windows.Forms.Cursors.Hand;
			this.guna2Button4.DefaultAutoSize = true;
			this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.guna2Button4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.guna2Button4.Font = new System.Drawing.Font("Tahoma", 10F);
			this.guna2Button4.ForeColor = System.Drawing.Color.DimGray;
			this.guna2Button4.Location = new System.Drawing.Point(98, 0);
			this.guna2Button4.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
			this.guna2Button4.Name = "guna2Button4";
			this.guna2Button4.Size = new System.Drawing.Size(104, 27);
			this.guna2Button4.TabIndex = 21;
			this.guna2Button4.Text = "CasioFx     x";
			// 
			// guna2Button5
			// 
			this.guna2Button5.BorderRadius = 5;
			this.guna2Button5.Cursor = System.Windows.Forms.Cursors.Hand;
			this.guna2Button5.DefaultAutoSize = true;
			this.guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.guna2Button5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.guna2Button5.Font = new System.Drawing.Font("Tahoma", 10F);
			this.guna2Button5.ForeColor = System.Drawing.Color.DimGray;
			this.guna2Button5.Location = new System.Drawing.Point(212, 0);
			this.guna2Button5.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
			this.guna2Button5.Name = "guna2Button5";
			this.guna2Button5.Size = new System.Drawing.Size(146, 27);
			this.guna2Button5.TabIndex = 22;
			this.guna2Button5.Text = "Drawing Table     x";
			// 
			// guna2Button6
			// 
			this.guna2Button6.BorderRadius = 5;
			this.guna2Button6.Cursor = System.Windows.Forms.Cursors.Hand;
			this.guna2Button6.DefaultAutoSize = true;
			this.guna2Button6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guna2Button6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.guna2Button6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.guna2Button6.Font = new System.Drawing.Font("Tahoma", 10F);
			this.guna2Button6.ForeColor = System.Drawing.Color.DimGray;
			this.guna2Button6.Location = new System.Drawing.Point(368, 0);
			this.guna2Button6.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
			this.guna2Button6.Name = "guna2Button6";
			this.guna2Button6.Size = new System.Drawing.Size(81, 27);
			this.guna2Button6.TabIndex = 23;
			this.guna2Button6.Text = "Pen     x";
			// 
			// guna2Button7
			// 
			this.guna2Button7.BorderRadius = 5;
			this.guna2Button7.Cursor = System.Windows.Forms.Cursors.Hand;
			this.guna2Button7.DefaultAutoSize = true;
			this.guna2Button7.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button7.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button7.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guna2Button7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.guna2Button7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.guna2Button7.Font = new System.Drawing.Font("Tahoma", 10F);
			this.guna2Button7.ForeColor = System.Drawing.Color.DimGray;
			this.guna2Button7.Location = new System.Drawing.Point(459, 0);
			this.guna2Button7.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
			this.guna2Button7.Name = "guna2Button7";
			this.guna2Button7.Size = new System.Drawing.Size(156, 27);
			this.guna2Button7.TabIndex = 24;
			this.guna2Button7.Text = "Geographic Map     x";
			// 
			// guna2Button8
			// 
			this.guna2Button8.BorderRadius = 5;
			this.guna2Button8.Cursor = System.Windows.Forms.Cursors.Hand;
			this.guna2Button8.DefaultAutoSize = true;
			this.guna2Button8.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button8.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button8.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guna2Button8.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.guna2Button8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.guna2Button8.Font = new System.Drawing.Font("Tahoma", 10F);
			this.guna2Button8.ForeColor = System.Drawing.Color.DimGray;
			this.guna2Button8.Location = new System.Drawing.Point(625, 0);
			this.guna2Button8.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
			this.guna2Button8.Name = "guna2Button8";
			this.guna2Button8.Size = new System.Drawing.Size(144, 27);
			this.guna2Button8.TabIndex = 25;
			this.guna2Button8.Text = "Đầu cắt moiiiii     x";
			// 
			// guna2Button9
			// 
			this.guna2Button9.BorderRadius = 5;
			this.guna2Button9.Cursor = System.Windows.Forms.Cursors.Hand;
			this.guna2Button9.DefaultAutoSize = true;
			this.guna2Button9.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button9.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button9.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guna2Button9.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.guna2Button9.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.guna2Button9.Font = new System.Drawing.Font("Tahoma", 10F);
			this.guna2Button9.ForeColor = System.Drawing.Color.DimGray;
			this.guna2Button9.Location = new System.Drawing.Point(779, 0);
			this.guna2Button9.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
			this.guna2Button9.Name = "guna2Button9";
			this.guna2Button9.Size = new System.Drawing.Size(150, 27);
			this.guna2Button9.TabIndex = 26;
			this.guna2Button9.Text = "Thằng hai dụ á     x";
			// 
			// guna2Button1
			// 
			this.guna2Button1.BorderRadius = 5;
			this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.guna2Button1.DefaultAutoSize = true;
			this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.guna2Button1.Font = new System.Drawing.Font("Tahoma", 10F);
			this.guna2Button1.ForeColor = System.Drawing.Color.DimGray;
			this.guna2Button1.Location = new System.Drawing.Point(939, 0);
			this.guna2Button1.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
			this.guna2Button1.Name = "guna2Button1";
			this.guna2Button1.Size = new System.Drawing.Size(136, 27);
			this.guna2Button1.TabIndex = 27;
			this.guna2Button1.Text = "Price > 127$     x";
			// 
			// guna2Button2
			// 
			this.guna2Button2.BorderRadius = 5;
			this.guna2Button2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.guna2Button2.DefaultAutoSize = true;
			this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.guna2Button2.Font = new System.Drawing.Font("Tahoma", 10F);
			this.guna2Button2.ForeColor = System.Drawing.Color.DimGray;
			this.guna2Button2.Location = new System.Drawing.Point(1085, 0);
			this.guna2Button2.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
			this.guna2Button2.Name = "guna2Button2";
			this.guna2Button2.Size = new System.Drawing.Size(173, 27);
			this.guna2Button2.TabIndex = 28;
			this.guna2Button2.Text = "Author: Hậu lùa gà     x";
			// 
			// btnFilter
			// 
			this.btnFilter.BackColor = System.Drawing.Color.Transparent;
			this.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnFilter.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
			this.btnFilter.FlatAppearance.BorderSize = 0;
			this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFilter.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
			this.btnFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnFilter.IconChar = FontAwesome.Sharp.IconChar.Plus;
			this.btnFilter.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnFilter.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnFilter.IconSize = 25;
			this.btnFilter.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnFilter.Location = new System.Drawing.Point(689, 8);
			this.btnFilter.Margin = new System.Windows.Forms.Padding(3, 3, 20, 5);
			this.btnFilter.Name = "btnFilter";
			this.btnFilter.Size = new System.Drawing.Size(115, 35);
			this.btnFilter.TabIndex = 0;
			this.btnFilter.TabStop = false;
			this.btnFilter.Text = "Add Filter";
			this.btnFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnFilter.UseVisualStyleBackColor = false;
			this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
			// 
			// tbSearch
			// 
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
			this.tbSearch.Location = new System.Drawing.Point(403, 8);
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
			this.lbHeaderBox2Title.Size = new System.Drawing.Size(138, 24);
			this.lbHeaderBox2Title.TabIndex = 56;
			this.lbHeaderBox2Title.Text = "Số lượng tồn";
			// 
			// lbHeaderBox2Detail
			// 
			this.lbHeaderBox2Detail.AutoSize = true;
			this.lbHeaderBox2Detail.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
			this.lbHeaderBox2Detail.ForeColor = System.Drawing.Color.DimGray;
			this.lbHeaderBox2Detail.Location = new System.Drawing.Point(4, 24);
			this.lbHeaderBox2Detail.Name = "lbHeaderBox2Detail";
			this.lbHeaderBox2Detail.Size = new System.Drawing.Size(141, 17);
			this.lbHeaderBox2Detail.TabIndex = 57;
			this.lbHeaderBox2Detail.Text = "Quota: 100000 pcs";
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
			this.lbHeaderBox1Title.Size = new System.Drawing.Size(117, 24);
			this.lbHeaderBox1Title.TabIndex = 71;
			this.lbHeaderBox1Title.Text = "Bestsellter";
			// 
			// lbHeaderBox1Detail
			// 
			this.lbHeaderBox1Detail.AutoSize = true;
			this.lbHeaderBox1Detail.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
			this.lbHeaderBox1Detail.ForeColor = System.Drawing.Color.DimGray;
			this.lbHeaderBox1Detail.Location = new System.Drawing.Point(4, 27);
			this.lbHeaderBox1Detail.Name = "lbHeaderBox1Detail";
			this.lbHeaderBox1Detail.Size = new System.Drawing.Size(114, 17);
			this.lbHeaderBox1Detail.TabIndex = 72;
			this.lbHeaderBox1Detail.Text = "Most: 6231 pcs";
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
        "Sách lừa đảo",
        "Đọc suy nghĩ động vật",
        "Thiết bị gian lận thi cử",
        "Tai nghe hạt đậu",
        "Người iu",
        "Tên lửa hạt nhân",
        "Chim cánh cụt",
        "Putin",
        "Đô nan chum"};
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
			// pnlDataDetails
			// 
			this.pnlDataDetails.BackColor = System.Drawing.Color.White;
			this.pnlDataDetails.BorderRadius = 15;
			this.pnlDataDetails.Controls.Add(this.lbProductStockDetail);
			this.pnlDataDetails.Controls.Add(this.lbProductBrandDetail);
			this.pnlDataDetails.Controls.Add(this.lbProductNameDetail);
			this.pnlDataDetails.Controls.Add(this.lbIDProductDetail);
			this.pnlDataDetails.Controls.Add(this.lbProductStock);
			this.pnlDataDetails.Controls.Add(this.lbProductBrand);
			this.pnlDataDetails.Controls.Add(this.lbProductName);
			this.pnlDataDetails.Controls.Add(this.lbIDProduct);
			this.pnlDataDetails.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.pnlDataDetails.Location = new System.Drawing.Point(943, 400);
			this.pnlDataDetails.Name = "pnlDataDetails";
			this.pnlDataDetails.Size = new System.Drawing.Size(316, 397);
			this.pnlDataDetails.TabIndex = 61;
			// 
			// lbProductStockDetail
			// 
			this.lbProductStockDetail.BackColor = System.Drawing.Color.Transparent;
			this.lbProductStockDetail.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.lbProductStockDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(85)))));
			this.lbProductStockDetail.Location = new System.Drawing.Point(21, 188);
			this.lbProductStockDetail.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
			this.lbProductStockDetail.Name = "lbProductStockDetail";
			this.lbProductStockDetail.Size = new System.Drawing.Size(120, 19);
			this.lbProductStockDetail.TabIndex = 67;
			this.lbProductStockDetail.Text = "36237582935";
			this.lbProductStockDetail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbProductBrandDetail
			// 
			this.lbProductBrandDetail.AutoSize = true;
			this.lbProductBrandDetail.BackColor = System.Drawing.Color.Transparent;
			this.lbProductBrandDetail.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.lbProductBrandDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(85)))));
			this.lbProductBrandDetail.Location = new System.Drawing.Point(21, 136);
			this.lbProductBrandDetail.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
			this.lbProductBrandDetail.Name = "lbProductBrandDetail";
			this.lbProductBrandDetail.Size = new System.Drawing.Size(256, 20);
			this.lbProductBrandDetail.TabIndex = 65;
			this.lbProductBrandDetail.Text = "Nhà sách cổ đại Ai cập thiên niên kỉ 8";
			this.lbProductBrandDetail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbProductNameDetail
			// 
			this.lbProductNameDetail.AutoSize = true;
			this.lbProductNameDetail.BackColor = System.Drawing.Color.Transparent;
			this.lbProductNameDetail.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.lbProductNameDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(85)))));
			this.lbProductNameDetail.Location = new System.Drawing.Point(21, 82);
			this.lbProductNameDetail.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
			this.lbProductNameDetail.Name = "lbProductNameDetail";
			this.lbProductNameDetail.Size = new System.Drawing.Size(201, 20);
			this.lbProductNameDetail.TabIndex = 64;
			this.lbProductNameDetail.Text = "Bí kiếp tán gái của Napoleon";
			this.lbProductNameDetail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbIDProductDetail
			// 
			this.lbIDProductDetail.AutoSize = true;
			this.lbIDProductDetail.BackColor = System.Drawing.Color.Transparent;
			this.lbIDProductDetail.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.lbIDProductDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(85)))));
			this.lbIDProductDetail.Location = new System.Drawing.Point(21, 29);
			this.lbIDProductDetail.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
			this.lbIDProductDetail.Name = "lbIDProductDetail";
			this.lbIDProductDetail.Size = new System.Drawing.Size(153, 20);
			this.lbIDProductDetail.TabIndex = 63;
			this.lbIDProductDetail.Text = "362375829356236726";
			this.lbIDProductDetail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbProductStock
			// 
			this.lbProductStock.AutoSize = true;
			this.lbProductStock.BackColor = System.Drawing.Color.Transparent;
			this.lbProductStock.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.lbProductStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(85)))));
			this.lbProductStock.Location = new System.Drawing.Point(7, 164);
			this.lbProductStock.Margin = new System.Windows.Forms.Padding(5, 10, 0, 0);
			this.lbProductStock.Name = "lbProductStock";
			this.lbProductStock.Size = new System.Drawing.Size(118, 19);
			this.lbProductStock.TabIndex = 9;
			this.lbProductStock.Text = "Số lượng tồn:";
			// 
			// lbProductBrand
			// 
			this.lbProductBrand.AutoSize = true;
			this.lbProductBrand.BackColor = System.Drawing.Color.Transparent;
			this.lbProductBrand.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.lbProductBrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(85)))));
			this.lbProductBrand.Location = new System.Drawing.Point(7, 112);
			this.lbProductBrand.Margin = new System.Windows.Forms.Padding(5, 10, 0, 0);
			this.lbProductBrand.Name = "lbProductBrand";
			this.lbProductBrand.Size = new System.Drawing.Size(117, 19);
			this.lbProductBrand.TabIndex = 8;
			this.lbProductBrand.Text = "Thương hiệu:";
			// 
			// lbProductName
			// 
			this.lbProductName.AutoSize = true;
			this.lbProductName.BackColor = System.Drawing.Color.Transparent;
			this.lbProductName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.lbProductName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(85)))));
			this.lbProductName.Location = new System.Drawing.Point(7, 59);
			this.lbProductName.Margin = new System.Windows.Forms.Padding(5, 10, 0, 0);
			this.lbProductName.Name = "lbProductName";
			this.lbProductName.Size = new System.Drawing.Size(129, 19);
			this.lbProductName.TabIndex = 7;
			this.lbProductName.Text = "Tên sản phẩm:";
			// 
			// lbIDProduct
			// 
			this.lbIDProduct.AutoSize = true;
			this.lbIDProduct.BackColor = System.Drawing.Color.Transparent;
			this.lbIDProduct.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.lbIDProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(85)))));
			this.lbIDProduct.Location = new System.Drawing.Point(7, 5);
			this.lbIDProduct.Margin = new System.Windows.Forms.Padding(5, 5, 0, 0);
			this.lbIDProduct.Name = "lbIDProduct";
			this.lbIDProduct.Size = new System.Drawing.Size(122, 19);
			this.lbIDProduct.TabIndex = 0;
			this.lbIDProduct.Text = "Mã sản phẩm:";
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
			this.Controls.Add(this.pnlDataDetails);
			this.Controls.Add(this.tlpHeader);
			this.Controls.Add(this.paneBottomLineTitleBar);
			this.Controls.Add(this.pnlDgv);
			this.Name = "Product";
			this.Size = new System.Drawing.Size(1306, 849);
			this.Load += new System.EventHandler(this.Product_Load);
			this.pnlDgv.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
			this.flpFilter.ResumeLayout(false);
			this.flpFilter.PerformLayout();
			this.paneBottomLineTitleBar.ResumeLayout(false);
			this.tlpHeader.ResumeLayout(false);
			this.pnlHeaderBox2.ResumeLayout(false);
			this.pnlHeaderBox2.PerformLayout();
			this.pnlHeaderBox1.ResumeLayout(false);
			this.pnlHeaderBox1.PerformLayout();
			this.pnlDataDetails.ResumeLayout(false);
			this.pnlDataDetails.PerformLayout();
			this.pnlChartBestsellterBox.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList;
		private Guna.UI2.WinForms.Guna2ShadowPanel pnlDgv;
		private FontAwesome.Sharp.IconButton btnFilter;
		private Guna.UI2.WinForms.Guna2TextBox tbSearch;
		private System.Windows.Forms.Panel paneBottomLineTitleBar;
		private System.Windows.Forms.Panel BottomLineTitleBar;
		private System.Windows.Forms.FlowLayoutPanel flpFilter;
		private Guna.UI2.WinForms.Guna2Button guna2Button3;
		private Guna.UI2.WinForms.Guna2Button guna2Button4;
		private Guna.UI2.WinForms.Guna2Button guna2Button5;
		private Guna.UI2.WinForms.Guna2Button guna2Button6;
		private Bunifu.Charts.WinForms.ChartTypes.BunifuDoughnutChart doughnutChartStock;
		private Guna.UI2.WinForms.Guna2Button guna2Button7;
		private System.Windows.Forms.Label lbHeaderBox2Title;
		private System.Windows.Forms.Label lbHeaderBox2Detail;
		private System.Windows.Forms.TableLayoutPanel tlpHeader;
		private Guna.UI2.WinForms.Guna2GradientPanel pnlHeaderBox2;
		private Bunifu.Charts.WinForms.ChartTypes.BunifuPieChart chartPieConsume;
		private Bunifu.Charts.WinForms.ChartTypes.BunifuBarChart chartBarBestSellerProduct;
		private Guna.UI2.WinForms.Guna2Button guna2Button8;
		private Guna.UI2.WinForms.Guna2Button guna2Button9;
		private Bunifu.Charts.WinForms.BunifuChartCanvas chartStock;
		private Guna.UI2.WinForms.Guna2Button guna2Button1;
		private Guna.UI2.WinForms.Guna2Button guna2Button2;
		private Bunifu.Charts.WinForms.ChartTypes.BunifuHorizontalBarChart chartHorizontalBestsellterProduct;
		public System.Windows.Forms.DataGridView dgvData;
		private Guna.UI2.WinForms.Guna2Panel pnlDataDetails;
		private System.Windows.Forms.Label lbIDProduct;
		private System.Windows.Forms.Label lbProductStock;
		private System.Windows.Forms.Label lbProductBrand;
		private System.Windows.Forms.Label lbProductName;
		private System.Windows.Forms.Label lbHeaderBox1Title;
		private System.Windows.Forms.Label lbHeaderBox1Detail;
		private System.Windows.Forms.Label lbProductStockDetail;
		private System.Windows.Forms.Label lbProductBrandDetail;
		private System.Windows.Forms.Label lbProductNameDetail;
		private System.Windows.Forms.Label lbIDProductDetail;
		private Guna.UI2.WinForms.Guna2GradientPanel pnlHeaderBox1;
		private Bunifu.Charts.WinForms.BunifuChartCanvas chartBestsellerProduct;
		private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlChartBestsellterBox;
		private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
		private System.Windows.Forms.DataGridViewTextBoxColumn BrandName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
		private System.Windows.Forms.DataGridViewTextBoxColumn DVT;
	}
}
