namespace BookStore.ChildForm
{
	partial class AccountPopup
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
			this.pnlContent = new System.Windows.Forms.Panel();
			this.flpDetailsStaff = new System.Windows.Forms.FlowLayoutPanel();
			this.pnlInfoChange = new Guna.UI2.WinForms.Guna2Panel();
			this.lbTotalStaff = new System.Windows.Forms.Label();
			this.pnlNav = new Guna.UI2.WinForms.Guna2Panel();
			this.btnNewStaff = new FontAwesome.Sharp.IconButton();
			this.tbSearch = new Guna.UI2.WinForms.Guna2TextBox();
			this.btnClosePopup = new FontAwesome.Sharp.IconButton();
			this.Content.SuspendLayout();
			this.pnlContent.SuspendLayout();
			this.pnlInfoChange.SuspendLayout();
			this.pnlNav.SuspendLayout();
			this.SuspendLayout();
			// 
			// Content
			// 
			this.Content.Controls.Add(this.btnClosePopup);
			this.Content.Controls.Add(this.pnlContent);
			this.Content.Padding = new System.Windows.Forms.Padding(50);
			this.Content.Size = new System.Drawing.Size(1465, 600);
			// 
			// pnlContent
			// 
			this.pnlContent.Controls.Add(this.flpDetailsStaff);
			this.pnlContent.Controls.Add(this.pnlInfoChange);
			this.pnlContent.Controls.Add(this.pnlNav);
			this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlContent.Location = new System.Drawing.Point(50, 50);
			this.pnlContent.Margin = new System.Windows.Forms.Padding(0);
			this.pnlContent.Name = "pnlContent";
			this.pnlContent.Size = new System.Drawing.Size(1365, 500);
			this.pnlContent.TabIndex = 0;
			// 
			// flpDetailsStaff
			// 
			this.flpDetailsStaff.AutoScroll = true;
			this.flpDetailsStaff.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flpDetailsStaff.Location = new System.Drawing.Point(0, 80);
			this.flpDetailsStaff.Margin = new System.Windows.Forms.Padding(0);
			this.flpDetailsStaff.Name = "flpDetailsStaff";
			this.flpDetailsStaff.Padding = new System.Windows.Forms.Padding(10);
			this.flpDetailsStaff.Size = new System.Drawing.Size(1365, 360);
			this.flpDetailsStaff.TabIndex = 17;
			// 
			// pnlInfoChange
			// 
			this.pnlInfoChange.BackColor = System.Drawing.Color.Transparent;
			this.pnlInfoChange.BorderRadius = 5;
			this.pnlInfoChange.Controls.Add(this.lbTotalStaff);
			this.pnlInfoChange.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pnlInfoChange.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
			this.pnlInfoChange.Location = new System.Drawing.Point(0, 440);
			this.pnlInfoChange.Margin = new System.Windows.Forms.Padding(0);
			this.pnlInfoChange.Name = "pnlInfoChange";
			this.pnlInfoChange.Size = new System.Drawing.Size(1365, 60);
			this.pnlInfoChange.TabIndex = 1;
			// 
			// lbTotalStaff
			// 
			this.lbTotalStaff.AutoSize = true;
			this.lbTotalStaff.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.lbTotalStaff.ForeColor = System.Drawing.Color.DimGray;
			this.lbTotalStaff.Location = new System.Drawing.Point(20, 20);
			this.lbTotalStaff.Margin = new System.Windows.Forms.Padding(20);
			this.lbTotalStaff.Name = "lbTotalStaff";
			this.lbTotalStaff.Size = new System.Drawing.Size(99, 21);
			this.lbTotalStaff.TabIndex = 0;
			this.lbTotalStaff.Text = "Account: 62";
			// 
			// pnlNav
			// 
			this.pnlNav.BackColor = System.Drawing.Color.Transparent;
			this.pnlNav.BorderRadius = 5;
			this.pnlNav.Controls.Add(this.btnNewStaff);
			this.pnlNav.Controls.Add(this.tbSearch);
			this.pnlNav.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlNav.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
			this.pnlNav.Location = new System.Drawing.Point(0, 0);
			this.pnlNav.Margin = new System.Windows.Forms.Padding(0);
			this.pnlNav.Name = "pnlNav";
			this.pnlNav.Size = new System.Drawing.Size(1365, 80);
			this.pnlNav.TabIndex = 0;
			// 
			// btnNewStaff
			// 
			this.btnNewStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(85)))));
			this.btnNewStaff.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNewStaff.FlatAppearance.BorderSize = 0;
			this.btnNewStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNewStaff.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNewStaff.ForeColor = System.Drawing.Color.White;
			this.btnNewStaff.IconChar = FontAwesome.Sharp.IconChar.Plus;
			this.btnNewStaff.IconColor = System.Drawing.Color.White;
			this.btnNewStaff.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnNewStaff.IconSize = 28;
			this.btnNewStaff.Location = new System.Drawing.Point(1305, 20);
			this.btnNewStaff.Margin = new System.Windows.Forms.Padding(20);
			this.btnNewStaff.Name = "btnNewStaff";
			this.btnNewStaff.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
			this.btnNewStaff.Size = new System.Drawing.Size(40, 40);
			this.btnNewStaff.TabIndex = 17;
			this.btnNewStaff.TabStop = false;
			this.btnNewStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnNewStaff.UseVisualStyleBackColor = false;
			// 
			// tbSearch
			// 
			this.tbSearch.BorderColor = System.Drawing.Color.Gray;
			this.tbSearch.BorderRadius = 10;
			this.tbSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbSearch.DefaultText = "";
			this.tbSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbSearch.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbSearch.ForeColor = System.Drawing.Color.Black;
			this.tbSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbSearch.IconLeft = global::BookStore.Properties.Resources.searchIcon;
			this.tbSearch.IconLeftSize = new System.Drawing.Size(30, 30);
			this.tbSearch.IconRightCursor = System.Windows.Forms.Cursors.Hand;
			this.tbSearch.Location = new System.Drawing.Point(20, 20);
			this.tbSearch.Margin = new System.Windows.Forms.Padding(20);
			this.tbSearch.Name = "tbSearch";
			this.tbSearch.PasswordChar = '\0';
			this.tbSearch.PlaceholderText = "Tìm kiếm tài khoản ...";
			this.tbSearch.SelectedText = "";
			this.tbSearch.Size = new System.Drawing.Size(400, 40);
			this.tbSearch.TabIndex = 16;
			this.tbSearch.TabStop = false;
			// 
			// btnClosePopup
			// 
			this.btnClosePopup.AutoSize = true;
			this.btnClosePopup.BackColor = System.Drawing.Color.Transparent;
			this.btnClosePopup.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnClosePopup.FlatAppearance.BorderSize = 0;
			this.btnClosePopup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClosePopup.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
			this.btnClosePopup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(69)))));
			this.btnClosePopup.IconChar = FontAwesome.Sharp.IconChar.Times;
			this.btnClosePopup.IconColor = System.Drawing.Color.Black;
			this.btnClosePopup.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.btnClosePopup.IconSize = 20;
			this.btnClosePopup.Location = new System.Drawing.Point(1434, 0);
			this.btnClosePopup.Margin = new System.Windows.Forms.Padding(0);
			this.btnClosePopup.Name = "btnClosePopup";
			this.btnClosePopup.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
			this.btnClosePopup.Size = new System.Drawing.Size(31, 31);
			this.btnClosePopup.TabIndex = 18;
			this.btnClosePopup.TabStop = false;
			this.btnClosePopup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnClosePopup.UseVisualStyleBackColor = false;
			this.btnClosePopup.Click += new System.EventHandler(this.btnClosePopup_Click);
			// 
			// StaffPopup
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Name = "StaffPopup";
			this.Size = new System.Drawing.Size(1465, 600);
			this.Content.ResumeLayout(false);
			this.Content.PerformLayout();
			this.pnlContent.ResumeLayout(false);
			this.pnlInfoChange.ResumeLayout(false);
			this.pnlInfoChange.PerformLayout();
			this.pnlNav.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlContent;
		private Guna.UI2.WinForms.Guna2Panel pnlNav;
		private Guna.UI2.WinForms.Guna2Panel pnlInfoChange;
		private System.Windows.Forms.Label lbTotalStaff;
		private Guna.UI2.WinForms.Guna2TextBox tbSearch;
		private System.Windows.Forms.FlowLayoutPanel flpDetailsStaff;
		private FontAwesome.Sharp.IconButton btnClosePopup;
		public FontAwesome.Sharp.IconButton btnNewStaff;
	}
}
