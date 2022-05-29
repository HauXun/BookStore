using System;
using System.Drawing;
using System.Windows.Forms;

namespace BookStore.ChildForm
{
	public partial class ProductSalableBox : UserControl
	{
		public ProductSalableBox(string lbProductID, string lbSallable,
			Color fillColor1, Color fillColor2, Color fillColor3, Color fillColor4)
		{
			InitializeComponent();
			this.lbProductID.Text = lbProductID;
			this.lbSallable.Text = lbSallable;
			this.pnlSallableBox.FillColor = fillColor1;
			this.pnlSallableBox.FillColor2 = fillColor2;
			this.pnlSallableBox.FillColor3 = fillColor3;
			this.pnlSallableBox.FillColor4 = fillColor4;
		}

		private void InitializeComponent()
		{
			this.pnlSallableBox = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
			this.flpSallableBox = new System.Windows.Forms.FlowLayoutPanel();
			this.pnlIcon = new Guna.UI2.WinForms.Guna2ShadowPanel();
			this.btnIcon = new FontAwesome.Sharp.IconButton();
			this.flpDetail = new System.Windows.Forms.FlowLayoutPanel();
			this.lbProductID = new System.Windows.Forms.Label();
			this.flpLbSalable = new System.Windows.Forms.FlowLayoutPanel();
			this.lbSallable = new System.Windows.Forms.Label();
			this.btnFoward = new FontAwesome.Sharp.IconButton();
			this.pnlSallableBox.SuspendLayout();
			this.flpSallableBox.SuspendLayout();
			this.pnlIcon.SuspendLayout();
			this.flpDetail.SuspendLayout();
			this.flpLbSalable.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlSallableBox
			// 
			this.pnlSallableBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(250)))), ((int)(((byte)(255)))));
			this.pnlSallableBox.BorderRadius = 5;
			this.pnlSallableBox.Controls.Add(this.flpSallableBox);
			this.pnlSallableBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.pnlSallableBox.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
			this.pnlSallableBox.FillColor4 = System.Drawing.Color.WhiteSmoke;
			this.pnlSallableBox.Location = new System.Drawing.Point(0, 0);
			this.pnlSallableBox.Margin = new System.Windows.Forms.Padding(0);
			this.pnlSallableBox.Name = "pnlSallableBox";
			this.pnlSallableBox.Padding = new System.Windows.Forms.Padding(5);
			this.pnlSallableBox.Size = new System.Drawing.Size(330, 80);
			this.pnlSallableBox.TabIndex = 16;
			// 
			// flpSallableBox
			// 
			this.flpSallableBox.BackColor = System.Drawing.Color.Transparent;
			this.flpSallableBox.Controls.Add(this.pnlIcon);
			this.flpSallableBox.Controls.Add(this.flpDetail);
			this.flpSallableBox.Location = new System.Drawing.Point(8, 6);
			this.flpSallableBox.Name = "flpSallableBox";
			this.flpSallableBox.Size = new System.Drawing.Size(322, 69);
			this.flpSallableBox.TabIndex = 8;
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
			this.btnIcon.TabIndex = 16;
			this.btnIcon.TabStop = false;
			this.btnIcon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnIcon.UseVisualStyleBackColor = false;
			// 
			// flpDetail
			// 
			this.flpDetail.AutoScroll = true;
			this.flpDetail.Controls.Add(this.lbProductID);
			this.flpDetail.Controls.Add(this.flpLbSalable);
			this.flpDetail.Controls.Add(this.btnFoward);
			this.flpDetail.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flpDetail.Location = new System.Drawing.Point(74, 0);
			this.flpDetail.Margin = new System.Windows.Forms.Padding(0);
			this.flpDetail.Name = "flpDetail";
			this.flpDetail.Size = new System.Drawing.Size(248, 69);
			this.flpDetail.TabIndex = 7;
			// 
			// lbProductID
			// 
			this.lbProductID.AutoSize = true;
			this.lbProductID.Dock = System.Windows.Forms.DockStyle.Left;
			this.lbProductID.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
			this.lbProductID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(85)))));
			this.lbProductID.Location = new System.Drawing.Point(3, 10);
			this.lbProductID.Margin = new System.Windows.Forms.Padding(3, 10, 3, 5);
			this.lbProductID.Name = "lbProductID";
			this.lbProductID.Size = new System.Drawing.Size(0, 17);
			this.lbProductID.TabIndex = 9;
			// 
			// flpLbSalable
			// 
			this.flpLbSalable.AutoScroll = true;
			this.flpLbSalable.Controls.Add(this.lbSallable);
			this.flpLbSalable.Dock = System.Windows.Forms.DockStyle.Left;
			this.flpLbSalable.Location = new System.Drawing.Point(3, 37);
			this.flpLbSalable.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
			this.flpLbSalable.Name = "flpLbSalable";
			this.flpLbSalable.Size = new System.Drawing.Size(216, 20);
			this.flpLbSalable.TabIndex = 8;
			// 
			// lbSallable
			// 
			this.lbSallable.AutoSize = true;
			this.lbSallable.Font = new System.Drawing.Font("Tahoma", 10F);
			this.lbSallable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(69)))));
			this.lbSallable.Location = new System.Drawing.Point(3, 0);
			this.lbSallable.Name = "lbSallable";
			this.lbSallable.Size = new System.Drawing.Size(109, 17);
			this.lbSallable.TabIndex = 10;
			this.lbSallable.Text = "Bán được: 0 pcs";
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
			this.btnFoward.Location = new System.Drawing.Point(222, 0);
			this.btnFoward.Margin = new System.Windows.Forms.Padding(0);
			this.btnFoward.Name = "btnFoward";
			this.btnFoward.Size = new System.Drawing.Size(26, 69);
			this.btnFoward.TabIndex = 14;
			this.btnFoward.TabStop = false;
			this.btnFoward.UseVisualStyleBackColor = false;
			// 
			// ProductSalableBox
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.pnlSallableBox);
			this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.Name = "ProductSalableBox";
			this.Size = new System.Drawing.Size(330, 80);
			this.pnlSallableBox.ResumeLayout(false);
			this.flpSallableBox.ResumeLayout(false);
			this.pnlIcon.ResumeLayout(false);
			this.pnlIcon.PerformLayout();
			this.flpDetail.ResumeLayout(false);
			this.flpDetail.PerformLayout();
			this.flpLbSalable.ResumeLayout(false);
			this.flpLbSalable.PerformLayout();
			this.ResumeLayout(false);

		}

		private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlSallableBox;
		private System.Windows.Forms.FlowLayoutPanel flpSallableBox;
		private Guna.UI2.WinForms.Guna2ShadowPanel pnlIcon;
		private FontAwesome.Sharp.IconButton btnIcon;
		private System.Windows.Forms.FlowLayoutPanel flpDetail;
		private System.Windows.Forms.Label lbProductID;
		private System.Windows.Forms.FlowLayoutPanel flpLbSalable;
		private System.Windows.Forms.Label lbSallable;
		public FontAwesome.Sharp.IconButton btnFoward;
	}
}