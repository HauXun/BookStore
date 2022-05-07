using System;
using System.Drawing;
using System.Windows.Forms;

namespace BookStore.ChildForm
{
	public partial class BillDetailBox : UserControl
	{
		public BillDetailBox(string lbDateNumber, string lbDateString, string lbBillID, string lbTotalBillPrice, string lbTimeBill,
			Color fillColor1, Color fillColor2, Color fillColor3, Color fillColor4)
		{
			InitializeComponent();
			this.lbDateNumber.Text = lbDateNumber;
			this.lbDateString.Text = lbDateString;
			this.lbBillID.Text = lbBillID;
			this.lbTotalBillPrice.Text = lbTotalBillPrice;
			this.lbTimeBill.Text = lbTimeBill;
			this.pnlBillDetailBox.FillColor = fillColor1;
			this.pnlBillDetailBox.FillColor2 = fillColor2;
			this.pnlBillDetailBox.FillColor3 = fillColor3;
			this.pnlBillDetailBox.FillColor4 = fillColor4;
		}

		private void InitializeComponent()
		{
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
			this.pnlBillDetailBox.SuspendLayout();
			this.flpBillDetailBox.SuspendLayout();
			this.pnlDateDefine.SuspendLayout();
			this.flpDetail.SuspendLayout();
			this.flpPriceNTime.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlBillDetailBox
			// 
			this.pnlBillDetailBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
			this.pnlBillDetailBox.BorderRadius = 5;
			this.pnlBillDetailBox.Controls.Add(this.flpBillDetailBox);
			this.pnlBillDetailBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(220)))), ((int)(((byte)(223)))));
			this.pnlBillDetailBox.FillColor4 = System.Drawing.Color.WhiteSmoke;
			this.pnlBillDetailBox.Location = new System.Drawing.Point(0, 0);
			this.pnlBillDetailBox.Margin = new System.Windows.Forms.Padding(0);
			this.pnlBillDetailBox.Name = "pnlBillDetailBox";
			this.pnlBillDetailBox.Padding = new System.Windows.Forms.Padding(5);
			this.pnlBillDetailBox.Size = new System.Drawing.Size(375, 80);
			this.pnlBillDetailBox.TabIndex = 14;
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
			this.lbDateString.Text = "Mon";
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
			this.lbDateNumber.Text = "25";
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
			this.lbBillID.Size = new System.Drawing.Size(135, 19);
			this.lbBillID.TabIndex = 9;
			this.lbBillID.Text = "84282649272154";
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
			this.lbTotalBillPrice.Size = new System.Drawing.Size(77, 20);
			this.lbTotalBillPrice.TabIndex = 10;
			this.lbTotalBillPrice.Text = "Cost: 156$";
			// 
			// lbDot
			// 
			this.lbDot.AutoSize = true;
			this.lbDot.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
			this.lbDot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(85)))));
			this.lbDot.Location = new System.Drawing.Point(86, 0);
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
			this.lbTimeBill.Location = new System.Drawing.Point(107, 0);
			this.lbTimeBill.Name = "lbTimeBill";
			this.lbTimeBill.Size = new System.Drawing.Size(70, 20);
			this.lbTimeBill.TabIndex = 12;
			this.lbTimeBill.Text = "13:47 pm";
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
			// BillDetailBox
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.pnlBillDetailBox);
			this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.Name = "BillDetailBox";
			this.Size = new System.Drawing.Size(375, 80);
			this.pnlBillDetailBox.ResumeLayout(false);
			this.flpBillDetailBox.ResumeLayout(false);
			this.pnlDateDefine.ResumeLayout(false);
			this.flpDetail.ResumeLayout(false);
			this.flpDetail.PerformLayout();
			this.flpPriceNTime.ResumeLayout(false);
			this.flpPriceNTime.PerformLayout();
			this.ResumeLayout(false);

		}

		private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlBillDetailBox;
		private System.Windows.Forms.FlowLayoutPanel flpBillDetailBox;
		private Guna.UI2.WinForms.Guna2ShadowPanel pnlDateDefine;
		private System.Windows.Forms.Label lbDateString;
		private System.Windows.Forms.Label lbDateNumber;
		private System.Windows.Forms.FlowLayoutPanel flpDetail;
		private System.Windows.Forms.Label lbBillID;
		private System.Windows.Forms.FlowLayoutPanel flpPriceNTime;
		private System.Windows.Forms.Label lbTotalBillPrice;
		private System.Windows.Forms.Label lbDot;
		private System.Windows.Forms.Label lbTimeBill;
		public FontAwesome.Sharp.IconButton btnFoward;
	}
}