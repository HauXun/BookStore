namespace BookStore.ChildForm
{
	partial class NewDoiTacKhachHang
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
			this.lbBack = new System.Windows.Forms.LinkLabel();
			this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
			this.tbSDT = new Guna.UI2.WinForms.Guna2TextBox();
			this.tbAdress = new Guna.UI2.WinForms.Guna2TextBox();
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
			this.Content.Margin = new System.Windows.Forms.Padding(0);
			this.Content.Size = new System.Drawing.Size(420, 400);
			// 
			// pnlContent
			// 
			this.pnlContent.Controls.Add(this.lbBack);
			this.pnlContent.Controls.Add(this.btnAdd);
			this.pnlContent.Controls.Add(this.tbSDT);
			this.pnlContent.Controls.Add(this.tbAdress);
			this.pnlContent.Controls.Add(this.tbName);
			this.pnlContent.Controls.Add(this.lbTitleInfo);
			this.pnlContent.Controls.Add(this.lbTitle);
			this.pnlContent.Location = new System.Drawing.Point(20, 20);
			this.pnlContent.Margin = new System.Windows.Forms.Padding(20);
			this.pnlContent.Name = "pnlContent";
			this.pnlContent.Size = new System.Drawing.Size(380, 360);
			this.pnlContent.TabIndex = 3;
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
			// btnAdd
			// 
			this.btnAdd.BorderRadius = 5;
			this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnAdd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAdd.ForeColor = System.Drawing.Color.White;
			this.btnAdd.Location = new System.Drawing.Point(270, 311);
			this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(100, 35);
			this.btnAdd.TabIndex = 25;
			this.btnAdd.Text = "Thêm";
			this.btnAdd.Click += new System.EventHandler(this.btnCreate_Click);
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
			this.tbSDT.Location = new System.Drawing.Point(10, 255);
			this.tbSDT.Margin = new System.Windows.Forms.Padding(3, 10, 10, 10);
			this.tbSDT.Name = "tbSDT";
			this.tbSDT.PasswordChar = '\0';
			this.tbSDT.PlaceholderText = "Số điện thoại ...";
			this.tbSDT.SelectedText = "";
			this.tbSDT.Size = new System.Drawing.Size(360, 36);
			this.tbSDT.TabIndex = 12;
			// 
			// tbAdress
			// 
			this.tbAdress.BorderRadius = 5;
			this.tbAdress.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbAdress.DefaultText = "";
			this.tbAdress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbAdress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbAdress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbAdress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbAdress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbAdress.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.tbAdress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbAdress.Location = new System.Drawing.Point(10, 199);
			this.tbAdress.Margin = new System.Windows.Forms.Padding(3, 10, 10, 10);
			this.tbAdress.Name = "tbAdress";
			this.tbAdress.PasswordChar = '\0';
			this.tbAdress.PlaceholderText = "Địa chỉ ...";
			this.tbAdress.SelectedText = "";
			this.tbAdress.Size = new System.Drawing.Size(360, 36);
			this.tbAdress.TabIndex = 11;
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
			this.tbName.Location = new System.Drawing.Point(10, 143);
			this.tbName.Margin = new System.Windows.Forms.Padding(3, 10, 10, 10);
			this.tbName.Name = "tbName";
			this.tbName.PasswordChar = '\0';
			this.tbName.PlaceholderText = "Tên khách hàng/ Đối tác/ Nhà cung cấp ...";
			this.tbName.SelectedText = "";
			this.tbName.Size = new System.Drawing.Size(360, 36);
			this.tbName.TabIndex = 10;
			// 
			// lbTitleInfo
			// 
			this.lbTitleInfo.AutoSize = true;
			this.lbTitleInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTitleInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
			this.lbTitleInfo.Location = new System.Drawing.Point(6, 108);
			this.lbTitleInfo.Name = "lbTitleInfo";
			this.lbTitleInfo.Size = new System.Drawing.Size(84, 21);
			this.lbTitleInfo.TabIndex = 9;
			this.lbTitleInfo.Text = "Thông tin";
			// 
			// lbTitle
			// 
			this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
			this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(85)))));
			this.lbTitle.Location = new System.Drawing.Point(3, 21);
			this.lbTitle.Name = "lbTitle";
			this.lbTitle.Size = new System.Drawing.Size(374, 76);
			this.lbTitle.TabIndex = 8;
			this.lbTitle.Text = "Đăng ký thông tin Khách hàng Đối tác - Nhà cung cấp";
			this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// errorProviderWar
			// 
			this.errorProviderWar.ContainerControl = this;
			// 
			// NewDoiTacKhachHang
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Name = "NewDoiTacKhachHang";
			this.Size = new System.Drawing.Size(420, 400);
			this.Content.ResumeLayout(false);
			this.pnlContent.ResumeLayout(false);
			this.pnlContent.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderWar)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlContent;
		private Guna.UI2.WinForms.Guna2TextBox tbSDT;
		private Guna.UI2.WinForms.Guna2TextBox tbAdress;
		private Guna.UI2.WinForms.Guna2TextBox tbName;
		private System.Windows.Forms.Label lbTitleInfo;
		private System.Windows.Forms.Label lbTitle;
		private Guna.UI2.WinForms.Guna2Button btnAdd;
		private System.Windows.Forms.LinkLabel lbBack;
		private System.Windows.Forms.ErrorProvider errorProviderWar;
	}
}
