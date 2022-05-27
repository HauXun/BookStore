namespace BookStore.ChildForm
{
	partial class Bills
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
			this.lbTitle = new System.Windows.Forms.Label();
			this.lbBillID = new System.Windows.Forms.Label();
			this.lbDate = new System.Windows.Forms.Label();
			this.lbDoitac = new System.Windows.Forms.Label();
			this.lbAddress = new System.Windows.Forms.Label();
			this.lbSDT = new System.Windows.Forms.Label();
			this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
			this.lbNguoiBan = new System.Windows.Forms.Label();
			this.pnlPaymentDetails = new System.Windows.Forms.Panel();
			this.lbDiscountValue = new Guna.UI2.WinForms.Guna2NumericUpDown();
			this.lbPaymentTypeValue = new System.Windows.Forms.Label();
			this.lbNote = new System.Windows.Forms.Label();
			this.lbPaymentTextValue = new System.Windows.Forms.Label();
			this.lbPaymentText = new System.Windows.Forms.Label();
			this.lbPaymentType = new System.Windows.Forms.Label();
			this.lbTotalPaymentValue = new System.Windows.Forms.Label();
			this.lbTotalPayment = new System.Windows.Forms.Label();
			this.lbTotalPriceValue = new System.Windows.Forms.Label();
			this.lbDiscount = new System.Windows.Forms.Label();
			this.lbTotalPrice = new System.Windows.Forms.Label();
			this.pnlTitleNavBox = new System.Windows.Forms.Panel();
			this.pnlTitleColumn = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
			this.flpTitleColumn = new System.Windows.Forms.FlowLayoutPanel();
			this.pnlNameColumn = new System.Windows.Forms.Panel();
			this.lbNameColumn = new System.Windows.Forms.Label();
			this.pnlPriceColumn = new System.Windows.Forms.Panel();
			this.lbPriceColumn = new System.Windows.Forms.Label();
			this.pnlAmountColumn = new System.Windows.Forms.Panel();
			this.lbAmountColumn = new System.Windows.Forms.Label();
			this.pnlTotalColumn = new System.Windows.Forms.Panel();
			this.lbTotalColumn = new System.Windows.Forms.Label();
			this.pnlBillDetails = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnEditBill = new FontAwesome.Sharp.IconButton();
			this.lbBack = new System.Windows.Forms.LinkLabel();
			this.btnPrint = new FontAwesome.Sharp.IconButton();
			this.btnDownload = new FontAwesome.Sharp.IconButton();
			this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
			this.Content.SuspendLayout();
			this.pnlHeader.SuspendLayout();
			this.pnlPaymentDetails.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.lbDiscountValue)).BeginInit();
			this.pnlTitleNavBox.SuspendLayout();
			this.pnlTitleColumn.SuspendLayout();
			this.flpTitleColumn.SuspendLayout();
			this.pnlNameColumn.SuspendLayout();
			this.pnlPriceColumn.SuspendLayout();
			this.pnlAmountColumn.SuspendLayout();
			this.pnlTotalColumn.SuspendLayout();
			this.pnlBillDetails.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// Content
			// 
			this.Content.AutoSize = true;
			this.Content.Controls.Add(this.guna2Panel1);
			this.Content.Controls.Add(this.panel1);
			this.Content.Controls.Add(this.pnlBillDetails);
			this.Content.Controls.Add(this.pnlHeader);
			this.Content.Margin = new System.Windows.Forms.Padding(0);
			this.Content.MinimumSize = new System.Drawing.Size(1002, 543);
			this.Content.Padding = new System.Windows.Forms.Padding(50);
			this.Content.Size = new System.Drawing.Size(1180, 543);
			// 
			// lbTitle
			// 
			this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTitle.Location = new System.Drawing.Point(0, 0);
			this.lbTitle.Margin = new System.Windows.Forms.Padding(0);
			this.lbTitle.Name = "lbTitle";
			this.lbTitle.Size = new System.Drawing.Size(903, 31);
			this.lbTitle.TabIndex = 0;
			this.lbTitle.Text = "HÓA ĐƠN BÁN HÀNG";
			this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbBillID
			// 
			this.lbBillID.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbBillID.Location = new System.Drawing.Point(0, 31);
			this.lbBillID.Margin = new System.Windows.Forms.Padding(0);
			this.lbBillID.Name = "lbBillID";
			this.lbBillID.Size = new System.Drawing.Size(903, 16);
			this.lbBillID.TabIndex = 1;
			this.lbBillID.Text = "Hóa đơn:";
			this.lbBillID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbDate
			// 
			this.lbDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbDate.Location = new System.Drawing.Point(0, 57);
			this.lbDate.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.lbDate.Name = "lbDate";
			this.lbDate.Size = new System.Drawing.Size(902, 25);
			this.lbDate.TabIndex = 2;
			this.lbDate.Text = "Ngày giờ: ";
			this.lbDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbDoitac
			// 
			this.lbDoitac.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbDoitac.Location = new System.Drawing.Point(0, 82);
			this.lbDoitac.Margin = new System.Windows.Forms.Padding(0);
			this.lbDoitac.Name = "lbDoitac";
			this.lbDoitac.Size = new System.Drawing.Size(902, 25);
			this.lbDoitac.TabIndex = 3;
			this.lbDoitac.Text = "Khách hàng/ Công ty/ Dối tác: ";
			this.lbDoitac.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbAddress
			// 
			this.lbAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbAddress.Location = new System.Drawing.Point(0, 107);
			this.lbAddress.Margin = new System.Windows.Forms.Padding(0);
			this.lbAddress.Name = "lbAddress";
			this.lbAddress.Size = new System.Drawing.Size(450, 25);
			this.lbAddress.TabIndex = 4;
			this.lbAddress.Text = "Địa chỉ: ";
			this.lbAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbSDT
			// 
			this.lbSDT.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbSDT.Location = new System.Drawing.Point(450, 107);
			this.lbSDT.Margin = new System.Windows.Forms.Padding(0);
			this.lbSDT.Name = "lbSDT";
			this.lbSDT.Size = new System.Drawing.Size(453, 25);
			this.lbSDT.TabIndex = 5;
			this.lbSDT.Text = "Điện thoại: ";
			this.lbSDT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pnlHeader
			// 
			this.pnlHeader.BackColor = System.Drawing.Color.Transparent;
			this.pnlHeader.Controls.Add(this.lbNguoiBan);
			this.pnlHeader.Controls.Add(this.lbSDT);
			this.pnlHeader.Controls.Add(this.lbAddress);
			this.pnlHeader.Controls.Add(this.lbDoitac);
			this.pnlHeader.Controls.Add(this.lbDate);
			this.pnlHeader.Controls.Add(this.lbBillID);
			this.pnlHeader.Controls.Add(this.lbTitle);
			this.pnlHeader.FillColor = System.Drawing.Color.White;
			this.pnlHeader.Location = new System.Drawing.Point(50, 50);
			this.pnlHeader.Margin = new System.Windows.Forms.Padding(0);
			this.pnlHeader.Name = "pnlHeader";
			this.pnlHeader.Size = new System.Drawing.Size(902, 159);
			this.pnlHeader.TabIndex = 21;
			// 
			// lbNguoiBan
			// 
			this.lbNguoiBan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbNguoiBan.Location = new System.Drawing.Point(0, 132);
			this.lbNguoiBan.Margin = new System.Windows.Forms.Padding(0);
			this.lbNguoiBan.Name = "lbNguoiBan";
			this.lbNguoiBan.Size = new System.Drawing.Size(902, 25);
			this.lbNguoiBan.TabIndex = 6;
			this.lbNguoiBan.Text = "Người bán: ";
			this.lbNguoiBan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pnlPaymentDetails
			// 
			this.pnlPaymentDetails.Controls.Add(this.lbDiscountValue);
			this.pnlPaymentDetails.Controls.Add(this.lbPaymentTypeValue);
			this.pnlPaymentDetails.Controls.Add(this.lbNote);
			this.pnlPaymentDetails.Controls.Add(this.lbPaymentTextValue);
			this.pnlPaymentDetails.Controls.Add(this.lbPaymentText);
			this.pnlPaymentDetails.Controls.Add(this.lbPaymentType);
			this.pnlPaymentDetails.Controls.Add(this.lbTotalPaymentValue);
			this.pnlPaymentDetails.Controls.Add(this.lbTotalPayment);
			this.pnlPaymentDetails.Controls.Add(this.lbTotalPriceValue);
			this.pnlPaymentDetails.Controls.Add(this.lbDiscount);
			this.pnlPaymentDetails.Controls.Add(this.lbTotalPrice);
			this.pnlPaymentDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnlPaymentDetails.Location = new System.Drawing.Point(0, 122);
			this.pnlPaymentDetails.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.pnlPaymentDetails.Name = "pnlPaymentDetails";
			this.pnlPaymentDetails.Size = new System.Drawing.Size(902, 152);
			this.pnlPaymentDetails.TabIndex = 16;
			// 
			// lbDiscountValue
			// 
			this.lbDiscountValue.BackColor = System.Drawing.Color.Transparent;
			this.lbDiscountValue.BorderColor = System.Drawing.Color.White;
			this.lbDiscountValue.BorderThickness = 0;
			this.lbDiscountValue.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.lbDiscountValue.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.lbDiscountValue.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lbDiscountValue.Location = new System.Drawing.Point(706, 25);
			this.lbDiscountValue.Margin = new System.Windows.Forms.Padding(0);
			this.lbDiscountValue.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
			this.lbDiscountValue.Name = "lbDiscountValue";
			this.lbDiscountValue.Size = new System.Drawing.Size(196, 25);
			this.lbDiscountValue.TabIndex = 31;
			this.lbDiscountValue.TextOffset = new System.Drawing.Point(3, 0);
			this.lbDiscountValue.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			// 
			// lbPaymentTypeValue
			// 
			this.lbPaymentTypeValue.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.lbPaymentTypeValue.Location = new System.Drawing.Point(133, 77);
			this.lbPaymentTypeValue.Margin = new System.Windows.Forms.Padding(0);
			this.lbPaymentTypeValue.Name = "lbPaymentTypeValue";
			this.lbPaymentTypeValue.Size = new System.Drawing.Size(768, 25);
			this.lbPaymentTypeValue.TabIndex = 28;
			this.lbPaymentTypeValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbNote
			// 
			this.lbNote.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.lbNote.Location = new System.Drawing.Point(0, 127);
			this.lbNote.Margin = new System.Windows.Forms.Padding(0);
			this.lbNote.Name = "lbNote";
			this.lbNote.Size = new System.Drawing.Size(902, 25);
			this.lbNote.TabIndex = 26;
			this.lbNote.Text = "Ghi chú:";
			this.lbNote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbPaymentTextValue
			// 
			this.lbPaymentTextValue.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.lbPaymentTextValue.Location = new System.Drawing.Point(182, 102);
			this.lbPaymentTextValue.Margin = new System.Windows.Forms.Padding(0);
			this.lbPaymentTextValue.Name = "lbPaymentTextValue";
			this.lbPaymentTextValue.Size = new System.Drawing.Size(719, 25);
			this.lbPaymentTextValue.TabIndex = 25;
			this.lbPaymentTextValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbPaymentText
			// 
			this.lbPaymentText.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.lbPaymentText.Location = new System.Drawing.Point(0, 102);
			this.lbPaymentText.Margin = new System.Windows.Forms.Padding(0);
			this.lbPaymentText.Name = "lbPaymentText";
			this.lbPaymentText.Size = new System.Drawing.Size(182, 25);
			this.lbPaymentText.TabIndex = 24;
			this.lbPaymentText.Text = "Số tiền thanh toán bằng chữ:";
			this.lbPaymentText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbPaymentType
			// 
			this.lbPaymentType.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.lbPaymentType.Location = new System.Drawing.Point(0, 77);
			this.lbPaymentType.Margin = new System.Windows.Forms.Padding(0);
			this.lbPaymentType.Name = "lbPaymentType";
			this.lbPaymentType.Size = new System.Drawing.Size(133, 25);
			this.lbPaymentType.TabIndex = 23;
			this.lbPaymentType.Text = "Hình thức thanh toán:";
			this.lbPaymentType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbTotalPaymentValue
			// 
			this.lbTotalPaymentValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTotalPaymentValue.Location = new System.Drawing.Point(703, 52);
			this.lbTotalPaymentValue.Margin = new System.Windows.Forms.Padding(0);
			this.lbTotalPaymentValue.Name = "lbTotalPaymentValue";
			this.lbTotalPaymentValue.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
			this.lbTotalPaymentValue.Size = new System.Drawing.Size(199, 25);
			this.lbTotalPaymentValue.TabIndex = 12;
			this.lbTotalPaymentValue.Text = "0";
			this.lbTotalPaymentValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbTotalPayment
			// 
			this.lbTotalPayment.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTotalPayment.Location = new System.Drawing.Point(0, 52);
			this.lbTotalPayment.Margin = new System.Windows.Forms.Padding(0);
			this.lbTotalPayment.Name = "lbTotalPayment";
			this.lbTotalPayment.Size = new System.Drawing.Size(703, 25);
			this.lbTotalPayment.TabIndex = 11;
			this.lbTotalPayment.Text = "Tổng tiền thanh toán:";
			this.lbTotalPayment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbTotalPriceValue
			// 
			this.lbTotalPriceValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTotalPriceValue.Location = new System.Drawing.Point(703, 0);
			this.lbTotalPriceValue.Margin = new System.Windows.Forms.Padding(0);
			this.lbTotalPriceValue.Name = "lbTotalPriceValue";
			this.lbTotalPriceValue.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
			this.lbTotalPriceValue.Size = new System.Drawing.Size(199, 25);
			this.lbTotalPriceValue.TabIndex = 9;
			this.lbTotalPriceValue.Text = "0";
			this.lbTotalPriceValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbDiscount
			// 
			this.lbDiscount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbDiscount.Location = new System.Drawing.Point(0, 24);
			this.lbDiscount.Margin = new System.Windows.Forms.Padding(0);
			this.lbDiscount.Name = "lbDiscount";
			this.lbDiscount.Size = new System.Drawing.Size(703, 25);
			this.lbDiscount.TabIndex = 8;
			this.lbDiscount.Text = "Giảm giá:";
			this.lbDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbTotalPrice
			// 
			this.lbTotalPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTotalPrice.Location = new System.Drawing.Point(0, 0);
			this.lbTotalPrice.Margin = new System.Windows.Forms.Padding(0);
			this.lbTotalPrice.Name = "lbTotalPrice";
			this.lbTotalPrice.Size = new System.Drawing.Size(703, 25);
			this.lbTotalPrice.TabIndex = 7;
			this.lbTotalPrice.Text = "Tổng tiền hàng:";
			this.lbTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// pnlTitleNavBox
			// 
			this.pnlTitleNavBox.AutoSize = true;
			this.pnlTitleNavBox.Controls.Add(this.pnlTitleColumn);
			this.pnlTitleNavBox.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlTitleNavBox.Location = new System.Drawing.Point(0, 0);
			this.pnlTitleNavBox.Margin = new System.Windows.Forms.Padding(0);
			this.pnlTitleNavBox.Name = "pnlTitleNavBox";
			this.pnlTitleNavBox.Size = new System.Drawing.Size(902, 51);
			this.pnlTitleNavBox.TabIndex = 21;
			// 
			// pnlTitleColumn
			// 
			this.pnlTitleColumn.BackColor = System.Drawing.Color.White;
			this.pnlTitleColumn.BorderThickness = 3;
			this.pnlTitleColumn.Controls.Add(this.flpTitleColumn);
			this.pnlTitleColumn.CustomBorderColor = System.Drawing.Color.DimGray;
			this.pnlTitleColumn.CustomBorderThickness = new System.Windows.Forms.Padding(1);
			this.pnlTitleColumn.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlTitleColumn.Location = new System.Drawing.Point(0, 0);
			this.pnlTitleColumn.Margin = new System.Windows.Forms.Padding(0);
			this.pnlTitleColumn.Name = "pnlTitleColumn";
			this.pnlTitleColumn.Padding = new System.Windows.Forms.Padding(5);
			this.pnlTitleColumn.Size = new System.Drawing.Size(902, 51);
			this.pnlTitleColumn.TabIndex = 21;
			// 
			// flpTitleColumn
			// 
			this.flpTitleColumn.AutoScroll = true;
			this.flpTitleColumn.Controls.Add(this.pnlNameColumn);
			this.flpTitleColumn.Controls.Add(this.pnlPriceColumn);
			this.flpTitleColumn.Controls.Add(this.pnlAmountColumn);
			this.flpTitleColumn.Controls.Add(this.pnlTotalColumn);
			this.flpTitleColumn.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flpTitleColumn.Location = new System.Drawing.Point(1, 1);
			this.flpTitleColumn.Margin = new System.Windows.Forms.Padding(1);
			this.flpTitleColumn.Name = "flpTitleColumn";
			this.flpTitleColumn.Size = new System.Drawing.Size(900, 49);
			this.flpTitleColumn.TabIndex = 7;
			// 
			// pnlNameColumn
			// 
			this.pnlNameColumn.BackColor = System.Drawing.Color.Transparent;
			this.pnlNameColumn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnlNameColumn.Controls.Add(this.lbNameColumn);
			this.pnlNameColumn.Location = new System.Drawing.Point(0, 0);
			this.pnlNameColumn.Margin = new System.Windows.Forms.Padding(0);
			this.pnlNameColumn.Name = "pnlNameColumn";
			this.pnlNameColumn.Size = new System.Drawing.Size(490, 49);
			this.pnlNameColumn.TabIndex = 0;
			// 
			// lbNameColumn
			// 
			this.lbNameColumn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.lbNameColumn.BackColor = System.Drawing.Color.Transparent;
			this.lbNameColumn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.lbNameColumn.ForeColor = System.Drawing.Color.DimGray;
			this.lbNameColumn.Location = new System.Drawing.Point(0, 12);
			this.lbNameColumn.Margin = new System.Windows.Forms.Padding(0, 20, 20, 20);
			this.lbNameColumn.Name = "lbNameColumn";
			this.lbNameColumn.Size = new System.Drawing.Size(483, 21);
			this.lbNameColumn.TabIndex = 1;
			this.lbNameColumn.Text = "TÊN SẢN PHẨM";
			this.lbNameColumn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pnlPriceColumn
			// 
			this.pnlPriceColumn.BackColor = System.Drawing.Color.Transparent;
			this.pnlPriceColumn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnlPriceColumn.Controls.Add(this.lbPriceColumn);
			this.pnlPriceColumn.Location = new System.Drawing.Point(490, 0);
			this.pnlPriceColumn.Margin = new System.Windows.Forms.Padding(0);
			this.pnlPriceColumn.Name = "pnlPriceColumn";
			this.pnlPriceColumn.Size = new System.Drawing.Size(180, 49);
			this.pnlPriceColumn.TabIndex = 1;
			// 
			// lbPriceColumn
			// 
			this.lbPriceColumn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.lbPriceColumn.BackColor = System.Drawing.Color.Transparent;
			this.lbPriceColumn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.lbPriceColumn.ForeColor = System.Drawing.Color.DimGray;
			this.lbPriceColumn.Location = new System.Drawing.Point(0, 12);
			this.lbPriceColumn.Margin = new System.Windows.Forms.Padding(0, 20, 20, 20);
			this.lbPriceColumn.Name = "lbPriceColumn";
			this.lbPriceColumn.Size = new System.Drawing.Size(176, 21);
			this.lbPriceColumn.TabIndex = 2;
			this.lbPriceColumn.Text = "ĐƠN GIÁ";
			this.lbPriceColumn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pnlAmountColumn
			// 
			this.pnlAmountColumn.BackColor = System.Drawing.Color.Transparent;
			this.pnlAmountColumn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnlAmountColumn.Controls.Add(this.lbAmountColumn);
			this.pnlAmountColumn.Location = new System.Drawing.Point(670, 0);
			this.pnlAmountColumn.Margin = new System.Windows.Forms.Padding(0);
			this.pnlAmountColumn.Name = "pnlAmountColumn";
			this.pnlAmountColumn.Size = new System.Drawing.Size(50, 49);
			this.pnlAmountColumn.TabIndex = 2;
			// 
			// lbAmountColumn
			// 
			this.lbAmountColumn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.lbAmountColumn.BackColor = System.Drawing.Color.Transparent;
			this.lbAmountColumn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.lbAmountColumn.ForeColor = System.Drawing.Color.DimGray;
			this.lbAmountColumn.Location = new System.Drawing.Point(0, 12);
			this.lbAmountColumn.Margin = new System.Windows.Forms.Padding(0, 20, 20, 20);
			this.lbAmountColumn.Name = "lbAmountColumn";
			this.lbAmountColumn.Size = new System.Drawing.Size(46, 21);
			this.lbAmountColumn.TabIndex = 3;
			this.lbAmountColumn.Text = "SL";
			this.lbAmountColumn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pnlTotalColumn
			// 
			this.pnlTotalColumn.BackColor = System.Drawing.Color.Transparent;
			this.pnlTotalColumn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnlTotalColumn.Controls.Add(this.lbTotalColumn);
			this.pnlTotalColumn.Location = new System.Drawing.Point(720, 0);
			this.pnlTotalColumn.Margin = new System.Windows.Forms.Padding(0);
			this.pnlTotalColumn.Name = "pnlTotalColumn";
			this.pnlTotalColumn.Size = new System.Drawing.Size(180, 49);
			this.pnlTotalColumn.TabIndex = 3;
			// 
			// lbTotalColumn
			// 
			this.lbTotalColumn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.lbTotalColumn.BackColor = System.Drawing.Color.Transparent;
			this.lbTotalColumn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.lbTotalColumn.ForeColor = System.Drawing.Color.DimGray;
			this.lbTotalColumn.Location = new System.Drawing.Point(0, 12);
			this.lbTotalColumn.Margin = new System.Windows.Forms.Padding(0, 20, 20, 20);
			this.lbTotalColumn.Name = "lbTotalColumn";
			this.lbTotalColumn.Size = new System.Drawing.Size(176, 21);
			this.lbTotalColumn.TabIndex = 2;
			this.lbTotalColumn.Text = "THÀNH TIỀN";
			this.lbTotalColumn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pnlBillDetails
			// 
			this.pnlBillDetails.AutoSize = true;
			this.pnlBillDetails.Controls.Add(this.pnlTitleNavBox);
			this.pnlBillDetails.Controls.Add(this.pnlPaymentDetails);
			this.pnlBillDetails.Location = new System.Drawing.Point(50, 219);
			this.pnlBillDetails.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.pnlBillDetails.Name = "pnlBillDetails";
			this.pnlBillDetails.Size = new System.Drawing.Size(902, 274);
			this.pnlBillDetails.TabIndex = 22;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.btnEditBill);
			this.panel1.Controls.Add(this.lbBack);
			this.panel1.Controls.Add(this.btnPrint);
			this.panel1.Controls.Add(this.btnDownload);
			this.panel1.Location = new System.Drawing.Point(995, 50);
			this.panel1.Margin = new System.Windows.Forms.Padding(0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(135, 443);
			this.panel1.TabIndex = 23;
			// 
			// btnEditBill
			// 
			this.btnEditBill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEditBill.BackColor = System.Drawing.Color.Transparent;
			this.btnEditBill.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEditBill.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
			this.btnEditBill.FlatAppearance.BorderSize = 0;
			this.btnEditBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEditBill.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
			this.btnEditBill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(229)))));
			this.btnEditBill.IconChar = FontAwesome.Sharp.IconChar.FileSignature;
			this.btnEditBill.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(229)))));
			this.btnEditBill.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnEditBill.IconSize = 25;
			this.btnEditBill.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnEditBill.Location = new System.Drawing.Point(48, 408);
			this.btnEditBill.Margin = new System.Windows.Forms.Padding(3, 3, 20, 0);
			this.btnEditBill.Name = "btnEditBill";
			this.btnEditBill.Size = new System.Drawing.Size(84, 35);
			this.btnEditBill.TabIndex = 65;
			this.btnEditBill.TabStop = false;
			this.btnEditBill.Text = "Sửa";
			this.btnEditBill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnEditBill.UseVisualStyleBackColor = false;
			this.btnEditBill.Click += new System.EventHandler(this.btnEditBill_Click);
			// 
			// lbBack
			// 
			this.lbBack.AutoSize = true;
			this.lbBack.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.lbBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(85)))));
			this.lbBack.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
			this.lbBack.LinkColor = System.Drawing.Color.Navy;
			this.lbBack.Location = new System.Drawing.Point(50, 0);
			this.lbBack.Margin = new System.Windows.Forms.Padding(50, 0, 0, 0);
			this.lbBack.Name = "lbBack";
			this.lbBack.Size = new System.Drawing.Size(82, 21);
			this.lbBack.TabIndex = 48;
			this.lbBack.TabStop = true;
			this.lbBack.Text = "< Quay lại";
			this.lbBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbBack_LinkClicked);
			this.lbBack.MouseEnter += new System.EventHandler(this.lbBack_MouseEnter);
			this.lbBack.MouseLeave += new System.EventHandler(this.lbBack_MouseLeave);
			// 
			// btnPrint
			// 
			this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnPrint.BackColor = System.Drawing.Color.Transparent;
			this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
			this.btnPrint.FlatAppearance.BorderSize = 0;
			this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPrint.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
			this.btnPrint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnPrint.IconChar = FontAwesome.Sharp.IconChar.Print;
			this.btnPrint.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(229)))));
			this.btnPrint.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnPrint.IconSize = 25;
			this.btnPrint.Location = new System.Drawing.Point(97, 26);
			this.btnPrint.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Padding = new System.Windows.Forms.Padding(1, 3, 0, 0);
			this.btnPrint.Size = new System.Drawing.Size(35, 35);
			this.btnPrint.TabIndex = 24;
			this.btnPrint.TabStop = false;
			this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnPrint.UseVisualStyleBackColor = false;
			// 
			// btnDownload
			// 
			this.btnDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDownload.BackColor = System.Drawing.Color.Transparent;
			this.btnDownload.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDownload.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
			this.btnDownload.FlatAppearance.BorderSize = 0;
			this.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDownload.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
			this.btnDownload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnDownload.IconChar = FontAwesome.Sharp.IconChar.Download;
			this.btnDownload.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(229)))));
			this.btnDownload.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnDownload.IconSize = 25;
			this.btnDownload.Location = new System.Drawing.Point(52, 26);
			this.btnDownload.Margin = new System.Windows.Forms.Padding(5);
			this.btnDownload.Name = "btnDownload";
			this.btnDownload.Padding = new System.Windows.Forms.Padding(1, 3, 0, 0);
			this.btnDownload.Size = new System.Drawing.Size(35, 35);
			this.btnDownload.TabIndex = 23;
			this.btnDownload.TabStop = false;
			this.btnDownload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnDownload.UseVisualStyleBackColor = false;
			// 
			// guna2Panel1
			// 
			this.guna2Panel1.BackColor = System.Drawing.Color.Black;
			this.guna2Panel1.BorderRadius = 5;
			this.guna2Panel1.Location = new System.Drawing.Point(974, 76);
			this.guna2Panel1.Name = "guna2Panel1";
			this.guna2Panel1.Size = new System.Drawing.Size(1, 380);
			this.guna2Panel1.TabIndex = 6;
			// 
			// Bills
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.Transparent;
			this.MinimumSize = new System.Drawing.Size(1180, 543);
			this.Name = "Bills";
			this.Size = new System.Drawing.Size(1180, 543);
			this.Content.ResumeLayout(false);
			this.Content.PerformLayout();
			this.pnlHeader.ResumeLayout(false);
			this.pnlPaymentDetails.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.lbDiscountValue)).EndInit();
			this.pnlTitleNavBox.ResumeLayout(false);
			this.pnlTitleColumn.ResumeLayout(false);
			this.flpTitleColumn.ResumeLayout(false);
			this.pnlNameColumn.ResumeLayout(false);
			this.pnlPriceColumn.ResumeLayout(false);
			this.pnlAmountColumn.ResumeLayout(false);
			this.pnlTotalColumn.ResumeLayout(false);
			this.pnlBillDetails.ResumeLayout(false);
			this.pnlBillDetails.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel pnlBillDetails;
		private System.Windows.Forms.Panel pnlTitleNavBox;
		private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlTitleColumn;
		private System.Windows.Forms.FlowLayoutPanel flpTitleColumn;
		private System.Windows.Forms.Panel pnlNameColumn;
		private System.Windows.Forms.Label lbNameColumn;
		private System.Windows.Forms.Panel pnlPriceColumn;
		private System.Windows.Forms.Label lbPriceColumn;
		private System.Windows.Forms.Panel pnlAmountColumn;
		private System.Windows.Forms.Panel pnlTotalColumn;
		private System.Windows.Forms.Panel pnlPaymentDetails;
		private System.Windows.Forms.Label lbPaymentTypeValue;
		private System.Windows.Forms.Label lbNote;
		private System.Windows.Forms.Label lbPaymentTextValue;
		private System.Windows.Forms.Label lbPaymentText;
		private System.Windows.Forms.Label lbPaymentType;
		private System.Windows.Forms.Label lbTotalPaymentValue;
		private System.Windows.Forms.Label lbTotalPayment;
		private System.Windows.Forms.Label lbTotalPriceValue;
		private System.Windows.Forms.Label lbDiscount;
		private System.Windows.Forms.Label lbTotalPrice;
		private Guna.UI2.WinForms.Guna2Panel pnlHeader;
		private System.Windows.Forms.Label lbSDT;
		private System.Windows.Forms.Label lbAddress;
		private System.Windows.Forms.Label lbDoitac;
		private System.Windows.Forms.Label lbDate;
		private System.Windows.Forms.Label lbBillID;
		private System.Windows.Forms.Label lbTitle;
		private System.Windows.Forms.Label lbAmountColumn;
		private System.Windows.Forms.Label lbTotalColumn;
		private Guna.UI2.WinForms.Guna2NumericUpDown lbDiscountValue;
		private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.LinkLabel lbBack;
		private FontAwesome.Sharp.IconButton btnPrint;
		private FontAwesome.Sharp.IconButton btnDownload;
		public FontAwesome.Sharp.IconButton btnEditBill;
		private System.Windows.Forms.Label lbNguoiBan;
	}
}
