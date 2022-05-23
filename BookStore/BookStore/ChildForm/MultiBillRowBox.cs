using BookStore.Model.BusinessLogicLayer;
using BookStore.Model.Entities;
using FontAwesome.Sharp;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace BookStore.ChildForm
{
	public partial class MultiBillRowBox : UserControl
	{
		private event EventHandler<InvokeInvoiceDetail> newBillDetail;
		public event EventHandler<InvokeInvoiceDetail> NewBillDetail
		{
			add
			{
				newBillDetail += value;
			}
			remove
			{
				newBillDetail -= value;
			}
		}

		private Guna2CustomGradientPanel pnlBillDetailBox3;
		private FlowLayoutPanel flpBillDetailBox3;
		private Guna2ShadowPanel pnlDateDefine3;
		private Label lbDateString3;
		private Label lbDateNumber3;
		private FlowLayoutPanel flpDetail3;
		private Label lbBillID3;
		private FlowLayoutPanel flpPriceNTime3;
		private Label lbTotalBillPrice3;
		private Label lbDot3;
		private Label lbTimeBill3;
		public FontAwesome.Sharp.IconButton btnFoward3;
		private Guna2CustomGradientPanel pnlBillDetailBox2;
		private FlowLayoutPanel flpBillDetailBox2;
		private Guna2ShadowPanel pnlDateDefine2;
		private Label lbDateString2;
		private Label lbDateNumber2;
		private FlowLayoutPanel flpDetail2;
		private Label lbBillID2;
		private FlowLayoutPanel flpPriceNTime2;
		private Label lbTotalBillPrice2;
		private Label lbDot2;
		private Label lbTimeBill2;
		public FontAwesome.Sharp.IconButton btnFoward2;
		private Guna2CustomGradientPanel pnlBillDetailBox;
		private FlowLayoutPanel flpBillDetailBox;
		private Guna2ShadowPanel pnlDateDefine;
		private Label lbDateString;
		private Label lbDateNumber;
		private FlowLayoutPanel flpDetail;
		private Label lbBillID;
		private FlowLayoutPanel flpPriceNTime;
		private Label lbTotalBillPrice;
		private Label lbDot;
		private Label lbTimeBill;
		public FontAwesome.Sharp.IconButton btnFoward;

		private int column;
		private List<HoaDon> listColumnData;

		public int Column { get => column; set => column = value; }
		public List<HoaDon> ListColumnData
		{
			get => listColumnData;
			set
			{
				listColumnData = value;
				Modifies(value);
			}
		}

		public MultiBillRowBox()
		{
			InitializeComponent();
			Column = this.Controls.Count;
		}

		private void Modifies(List<HoaDon> listColumnData)
		{
			int columnCount = listColumnData.Count;
			pnlBillDetailBox.Enabled = pnlBillDetailBox.Visible =
				pnlBillDetailBox2.Enabled = pnlBillDetailBox2.Visible =
				pnlBillDetailBox3.Enabled = pnlBillDetailBox3.Visible = false;

			for (int i = 0; i < columnCount; i++)
			{
				switch (i)
				{
					case 0:
						pnlBillDetailBox.Enabled = pnlBillDetailBox.Visible = true;
						lbDateNumber.Text = listColumnData[i].NgayGiaoDich.Day.ToString();
						lbDateString.Text = listColumnData[i].NgayGiaoDich.DayOfWeek.ToString().Substring(0, 3);
						lbBillID.Text = listColumnData[i].MaHoaDon.ToString();
						lbTotalBillPrice.Text = $"Thành tiền: {listColumnData[i].TongTien}";
						lbTimeBill.Text = listColumnData[i].NgayGiaoDich.ToShortTimeString();
						pnlBillDetailBox.FillColor = Color.FromArgb(199, 220, 223);
						pnlBillDetailBox.FillColor2 = Color.White;
						pnlBillDetailBox.FillColor3 = Color.White;
						pnlBillDetailBox.FillColor4 = Color.WhiteSmoke;
						btnFoward.Tag = listColumnData[i].MaHoaDon;
						btnFoward.Click += BtnFoward_Click;
						break;
					case 1:
						pnlBillDetailBox2.Enabled = pnlBillDetailBox2.Visible = true;
						lbDateNumber2.Text = listColumnData[i].NgayGiaoDich.Day.ToString();
						lbDateString2.Text = listColumnData[i].NgayGiaoDich.DayOfWeek.ToString().Substring(0, 3);
						lbBillID2.Text = listColumnData[i].MaHoaDon.ToString();
						lbTotalBillPrice2.Text = $"Thành tiền: {listColumnData[i].TongTien}";
						lbTimeBill2.Text = listColumnData[i].NgayGiaoDich.ToShortTimeString();
						pnlBillDetailBox2.FillColor = Color.FromArgb(199, 220, 223);
						pnlBillDetailBox2.FillColor2 = Color.White;
						pnlBillDetailBox2.FillColor3 = Color.White;
						pnlBillDetailBox2.FillColor4 = Color.WhiteSmoke;
						btnFoward2.Tag = listColumnData[i].MaHoaDon;
						btnFoward2.Click += BtnFoward_Click;
						break;
					case 2:
						pnlBillDetailBox3.Enabled = pnlBillDetailBox3.Visible = true;
						lbDateNumber3.Text = listColumnData[i].NgayGiaoDich.Day.ToString();
						lbDateString3.Text = listColumnData[i].NgayGiaoDich.DayOfWeek.ToString().Substring(0, 3);
						lbBillID3.Text = listColumnData[i].MaHoaDon.ToString();
						lbTotalBillPrice3.Text = $"Thành tiền: {listColumnData[i].TongTien}";
						lbTimeBill3.Text = listColumnData[i].NgayGiaoDich.ToShortTimeString();
						pnlBillDetailBox3.FillColor = Color.FromArgb(199, 220, 223);
						pnlBillDetailBox3.FillColor2 = Color.White;
						pnlBillDetailBox3.FillColor3 = Color.White;
						pnlBillDetailBox3.FillColor4 = Color.WhiteSmoke;
						btnFoward3.Tag = listColumnData[i].MaHoaDon;
						btnFoward3.Click += BtnFoward_Click;
						break;
				}
			}
		}

		private void BtnFoward_Click(object sender, EventArgs e)
		{
			if (newBillDetail != null)
			{
				int maHoaDon = int.Parse((sender as IconButton).Tag.ToString());
				InvoiceDetail invoice = BillBLL.Instance.GetInvoiceDetail(maHoaDon);
				newBillDetail(this, new InvokeInvoiceDetail(invoice));
			}
		}

		private void InitializeComponent()
		{
			this.pnlBillDetailBox3 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
			this.flpBillDetailBox3 = new System.Windows.Forms.FlowLayoutPanel();
			this.pnlDateDefine3 = new Guna.UI2.WinForms.Guna2ShadowPanel();
			this.lbDateString3 = new System.Windows.Forms.Label();
			this.lbDateNumber3 = new System.Windows.Forms.Label();
			this.flpDetail3 = new System.Windows.Forms.FlowLayoutPanel();
			this.lbBillID3 = new System.Windows.Forms.Label();
			this.flpPriceNTime3 = new System.Windows.Forms.FlowLayoutPanel();
			this.lbTotalBillPrice3 = new System.Windows.Forms.Label();
			this.lbDot3 = new System.Windows.Forms.Label();
			this.lbTimeBill3 = new System.Windows.Forms.Label();
			this.btnFoward3 = new FontAwesome.Sharp.IconButton();
			this.pnlBillDetailBox2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
			this.flpBillDetailBox2 = new System.Windows.Forms.FlowLayoutPanel();
			this.pnlDateDefine2 = new Guna.UI2.WinForms.Guna2ShadowPanel();
			this.lbDateString2 = new System.Windows.Forms.Label();
			this.lbDateNumber2 = new System.Windows.Forms.Label();
			this.flpDetail2 = new System.Windows.Forms.FlowLayoutPanel();
			this.lbBillID2 = new System.Windows.Forms.Label();
			this.flpPriceNTime2 = new System.Windows.Forms.FlowLayoutPanel();
			this.lbTotalBillPrice2 = new System.Windows.Forms.Label();
			this.lbDot2 = new System.Windows.Forms.Label();
			this.lbTimeBill2 = new System.Windows.Forms.Label();
			this.btnFoward2 = new FontAwesome.Sharp.IconButton();
			this.pnlBillDetailBox = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
			this.flpBillDetailBox = new System.Windows.Forms.FlowLayoutPanel();
			this.pnlDateDefine = new Guna.UI2.WinForms.Guna2ShadowPanel();
			this.lbDateString = new System.Windows.Forms.Label();
			this.lbDateNumber = new System.Windows.Forms.Label();
			this.flpDetail = new System.Windows.Forms.FlowLayoutPanel();
			this.lbBillID = new System.Windows.Forms.Label();
			this.flpPriceNTime = new System.Windows.Forms.FlowLayoutPanel();
			this.lbTotalBillPrice = new System.Windows.Forms.Label();
			this.lbDot = new System.Windows.Forms.Label();
			this.lbTimeBill = new System.Windows.Forms.Label();
			this.btnFoward = new FontAwesome.Sharp.IconButton();
			this.pnlBillDetailBox3.SuspendLayout();
			this.flpBillDetailBox3.SuspendLayout();
			this.pnlDateDefine3.SuspendLayout();
			this.flpDetail3.SuspendLayout();
			this.flpPriceNTime3.SuspendLayout();
			this.pnlBillDetailBox2.SuspendLayout();
			this.flpBillDetailBox2.SuspendLayout();
			this.pnlDateDefine2.SuspendLayout();
			this.flpDetail2.SuspendLayout();
			this.flpPriceNTime2.SuspendLayout();
			this.pnlBillDetailBox.SuspendLayout();
			this.flpBillDetailBox.SuspendLayout();
			this.pnlDateDefine.SuspendLayout();
			this.flpDetail.SuspendLayout();
			this.flpPriceNTime.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlBillDetailBox3
			// 
			this.pnlBillDetailBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
			this.pnlBillDetailBox3.BorderRadius = 5;
			this.pnlBillDetailBox3.Controls.Add(this.flpBillDetailBox3);
			this.pnlBillDetailBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(220)))), ((int)(((byte)(223)))));
			this.pnlBillDetailBox3.FillColor4 = System.Drawing.Color.WhiteSmoke;
			this.pnlBillDetailBox3.Location = new System.Drawing.Point(811, 0);
			this.pnlBillDetailBox3.Margin = new System.Windows.Forms.Padding(0);
			this.pnlBillDetailBox3.Name = "pnlBillDetailBox3";
			this.pnlBillDetailBox3.Padding = new System.Windows.Forms.Padding(5);
			this.pnlBillDetailBox3.Size = new System.Drawing.Size(375, 80);
			this.pnlBillDetailBox3.TabIndex = 20;
			// 
			// flpBillDetailBox3
			// 
			this.flpBillDetailBox3.BackColor = System.Drawing.Color.Transparent;
			this.flpBillDetailBox3.Controls.Add(this.pnlDateDefine3);
			this.flpBillDetailBox3.Controls.Add(this.flpDetail3);
			this.flpBillDetailBox3.Location = new System.Drawing.Point(8, 6);
			this.flpBillDetailBox3.Name = "flpBillDetailBox3";
			this.flpBillDetailBox3.Size = new System.Drawing.Size(367, 69);
			this.flpBillDetailBox3.TabIndex = 7;
			// 
			// pnlDateDefine3
			// 
			this.pnlDateDefine3.BackColor = System.Drawing.Color.Transparent;
			this.pnlDateDefine3.Controls.Add(this.lbDateString3);
			this.pnlDateDefine3.Controls.Add(this.lbDateNumber3);
			this.pnlDateDefine3.FillColor = System.Drawing.Color.White;
			this.pnlDateDefine3.Location = new System.Drawing.Point(0, 0);
			this.pnlDateDefine3.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
			this.pnlDateDefine3.Name = "pnlDateDefine3";
			this.pnlDateDefine3.Radius = 10;
			this.pnlDateDefine3.ShadowColor = System.Drawing.Color.Black;
			this.pnlDateDefine3.ShadowDepth = 50;
			this.pnlDateDefine3.ShadowShift = 2;
			this.pnlDateDefine3.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
			this.pnlDateDefine3.Size = new System.Drawing.Size(64, 69);
			this.pnlDateDefine3.TabIndex = 7;
			// 
			// lbDateString3
			// 
			this.lbDateString3.BackColor = System.Drawing.Color.Transparent;
			this.lbDateString3.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
			this.lbDateString3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(85)))));
			this.lbDateString3.Location = new System.Drawing.Point(3, 37);
			this.lbDateString3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
			this.lbDateString3.Name = "lbDateString3";
			this.lbDateString3.Size = new System.Drawing.Size(58, 20);
			this.lbDateString3.TabIndex = 12;
			this.lbDateString3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// lbDateNumber3
			// 
			this.lbDateNumber3.BackColor = System.Drawing.Color.Transparent;
			this.lbDateNumber3.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold);
			this.lbDateNumber3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(85)))));
			this.lbDateNumber3.Location = new System.Drawing.Point(3, 4);
			this.lbDateNumber3.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
			this.lbDateNumber3.Name = "lbDateNumber3";
			this.lbDateNumber3.Size = new System.Drawing.Size(58, 36);
			this.lbDateNumber3.TabIndex = 11;
			this.lbDateNumber3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// flpDetail3
			// 
			this.flpDetail3.AutoScroll = true;
			this.flpDetail3.Controls.Add(this.lbBillID3);
			this.flpDetail3.Controls.Add(this.flpPriceNTime3);
			this.flpDetail3.Controls.Add(this.btnFoward3);
			this.flpDetail3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flpDetail3.Location = new System.Drawing.Point(74, 0);
			this.flpDetail3.Margin = new System.Windows.Forms.Padding(0);
			this.flpDetail3.Name = "flpDetail3";
			this.flpDetail3.Size = new System.Drawing.Size(293, 69);
			this.flpDetail3.TabIndex = 7;
			// 
			// lbBillID3
			// 
			this.lbBillID3.AutoSize = true;
			this.lbBillID3.Dock = System.Windows.Forms.DockStyle.Left;
			this.lbBillID3.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
			this.lbBillID3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(85)))));
			this.lbBillID3.Location = new System.Drawing.Point(3, 10);
			this.lbBillID3.Margin = new System.Windows.Forms.Padding(3, 10, 3, 5);
			this.lbBillID3.Name = "lbBillID3";
			this.lbBillID3.Size = new System.Drawing.Size(0, 19);
			this.lbBillID3.TabIndex = 9;
			// 
			// flpPriceNTime3
			// 
			this.flpPriceNTime3.AutoScroll = true;
			this.flpPriceNTime3.Controls.Add(this.lbTotalBillPrice3);
			this.flpPriceNTime3.Controls.Add(this.lbDot3);
			this.flpPriceNTime3.Controls.Add(this.lbTimeBill3);
			this.flpPriceNTime3.Dock = System.Windows.Forms.DockStyle.Left;
			this.flpPriceNTime3.Location = new System.Drawing.Point(3, 39);
			this.flpPriceNTime3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
			this.flpPriceNTime3.Name = "flpPriceNTime3";
			this.flpPriceNTime3.Size = new System.Drawing.Size(261, 20);
			this.flpPriceNTime3.TabIndex = 8;
			// 
			// lbTotalBillPrice3
			// 
			this.lbTotalBillPrice3.AutoSize = true;
			this.lbTotalBillPrice3.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
			this.lbTotalBillPrice3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(69)))));
			this.lbTotalBillPrice3.Location = new System.Drawing.Point(3, 0);
			this.lbTotalBillPrice3.Name = "lbTotalBillPrice3";
			this.lbTotalBillPrice3.Size = new System.Drawing.Size(85, 20);
			this.lbTotalBillPrice3.TabIndex = 10;
			this.lbTotalBillPrice3.Text = "Thành tiền:";
			// 
			// lbDot3
			// 
			this.lbDot3.AutoSize = true;
			this.lbDot3.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
			this.lbDot3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(85)))));
			this.lbDot3.Location = new System.Drawing.Point(94, 0);
			this.lbDot3.Name = "lbDot3";
			this.lbDot3.Size = new System.Drawing.Size(15, 19);
			this.lbDot3.TabIndex = 11;
			this.lbDot3.Text = "•";
			// 
			// lbTimeBill3
			// 
			this.lbTimeBill3.AutoSize = true;
			this.lbTimeBill3.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
			this.lbTimeBill3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(85)))));
			this.lbTimeBill3.Location = new System.Drawing.Point(115, 0);
			this.lbTimeBill3.Name = "lbTimeBill3";
			this.lbTimeBill3.Size = new System.Drawing.Size(0, 20);
			this.lbTimeBill3.TabIndex = 12;
			// 
			// btnFoward3
			// 
			this.btnFoward3.BackColor = System.Drawing.Color.Transparent;
			this.btnFoward3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnFoward3.Dock = System.Windows.Forms.DockStyle.Left;
			this.btnFoward3.FlatAppearance.BorderSize = 0;
			this.btnFoward3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFoward3.Font = new System.Drawing.Font("Microsoft YaHei", 20F, System.Drawing.FontStyle.Bold);
			this.btnFoward3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(85)))));
			this.btnFoward3.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
			this.btnFoward3.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(85)))));
			this.btnFoward3.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnFoward3.IconSize = 25;
			this.btnFoward3.Location = new System.Drawing.Point(267, 0);
			this.btnFoward3.Margin = new System.Windows.Forms.Padding(0);
			this.btnFoward3.Name = "btnFoward3";
			this.btnFoward3.Size = new System.Drawing.Size(26, 69);
			this.btnFoward3.TabIndex = 14;
			this.btnFoward3.TabStop = false;
			this.btnFoward3.UseVisualStyleBackColor = false;
			// 
			// pnlBillDetailBox2
			// 
			this.pnlBillDetailBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
			this.pnlBillDetailBox2.BorderRadius = 5;
			this.pnlBillDetailBox2.Controls.Add(this.flpBillDetailBox2);
			this.pnlBillDetailBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(220)))), ((int)(((byte)(223)))));
			this.pnlBillDetailBox2.FillColor4 = System.Drawing.Color.WhiteSmoke;
			this.pnlBillDetailBox2.Location = new System.Drawing.Point(406, 0);
			this.pnlBillDetailBox2.Margin = new System.Windows.Forms.Padding(0, 0, 30, 0);
			this.pnlBillDetailBox2.Name = "pnlBillDetailBox2";
			this.pnlBillDetailBox2.Padding = new System.Windows.Forms.Padding(5);
			this.pnlBillDetailBox2.Size = new System.Drawing.Size(375, 80);
			this.pnlBillDetailBox2.TabIndex = 19;
			// 
			// flpBillDetailBox2
			// 
			this.flpBillDetailBox2.BackColor = System.Drawing.Color.Transparent;
			this.flpBillDetailBox2.Controls.Add(this.pnlDateDefine2);
			this.flpBillDetailBox2.Controls.Add(this.flpDetail2);
			this.flpBillDetailBox2.Location = new System.Drawing.Point(8, 6);
			this.flpBillDetailBox2.Name = "flpBillDetailBox2";
			this.flpBillDetailBox2.Size = new System.Drawing.Size(367, 69);
			this.flpBillDetailBox2.TabIndex = 7;
			// 
			// pnlDateDefine2
			// 
			this.pnlDateDefine2.BackColor = System.Drawing.Color.Transparent;
			this.pnlDateDefine2.Controls.Add(this.lbDateString2);
			this.pnlDateDefine2.Controls.Add(this.lbDateNumber2);
			this.pnlDateDefine2.FillColor = System.Drawing.Color.White;
			this.pnlDateDefine2.Location = new System.Drawing.Point(0, 0);
			this.pnlDateDefine2.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
			this.pnlDateDefine2.Name = "pnlDateDefine2";
			this.pnlDateDefine2.Radius = 10;
			this.pnlDateDefine2.ShadowColor = System.Drawing.Color.Black;
			this.pnlDateDefine2.ShadowDepth = 50;
			this.pnlDateDefine2.ShadowShift = 2;
			this.pnlDateDefine2.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
			this.pnlDateDefine2.Size = new System.Drawing.Size(64, 69);
			this.pnlDateDefine2.TabIndex = 7;
			// 
			// lbDateString2
			// 
			this.lbDateString2.BackColor = System.Drawing.Color.Transparent;
			this.lbDateString2.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
			this.lbDateString2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(85)))));
			this.lbDateString2.Location = new System.Drawing.Point(3, 37);
			this.lbDateString2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
			this.lbDateString2.Name = "lbDateString2";
			this.lbDateString2.Size = new System.Drawing.Size(58, 20);
			this.lbDateString2.TabIndex = 12;
			this.lbDateString2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// lbDateNumber2
			// 
			this.lbDateNumber2.BackColor = System.Drawing.Color.Transparent;
			this.lbDateNumber2.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold);
			this.lbDateNumber2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(85)))));
			this.lbDateNumber2.Location = new System.Drawing.Point(3, 4);
			this.lbDateNumber2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
			this.lbDateNumber2.Name = "lbDateNumber2";
			this.lbDateNumber2.Size = new System.Drawing.Size(58, 36);
			this.lbDateNumber2.TabIndex = 11;
			this.lbDateNumber2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// flpDetail2
			// 
			this.flpDetail2.AutoScroll = true;
			this.flpDetail2.Controls.Add(this.lbBillID2);
			this.flpDetail2.Controls.Add(this.flpPriceNTime2);
			this.flpDetail2.Controls.Add(this.btnFoward2);
			this.flpDetail2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flpDetail2.Location = new System.Drawing.Point(74, 0);
			this.flpDetail2.Margin = new System.Windows.Forms.Padding(0);
			this.flpDetail2.Name = "flpDetail2";
			this.flpDetail2.Size = new System.Drawing.Size(293, 69);
			this.flpDetail2.TabIndex = 7;
			// 
			// lbBillID2
			// 
			this.lbBillID2.AutoSize = true;
			this.lbBillID2.Dock = System.Windows.Forms.DockStyle.Left;
			this.lbBillID2.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
			this.lbBillID2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(85)))));
			this.lbBillID2.Location = new System.Drawing.Point(3, 10);
			this.lbBillID2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 5);
			this.lbBillID2.Name = "lbBillID2";
			this.lbBillID2.Size = new System.Drawing.Size(0, 19);
			this.lbBillID2.TabIndex = 9;
			// 
			// flpPriceNTime2
			// 
			this.flpPriceNTime2.AutoScroll = true;
			this.flpPriceNTime2.Controls.Add(this.lbTotalBillPrice2);
			this.flpPriceNTime2.Controls.Add(this.lbDot2);
			this.flpPriceNTime2.Controls.Add(this.lbTimeBill2);
			this.flpPriceNTime2.Dock = System.Windows.Forms.DockStyle.Left;
			this.flpPriceNTime2.Location = new System.Drawing.Point(3, 39);
			this.flpPriceNTime2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
			this.flpPriceNTime2.Name = "flpPriceNTime2";
			this.flpPriceNTime2.Size = new System.Drawing.Size(261, 20);
			this.flpPriceNTime2.TabIndex = 8;
			// 
			// lbTotalBillPrice2
			// 
			this.lbTotalBillPrice2.AutoSize = true;
			this.lbTotalBillPrice2.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
			this.lbTotalBillPrice2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(69)))));
			this.lbTotalBillPrice2.Location = new System.Drawing.Point(3, 0);
			this.lbTotalBillPrice2.Name = "lbTotalBillPrice2";
			this.lbTotalBillPrice2.Size = new System.Drawing.Size(85, 20);
			this.lbTotalBillPrice2.TabIndex = 10;
			this.lbTotalBillPrice2.Text = "Thành tiền:";
			// 
			// lbDot2
			// 
			this.lbDot2.AutoSize = true;
			this.lbDot2.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
			this.lbDot2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(85)))));
			this.lbDot2.Location = new System.Drawing.Point(94, 0);
			this.lbDot2.Name = "lbDot2";
			this.lbDot2.Size = new System.Drawing.Size(15, 19);
			this.lbDot2.TabIndex = 11;
			this.lbDot2.Text = "•";
			// 
			// lbTimeBill2
			// 
			this.lbTimeBill2.AutoSize = true;
			this.lbTimeBill2.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
			this.lbTimeBill2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(85)))));
			this.lbTimeBill2.Location = new System.Drawing.Point(115, 0);
			this.lbTimeBill2.Name = "lbTimeBill2";
			this.lbTimeBill2.Size = new System.Drawing.Size(0, 20);
			this.lbTimeBill2.TabIndex = 12;
			// 
			// btnFoward2
			// 
			this.btnFoward2.BackColor = System.Drawing.Color.Transparent;
			this.btnFoward2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnFoward2.Dock = System.Windows.Forms.DockStyle.Left;
			this.btnFoward2.FlatAppearance.BorderSize = 0;
			this.btnFoward2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFoward2.Font = new System.Drawing.Font("Microsoft YaHei", 20F, System.Drawing.FontStyle.Bold);
			this.btnFoward2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(85)))));
			this.btnFoward2.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
			this.btnFoward2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(85)))));
			this.btnFoward2.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnFoward2.IconSize = 25;
			this.btnFoward2.Location = new System.Drawing.Point(267, 0);
			this.btnFoward2.Margin = new System.Windows.Forms.Padding(0);
			this.btnFoward2.Name = "btnFoward2";
			this.btnFoward2.Size = new System.Drawing.Size(26, 69);
			this.btnFoward2.TabIndex = 14;
			this.btnFoward2.TabStop = false;
			this.btnFoward2.UseVisualStyleBackColor = false;
			// 
			// pnlBillDetailBox
			// 
			this.pnlBillDetailBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
			this.pnlBillDetailBox.BorderRadius = 5;
			this.pnlBillDetailBox.Controls.Add(this.flpBillDetailBox);
			this.pnlBillDetailBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(220)))), ((int)(((byte)(223)))));
			this.pnlBillDetailBox.FillColor4 = System.Drawing.Color.WhiteSmoke;
			this.pnlBillDetailBox.Location = new System.Drawing.Point(1, 0);
			this.pnlBillDetailBox.Margin = new System.Windows.Forms.Padding(0, 0, 30, 0);
			this.pnlBillDetailBox.Name = "pnlBillDetailBox";
			this.pnlBillDetailBox.Padding = new System.Windows.Forms.Padding(5);
			this.pnlBillDetailBox.Size = new System.Drawing.Size(375, 80);
			this.pnlBillDetailBox.TabIndex = 18;
			// 
			// flpBillDetailBox
			// 
			this.flpBillDetailBox.BackColor = System.Drawing.Color.Transparent;
			this.flpBillDetailBox.Controls.Add(this.pnlDateDefine);
			this.flpBillDetailBox.Controls.Add(this.flpDetail);
			this.flpBillDetailBox.Location = new System.Drawing.Point(8, 6);
			this.flpBillDetailBox.Name = "flpBillDetailBox";
			this.flpBillDetailBox.Size = new System.Drawing.Size(367, 69);
			this.flpBillDetailBox.TabIndex = 7;
			// 
			// pnlDateDefine
			// 
			this.pnlDateDefine.BackColor = System.Drawing.Color.Transparent;
			this.pnlDateDefine.Controls.Add(this.lbDateString);
			this.pnlDateDefine.Controls.Add(this.lbDateNumber);
			this.pnlDateDefine.FillColor = System.Drawing.Color.White;
			this.pnlDateDefine.Location = new System.Drawing.Point(0, 0);
			this.pnlDateDefine.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
			this.pnlDateDefine.Name = "pnlDateDefine";
			this.pnlDateDefine.Radius = 10;
			this.pnlDateDefine.ShadowColor = System.Drawing.Color.Black;
			this.pnlDateDefine.ShadowDepth = 50;
			this.pnlDateDefine.ShadowShift = 2;
			this.pnlDateDefine.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
			this.pnlDateDefine.Size = new System.Drawing.Size(64, 69);
			this.pnlDateDefine.TabIndex = 7;
			// 
			// lbDateString
			// 
			this.lbDateString.BackColor = System.Drawing.Color.Transparent;
			this.lbDateString.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
			this.lbDateString.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(85)))));
			this.lbDateString.Location = new System.Drawing.Point(3, 37);
			this.lbDateString.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
			this.lbDateString.Name = "lbDateString";
			this.lbDateString.Size = new System.Drawing.Size(58, 20);
			this.lbDateString.TabIndex = 12;
			this.lbDateString.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// lbDateNumber
			// 
			this.lbDateNumber.BackColor = System.Drawing.Color.Transparent;
			this.lbDateNumber.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold);
			this.lbDateNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(85)))));
			this.lbDateNumber.Location = new System.Drawing.Point(3, 4);
			this.lbDateNumber.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
			this.lbDateNumber.Name = "lbDateNumber";
			this.lbDateNumber.Size = new System.Drawing.Size(58, 36);
			this.lbDateNumber.TabIndex = 11;
			this.lbDateNumber.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// flpDetail
			// 
			this.flpDetail.AutoScroll = true;
			this.flpDetail.Controls.Add(this.lbBillID);
			this.flpDetail.Controls.Add(this.flpPriceNTime);
			this.flpDetail.Controls.Add(this.btnFoward);
			this.flpDetail.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flpDetail.Location = new System.Drawing.Point(74, 0);
			this.flpDetail.Margin = new System.Windows.Forms.Padding(0);
			this.flpDetail.Name = "flpDetail";
			this.flpDetail.Size = new System.Drawing.Size(293, 69);
			this.flpDetail.TabIndex = 7;
			// 
			// lbBillID
			// 
			this.lbBillID.AutoSize = true;
			this.lbBillID.Dock = System.Windows.Forms.DockStyle.Left;
			this.lbBillID.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
			this.lbBillID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(85)))));
			this.lbBillID.Location = new System.Drawing.Point(3, 10);
			this.lbBillID.Margin = new System.Windows.Forms.Padding(3, 10, 3, 5);
			this.lbBillID.Name = "lbBillID";
			this.lbBillID.Size = new System.Drawing.Size(0, 19);
			this.lbBillID.TabIndex = 9;
			// 
			// flpPriceNTime
			// 
			this.flpPriceNTime.AutoScroll = true;
			this.flpPriceNTime.Controls.Add(this.lbTotalBillPrice);
			this.flpPriceNTime.Controls.Add(this.lbDot);
			this.flpPriceNTime.Controls.Add(this.lbTimeBill);
			this.flpPriceNTime.Dock = System.Windows.Forms.DockStyle.Left;
			this.flpPriceNTime.Location = new System.Drawing.Point(3, 39);
			this.flpPriceNTime.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
			this.flpPriceNTime.Name = "flpPriceNTime";
			this.flpPriceNTime.Size = new System.Drawing.Size(261, 20);
			this.flpPriceNTime.TabIndex = 8;
			// 
			// lbTotalBillPrice
			// 
			this.lbTotalBillPrice.AutoSize = true;
			this.lbTotalBillPrice.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
			this.lbTotalBillPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(69)))));
			this.lbTotalBillPrice.Location = new System.Drawing.Point(3, 0);
			this.lbTotalBillPrice.Name = "lbTotalBillPrice";
			this.lbTotalBillPrice.Size = new System.Drawing.Size(85, 20);
			this.lbTotalBillPrice.TabIndex = 10;
			this.lbTotalBillPrice.Text = "Thành tiền:";
			// 
			// lbDot
			// 
			this.lbDot.AutoSize = true;
			this.lbDot.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
			this.lbDot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(85)))));
			this.lbDot.Location = new System.Drawing.Point(94, 0);
			this.lbDot.Name = "lbDot";
			this.lbDot.Size = new System.Drawing.Size(15, 19);
			this.lbDot.TabIndex = 11;
			this.lbDot.Text = "•";
			// 
			// lbTimeBill
			// 
			this.lbTimeBill.AutoSize = true;
			this.lbTimeBill.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
			this.lbTimeBill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(85)))));
			this.lbTimeBill.Location = new System.Drawing.Point(115, 0);
			this.lbTimeBill.Name = "lbTimeBill";
			this.lbTimeBill.Size = new System.Drawing.Size(0, 20);
			this.lbTimeBill.TabIndex = 12;
			// 
			// btnFoward
			// 
			this.btnFoward.BackColor = System.Drawing.Color.Transparent;
			this.btnFoward.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnFoward.Dock = System.Windows.Forms.DockStyle.Left;
			this.btnFoward.FlatAppearance.BorderSize = 0;
			this.btnFoward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFoward.Font = new System.Drawing.Font("Microsoft YaHei", 20F, System.Drawing.FontStyle.Bold);
			this.btnFoward.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(85)))));
			this.btnFoward.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
			this.btnFoward.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(85)))));
			this.btnFoward.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnFoward.IconSize = 25;
			this.btnFoward.Location = new System.Drawing.Point(267, 0);
			this.btnFoward.Margin = new System.Windows.Forms.Padding(0);
			this.btnFoward.Name = "btnFoward";
			this.btnFoward.Size = new System.Drawing.Size(26, 69);
			this.btnFoward.TabIndex = 14;
			this.btnFoward.TabStop = false;
			this.btnFoward.UseVisualStyleBackColor = false;
			// 
			// MultiBillRowBox
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.pnlBillDetailBox3);
			this.Controls.Add(this.pnlBillDetailBox2);
			this.Controls.Add(this.pnlBillDetailBox);
			this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.Name = "MultiBillRowBox";
			this.Size = new System.Drawing.Size(1186, 80);
			this.pnlBillDetailBox3.ResumeLayout(false);
			this.flpBillDetailBox3.ResumeLayout(false);
			this.pnlDateDefine3.ResumeLayout(false);
			this.flpDetail3.ResumeLayout(false);
			this.flpDetail3.PerformLayout();
			this.flpPriceNTime3.ResumeLayout(false);
			this.flpPriceNTime3.PerformLayout();
			this.pnlBillDetailBox2.ResumeLayout(false);
			this.flpBillDetailBox2.ResumeLayout(false);
			this.pnlDateDefine2.ResumeLayout(false);
			this.flpDetail2.ResumeLayout(false);
			this.flpDetail2.PerformLayout();
			this.flpPriceNTime2.ResumeLayout(false);
			this.flpPriceNTime2.PerformLayout();
			this.pnlBillDetailBox.ResumeLayout(false);
			this.flpBillDetailBox.ResumeLayout(false);
			this.pnlDateDefine.ResumeLayout(false);
			this.flpDetail.ResumeLayout(false);
			this.flpDetail.PerformLayout();
			this.flpPriceNTime.ResumeLayout(false);
			this.flpPriceNTime.PerformLayout();
			this.ResumeLayout(false);

		}
	}
}