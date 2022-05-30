using System;
using System.Drawing;
using System.Windows.Forms;

namespace BookStore.ChildForm
{
	public partial class RevenueDetailBox : UserControl
	{
		public RevenueDetailBox(string lbProductID, string lbTotalProductRevenue, string lbSalable,
			Color fillColor1, Color fillColor2, Color fillColor3, Color fillColor4)
		{
			InitializeComponent();
			this.lbProductID.Text = lbProductID;
			this.lbTotalProductRevenue.Text = lbTotalProductRevenue;
			this.lbSalable.Text = lbSalable;
			this.pnlProductRevenue.FillColor = fillColor1;
			this.pnlProductRevenue.FillColor2 = fillColor2;
			this.pnlProductRevenue.FillColor3 = fillColor3;
			this.pnlProductRevenue.FillColor4 = fillColor4;
		}

		private void InitializeComponent()
		{
			this.flpProductRevenue = new System.Windows.Forms.FlowLayoutPanel();
			this.pnlIcon = new Guna.UI2.WinForms.Guna2ShadowPanel();
			this.btnIcon = new FontAwesome.Sharp.IconButton();
			this.flpDetail = new System.Windows.Forms.FlowLayoutPanel();
			this.lbProductID = new System.Windows.Forms.Label();
			this.flpPriceNTime = new System.Windows.Forms.FlowLayoutPanel();
			this.lbTotalProductRevenue = new System.Windows.Forms.Label();
			this.lbDot = new System.Windows.Forms.Label();
			this.lbSalable = new System.Windows.Forms.Label();
			this.btnFoward = new FontAwesome.Sharp.IconButton();
			this.pnlProductRevenue = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
			this.flpProductRevenue.SuspendLayout();
			this.pnlIcon.SuspendLayout();
			this.flpDetail.SuspendLayout();
			this.flpPriceNTime.SuspendLayout();
			this.pnlProductRevenue.SuspendLayout();
			this.SuspendLayout();
			// 
			// flpProductRevenue
			// 
			this.flpProductRevenue.BackColor = System.Drawing.Color.Transparent;
			this.flpProductRevenue.Controls.Add(this.pnlIcon);
			this.flpProductRevenue.Controls.Add(this.flpDetail);
			this.flpProductRevenue.Location = new System.Drawing.Point(8, 6);
			this.flpProductRevenue.Name = "flpProductRevenue";
			this.flpProductRevenue.Size = new System.Drawing.Size(367, 69);
			this.flpProductRevenue.TabIndex = 7;
			// 
			// pnlIcon
			// 
			this.pnlIcon.BackColor = System.Drawing.Color.Transparent;
			this.pnlIcon.Controls.Add(this.btnIcon);
			this.pnlIcon.FillColor = System.Drawing.Color.White;
			this.pnlIcon.Location = new System.Drawing.Point(0, 0);
			this.pnlIcon.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
			this.pnlIcon.Name = "pnlIcon";
			this.pnlIcon.Radius = 10;
			this.pnlIcon.ShadowColor = System.Drawing.Color.Black;
			this.pnlIcon.ShadowDepth = 50;
			this.pnlIcon.ShadowShift = 2;
			this.pnlIcon.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
			this.pnlIcon.Size = new System.Drawing.Size(64, 69);
			this.pnlIcon.TabIndex = 7;
			// 
			// btnIcon
			// 
			this.btnIcon.AutoSize = true;
			this.btnIcon.BackColor = System.Drawing.Color.Transparent;
			this.btnIcon.Cursor = System.Windows.Forms.Cursors.Default;
			this.btnIcon.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnIcon.Enabled = false;
			this.btnIcon.FlatAppearance.BorderSize = 0;
			this.btnIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnIcon.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
			this.btnIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(69)))));
			this.btnIcon.IconChar = FontAwesome.Sharp.IconChar.ProductHunt;
			this.btnIcon.IconColor = System.Drawing.Color.Black;
			this.btnIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnIcon.IconSize = 50;
			this.btnIcon.Location = new System.Drawing.Point(0, 0);
			this.btnIcon.Margin = new System.Windows.Forms.Padding(0);
			this.btnIcon.Name = "btnIcon";
			this.btnIcon.Padding = new System.Windows.Forms.Padding(2, 5, 0, 0);
			this.btnIcon.Size = new System.Drawing.Size(64, 69);
			this.btnIcon.TabIndex = 18;
			this.btnIcon.TabStop = false;
			this.btnIcon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnIcon.UseVisualStyleBackColor = false;
			// 
			// flpDetail
			// 
			this.flpDetail.AutoScroll = true;
			this.flpDetail.Controls.Add(this.lbProductID);
			this.flpDetail.Controls.Add(this.flpPriceNTime);
			this.flpDetail.Controls.Add(this.btnFoward);
			this.flpDetail.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flpDetail.Location = new System.Drawing.Point(74, 0);
			this.flpDetail.Margin = new System.Windows.Forms.Padding(0);
			this.flpDetail.Name = "flpDetail";
			this.flpDetail.Size = new System.Drawing.Size(293, 69);
			this.flpDetail.TabIndex = 7;
			// 
			// lbProductID
			// 
			this.lbProductID.AutoSize = true;
			this.lbProductID.Dock = System.Windows.Forms.DockStyle.Left;
			this.lbProductID.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
			this.lbProductID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(85)))));
			this.lbProductID.Location = new System.Drawing.Point(3, 10);
			this.lbProductID.Margin = new System.Windows.Forms.Padding(3, 10, 3, 5);
			this.lbProductID.Name = "lbProductID";
			this.lbProductID.Size = new System.Drawing.Size(0, 19);
			this.lbProductID.TabIndex = 9;
			// 
			// flpPriceNTime
			// 
			this.flpPriceNTime.AutoScroll = true;
			this.flpPriceNTime.Controls.Add(this.lbTotalProductRevenue);
			this.flpPriceNTime.Controls.Add(this.lbDot);
			this.flpPriceNTime.Controls.Add(this.lbSalable);
			this.flpPriceNTime.Dock = System.Windows.Forms.DockStyle.Left;
			this.flpPriceNTime.Location = new System.Drawing.Point(3, 39);
			this.flpPriceNTime.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
			this.flpPriceNTime.Name = "flpPriceNTime";
			this.flpPriceNTime.Size = new System.Drawing.Size(261, 20);
			this.flpPriceNTime.TabIndex = 8;
			// 
			// lbTotalProductRevenue
			// 
			this.lbTotalProductRevenue.AutoSize = true;
			this.lbTotalProductRevenue.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
			this.lbTotalProductRevenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(69)))));
			this.lbTotalProductRevenue.Location = new System.Drawing.Point(3, 0);
			this.lbTotalProductRevenue.Name = "lbTotalProductRevenue";
			this.lbTotalProductRevenue.Size = new System.Drawing.Size(85, 20);
			this.lbTotalProductRevenue.TabIndex = 10;
			this.lbTotalProductRevenue.Text = "Thành tiền:";
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
			// lbSalable
			// 
			this.lbSalable.AutoSize = true;
			this.lbSalable.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
			this.lbSalable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(85)))));
			this.lbSalable.Location = new System.Drawing.Point(115, 0);
			this.lbSalable.Name = "lbSalable";
			this.lbSalable.Size = new System.Drawing.Size(64, 20);
			this.lbSalable.TabIndex = 12;
			this.lbSalable.Text = "Bán: pcs";
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
			// pnlProductRevenue
			// 
			this.pnlProductRevenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
			this.pnlProductRevenue.BorderRadius = 5;
			this.pnlProductRevenue.Controls.Add(this.flpProductRevenue);
			this.pnlProductRevenue.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(220)))), ((int)(((byte)(223)))));
			this.pnlProductRevenue.FillColor4 = System.Drawing.Color.WhiteSmoke;
			this.pnlProductRevenue.Location = new System.Drawing.Point(0, 0);
			this.pnlProductRevenue.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.pnlProductRevenue.Name = "pnlProductRevenue";
			this.pnlProductRevenue.Padding = new System.Windows.Forms.Padding(5);
			this.pnlProductRevenue.Size = new System.Drawing.Size(375, 80);
			this.pnlProductRevenue.TabIndex = 14;
			// 
			// RevenueDetailBox
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.pnlProductRevenue);
			this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.Name = "RevenueDetailBox";
			this.Size = new System.Drawing.Size(375, 80);
			this.flpProductRevenue.ResumeLayout(false);
			this.pnlIcon.ResumeLayout(false);
			this.pnlIcon.PerformLayout();
			this.flpDetail.ResumeLayout(false);
			this.flpDetail.PerformLayout();
			this.flpPriceNTime.ResumeLayout(false);
			this.flpPriceNTime.PerformLayout();
			this.pnlProductRevenue.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		private System.Windows.Forms.FlowLayoutPanel flpProductRevenue;
		private Guna.UI2.WinForms.Guna2ShadowPanel pnlIcon;
		private FontAwesome.Sharp.IconButton btnIcon;
		private System.Windows.Forms.FlowLayoutPanel flpDetail;
		private System.Windows.Forms.Label lbProductID;
		private System.Windows.Forms.FlowLayoutPanel flpPriceNTime;
		private System.Windows.Forms.Label lbTotalProductRevenue;
		private System.Windows.Forms.Label lbDot;
		private System.Windows.Forms.Label lbSalable;
		public FontAwesome.Sharp.IconButton btnFoward;
		private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlProductRevenue;

	}
}