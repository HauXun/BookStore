using BookStore.Model.BusinessLogicLayer;
using BookStore.Model.Entities;
using BookStore.Partial;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore.ChildForm
{
	public partial class AccountRowBox : UserControl
	{
		private FlowLayoutPanel flpInfo;
		private Guna.UI2.WinForms.Guna2ShadowPanel pnlIcon;
		private FontAwesome.Sharp.IconButton btnIcon;
		private FlowLayoutPanel flpDetail;
		private Panel pnlID;
		public Label lbID;
		private Panel pnlName;
		public Label lbName;
		private Panel pnlAddress;
		public Label lbAddress;
		private Panel pnlTell;
		public Label lbTell;
		private Panel pnlRole;
		public Label lbRole;
		private Panel pnlActive;
		public FontAwesome.Sharp.IconButton iconActive;
		private Guna.UI2.WinForms.Guna2ContextMenuStrip cms;
		private ToolStripMenuItem tsmiResetPassword;
		private Taikhoan taikhoan;

		public Taikhoan Taikhoan
		{
			get => taikhoan;
			set
			{
				taikhoan = value;
				LoadData(value);
			}
		}

		public AccountRowBox()
		{
			InitializeComponent(); 
			Region = System.Drawing.Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
			iconActive.Region = System.Drawing.Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, iconActive.Width, iconActive.Height, 5, 5));
		}

		public AccountRowBox(Taikhoan taikhoan) : this()
		{
			Taikhoan = taikhoan;
		}

		private void LoadData(Taikhoan taikhoan)
		{
			lbID.Text = taikhoan.IDAccount;
			lbName.Text = taikhoan.HoTen;
			lbAddress.Text = taikhoan.DiaChi;
			lbTell.Text = taikhoan.SDT;
			lbRole.Text = taikhoan.RoleID;
			iconActive.IconColor = taikhoan.Active ? Color.Lime : Color.Red;
		}

		private void InitializeComponent()
		{
			this.flpInfo = new System.Windows.Forms.FlowLayoutPanel();
			this.pnlIcon = new Guna.UI2.WinForms.Guna2ShadowPanel();
			this.btnIcon = new FontAwesome.Sharp.IconButton();
			this.flpDetail = new System.Windows.Forms.FlowLayoutPanel();
			this.pnlID = new System.Windows.Forms.Panel();
			this.lbID = new System.Windows.Forms.Label();
			this.pnlName = new System.Windows.Forms.Panel();
			this.lbName = new System.Windows.Forms.Label();
			this.pnlAddress = new System.Windows.Forms.Panel();
			this.lbAddress = new System.Windows.Forms.Label();
			this.pnlTell = new System.Windows.Forms.Panel();
			this.lbTell = new System.Windows.Forms.Label();
			this.pnlRole = new System.Windows.Forms.Panel();
			this.lbRole = new System.Windows.Forms.Label();
			this.pnlActive = new System.Windows.Forms.Panel();
			this.iconActive = new FontAwesome.Sharp.IconButton();
			this.cms = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
			this.tsmiResetPassword = new System.Windows.Forms.ToolStripMenuItem();
			this.flpInfo.SuspendLayout();
			this.pnlIcon.SuspendLayout();
			this.flpDetail.SuspendLayout();
			this.pnlID.SuspendLayout();
			this.pnlName.SuspendLayout();
			this.pnlAddress.SuspendLayout();
			this.pnlTell.SuspendLayout();
			this.pnlRole.SuspendLayout();
			this.pnlActive.SuspendLayout();
			this.cms.SuspendLayout();
			this.SuspendLayout();
			// 
			// flpInfo
			// 
			this.flpInfo.BackColor = System.Drawing.Color.Transparent;
			this.flpInfo.Controls.Add(this.pnlIcon);
			this.flpInfo.Controls.Add(this.flpDetail);
			this.flpInfo.Location = new System.Drawing.Point(0, 0);
			this.flpInfo.Margin = new System.Windows.Forms.Padding(0);
			this.flpInfo.Name = "flpInfo";
			this.flpInfo.Size = new System.Drawing.Size(1336, 50);
			this.flpInfo.TabIndex = 10;
			this.flpInfo.MouseEnter += new System.EventHandler(this.btnIcon_MouseEnter);
			this.flpInfo.MouseLeave += new System.EventHandler(this.btnIcon_MouseLeave);
			// 
			// pnlIcon
			// 
			this.pnlIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlIcon.BackColor = System.Drawing.Color.Transparent;
			this.pnlIcon.Controls.Add(this.btnIcon);
			this.pnlIcon.FillColor = System.Drawing.Color.White;
			this.pnlIcon.Location = new System.Drawing.Point(5, 5);
			this.pnlIcon.Margin = new System.Windows.Forms.Padding(5, 5, 10, 0);
			this.pnlIcon.Name = "pnlIcon";
			this.pnlIcon.Radius = 8;
			this.pnlIcon.ShadowColor = System.Drawing.Color.Black;
			this.pnlIcon.ShadowDepth = 50;
			this.pnlIcon.ShadowShift = 2;
			this.pnlIcon.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.Dropped;
			this.pnlIcon.Size = new System.Drawing.Size(45, 45);
			this.pnlIcon.TabIndex = 7;
			this.pnlIcon.MouseEnter += new System.EventHandler(this.btnIcon_MouseEnter);
			this.pnlIcon.MouseLeave += new System.EventHandler(this.btnIcon_MouseLeave);
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
			this.btnIcon.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
			this.btnIcon.IconColor = System.Drawing.Color.Black;
			this.btnIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnIcon.IconSize = 30;
			this.btnIcon.Location = new System.Drawing.Point(0, 0);
			this.btnIcon.Margin = new System.Windows.Forms.Padding(0);
			this.btnIcon.Name = "btnIcon";
			this.btnIcon.Padding = new System.Windows.Forms.Padding(5, 3, 0, 0);
			this.btnIcon.Size = new System.Drawing.Size(45, 45);
			this.btnIcon.TabIndex = 17;
			this.btnIcon.TabStop = false;
			this.btnIcon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnIcon.UseVisualStyleBackColor = false;
			this.btnIcon.MouseEnter += new System.EventHandler(this.btnIcon_MouseEnter);
			this.btnIcon.MouseLeave += new System.EventHandler(this.btnIcon_MouseLeave);
			// 
			// flpDetail
			// 
			this.flpDetail.AutoScroll = true;
			this.flpDetail.Controls.Add(this.pnlID);
			this.flpDetail.Controls.Add(this.pnlName);
			this.flpDetail.Controls.Add(this.pnlAddress);
			this.flpDetail.Controls.Add(this.pnlTell);
			this.flpDetail.Controls.Add(this.pnlRole);
			this.flpDetail.Controls.Add(this.pnlActive);
			this.flpDetail.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flpDetail.Location = new System.Drawing.Point(60, 0);
			this.flpDetail.Margin = new System.Windows.Forms.Padding(0);
			this.flpDetail.Name = "flpDetail";
			this.flpDetail.Size = new System.Drawing.Size(1276, 50);
			this.flpDetail.TabIndex = 7;
			this.flpDetail.MouseEnter += new System.EventHandler(this.btnIcon_MouseEnter);
			this.flpDetail.MouseLeave += new System.EventHandler(this.btnIcon_MouseLeave);
			// 
			// pnlID
			// 
			this.pnlID.Controls.Add(this.lbID);
			this.pnlID.Location = new System.Drawing.Point(0, 0);
			this.pnlID.Margin = new System.Windows.Forms.Padding(0);
			this.pnlID.Name = "pnlID";
			this.pnlID.Size = new System.Drawing.Size(150, 50);
			this.pnlID.TabIndex = 3;
			this.pnlID.MouseEnter += new System.EventHandler(this.btnIcon_MouseEnter);
			this.pnlID.MouseLeave += new System.EventHandler(this.btnIcon_MouseLeave);
			// 
			// lbID
			// 
			this.lbID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.lbID.ForeColor = System.Drawing.Color.DimGray;
			this.lbID.Location = new System.Drawing.Point(0, 15);
			this.lbID.Margin = new System.Windows.Forms.Padding(0, 20, 0, 20);
			this.lbID.Name = "lbID";
			this.lbID.Size = new System.Drawing.Size(150, 21);
			this.lbID.TabIndex = 1;
			this.lbID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbID.MouseEnter += new System.EventHandler(this.btnIcon_MouseEnter);
			this.lbID.MouseLeave += new System.EventHandler(this.btnIcon_MouseLeave);
			// 
			// pnlName
			// 
			this.pnlName.Controls.Add(this.lbName);
			this.pnlName.Location = new System.Drawing.Point(150, 0);
			this.pnlName.Margin = new System.Windows.Forms.Padding(0);
			this.pnlName.Name = "pnlName";
			this.pnlName.Size = new System.Drawing.Size(250, 50);
			this.pnlName.TabIndex = 0;
			this.pnlName.MouseEnter += new System.EventHandler(this.btnIcon_MouseEnter);
			this.pnlName.MouseLeave += new System.EventHandler(this.btnIcon_MouseLeave);
			// 
			// lbName
			// 
			this.lbName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.lbName.ForeColor = System.Drawing.Color.DimGray;
			this.lbName.Location = new System.Drawing.Point(0, 15);
			this.lbName.Margin = new System.Windows.Forms.Padding(0, 20, 0, 20);
			this.lbName.Name = "lbName";
			this.lbName.Size = new System.Drawing.Size(250, 21);
			this.lbName.TabIndex = 1;
			this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbName.MouseEnter += new System.EventHandler(this.btnIcon_MouseEnter);
			this.lbName.MouseLeave += new System.EventHandler(this.btnIcon_MouseLeave);
			// 
			// pnlAddress
			// 
			this.pnlAddress.Controls.Add(this.lbAddress);
			this.pnlAddress.Location = new System.Drawing.Point(400, 0);
			this.pnlAddress.Margin = new System.Windows.Forms.Padding(0);
			this.pnlAddress.Name = "pnlAddress";
			this.pnlAddress.Size = new System.Drawing.Size(456, 50);
			this.pnlAddress.TabIndex = 4;
			this.pnlAddress.MouseEnter += new System.EventHandler(this.btnIcon_MouseEnter);
			this.pnlAddress.MouseLeave += new System.EventHandler(this.btnIcon_MouseLeave);
			// 
			// lbAddress
			// 
			this.lbAddress.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.lbAddress.ForeColor = System.Drawing.Color.DimGray;
			this.lbAddress.Location = new System.Drawing.Point(0, 15);
			this.lbAddress.Margin = new System.Windows.Forms.Padding(0, 20, 0, 20);
			this.lbAddress.Name = "lbAddress";
			this.lbAddress.Size = new System.Drawing.Size(454, 21);
			this.lbAddress.TabIndex = 2;
			this.lbAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lbAddress.MouseEnter += new System.EventHandler(this.btnIcon_MouseEnter);
			this.lbAddress.MouseLeave += new System.EventHandler(this.btnIcon_MouseLeave);
			// 
			// pnlTell
			// 
			this.pnlTell.Controls.Add(this.lbTell);
			this.pnlTell.Location = new System.Drawing.Point(856, 0);
			this.pnlTell.Margin = new System.Windows.Forms.Padding(0);
			this.pnlTell.Name = "pnlTell";
			this.pnlTell.Size = new System.Drawing.Size(150, 50);
			this.pnlTell.TabIndex = 1;
			this.pnlTell.MouseEnter += new System.EventHandler(this.btnIcon_MouseEnter);
			this.pnlTell.MouseLeave += new System.EventHandler(this.btnIcon_MouseLeave);
			// 
			// lbTell
			// 
			this.lbTell.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.lbTell.ForeColor = System.Drawing.Color.DimGray;
			this.lbTell.Location = new System.Drawing.Point(0, 15);
			this.lbTell.Margin = new System.Windows.Forms.Padding(0, 20, 0, 20);
			this.lbTell.Name = "lbTell";
			this.lbTell.Size = new System.Drawing.Size(150, 21);
			this.lbTell.TabIndex = 2;
			this.lbTell.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbTell.MouseEnter += new System.EventHandler(this.btnIcon_MouseEnter);
			this.lbTell.MouseLeave += new System.EventHandler(this.btnIcon_MouseLeave);
			// 
			// pnlRole
			// 
			this.pnlRole.Controls.Add(this.lbRole);
			this.pnlRole.Location = new System.Drawing.Point(1006, 0);
			this.pnlRole.Margin = new System.Windows.Forms.Padding(0);
			this.pnlRole.Name = "pnlRole";
			this.pnlRole.Size = new System.Drawing.Size(120, 50);
			this.pnlRole.TabIndex = 5;
			this.pnlRole.MouseEnter += new System.EventHandler(this.btnIcon_MouseEnter);
			this.pnlRole.MouseLeave += new System.EventHandler(this.btnIcon_MouseLeave);
			// 
			// lbRole
			// 
			this.lbRole.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.lbRole.ForeColor = System.Drawing.Color.DimGray;
			this.lbRole.Location = new System.Drawing.Point(0, 15);
			this.lbRole.Margin = new System.Windows.Forms.Padding(0, 20, 0, 20);
			this.lbRole.Name = "lbRole";
			this.lbRole.Size = new System.Drawing.Size(120, 21);
			this.lbRole.TabIndex = 2;
			this.lbRole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbRole.MouseEnter += new System.EventHandler(this.btnIcon_MouseEnter);
			this.lbRole.MouseLeave += new System.EventHandler(this.btnIcon_MouseLeave);
			// 
			// pnlActive
			// 
			this.pnlActive.Controls.Add(this.iconActive);
			this.pnlActive.Location = new System.Drawing.Point(1126, 0);
			this.pnlActive.Margin = new System.Windows.Forms.Padding(0);
			this.pnlActive.Name = "pnlActive";
			this.pnlActive.Size = new System.Drawing.Size(150, 50);
			this.pnlActive.TabIndex = 2;
			this.pnlActive.MouseEnter += new System.EventHandler(this.btnIcon_MouseEnter);
			this.pnlActive.MouseLeave += new System.EventHandler(this.btnIcon_MouseLeave);
			// 
			// iconActive
			// 
			this.iconActive.BackColor = System.Drawing.Color.Transparent;
			this.iconActive.Cursor = System.Windows.Forms.Cursors.Hand;
			this.iconActive.FlatAppearance.BorderSize = 0;
			this.iconActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.iconActive.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.iconActive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(69)))));
			this.iconActive.IconChar = FontAwesome.Sharp.IconChar.DotCircle;
			this.iconActive.IconColor = System.Drawing.Color.Lime;
			this.iconActive.IconFont = FontAwesome.Sharp.IconFont.Solid;
			this.iconActive.IconSize = 10;
			this.iconActive.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.iconActive.Location = new System.Drawing.Point(25, 10);
			this.iconActive.Margin = new System.Windows.Forms.Padding(25, 10, 25, 10);
			this.iconActive.Name = "iconActive";
			this.iconActive.Size = new System.Drawing.Size(100, 30);
			this.iconActive.TabIndex = 15;
			this.iconActive.TabStop = false;
			this.iconActive.Text = "Active";
			this.iconActive.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.iconActive.UseVisualStyleBackColor = false;
			this.iconActive.MouseEnter += new System.EventHandler(this.btnIcon_MouseEnter);
			this.iconActive.MouseLeave += new System.EventHandler(this.btnIcon_MouseLeave);
			// 
			// cms
			// 
			this.cms.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiResetPassword});
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
			this.cms.Size = new System.Drawing.Size(156, 26);
			// 
			// tsmiResetPassword
			// 
			this.tsmiResetPassword.Name = "tsmiResetPassword";
			this.tsmiResetPassword.Size = new System.Drawing.Size(180, 22);
			this.tsmiResetPassword.Text = "Reset Password";
			this.tsmiResetPassword.Click += new System.EventHandler(this.tsmiResetPassword_Click);
			// 
			// StaffRowBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ContextMenuStrip = this.cms;
			this.Controls.Add(this.flpInfo);
			this.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.Name = "StaffRowBox";
			this.Size = new System.Drawing.Size(1336, 50);
			this.flpInfo.ResumeLayout(false);
			this.pnlIcon.ResumeLayout(false);
			this.pnlIcon.PerformLayout();
			this.flpDetail.ResumeLayout(false);
			this.pnlID.ResumeLayout(false);
			this.pnlName.ResumeLayout(false);
			this.pnlAddress.ResumeLayout(false);
			this.pnlTell.ResumeLayout(false);
			this.pnlRole.ResumeLayout(false);
			this.pnlActive.ResumeLayout(false);
			this.cms.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		private void btnIcon_MouseEnter(object sender, EventArgs e)
		{
			this.BackColor = Color.WhiteSmoke;
		}

		private void btnIcon_MouseLeave(object sender, EventArgs e)
		{
			this.BackColor = Color.White;
		}

		private void tsmiResetPassword_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show($"Reset mật khẩu cho tài khoản {lbID.Text}?", "Book Store",
					MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK
					 && AccountBLL.Instance.ResetPassword(this.lbID.Text) > 0)
			{
				MessageBox.Show("Reset mật khẩu thành công!", "Book Store",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
	}
}
