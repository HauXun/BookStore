namespace BookStore.Pages
{
	partial class Bill
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
			this.guna2Panel6 = new Guna.UI2.WinForms.Guna2Panel();
			this.btnPriceApply = new FontAwesome.Sharp.IconButton();
			this.lbPeriodPrice = new System.Windows.Forms.Label();
			this.tbPeriodPrice2 = new Guna.UI2.WinForms.Guna2TextBox();
			this.lbPeriodPriceSeperator = new System.Windows.Forms.Label();
			this.tbPeriodPrice1 = new Guna.UI2.WinForms.Guna2TextBox();
			this.lbPeriodTime = new System.Windows.Forms.Label();
			this.lbBillRole = new System.Windows.Forms.Label();
			this.lbDpkHeader = new System.Windows.Forms.Label();
			this.cbBillRole = new Guna.UI2.WinForms.Guna2ComboBox();
			this.dpkHeader1 = new Bunifu.Framework.UI.BunifuDatepicker();
			this.dpkHeader2 = new Bunifu.Framework.UI.BunifuDatepicker();
			this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
			this.lbSearchTitle = new System.Windows.Forms.Label();
			this.tbSearch = new Guna.UI2.WinForms.Guna2TextBox();
			this.flpBillRow = new System.Windows.Forms.FlowLayoutPanel();
			this.errorProviderWar = new System.Windows.Forms.ErrorProvider(this.components);
			this.lbTotalBill = new System.Windows.Forms.Label();
			this.lbTotalBillPrice = new System.Windows.Forms.Label();
			this.guna2Panel6.SuspendLayout();
			this.guna2Panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderWar)).BeginInit();
			this.SuspendLayout();
			// 
			// guna2Panel6
			// 
			this.guna2Panel6.Controls.Add(this.btnPriceApply);
			this.guna2Panel6.Controls.Add(this.lbPeriodPrice);
			this.guna2Panel6.Controls.Add(this.tbPeriodPrice2);
			this.guna2Panel6.Controls.Add(this.lbPeriodPriceSeperator);
			this.guna2Panel6.Controls.Add(this.tbPeriodPrice1);
			this.guna2Panel6.Controls.Add(this.lbPeriodTime);
			this.guna2Panel6.Controls.Add(this.lbBillRole);
			this.guna2Panel6.Controls.Add(this.lbDpkHeader);
			this.guna2Panel6.Controls.Add(this.cbBillRole);
			this.guna2Panel6.Controls.Add(this.dpkHeader1);
			this.guna2Panel6.Controls.Add(this.dpkHeader2);
			this.guna2Panel6.Location = new System.Drawing.Point(50, 122);
			this.guna2Panel6.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.guna2Panel6.Name = "guna2Panel6";
			this.guna2Panel6.Size = new System.Drawing.Size(1206, 62);
			this.guna2Panel6.TabIndex = 101;
			// 
			// btnPriceApply
			// 
			this.btnPriceApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnPriceApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(148)))), ((int)(((byte)(88)))));
			this.btnPriceApply.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPriceApply.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
			this.btnPriceApply.FlatAppearance.BorderSize = 0;
			this.btnPriceApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPriceApply.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
			this.btnPriceApply.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnPriceApply.IconChar = FontAwesome.Sharp.IconChar.Play;
			this.btnPriceApply.IconColor = System.Drawing.Color.White;
			this.btnPriceApply.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnPriceApply.IconSize = 25;
			this.btnPriceApply.Location = new System.Drawing.Point(590, 23);
			this.btnPriceApply.Margin = new System.Windows.Forms.Padding(3, 3, 50, 3);
			this.btnPriceApply.Name = "btnPriceApply";
			this.btnPriceApply.Padding = new System.Windows.Forms.Padding(3, 4, 0, 0);
			this.btnPriceApply.Size = new System.Drawing.Size(36, 36);
			this.btnPriceApply.TabIndex = 108;
			this.btnPriceApply.TabStop = false;
			this.btnPriceApply.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnPriceApply.UseVisualStyleBackColor = false;
			this.btnPriceApply.Click += new System.EventHandler(this.btnPriceApply_Click);
			// 
			// lbPeriodPrice
			// 
			this.lbPeriodPrice.AutoSize = true;
			this.lbPeriodPrice.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.lbPeriodPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.lbPeriodPrice.Location = new System.Drawing.Point(356, 3);
			this.lbPeriodPrice.Margin = new System.Windows.Forms.Padding(3);
			this.lbPeriodPrice.Name = "lbPeriodPrice";
			this.lbPeriodPrice.Size = new System.Drawing.Size(85, 19);
			this.lbPeriodPrice.TabIndex = 107;
			this.lbPeriodPrice.Text = "Khoảng giá";
			this.lbPeriodPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tbPeriodPrice2
			// 
			this.tbPeriodPrice2.Animated = true;
			this.tbPeriodPrice2.BorderRadius = 5;
			this.tbPeriodPrice2.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbPeriodPrice2.DefaultText = "";
			this.tbPeriodPrice2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbPeriodPrice2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbPeriodPrice2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbPeriodPrice2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbPeriodPrice2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbPeriodPrice2.Font = new System.Drawing.Font("Tahoma", 10F);
			this.tbPeriodPrice2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbPeriodPrice2.Location = new System.Drawing.Point(484, 23);
			this.tbPeriodPrice2.Name = "tbPeriodPrice2";
			this.tbPeriodPrice2.PasswordChar = '\0';
			this.tbPeriodPrice2.PlaceholderText = "đ Đến";
			this.tbPeriodPrice2.SelectedText = "";
			this.tbPeriodPrice2.Size = new System.Drawing.Size(100, 36);
			this.tbPeriodPrice2.TabIndex = 106;
			// 
			// lbPeriodPriceSeperator
			// 
			this.lbPeriodPriceSeperator.AutoSize = true;
			this.lbPeriodPriceSeperator.Font = new System.Drawing.Font("Tahoma", 12F);
			this.lbPeriodPriceSeperator.ForeColor = System.Drawing.Color.DimGray;
			this.lbPeriodPriceSeperator.Location = new System.Drawing.Point(463, 33);
			this.lbPeriodPriceSeperator.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
			this.lbPeriodPriceSeperator.Name = "lbPeriodPriceSeperator";
			this.lbPeriodPriceSeperator.Size = new System.Drawing.Size(15, 19);
			this.lbPeriodPriceSeperator.TabIndex = 105;
			this.lbPeriodPriceSeperator.Text = "-";
			// 
			// tbPeriodPrice1
			// 
			this.tbPeriodPrice1.Animated = true;
			this.tbPeriodPrice1.BorderRadius = 5;
			this.tbPeriodPrice1.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbPeriodPrice1.DefaultText = "";
			this.tbPeriodPrice1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbPeriodPrice1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbPeriodPrice1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbPeriodPrice1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbPeriodPrice1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbPeriodPrice1.Font = new System.Drawing.Font("Tahoma", 10F);
			this.tbPeriodPrice1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbPeriodPrice1.Location = new System.Drawing.Point(356, 23);
			this.tbPeriodPrice1.Name = "tbPeriodPrice1";
			this.tbPeriodPrice1.PasswordChar = '\0';
			this.tbPeriodPrice1.PlaceholderText = "đ Từ";
			this.tbPeriodPrice1.SelectedText = "";
			this.tbPeriodPrice1.Size = new System.Drawing.Size(100, 36);
			this.tbPeriodPrice1.TabIndex = 104;
			// 
			// lbPeriodTime
			// 
			this.lbPeriodTime.AutoSize = true;
			this.lbPeriodTime.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.lbPeriodTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.lbPeriodTime.Location = new System.Drawing.Point(759, 3);
			this.lbPeriodTime.Margin = new System.Windows.Forms.Padding(3);
			this.lbPeriodTime.Name = "lbPeriodTime";
			this.lbPeriodTime.Size = new System.Drawing.Size(123, 19);
			this.lbPeriodTime.TabIndex = 103;
			this.lbPeriodTime.Text = "Khoảng thời gian";
			this.lbPeriodTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbBillRole
			// 
			this.lbBillRole.AutoSize = true;
			this.lbBillRole.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.lbBillRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.lbBillRole.Location = new System.Drawing.Point(3, 3);
			this.lbBillRole.Margin = new System.Windows.Forms.Padding(3);
			this.lbBillRole.Name = "lbBillRole";
			this.lbBillRole.Size = new System.Drawing.Size(96, 19);
			this.lbBillRole.TabIndex = 102;
			this.lbBillRole.Text = "Loại hóa đơn";
			this.lbBillRole.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbDpkHeader
			// 
			this.lbDpkHeader.AutoSize = true;
			this.lbDpkHeader.Font = new System.Drawing.Font("Tahoma", 12F);
			this.lbDpkHeader.ForeColor = System.Drawing.Color.DimGray;
			this.lbDpkHeader.Location = new System.Drawing.Point(969, 33);
			this.lbDpkHeader.Margin = new System.Windows.Forms.Padding(3, 0, 3, 10);
			this.lbDpkHeader.Name = "lbDpkHeader";
			this.lbDpkHeader.Size = new System.Drawing.Size(28, 19);
			this.lbDpkHeader.TabIndex = 8;
			this.lbDpkHeader.Text = "To";
			// 
			// cbBillRole
			// 
			this.cbBillRole.BackColor = System.Drawing.Color.Transparent;
			this.cbBillRole.BorderRadius = 5;
			this.cbBillRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbBillRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbBillRole.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbBillRole.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbBillRole.Font = new System.Drawing.Font("Tahoma", 10F);
			this.cbBillRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
			this.cbBillRole.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.cbBillRole.ItemHeight = 30;
			this.cbBillRole.Items.AddRange(new object[] {
            "Hóa đơn bán hàng",
            "Hóa đơn nhập hàng"});
			this.cbBillRole.Location = new System.Drawing.Point(3, 24);
			this.cbBillRole.Margin = new System.Windows.Forms.Padding(3, 3, 150, 3);
			this.cbBillRole.Name = "cbBillRole";
			this.cbBillRole.Size = new System.Drawing.Size(200, 36);
			this.cbBillRole.StartIndex = 0;
			this.cbBillRole.TabIndex = 17;
			this.cbBillRole.SelectedIndexChanged += new System.EventHandler(this.cbBillRole_SelectedIndexChanged);
			// 
			// dpkHeader1
			// 
			this.dpkHeader1.BackColor = System.Drawing.Color.White;
			this.dpkHeader1.BorderRadius = 0;
			this.dpkHeader1.ForeColor = System.Drawing.Color.DimGray;
			this.dpkHeader1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dpkHeader1.FormatCustom = "MMM/dd/yyyy";
			this.dpkHeader1.Location = new System.Drawing.Point(763, 23);
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
			this.dpkHeader2.Location = new System.Drawing.Point(1003, 23);
			this.dpkHeader2.Name = "dpkHeader2";
			this.dpkHeader2.Size = new System.Drawing.Size(200, 36);
			this.dpkHeader2.TabIndex = 6;
			this.dpkHeader2.Value = new System.DateTime(2022, 4, 13, 0, 0, 0, 0);
			this.dpkHeader2.onValueChanged += new System.EventHandler(this.dpkHeader1_onValueChanged);
			// 
			// guna2Panel1
			// 
			this.guna2Panel1.Controls.Add(this.lbTotalBillPrice);
			this.guna2Panel1.Controls.Add(this.lbTotalBill);
			this.guna2Panel1.Controls.Add(this.lbSearchTitle);
			this.guna2Panel1.Controls.Add(this.tbSearch);
			this.guna2Panel1.Location = new System.Drawing.Point(50, 50);
			this.guna2Panel1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.guna2Panel1.Name = "guna2Panel1";
			this.guna2Panel1.Size = new System.Drawing.Size(1206, 62);
			this.guna2Panel1.TabIndex = 102;
			// 
			// lbSearchTitle
			// 
			this.lbSearchTitle.AutoSize = true;
			this.lbSearchTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.lbSearchTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.lbSearchTitle.Location = new System.Drawing.Point(3, 3);
			this.lbSearchTitle.Margin = new System.Windows.Forms.Padding(3);
			this.lbSearchTitle.Name = "lbSearchTitle";
			this.lbSearchTitle.Size = new System.Drawing.Size(71, 19);
			this.lbSearchTitle.TabIndex = 101;
			this.lbSearchTitle.Text = "Tìm kiếm";
			this.lbSearchTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.tbSearch.Location = new System.Drawing.Point(7, 25);
			this.tbSearch.Margin = new System.Windows.Forms.Padding(3, 0, 50, 5);
			this.tbSearch.Name = "tbSearch";
			this.tbSearch.PasswordChar = '\0';
			this.tbSearch.PlaceholderText = "Tìm kiếm hóa đơn/ Khách hàng ...";
			this.tbSearch.SelectedText = "";
			this.tbSearch.Size = new System.Drawing.Size(339, 35);
			this.tbSearch.TabIndex = 16;
			this.tbSearch.TabStop = false;
			this.tbSearch.IconRightClick += new System.EventHandler(this.tbSearch_IconRightClick);
			this.tbSearch.Enter += new System.EventHandler(this.tbSearch_Enter);
			this.tbSearch.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tbSearch_MouseDoubleClick);
			this.tbSearch.MouseLeave += new System.EventHandler(this.tbSearch_MouseLeave);
			// 
			// flpBillRow
			// 
			this.flpBillRow.AutoScroll = true;
			this.flpBillRow.Location = new System.Drawing.Point(50, 194);
			this.flpBillRow.Margin = new System.Windows.Forms.Padding(0);
			this.flpBillRow.Name = "flpBillRow";
			this.flpBillRow.Size = new System.Drawing.Size(1206, 605);
			this.flpBillRow.TabIndex = 103;
			// 
			// errorProviderWar
			// 
			this.errorProviderWar.ContainerControl = this;
			// 
			// lbTotalBill
			// 
			this.lbTotalBill.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
			this.lbTotalBill.ForeColor = System.Drawing.Color.DimGray;
			this.lbTotalBill.Location = new System.Drawing.Point(903, 3);
			this.lbTotalBill.Name = "lbTotalBill";
			this.lbTotalBill.Size = new System.Drawing.Size(300, 17);
			this.lbTotalBill.TabIndex = 102;
			this.lbTotalBill.Text = "Số lượng hóa đơn:";
			this.lbTotalBill.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbTotalBillPrice
			// 
			this.lbTotalBillPrice.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
			this.lbTotalBillPrice.ForeColor = System.Drawing.Color.DimGray;
			this.lbTotalBillPrice.Location = new System.Drawing.Point(903, 25);
			this.lbTotalBillPrice.Name = "lbTotalBillPrice";
			this.lbTotalBillPrice.Size = new System.Drawing.Size(300, 17);
			this.lbTotalBillPrice.TabIndex = 103;
			this.lbTotalBillPrice.Text = "Tổng trị giá hóa đơn:";
			this.lbTotalBillPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// Bill
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.flpBillRow);
			this.Controls.Add(this.guna2Panel1);
			this.Controls.Add(this.guna2Panel6);
			this.Margin = new System.Windows.Forms.Padding(0);
			this.Name = "Bill";
			this.Padding = new System.Windows.Forms.Padding(50);
			this.Size = new System.Drawing.Size(1306, 849);
			this.Load += new System.EventHandler(this.Bill_Load);
			this.guna2Panel6.ResumeLayout(false);
			this.guna2Panel6.PerformLayout();
			this.guna2Panel1.ResumeLayout(false);
			this.guna2Panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderWar)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2Panel guna2Panel6;
		private System.Windows.Forms.Label lbDpkHeader;
		private Bunifu.Framework.UI.BunifuDatepicker dpkHeader1;
		private Bunifu.Framework.UI.BunifuDatepicker dpkHeader2;
		private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
		private Guna.UI2.WinForms.Guna2TextBox tbSearch;
		private Guna.UI2.WinForms.Guna2ComboBox cbBillRole;
		private System.Windows.Forms.Label lbPeriodPrice;
		private Guna.UI2.WinForms.Guna2TextBox tbPeriodPrice2;
		private System.Windows.Forms.Label lbPeriodPriceSeperator;
		private Guna.UI2.WinForms.Guna2TextBox tbPeriodPrice1;
		private System.Windows.Forms.Label lbPeriodTime;
		private System.Windows.Forms.Label lbBillRole;
		private System.Windows.Forms.Label lbSearchTitle;
		public FontAwesome.Sharp.IconButton btnPriceApply;
		private System.Windows.Forms.FlowLayoutPanel flpBillRow;
		private System.Windows.Forms.ErrorProvider errorProviderWar;
		private System.Windows.Forms.Label lbTotalBillPrice;
		private System.Windows.Forms.Label lbTotalBill;
	}
}
