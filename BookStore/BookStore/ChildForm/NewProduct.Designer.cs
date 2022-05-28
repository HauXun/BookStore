namespace BookStore.ChildForm
{
	partial class NewProduct
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
			this.label1 = new System.Windows.Forms.Label();
			this.cbTableName = new Guna.UI2.WinForms.Guna2ComboBox();
			this.lbTitle = new System.Windows.Forms.Label();
			this.errorProviderWar = new System.Windows.Forms.ErrorProvider(this.components);
			this.lbBack = new System.Windows.Forms.LinkLabel();
			this.flpInputControl = new System.Windows.Forms.FlowLayoutPanel();
			this.tableBox = new System.Windows.Forms.TableLayoutPanel();
			this.pnlBox3 = new Guna.UI2.WinForms.Guna2Panel();
			this.pnlDetail3 = new Guna.UI2.WinForms.Guna2Panel();
			this.tbUnit = new Guna.UI2.WinForms.Guna2TextBox();
			this.lbTitleDetail3 = new System.Windows.Forms.Label();
			this.pnlBox2 = new Guna.UI2.WinForms.Guna2Panel();
			this.pnlDetail2 = new Guna.UI2.WinForms.Guna2Panel();
			this.tbBrand = new Guna.UI2.WinForms.Guna2TextBox();
			this.lbTitleDetail2 = new System.Windows.Forms.Label();
			this.pnlBox1 = new Guna.UI2.WinForms.Guna2Panel();
			this.pnlDetail1 = new Guna.UI2.WinForms.Guna2Panel();
			this.tbProductName = new Guna.UI2.WinForms.Guna2TextBox();
			this.lbTitleDetail1 = new System.Windows.Forms.Label();
			this.guna2Panel6 = new Guna.UI2.WinForms.Guna2Panel();
			this.btnCreate = new Guna.UI2.WinForms.Guna2Button();
			this.Content.SuspendLayout();
			this.pnlHeader.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderWar)).BeginInit();
			this.flpInputControl.SuspendLayout();
			this.tableBox.SuspendLayout();
			this.pnlBox3.SuspendLayout();
			this.pnlDetail3.SuspendLayout();
			this.pnlBox2.SuspendLayout();
			this.pnlDetail2.SuspendLayout();
			this.pnlBox1.SuspendLayout();
			this.pnlDetail1.SuspendLayout();
			this.guna2Panel6.SuspendLayout();
			this.SuspendLayout();
			// 
			// Content
			// 
			this.Content.Controls.Add(this.lbBack);
			this.Content.Controls.Add(this.flpInputControl);
			this.Content.Controls.Add(this.guna2Panel6);
			this.Content.Controls.Add(this.pnlHeader);
			this.Content.Margin = new System.Windows.Forms.Padding(0);
			this.Content.Padding = new System.Windows.Forms.Padding(50);
			this.Content.Size = new System.Drawing.Size(1050, 511);
			// 
			// pnlHeader
			// 
			this.pnlHeader.BackColor = System.Drawing.Color.Transparent;
			this.pnlHeader.Controls.Add(this.label1);
			this.pnlHeader.Controls.Add(this.cbTableName);
			this.pnlHeader.Controls.Add(this.lbTitle);
			this.pnlHeader.FillColor = System.Drawing.Color.White;
			this.pnlHeader.Location = new System.Drawing.Point(50, 50);
			this.pnlHeader.Margin = new System.Windows.Forms.Padding(0);
			this.pnlHeader.Name = "pnlHeader";
			this.pnlHeader.Size = new System.Drawing.Size(950, 91);
			this.pnlHeader.TabIndex = 22;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label1.Location = new System.Drawing.Point(2, 36);
			this.label1.Margin = new System.Windows.Forms.Padding(0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 19);
			this.label1.TabIndex = 100;
			this.label1.Text = "Phân loại";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cbTableName
			// 
			this.cbTableName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.cbTableName.BackColor = System.Drawing.Color.Transparent;
			this.cbTableName.BorderRadius = 5;
			this.cbTableName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbTableName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbTableName.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbTableName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbTableName.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.cbTableName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
			this.cbTableName.ItemHeight = 30;
			this.cbTableName.Location = new System.Drawing.Point(0, 55);
			this.cbTableName.Margin = new System.Windows.Forms.Padding(0);
			this.cbTableName.Name = "cbTableName";
			this.cbTableName.Size = new System.Drawing.Size(245, 36);
			this.cbTableName.TabIndex = 99;
			this.cbTableName.SelectedIndexChanged += new System.EventHandler(this.cbTableName_SelectedIndexChanged);
			// 
			// lbTitle
			// 
			this.lbTitle.AutoSize = true;
			this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.lbTitle.Location = new System.Drawing.Point(705, 0);
			this.lbTitle.Margin = new System.Windows.Forms.Padding(0);
			this.lbTitle.Name = "lbTitle";
			this.lbTitle.Size = new System.Drawing.Size(245, 32);
			this.lbTitle.TabIndex = 0;
			this.lbTitle.Text = "Thêm mới sản phẩm";
			this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// errorProviderWar
			// 
			this.errorProviderWar.ContainerControl = this;
			// 
			// lbBack
			// 
			this.lbBack.AutoSize = true;
			this.lbBack.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.lbBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(85)))));
			this.lbBack.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
			this.lbBack.LinkColor = System.Drawing.Color.Navy;
			this.lbBack.Location = new System.Drawing.Point(918, 20);
			this.lbBack.Margin = new System.Windows.Forms.Padding(50, 20, 50, 0);
			this.lbBack.Name = "lbBack";
			this.lbBack.Size = new System.Drawing.Size(82, 21);
			this.lbBack.TabIndex = 98;
			this.lbBack.TabStop = true;
			this.lbBack.Text = "< Quay lại";
			this.lbBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbBack_LinkClicked);
			this.lbBack.MouseEnter += new System.EventHandler(this.lbBack_MouseEnter);
			this.lbBack.MouseLeave += new System.EventHandler(this.lbBack_MouseLeave);
			// 
			// flpInputControl
			// 
			this.flpInputControl.AutoScroll = true;
			this.flpInputControl.Controls.Add(this.tableBox);
			this.flpInputControl.Location = new System.Drawing.Point(50, 151);
			this.flpInputControl.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
			this.flpInputControl.Name = "flpInputControl";
			this.flpInputControl.Size = new System.Drawing.Size(950, 260);
			this.flpInputControl.TabIndex = 99;
			// 
			// tableBox
			// 
			this.tableBox.AutoSize = true;
			this.tableBox.ColumnCount = 3;
			this.tableBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableBox.Controls.Add(this.pnlBox3, 2, 0);
			this.tableBox.Controls.Add(this.pnlBox2, 1, 0);
			this.tableBox.Controls.Add(this.pnlBox1, 0, 0);
			this.tableBox.Location = new System.Drawing.Point(0, 0);
			this.tableBox.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
			this.tableBox.Name = "tableBox";
			this.tableBox.RowCount = 1;
			this.tableBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableBox.Size = new System.Drawing.Size(930, 66);
			this.tableBox.TabIndex = 100;
			// 
			// pnlBox3
			// 
			this.pnlBox3.AutoSize = true;
			this.pnlBox3.Controls.Add(this.pnlDetail3);
			this.pnlBox3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlBox3.Location = new System.Drawing.Point(620, 0);
			this.pnlBox3.Margin = new System.Windows.Forms.Padding(0);
			this.pnlBox3.Name = "pnlBox3";
			this.pnlBox3.Size = new System.Drawing.Size(310, 66);
			this.pnlBox3.TabIndex = 100;
			// 
			// pnlDetail3
			// 
			this.pnlDetail3.AutoSize = true;
			this.pnlDetail3.Controls.Add(this.tbUnit);
			this.pnlDetail3.Controls.Add(this.lbTitleDetail3);
			this.pnlDetail3.Location = new System.Drawing.Point(10, 5);
			this.pnlDetail3.Margin = new System.Windows.Forms.Padding(10, 5, 0, 0);
			this.pnlDetail3.Name = "pnlDetail3";
			this.pnlDetail3.Size = new System.Drawing.Size(292, 61);
			this.pnlDetail3.TabIndex = 113;
			// 
			// tbUnit
			// 
			this.tbUnit.Animated = true;
			this.tbUnit.BorderRadius = 5;
			this.tbUnit.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbUnit.DefaultText = "";
			this.tbUnit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbUnit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbUnit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbUnit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbUnit.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.tbUnit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbUnit.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.tbUnit.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbUnit.Location = new System.Drawing.Point(0, 25);
			this.tbUnit.Margin = new System.Windows.Forms.Padding(0);
			this.tbUnit.Name = "tbUnit";
			this.tbUnit.PasswordChar = '\0';
			this.tbUnit.PlaceholderText = "";
			this.tbUnit.SelectedText = "";
			this.tbUnit.Size = new System.Drawing.Size(292, 36);
			this.tbUnit.TabIndex = 97;
			// 
			// lbTitleDetail3
			// 
			this.lbTitleDetail3.AutoSize = true;
			this.lbTitleDetail3.Dock = System.Windows.Forms.DockStyle.Top;
			this.lbTitleDetail3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.lbTitleDetail3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(69)))));
			this.lbTitleDetail3.Location = new System.Drawing.Point(0, 0);
			this.lbTitleDetail3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.lbTitleDetail3.Name = "lbTitleDetail3";
			this.lbTitleDetail3.Size = new System.Drawing.Size(97, 19);
			this.lbTitleDetail3.TabIndex = 96;
			this.lbTitleDetail3.Text = "Đơn vị tính";
			// 
			// pnlBox2
			// 
			this.pnlBox2.AutoSize = true;
			this.pnlBox2.Controls.Add(this.pnlDetail2);
			this.pnlBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlBox2.Location = new System.Drawing.Point(310, 0);
			this.pnlBox2.Margin = new System.Windows.Forms.Padding(0);
			this.pnlBox2.Name = "pnlBox2";
			this.pnlBox2.Size = new System.Drawing.Size(310, 66);
			this.pnlBox2.TabIndex = 99;
			// 
			// pnlDetail2
			// 
			this.pnlDetail2.AutoSize = true;
			this.pnlDetail2.Controls.Add(this.tbBrand);
			this.pnlDetail2.Controls.Add(this.lbTitleDetail2);
			this.pnlDetail2.Location = new System.Drawing.Point(10, 5);
			this.pnlDetail2.Margin = new System.Windows.Forms.Padding(10, 5, 10, 0);
			this.pnlDetail2.Name = "pnlDetail2";
			this.pnlDetail2.Size = new System.Drawing.Size(289, 61);
			this.pnlDetail2.TabIndex = 113;
			// 
			// tbBrand
			// 
			this.tbBrand.Animated = true;
			this.tbBrand.BorderRadius = 5;
			this.tbBrand.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbBrand.DefaultText = "";
			this.tbBrand.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbBrand.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbBrand.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbBrand.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbBrand.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.tbBrand.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbBrand.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.tbBrand.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbBrand.Location = new System.Drawing.Point(0, 25);
			this.tbBrand.Margin = new System.Windows.Forms.Padding(0);
			this.tbBrand.Name = "tbBrand";
			this.tbBrand.PasswordChar = '\0';
			this.tbBrand.PlaceholderText = "";
			this.tbBrand.SelectedText = "";
			this.tbBrand.Size = new System.Drawing.Size(289, 36);
			this.tbBrand.TabIndex = 99;
			// 
			// lbTitleDetail2
			// 
			this.lbTitleDetail2.AutoSize = true;
			this.lbTitleDetail2.Dock = System.Windows.Forms.DockStyle.Top;
			this.lbTitleDetail2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.lbTitleDetail2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(69)))));
			this.lbTitleDetail2.Location = new System.Drawing.Point(0, 0);
			this.lbTitleDetail2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.lbTitleDetail2.Name = "lbTitleDetail2";
			this.lbTitleDetail2.Size = new System.Drawing.Size(111, 19);
			this.lbTitleDetail2.TabIndex = 98;
			this.lbTitleDetail2.Text = "Thương hiệu";
			// 
			// pnlBox1
			// 
			this.pnlBox1.AutoSize = true;
			this.pnlBox1.Controls.Add(this.pnlDetail1);
			this.pnlBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlBox1.Location = new System.Drawing.Point(0, 0);
			this.pnlBox1.Margin = new System.Windows.Forms.Padding(0);
			this.pnlBox1.Name = "pnlBox1";
			this.pnlBox1.Size = new System.Drawing.Size(310, 66);
			this.pnlBox1.TabIndex = 97;
			// 
			// pnlDetail1
			// 
			this.pnlDetail1.AutoSize = true;
			this.pnlDetail1.Controls.Add(this.tbProductName);
			this.pnlDetail1.Controls.Add(this.lbTitleDetail1);
			this.pnlDetail1.Location = new System.Drawing.Point(1, 5);
			this.pnlDetail1.Margin = new System.Windows.Forms.Padding(0, 5, 10, 0);
			this.pnlDetail1.Name = "pnlDetail1";
			this.pnlDetail1.Size = new System.Drawing.Size(299, 61);
			this.pnlDetail1.TabIndex = 115;
			// 
			// tbProductName
			// 
			this.tbProductName.Animated = true;
			this.tbProductName.BorderRadius = 5;
			this.tbProductName.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbProductName.DefaultText = "";
			this.tbProductName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbProductName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbProductName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbProductName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbProductName.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.tbProductName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbProductName.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.tbProductName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbProductName.Location = new System.Drawing.Point(0, 25);
			this.tbProductName.Margin = new System.Windows.Forms.Padding(0);
			this.tbProductName.Name = "tbProductName";
			this.tbProductName.PasswordChar = '\0';
			this.tbProductName.PlaceholderText = "";
			this.tbProductName.SelectedText = "";
			this.tbProductName.Size = new System.Drawing.Size(299, 36);
			this.tbProductName.TabIndex = 99;
			// 
			// lbTitleDetail1
			// 
			this.lbTitleDetail1.AutoSize = true;
			this.lbTitleDetail1.Dock = System.Windows.Forms.DockStyle.Top;
			this.lbTitleDetail1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.lbTitleDetail1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(69)))));
			this.lbTitleDetail1.Location = new System.Drawing.Point(0, 0);
			this.lbTitleDetail1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.lbTitleDetail1.Name = "lbTitleDetail1";
			this.lbTitleDetail1.Size = new System.Drawing.Size(123, 19);
			this.lbTitleDetail1.TabIndex = 98;
			this.lbTitleDetail1.Text = "Tên sản phẩm";
			// 
			// guna2Panel6
			// 
			this.guna2Panel6.Controls.Add(this.btnCreate);
			this.guna2Panel6.Location = new System.Drawing.Point(50, 421);
			this.guna2Panel6.Margin = new System.Windows.Forms.Padding(0);
			this.guna2Panel6.Name = "guna2Panel6";
			this.guna2Panel6.Size = new System.Drawing.Size(950, 41);
			this.guna2Panel6.TabIndex = 100;
			// 
			// btnCreate
			// 
			this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCreate.Animated = true;
			this.btnCreate.BorderRadius = 5;
			this.btnCreate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnCreate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnCreate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnCreate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.btnCreate.ForeColor = System.Drawing.Color.White;
			this.btnCreate.Location = new System.Drawing.Point(824, 3);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(123, 35);
			this.btnCreate.TabIndex = 0;
			this.btnCreate.Text = "Thêm mới";
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			// 
			// NewProduct
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Margin = new System.Windows.Forms.Padding(0);
			this.Name = "NewProduct";
			this.Size = new System.Drawing.Size(1050, 511);
			this.Load += new System.EventHandler(this.NewProduct_Load);
			this.Content.ResumeLayout(false);
			this.Content.PerformLayout();
			this.pnlHeader.ResumeLayout(false);
			this.pnlHeader.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProviderWar)).EndInit();
			this.flpInputControl.ResumeLayout(false);
			this.flpInputControl.PerformLayout();
			this.tableBox.ResumeLayout(false);
			this.tableBox.PerformLayout();
			this.pnlBox3.ResumeLayout(false);
			this.pnlBox3.PerformLayout();
			this.pnlDetail3.ResumeLayout(false);
			this.pnlDetail3.PerformLayout();
			this.pnlBox2.ResumeLayout(false);
			this.pnlBox2.PerformLayout();
			this.pnlDetail2.ResumeLayout(false);
			this.pnlDetail2.PerformLayout();
			this.pnlBox1.ResumeLayout(false);
			this.pnlBox1.PerformLayout();
			this.pnlDetail1.ResumeLayout(false);
			this.pnlDetail1.PerformLayout();
			this.guna2Panel6.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2Panel pnlHeader;
		private System.Windows.Forms.Label lbTitle;
		private System.Windows.Forms.ErrorProvider errorProviderWar;
		private System.Windows.Forms.LinkLabel lbBack;
		private System.Windows.Forms.FlowLayoutPanel flpInputControl;
		private Guna.UI2.WinForms.Guna2Panel guna2Panel6;
		private Guna.UI2.WinForms.Guna2Button btnCreate;
		private System.Windows.Forms.Label label1;
		private Guna.UI2.WinForms.Guna2ComboBox cbTableName;
		public System.Windows.Forms.TableLayoutPanel tableBox;
		private Guna.UI2.WinForms.Guna2Panel pnlBox3;
		private Guna.UI2.WinForms.Guna2Panel pnlDetail3;
		private System.Windows.Forms.Label lbTitleDetail3;
		private Guna.UI2.WinForms.Guna2Panel pnlBox2;
		private Guna.UI2.WinForms.Guna2Panel pnlDetail2;
		private System.Windows.Forms.Label lbTitleDetail2;
		private Guna.UI2.WinForms.Guna2Panel pnlBox1;
		private Guna.UI2.WinForms.Guna2Panel pnlDetail1;
		private System.Windows.Forms.Label lbTitleDetail1;
		private Guna.UI2.WinForms.Guna2TextBox tbUnit;
		private Guna.UI2.WinForms.Guna2TextBox tbBrand;
		private Guna.UI2.WinForms.Guna2TextBox tbProductName;
	}
}
