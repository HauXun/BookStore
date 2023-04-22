namespace BookStore.ChildForm
{
	partial class BillSetup
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
			this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
			this.cbCustomer = new Guna.UI2.WinForms.Guna2ComboBox();
			this.lbStatus = new System.Windows.Forms.Label();
			this.cbStatus = new Guna.UI2.WinForms.Guna2CheckBox();
			this.cbPayments = new Guna.UI2.WinForms.Guna2ComboBox();
			this.lbPayments = new System.Windows.Forms.Label();
			this.tbSDT = new Guna.UI2.WinForms.Guna2TextBox();
			this.btnPrint = new FontAwesome.Sharp.IconButton();
			this.btnDownload = new FontAwesome.Sharp.IconButton();
			this.lbCustomer = new System.Windows.Forms.Label();
			this.lbSDT = new System.Windows.Forms.Label();
			this.lbTitle = new System.Windows.Forms.Label();
			this.pnlPaymentDetails = new System.Windows.Forms.Panel();
			this.btnCancle = new Guna.UI2.WinForms.Guna2Button();
			this.btnSave = new Guna.UI2.WinForms.Guna2Button();
			this.paneBottomLineTitleBar = new System.Windows.Forms.Panel();
			this.BottomLineTitleBar = new System.Windows.Forms.Panel();
			this.tbNote = new Guna.UI2.WinForms.Guna2TextBox();
			this.nudDiscountValue = new Guna.UI2.WinForms.Guna2NumericUpDown();
			this.lbTotalPaymentValue = new System.Windows.Forms.Label();
			this.lbTotalPayment = new System.Windows.Forms.Label();
			this.lbTotalPriceValue = new System.Windows.Forms.Label();
			this.lbDiscount = new System.Windows.Forms.Label();
			this.lbTotalPrice = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.flpRowDetailBox = new System.Windows.Forms.FlowLayoutPanel();
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
			this.pnlNavBtn = new System.Windows.Forms.Panel();
			this.btnAdditionalProduct = new FontAwesome.Sharp.IconButton();
			this.errorProviderWar = new System.Windows.Forms.ErrorProvider(this.components);
			this.Content.SuspendLayout();
			this.pnlHeader.SuspendLayout();
			this.pnlPaymentDetails.SuspendLayout();
			this.paneBottomLineTitleBar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudDiscountValue)).BeginInit();
			this.panel1.SuspendLayout();
			this.flpRowDetailBox.SuspendLayout();
			this.pnlTitleNavBox.SuspendLayout();
			this.pnlTitleColumn.SuspendLayout();
			this.flpTitleColumn.SuspendLayout();
			this.pnlNameColumn.SuspendLayout();
			this.pnlPriceColumn.SuspendLayout();
			this.pnlAmountColumn.SuspendLayout();
			this.pnlTotalColumn.SuspendLayout();
			this.pnlNavBtn.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderWar)).BeginInit();
			this.SuspendLayout();
			// 
			// Content
			// 
			this.Content.Controls.Add(this.flpRowDetailBox);
			this.Content.Controls.Add(this.panel1);
			this.Content.Controls.Add(this.pnlPaymentDetails);
			this.Content.Controls.Add(this.pnlHeader);
			this.Content.Margin = new System.Windows.Forms.Padding(0);
			this.Content.Padding = new System.Windows.Forms.Padding(50);
			this.Content.Size = new System.Drawing.Size(1022, 813);
			// 
			// pnlHeader
			// 
			this.pnlHeader.BackColor = System.Drawing.Color.Transparent;
			this.pnlHeader.Controls.Add(this.cbCustomer);
			this.pnlHeader.Controls.Add(this.lbStatus);
			this.pnlHeader.Controls.Add(this.cbStatus);
			this.pnlHeader.Controls.Add(this.cbPayments);
			this.pnlHeader.Controls.Add(this.lbPayments);
			this.pnlHeader.Controls.Add(this.tbSDT);
			this.pnlHeader.Controls.Add(this.btnPrint);
			this.pnlHeader.Controls.Add(this.btnDownload);
			this.pnlHeader.Controls.Add(this.lbCustomer);
			this.pnlHeader.Controls.Add(this.lbSDT);
			this.pnlHeader.Controls.Add(this.lbTitle);
			this.pnlHeader.FillColor = System.Drawing.Color.White;
			this.pnlHeader.Location = new System.Drawing.Point(50, 50);
			this.pnlHeader.Margin = new System.Windows.Forms.Padding(0);
			this.pnlHeader.Name = "pnlHeader";
			this.pnlHeader.Size = new System.Drawing.Size(922, 193);
			this.pnlHeader.TabIndex = 22;
			// 
			// cbCustomer
			// 
			this.cbCustomer.BackColor = System.Drawing.Color.Transparent;
			this.cbCustomer.BorderRadius = 5;
			this.cbCustomer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCustomer.DropDownWidth = 900;
			this.cbCustomer.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbCustomer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbCustomer.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.cbCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
			this.cbCustomer.ItemHeight = 30;
			this.cbCustomer.Location = new System.Drawing.Point(262, 66);
			this.cbCustomer.Margin = new System.Windows.Forms.Padding(3, 3, 25, 3);
			this.cbCustomer.Name = "cbCustomer";
			this.cbCustomer.Size = new System.Drawing.Size(628, 36);
			this.cbCustomer.TabIndex = 20;
			this.cbCustomer.SelectedIndexChanged += new System.EventHandler(this.cbCustomer_SelectedIndexChanged);
			// 
			// lbStatus
			// 
			this.lbStatus.AutoSize = true;
			this.lbStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.lbStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.lbStatus.Location = new System.Drawing.Point(258, 122);
			this.lbStatus.Margin = new System.Windows.Forms.Padding(0);
			this.lbStatus.Name = "lbStatus";
			this.lbStatus.Size = new System.Drawing.Size(76, 19);
			this.lbStatus.TabIndex = 19;
			this.lbStatus.Text = "Trạng thái";
			this.lbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cbStatus
			// 
			this.cbStatus.AutoSize = true;
			this.cbStatus.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbStatus.CheckedState.BorderRadius = 0;
			this.cbStatus.CheckedState.BorderThickness = 0;
			this.cbStatus.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbStatus.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cbStatus.Location = new System.Drawing.Point(262, 155);
			this.cbStatus.Name = "cbStatus";
			this.cbStatus.Size = new System.Drawing.Size(105, 17);
			this.cbStatus.TabIndex = 18;
			this.cbStatus.Text = "Chưa thanh toán";
			this.cbStatus.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			this.cbStatus.UncheckedState.BorderRadius = 0;
			this.cbStatus.UncheckedState.BorderThickness = 0;
			this.cbStatus.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			// 
			// cbPayments
			// 
			this.cbPayments.BackColor = System.Drawing.Color.Transparent;
			this.cbPayments.BorderRadius = 5;
			this.cbPayments.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbPayments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbPayments.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbPayments.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbPayments.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.cbPayments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
			this.cbPayments.ItemHeight = 30;
			this.cbPayments.Items.AddRange(new object[] {
            "Chuyển khoản",
            "Tiền mặt",
            "ZaloPay",
            "MoMo",
            "Quẹt thẻ tại chỗ"});
			this.cbPayments.Location = new System.Drawing.Point(34, 145);
			this.cbPayments.Margin = new System.Windows.Forms.Padding(3, 3, 25, 3);
			this.cbPayments.Name = "cbPayments";
			this.cbPayments.Size = new System.Drawing.Size(200, 36);
			this.cbPayments.StartIndex = 4;
			this.cbPayments.TabIndex = 15;
			// 
			// lbPayments
			// 
			this.lbPayments.AutoSize = true;
			this.lbPayments.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.lbPayments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.lbPayments.Location = new System.Drawing.Point(30, 122);
			this.lbPayments.Margin = new System.Windows.Forms.Padding(0);
			this.lbPayments.Name = "lbPayments";
			this.lbPayments.Size = new System.Drawing.Size(152, 19);
			this.lbPayments.TabIndex = 14;
			this.lbPayments.Text = "Hình thức thanh toán:";
			this.lbPayments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tbSDT
			// 
			this.tbSDT.Animated = true;
			this.tbSDT.BorderRadius = 5;
			this.tbSDT.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbSDT.DefaultText = "";
			this.tbSDT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbSDT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbSDT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbSDT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbSDT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbSDT.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.tbSDT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbSDT.IconRight = global::BookStore.Properties.Resources.addIcon;
			this.tbSDT.IconRightCursor = System.Windows.Forms.Cursors.Hand;
			this.tbSDT.Location = new System.Drawing.Point(34, 66);
			this.tbSDT.Margin = new System.Windows.Forms.Padding(3, 3, 25, 3);
			this.tbSDT.Name = "tbSDT";
			this.tbSDT.PasswordChar = '\0';
			this.tbSDT.PlaceholderText = "Nhập tên hoặc số điện thoại ...";
			this.tbSDT.SelectedText = "";
			this.tbSDT.Size = new System.Drawing.Size(200, 36);
			this.tbSDT.TabIndex = 9;
			this.tbSDT.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tbSDT_MouseDoubleClick);
			this.tbSDT.MouseLeave += new System.EventHandler(this.tbSDT_MouseLeave);
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
			this.btnPrint.Location = new System.Drawing.Point(859, 5);
			this.btnPrint.Margin = new System.Windows.Forms.Padding(5);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Padding = new System.Windows.Forms.Padding(1, 3, 0, 0);
			this.btnPrint.Size = new System.Drawing.Size(35, 35);
			this.btnPrint.TabIndex = 7;
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
			this.btnDownload.Location = new System.Drawing.Point(814, 5);
			this.btnDownload.Margin = new System.Windows.Forms.Padding(5);
			this.btnDownload.Name = "btnDownload";
			this.btnDownload.Padding = new System.Windows.Forms.Padding(1, 3, 0, 0);
			this.btnDownload.Size = new System.Drawing.Size(35, 35);
			this.btnDownload.TabIndex = 6;
			this.btnDownload.TabStop = false;
			this.btnDownload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnDownload.UseVisualStyleBackColor = false;
			// 
			// lbCustomer
			// 
			this.lbCustomer.AutoSize = true;
			this.lbCustomer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.lbCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.lbCustomer.Location = new System.Drawing.Point(258, 44);
			this.lbCustomer.Margin = new System.Windows.Forms.Padding(0);
			this.lbCustomer.Name = "lbCustomer";
			this.lbCustomer.Size = new System.Drawing.Size(90, 19);
			this.lbCustomer.TabIndex = 4;
			this.lbCustomer.Text = "Khách hàng:";
			this.lbCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbSDT
			// 
			this.lbSDT.AutoSize = true;
			this.lbSDT.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.lbSDT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.lbSDT.Location = new System.Drawing.Point(30, 44);
			this.lbSDT.Margin = new System.Windows.Forms.Padding(0);
			this.lbSDT.Name = "lbSDT";
			this.lbSDT.Size = new System.Drawing.Size(101, 19);
			this.lbSDT.TabIndex = 3;
			this.lbSDT.Text = "Số điện thoại:";
			this.lbSDT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbTitle
			// 
			this.lbTitle.AutoSize = true;
			this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.lbTitle.Location = new System.Drawing.Point(0, 0);
			this.lbTitle.Margin = new System.Windows.Forms.Padding(0);
			this.lbTitle.Name = "lbTitle";
			this.lbTitle.Size = new System.Drawing.Size(208, 32);
			this.lbTitle.TabIndex = 0;
			this.lbTitle.Text = "Tạo mới hóa đơn";
			this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pnlPaymentDetails
			// 
			this.pnlPaymentDetails.Controls.Add(this.btnCancle);
			this.pnlPaymentDetails.Controls.Add(this.btnSave);
			this.pnlPaymentDetails.Controls.Add(this.paneBottomLineTitleBar);
			this.pnlPaymentDetails.Controls.Add(this.tbNote);
			this.pnlPaymentDetails.Controls.Add(this.nudDiscountValue);
			this.pnlPaymentDetails.Controls.Add(this.lbTotalPaymentValue);
			this.pnlPaymentDetails.Controls.Add(this.lbTotalPayment);
			this.pnlPaymentDetails.Controls.Add(this.lbTotalPriceValue);
			this.pnlPaymentDetails.Controls.Add(this.lbDiscount);
			this.pnlPaymentDetails.Controls.Add(this.lbTotalPrice);
			this.pnlPaymentDetails.Location = new System.Drawing.Point(51, 600);
			this.pnlPaymentDetails.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.pnlPaymentDetails.Name = "pnlPaymentDetails";
			this.pnlPaymentDetails.Size = new System.Drawing.Size(921, 163);
			this.pnlPaymentDetails.TabIndex = 16;
			// 
			// btnCancle
			// 
			this.btnCancle.Animated = true;
			this.btnCancle.BorderRadius = 5;
			this.btnCancle.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCancle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnCancle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnCancle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnCancle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnCancle.FillColor = System.Drawing.Color.WhiteSmoke;
			this.btnCancle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.btnCancle.ForeColor = System.Drawing.Color.Silver;
			this.btnCancle.Location = new System.Drawing.Point(588, 122);
			this.btnCancle.Margin = new System.Windows.Forms.Padding(0);
			this.btnCancle.Name = "btnCancle";
			this.btnCancle.Size = new System.Drawing.Size(132, 36);
			this.btnCancle.TabIndex = 51;
			this.btnCancle.Text = "Hủy";
			this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
			// 
			// btnSave
			// 
			this.btnSave.Animated = true;
			this.btnSave.BorderRadius = 5;
			this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.btnSave.ForeColor = System.Drawing.Color.White;
			this.btnSave.Location = new System.Drawing.Point(736, 122);
			this.btnSave.Margin = new System.Windows.Forms.Padding(0);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(153, 36);
			this.btnSave.TabIndex = 50;
			this.btnSave.Text = "Lưu hóa đơn";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// paneBottomLineTitleBar
			// 
			this.paneBottomLineTitleBar.Controls.Add(this.BottomLineTitleBar);
			this.paneBottomLineTitleBar.Location = new System.Drawing.Point(89, 97);
			this.paneBottomLineTitleBar.Margin = new System.Windows.Forms.Padding(3, 20, 3, 20);
			this.paneBottomLineTitleBar.Name = "paneBottomLineTitleBar";
			this.paneBottomLineTitleBar.Size = new System.Drawing.Size(720, 5);
			this.paneBottomLineTitleBar.TabIndex = 49;
			// 
			// BottomLineTitleBar
			// 
			this.BottomLineTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.BottomLineTitleBar.Location = new System.Drawing.Point(50, 4);
			this.BottomLineTitleBar.Name = "BottomLineTitleBar";
			this.BottomLineTitleBar.Size = new System.Drawing.Size(620, 1);
			this.BottomLineTitleBar.TabIndex = 0;
			// 
			// tbNote
			// 
			this.tbNote.Animated = true;
			this.tbNote.BorderRadius = 5;
			this.tbNote.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbNote.DefaultText = "";
			this.tbNote.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbNote.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbNote.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbNote.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbNote.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbNote.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.tbNote.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbNote.Location = new System.Drawing.Point(0, 0);
			this.tbNote.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
			this.tbNote.Name = "tbNote";
			this.tbNote.PasswordChar = '\0';
			this.tbNote.PlaceholderText = "Viết mổ tả ghi chú cho hóa đơn ...";
			this.tbNote.SelectedText = "";
			this.tbNote.Size = new System.Drawing.Size(578, 77);
			this.tbNote.TabIndex = 32;
			this.tbNote.TextOffset = new System.Drawing.Point(0, -20);
			// 
			// nudDiscountValue
			// 
			this.nudDiscountValue.BackColor = System.Drawing.Color.Transparent;
			this.nudDiscountValue.BorderColor = System.Drawing.Color.White;
			this.nudDiscountValue.BorderThickness = 0;
			this.nudDiscountValue.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.nudDiscountValue.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.nudDiscountValue.ForeColor = System.Drawing.SystemColors.ControlText;
			this.nudDiscountValue.Location = new System.Drawing.Point(725, 25);
			this.nudDiscountValue.Margin = new System.Windows.Forms.Padding(0);
			this.nudDiscountValue.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
			this.nudDiscountValue.Name = "nudDiscountValue";
			this.nudDiscountValue.Size = new System.Drawing.Size(196, 25);
			this.nudDiscountValue.TabIndex = 31;
			this.nudDiscountValue.TextOffset = new System.Drawing.Point(3, 0);
			this.nudDiscountValue.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.nudDiscountValue.ValueChanged += new System.EventHandler(this.lbDiscountValue_ValueChanged);
			// 
			// lbTotalPaymentValue
			// 
			this.lbTotalPaymentValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTotalPaymentValue.Location = new System.Drawing.Point(722, 52);
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
			this.lbTotalPayment.Location = new System.Drawing.Point(582, 52);
			this.lbTotalPayment.Margin = new System.Windows.Forms.Padding(0);
			this.lbTotalPayment.Name = "lbTotalPayment";
			this.lbTotalPayment.Size = new System.Drawing.Size(140, 25);
			this.lbTotalPayment.TabIndex = 11;
			this.lbTotalPayment.Text = "Tổng tiền thanh toán:";
			this.lbTotalPayment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbTotalPriceValue
			// 
			this.lbTotalPriceValue.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTotalPriceValue.Location = new System.Drawing.Point(722, 0);
			this.lbTotalPriceValue.Margin = new System.Windows.Forms.Padding(0);
			this.lbTotalPriceValue.Name = "lbTotalPriceValue";
			this.lbTotalPriceValue.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
			this.lbTotalPriceValue.Size = new System.Drawing.Size(199, 25);
			this.lbTotalPriceValue.TabIndex = 9;
			this.lbTotalPriceValue.Text = "0";
			this.lbTotalPriceValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lbTotalPriceValue.TextChanged += new System.EventHandler(this.lbTotalPriceValue_TextChanged);
			// 
			// lbDiscount
			// 
			this.lbDiscount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbDiscount.Location = new System.Drawing.Point(585, 24);
			this.lbDiscount.Margin = new System.Windows.Forms.Padding(0);
			this.lbDiscount.Name = "lbDiscount";
			this.lbDiscount.Size = new System.Drawing.Size(137, 25);
			this.lbDiscount.TabIndex = 8;
			this.lbDiscount.Text = "Giảm giá:";
			this.lbDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbTotalPrice
			// 
			this.lbTotalPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTotalPrice.Location = new System.Drawing.Point(588, 0);
			this.lbTotalPrice.Margin = new System.Windows.Forms.Padding(0);
			this.lbTotalPrice.Name = "lbTotalPrice";
			this.lbTotalPrice.Size = new System.Drawing.Size(134, 25);
			this.lbTotalPrice.TabIndex = 7;
			this.lbTotalPrice.Text = "Tổng tiền hàng:";
			this.lbTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Location = new System.Drawing.Point(153, 252);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(720, 5);
			this.panel1.TabIndex = 50;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.panel2.Location = new System.Drawing.Point(50, 4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(620, 1);
			this.panel2.TabIndex = 0;
			// 
			// flpRowDetailBox
			// 
			this.flpRowDetailBox.AutoScroll = true;
			this.flpRowDetailBox.Controls.Add(this.pnlTitleNavBox);
			this.flpRowDetailBox.Location = new System.Drawing.Point(50, 266);
			this.flpRowDetailBox.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.flpRowDetailBox.Name = "flpRowDetailBox";
			this.flpRowDetailBox.Size = new System.Drawing.Size(922, 324);
			this.flpRowDetailBox.TabIndex = 51;
			// 
			// pnlTitleNavBox
			// 
			this.pnlTitleNavBox.AutoSize = true;
			this.pnlTitleNavBox.Controls.Add(this.pnlTitleColumn);
			this.pnlTitleNavBox.Controls.Add(this.pnlNavBtn);
			this.pnlTitleNavBox.Location = new System.Drawing.Point(0, 0);
			this.pnlTitleNavBox.Margin = new System.Windows.Forms.Padding(0);
			this.pnlTitleNavBox.Name = "pnlTitleNavBox";
			this.pnlTitleNavBox.Size = new System.Drawing.Size(902, 91);
			this.pnlTitleNavBox.TabIndex = 54;
			// 
			// pnlTitleColumn
			// 
			this.pnlTitleColumn.BackColor = System.Drawing.Color.White;
			this.pnlTitleColumn.BorderThickness = 3;
			this.pnlTitleColumn.Controls.Add(this.flpTitleColumn);
			this.pnlTitleColumn.CustomBorderColor = System.Drawing.Color.DimGray;
			this.pnlTitleColumn.CustomBorderThickness = new System.Windows.Forms.Padding(1);
			this.pnlTitleColumn.Location = new System.Drawing.Point(0, 40);
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
			// pnlNavBtn
			// 
			this.pnlNavBtn.Controls.Add(this.btnAdditionalProduct);
			this.pnlNavBtn.Location = new System.Drawing.Point(0, 0);
			this.pnlNavBtn.Margin = new System.Windows.Forms.Padding(0);
			this.pnlNavBtn.Name = "pnlNavBtn";
			this.pnlNavBtn.Size = new System.Drawing.Size(902, 40);
			this.pnlNavBtn.TabIndex = 23;
			// 
			// btnAdditionalProduct
			// 
			this.btnAdditionalProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAdditionalProduct.BackColor = System.Drawing.Color.Transparent;
			this.btnAdditionalProduct.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAdditionalProduct.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
			this.btnAdditionalProduct.FlatAppearance.BorderSize = 0;
			this.btnAdditionalProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdditionalProduct.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
			this.btnAdditionalProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(229)))));
			this.btnAdditionalProduct.IconChar = FontAwesome.Sharp.IconChar.Plus;
			this.btnAdditionalProduct.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(134)))), ((int)(((byte)(229)))));
			this.btnAdditionalProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnAdditionalProduct.IconSize = 25;
			this.btnAdditionalProduct.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnAdditionalProduct.Location = new System.Drawing.Point(737, 3);
			this.btnAdditionalProduct.Margin = new System.Windows.Forms.Padding(3, 3, 20, 5);
			this.btnAdditionalProduct.Name = "btnAdditionalProduct";
			this.btnAdditionalProduct.Size = new System.Drawing.Size(153, 35);
			this.btnAdditionalProduct.TabIndex = 63;
			this.btnAdditionalProduct.TabStop = false;
			this.btnAdditionalProduct.Text = "Thêm mặt hàng";
			this.btnAdditionalProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnAdditionalProduct.UseVisualStyleBackColor = false;
			// 
			// errorProviderWar
			// 
			this.errorProviderWar.ContainerControl = this;
			// 
			// BillSetup
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Margin = new System.Windows.Forms.Padding(0);
			this.Name = "BillSetup";
			this.Size = new System.Drawing.Size(1022, 813);
			this.Load += new System.EventHandler(this.BillSetup_Load);
			this.Content.ResumeLayout(false);
			this.pnlHeader.ResumeLayout(false);
			this.pnlHeader.PerformLayout();
			this.pnlPaymentDetails.ResumeLayout(false);
			this.paneBottomLineTitleBar.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nudDiscountValue)).EndInit();
			this.panel1.ResumeLayout(false);
			this.flpRowDetailBox.ResumeLayout(false);
			this.flpRowDetailBox.PerformLayout();
			this.pnlTitleNavBox.ResumeLayout(false);
			this.pnlTitleColumn.ResumeLayout(false);
			this.flpTitleColumn.ResumeLayout(false);
			this.pnlNameColumn.ResumeLayout(false);
			this.pnlPriceColumn.ResumeLayout(false);
			this.pnlAmountColumn.ResumeLayout(false);
			this.pnlTotalColumn.ResumeLayout(false);
			this.pnlNavBtn.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.errorProviderWar)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2Panel pnlHeader;
		private System.Windows.Forms.Label lbCustomer;
		private System.Windows.Forms.Label lbSDT;
		private System.Windows.Forms.Label lbTitle;
		private System.Windows.Forms.Panel pnlPaymentDetails;
		private Guna.UI2.WinForms.Guna2NumericUpDown nudDiscountValue;
		private System.Windows.Forms.Label lbTotalPaymentValue;
		private System.Windows.Forms.Label lbTotalPayment;
		private System.Windows.Forms.Label lbTotalPriceValue;
		private System.Windows.Forms.Label lbDiscount;
		private System.Windows.Forms.Label lbTotalPrice;
		private FontAwesome.Sharp.IconButton btnPrint;
		private FontAwesome.Sharp.IconButton btnDownload;
		private Guna.UI2.WinForms.Guna2TextBox tbNote;
		private Guna.UI2.WinForms.Guna2ComboBox cbPayments;
		private System.Windows.Forms.Label lbPayments;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private Guna.UI2.WinForms.Guna2Button btnCancle;
		private Guna.UI2.WinForms.Guna2Button btnSave;
		private System.Windows.Forms.Panel paneBottomLineTitleBar;
		private System.Windows.Forms.Panel BottomLineTitleBar;
		private System.Windows.Forms.FlowLayoutPanel flpRowDetailBox;
		private System.Windows.Forms.Panel pnlTitleNavBox;
		private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlTitleColumn;
		private System.Windows.Forms.FlowLayoutPanel flpTitleColumn;
		private System.Windows.Forms.Panel pnlNameColumn;
		private System.Windows.Forms.Label lbNameColumn;
		private System.Windows.Forms.Panel pnlPriceColumn;
		private System.Windows.Forms.Label lbPriceColumn;
		private System.Windows.Forms.Panel pnlAmountColumn;
		private System.Windows.Forms.Label lbAmountColumn;
		private System.Windows.Forms.Panel pnlTotalColumn;
		private System.Windows.Forms.Label lbTotalColumn;
		private System.Windows.Forms.Panel pnlNavBtn;
		public FontAwesome.Sharp.IconButton btnAdditionalProduct;
		private System.Windows.Forms.ErrorProvider errorProviderWar;
		private System.Windows.Forms.Label lbStatus;
		private Guna.UI2.WinForms.Guna2CheckBox cbStatus;
		private Guna.UI2.WinForms.Guna2ComboBox cbCustomer;
		public Guna.UI2.WinForms.Guna2TextBox tbSDT;
	}
}
