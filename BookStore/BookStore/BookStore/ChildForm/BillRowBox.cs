using Guna.UI2.WinForms;
using System;
using System.Data;
using System.Windows.Forms;

namespace BookStore.ChildForm
{
	public partial class BillRowBox : UserControl
	{
		private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlBillRowBox;
		private FlowLayoutPanel flpBillRowBox;
		private Panel pnlBox1;
		private Label lbProductName;
		private Panel pnlBox2;
		private Guna.UI2.WinForms.Guna2NumericUpDown nudPrice;
		private Panel pnlBox3;
		private Guna.UI2.WinForms.Guna2NumericUpDown nudProductAmount;
		private Panel pnlBox4;
		private Guna2ContextMenuStrip cms;
		public ToolStripMenuItem tsmiXoa;
		private Label lbTotalPrice;
		private decimal preAmountValue = 1;

		public Label LbProductName { get => lbProductName; set => lbProductName = value; }
		public Guna2NumericUpDown NudPrice { get => nudPrice; set => nudPrice = value; }
		public Guna2NumericUpDown NudProductAmount { get => nudProductAmount; set => nudProductAmount = value; }
		public Label LbTotalPrice { get => lbTotalPrice; set => lbTotalPrice = value; }
		public decimal PreAmountValue { get => preAmountValue; set => preAmountValue = value; }

		public BillRowBox()
		{
			InitializeComponent();
		}

		public BillRowBox(DataRow row) : this()
		{
			LbProductName.Text = row["TenSP"].ToString();
			NudPrice.Value = decimal.Parse(row["Gia"].ToString());
			NudProductAmount.Value = decimal.Parse(row["SoLuong"].ToString());
		}

		public BillRowBox(string productName, decimal nudPrice, byte nudProductAmount) : this()
		{
			this.LbProductName.Text = productName;
			this.NudPrice.Value = nudPrice;
			this.NudProductAmount.Value = nudProductAmount;
			this.LbTotalPrice.Text = (NudPrice.Value * NudProductAmount.Value).ToString();
		}

