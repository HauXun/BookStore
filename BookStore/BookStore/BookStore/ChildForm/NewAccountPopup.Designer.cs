namespace BookStore.ChildForm
{
	partial class NewAccountPopup
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
			this.pnlContent = new System.Windows.Forms.Panel();
			this.cbRole = new Guna.UI2.WinForms.Guna2ComboBox();
			this.tbAddress = new Guna.UI2.WinForms.Guna2TextBox();
			this.lbBack = new System.Windows.Forms.LinkLabel();
			this.btnCreate = new Guna.UI2.WinForms.Guna2Button();
			this.tbSDT = new Guna.UI2.WinForms.Guna2TextBox();
			this.tbName = new Guna.UI2.WinForms.Guna2TextBox();
			this.lbTitleInfo = new System.Windows.Forms.Label();
			this.lbTitle = new System.Windows.Forms.Label();
			this.errorProviderWar = new System.Windows.Forms.ErrorProvider(this.components);
			this.Content.SuspendLayout();
			this.pnlContent.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderWar)).BeginInit();
			this.SuspendLayout();
			// 
			// Content
			// 
			this.Content.Controls.Add(this.pnlContent);
			this.Content.Size = new System.Drawing.Size(400, 444);
			// 
			// pnlContent
			// 
			this.pnlContent.Controls.Add(this.cbRole);
			this.pnlContent.Controls.Add(this.tbAddress);
			this.pnlContent.Controls.Add(this.lbBack);
			this.pnlContent.Controls.Add(this.btnCreate);
			this.pnlContent.Controls.Add(this.tbSDT);
			this.pnlContent.Controls.Add(this.tbName);
			this.pnlContent.Controls.Add(this.lbTitleInfo);
			this.pnlContent.Controls.Add(this.lbTitle);
			this.pnlContent.Location = new System.Drawing.Point(15, 15);
			this.pnlContent.Margin = new System.Windows.Forms.Padding(15);
			this.pnlContent.Name = "pnlContent";
			this.pnlContent.Size = new System.Drawing.Size(370, 416);
			this.pnlContent.TabIndex = 3;
			// 
			// cbRole
			// 
			this.cbRole.BackColor = System.Drawing.Color.Transparent;
			this.cbRole.BorderRadius = 5;
			this.cbRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbRole.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbRole.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbRole.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.cbRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
			this.cbRole.ItemHeight = 30;
			this.cbRole.Location = new System.Drawing.Point(20, 311);
			this.cbRole.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
			this.cbRole.Name = "cbRole";
			this.cbRole.Size = new System.Drawing.Size(330, 36);
			this.cbRole.TabIndex = 28;
			// 
			// tbAddress
			// 
			this.tbAddress.BorderRadius = 5;
			this.tbAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbAddress.DefaultText = "";
			this.tbAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbAddress.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.tbAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbAddress.Location = new System.Drawing.Point(20, 199);
			this.tbAddress.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
			this.tbAddress.Name = "tbAddress";
			this.tbAddress.PasswordChar = '\0';
			this.tbAddress.PlaceholderText = "Địa chỉ ...";
			this.tbAddress.SelectedText = "";
			this.tbAddress.Size = new System.Drawing.Size(330, 36);
			this.tbAddress.TabIndex = 27;
			// 
			// lbBack
			// 
			this.lbBack.AutoSize = true;
			this.lbBack.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.lbBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(85)))));
			this.lbBack.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
			this.lbBack.LinkColor = System.Drawing.Color.Navy;
			this.lbBack.Location = new System.Drawing.Point(3, 0);
			this.lbBack.Name = "lbBack";
			this.lbBack.Size = new System.Drawing.Size(82, 21);
			this.lbBack.TabIndex = 26;
			this.lbBack.TabStop = true;
			this.lbBack.Text = "< Quay lại";
			this.lbBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbBack_LinkClicked);
			this.lbBack.MouseEnter += new System.EventHandler(this.lbBack_MouseEnter);
			this.lbBack.MouseLeave += new System.EventHandler(this.lbBack_MouseLeave);
			// 
			// btnCreate
			// 
			this.btnCreate.BorderRadius = 5;
			this.btnCreate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnCreate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnCreate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnCreate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnCreate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCreate.ForeColor = System.Drawing.Color.White;
			this.btnCreate.Location = new System.Drawing.Point(250, 367);
			this.btnCreate.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(100, 35);
			this.btnCreate.TabIndex = 25;
			this.btnCreate.Text = "Tạo";
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			// 
			// tbSDT
			// 
			this.tbSDT.BorderRadius = 5;
			this.tbSDT.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbSDT.DefaultText = "";
			this.tbSDT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbSDT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbSDT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbSDT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbSDT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbSDT.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.tbSDT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbSDT.Location = new System.Drawing.Point(20, 255);
			this.tbSDT.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
			this.tbSDT.Name = "tbSDT";
			this.tbSDT.PasswordChar = '\0';
			this.tbSDT.PlaceholderText = "Số điện thoại ...";
			this.tbSDT.SelectedText = "";
			this.tbSDT.Size = new System.Drawing.Size(330, 36);
			this.tbSDT.TabIndex = 11;
			// 
			// tbName
			// 
			this.tbName.BorderRadius = 5;
			this.tbName.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbName.DefaultText = "";
			this.tbName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbName.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.tbName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbName.Location = new System.Drawing.Point(20, 143);
			this.tbName.Margin = new System.Windows.Forms.Padding(20, 10, 20, 10);
			this.tbName.Name = "tbName";
			this.tbName.PasswordChar = '\0';
			this.tbName.PlaceholderText = "Họ và tên ...";
			this.tbName.SelectedText = "";
			this.tbName.Size = new System.Drawing.Size(330, 36);
			this.tbName.TabIndex = 10;
			// 
			// lbTitleInfo
			// 
			this.lbTitleInfo.AutoSize = true;
			this.lbTitleInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTitleInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
			this.lbTitleInfo.Location = new System.Drawing.Point(6, 108);
			this.lbTitleInfo.Name = "lbTitleInfo";
			this.lbTitleInfo.Size = new System.Drawing.Size(160, 21);
			this.lbTitleInfo.TabIndex = 9;
			this.lbTitleInfo.Text = "Thông tin tài khoản";
			// 
			// lbTitle
			// 
			this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
			this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(85)))));
			this.lbTitle.Location = new System.Drawing.Point(3, 21);
			this.lbTitle.Name = "lbTitle";
			this.lbTitle.Size = new System.Drawing.Size(364, 76);
			this.lbTitle.TabIndex = 8;
			this.lbTitle.Text = "Đăng ký thông tin tài khoản cửa hàng";
			this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// errorProviderWar
			// 
			this.errorProviderWar.ContainerControl = this;
			// 
			// NewAccountPopup
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Name = "NewAccountPopup";
			this.Size = new System.Drawing.Size(400, 445);
			this.Load += new System.EventHandler(this.NewStaffPopup_Load);
			this.Content.ResumeLayout(false);
			this.pnlContent.ResumeLayout(false);
			this.pnlContent.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderWar)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlContent;
		private Guna.UI2.WinForms.Guna2TextBox tbSDT;
		private Guna.UI2.WinForms.Guna2TextBox tbName;
		private System.Windows.Forms.Label lbTitleInfo;
		private System.Windows.Forms.Label lbTitle;
		private Guna.UI2.WinForms.Guna2Button btnCreate;
		private System.Windows.Forms.LinkLabel lbBack;
		private System.Windows.Forms.ErrorProvider errorProviderWar;
		private Guna.UI2.WinForms.Guna2ComboBox cbRole;
		private Guna.UI2.WinForms.Guna2TextBox tbAddress;
	}
}