		private void InitializeComponent()
		{
			this.pnlBillRowBox = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
			this.flpBillRowBox = new System.Windows.Forms.FlowLayoutPanel();
			this.pnlBox1 = new System.Windows.Forms.Panel();
			this.lbProductName = new System.Windows.Forms.Label();
			this.pnlBox2 = new System.Windows.Forms.Panel();
			this.nudPrice = new Guna.UI2.WinForms.Guna2NumericUpDown();
			this.pnlBox3 = new System.Windows.Forms.Panel();
			this.nudProductAmount = new Guna.UI2.WinForms.Guna2NumericUpDown();
			this.pnlBox4 = new System.Windows.Forms.Panel();
			this.lbTotalPrice = new System.Windows.Forms.Label();
			this.cms = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
			this.tsmiXoa = new System.Windows.Forms.ToolStripMenuItem();
			this.pnlBillRowBox.SuspendLayout();
			this.flpBillRowBox.SuspendLayout();
			this.pnlBox1.SuspendLayout();
			this.pnlBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
			this.pnlBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudProductAmount)).BeginInit();
			this.pnlBox4.SuspendLayout();
			this.cms.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlBillRowBox
			// 
			this.pnlBillRowBox.BackColor = System.Drawing.Color.White;
			this.pnlBillRowBox.BorderThickness = 3;
			this.pnlBillRowBox.Controls.Add(this.flpBillRowBox);
			this.pnlBillRowBox.CustomBorderColor = System.Drawing.Color.DimGray;
			this.pnlBillRowBox.CustomBorderThickness = new System.Windows.Forms.Padding(1);
			this.pnlBillRowBox.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlBillRowBox.Location = new System.Drawing.Point(0, 0);
			this.pnlBillRowBox.Margin = new System.Windows.Forms.Padding(0);
			this.pnlBillRowBox.Name = "pnlBillRowBox";
			this.pnlBillRowBox.Padding = new System.Windows.Forms.Padding(5);
			this.pnlBillRowBox.Size = new System.Drawing.Size(902, 51);
			this.pnlBillRowBox.TabIndex = 26;
			// 
			// flpBillRowBox
			// 
			this.flpBillRowBox.AutoScroll = true;
			this.flpBillRowBox.Controls.Add(this.pnlBox1);
			this.flpBillRowBox.Controls.Add(this.pnlBox2);
			this.flpBillRowBox.Controls.Add(this.pnlBox3);
			this.flpBillRowBox.Controls.Add(this.pnlBox4);
			this.flpBillRowBox.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flpBillRowBox.Location = new System.Drawing.Point(1, 1);
			this.flpBillRowBox.Margin = new System.Windows.Forms.Padding(1);
			this.flpBillRowBox.Name = "flpBillRowBox";
			this.flpBillRowBox.Size = new System.Drawing.Size(900, 49);
			this.flpBillRowBox.TabIndex = 7;
			// 
			// pnlBox1
			// 
			this.pnlBox1.BackColor = System.Drawing.Color.Transparent;
			this.pnlBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnlBox1.Controls.Add(this.lbProductName);
			this.pnlBox1.Location = new System.Drawing.Point(0, 0);
			this.pnlBox1.Margin = new System.Windows.Forms.Padding(0);
			this.pnlBox1.Name = "pnlBox1";
			this.pnlBox1.Size = new System.Drawing.Size(490, 49);
			this.pnlBox1.TabIndex = 0;
			// 
			// lbProductName
			// 
			this.lbProductName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.lbProductName.BackColor = System.Drawing.Color.Transparent;
			this.lbProductName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.lbProductName.ForeColor = System.Drawing.Color.DimGray;
			this.lbProductName.Location = new System.Drawing.Point(0, 12);
			this.lbProductName.Margin = new System.Windows.Forms.Padding(0, 20, 20, 20);
			this.lbProductName.Name = "lbProductName";
			this.lbProductName.Size = new System.Drawing.Size(483, 21);
			this.lbProductName.TabIndex = 1;
			this.lbProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pnlBox2
			// 
			this.pnlBox2.BackColor = System.Drawing.Color.Transparent;
			this.pnlBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnlBox2.Controls.Add(this.nudPrice);
			this.pnlBox2.Location = new System.Drawing.Point(490, 0);
			this.pnlBox2.Margin = new System.Windows.Forms.Padding(0);
			this.pnlBox2.Name = "pnlBox2";
			this.pnlBox2.Size = new System.Drawing.Size(180, 49);
			this.pnlBox2.TabIndex = 1;
			// 
			// nudPrice
			// 
			this.nudPrice.BackColor = System.Drawing.Color.Transparent;
			this.nudPrice.BorderColor = System.Drawing.Color.White;
			this.nudPrice.BorderThickness = 0;
			this.nudPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.nudPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.nudPrice.ForeColor = System.Drawing.Color.DimGray;
			this.nudPrice.Location = new System.Drawing.Point(0, 14);
			this.nudPrice.Margin = new System.Windows.Forms.Padding(0);
			this.nudPrice.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
			this.nudPrice.Name = "nudPrice";
			this.nudPrice.Size = new System.Drawing.Size(180, 22);
			this.nudPrice.TabIndex = 30;
			this.nudPrice.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			// 
			// pnlBox3
			// 
			this.pnlBox3.BackColor = System.Drawing.Color.Transparent;
			this.pnlBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnlBox3.Controls.Add(this.nudProductAmount);
			this.pnlBox3.Location = new System.Drawing.Point(670, 0);
			this.pnlBox3.Margin = new System.Windows.Forms.Padding(0);
			this.pnlBox3.Name = "pnlBox3";
			this.pnlBox3.Size = new System.Drawing.Size(50, 49);
			this.pnlBox3.TabIndex = 2;
			// 
			// nudProductAmount
			// 
			this.nudProductAmount.BackColor = System.Drawing.Color.Transparent;
			this.nudProductAmount.BorderColor = System.Drawing.Color.White;
			this.nudProductAmount.BorderThickness = 0;
			this.nudProductAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.nudProductAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.nudProductAmount.ForeColor = System.Drawing.Color.DimGray;
			this.nudProductAmount.Location = new System.Drawing.Point(0, 14);
			this.nudProductAmount.Margin = new System.Windows.Forms.Padding(0);
			this.nudProductAmount.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.nudProductAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudProductAmount.Name = "nudProductAmount";
			this.nudProductAmount.Size = new System.Drawing.Size(50, 22);
			this.nudProductAmount.TabIndex = 29;
			this.nudProductAmount.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.nudProductAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// pnlBox4
			// 
			this.pnlBox4.BackColor = System.Drawing.Color.Transparent;
			this.pnlBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnlBox4.Controls.Add(this.lbTotalPrice);
			this.pnlBox4.Location = new System.Drawing.Point(720, 0);
			this.pnlBox4.Margin = new System.Windows.Forms.Padding(0);
			this.pnlBox4.Name = "pnlBox4";
			this.pnlBox4.Size = new System.Drawing.Size(180, 49);
			this.pnlBox4.TabIndex = 3;
			// 
			// lbTotalPrice
			// 
			this.lbTotalPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.lbTotalPrice.BackColor = System.Drawing.Color.Transparent;
			this.lbTotalPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.lbTotalPrice.ForeColor = System.Drawing.Color.DimGray;
			this.lbTotalPrice.Location = new System.Drawing.Point(0, 12);
			this.lbTotalPrice.Margin = new System.Windows.Forms.Padding(0, 20, 20, 20);
			this.lbTotalPrice.Name = "lbTotalPrice";
			this.lbTotalPrice.Size = new System.Drawing.Size(176, 21);
			this.lbTotalPrice.TabIndex = 2;
			this.lbTotalPrice.Text = "0";
			this.lbTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// cms
			// 
			this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiXoa});
			this.cms.Name = "cms";
			this.cms.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
			this.cms.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
			this.cms.RenderStyle.ColorTable = null;
			this.cms.RenderStyle.RoundedEdges = true;
			this.cms.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
			this.cms.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.cms.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
			this.cms.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
			this.cms.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
			this.cms.Size = new System.Drawing.Size(144, 26);
			// 
			// tsmiXoa
			// 
			this.tsmiXoa.Name = "tsmiXoa";
			this.tsmiXoa.Size = new System.Drawing.Size(143, 22);
			this.tsmiXoa.Text = "Xóa mục này";
			// 
			// BillRowBox
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ContextMenuStrip = this.cms;
			this.Controls.Add(this.pnlBillRowBox);
			this.Margin = new System.Windows.Forms.Padding(0);
			this.Name = "BillRowBox";
			this.Size = new System.Drawing.Size(902, 51);
			this.pnlBillRowBox.ResumeLayout(false);
			this.flpBillRowBox.ResumeLayout(false);
			this.pnlBox1.ResumeLayout(false);
			this.pnlBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
			this.pnlBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.nudProductAmount)).EndInit();
			this.pnlBox4.ResumeLayout(false);
			this.cms.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}