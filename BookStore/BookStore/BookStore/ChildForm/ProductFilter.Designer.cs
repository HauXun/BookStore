namespace BookStore.ChildForm
{
	partial class ProductFilter
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
			this.lbBack = new System.Windows.Forms.LinkLabel();
			this.flpFilterControl = new System.Windows.Forms.FlowLayoutPanel();
			this.guna2Panel6 = new Guna.UI2.WinForms.Guna2Panel();
			this.btnApplyFilter = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
			this.cbTableName = new Guna.UI2.WinForms.Guna2ComboBox();
			this.Content.SuspendLayout();
			this.guna2Panel6.SuspendLayout();
			this.guna2Panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// Content
			// 
			this.Content.Controls.Add(this.guna2Panel1);
			this.Content.Controls.Add(this.lbBack);
			this.Content.Controls.Add(this.flpFilterControl);
			this.Content.Controls.Add(this.guna2Panel6);
			this.Content.Margin = new System.Windows.Forms.Padding(0);
			this.Content.Padding = new System.Windows.Forms.Padding(50);
			this.Content.Size = new System.Drawing.Size(1011, 600);
			// 
			// lbBack
			// 
			this.lbBack.AutoSize = true;
			this.lbBack.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.lbBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(85)))));
			this.lbBack.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
			this.lbBack.LinkColor = System.Drawing.Color.Navy;
			this.lbBack.Location = new System.Drawing.Point(50, 20);
			this.lbBack.Margin = new System.Windows.Forms.Padding(50, 20, 0, 0);
			this.lbBack.Name = "lbBack";
			this.lbBack.Size = new System.Drawing.Size(82, 21);
			this.lbBack.TabIndex = 29;
			this.lbBack.TabStop = true;
			this.lbBack.Text = "< Quay lại";
			this.lbBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbBack_LinkClicked);
			this.lbBack.MouseEnter += new System.EventHandler(this.lbBack_MouseEnter);
			this.lbBack.MouseLeave += new System.EventHandler(this.lbBack_MouseLeave);
			// 
			// flpFilterControl
			// 
			this.flpFilterControl.AutoScroll = true;
			this.flpFilterControl.Location = new System.Drawing.Point(50, 101);
			this.flpFilterControl.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.flpFilterControl.Name = "flpFilterControl";
			this.flpFilterControl.Size = new System.Drawing.Size(910, 398);
			this.flpFilterControl.TabIndex = 30;
			// 
			// guna2Panel6
			// 
			this.guna2Panel6.Controls.Add(this.btnApplyFilter);
			this.guna2Panel6.Location = new System.Drawing.Point(50, 509);
			this.guna2Panel6.Margin = new System.Windows.Forms.Padding(0);
			this.guna2Panel6.Name = "guna2Panel6";
			this.guna2Panel6.Size = new System.Drawing.Size(910, 41);
			this.guna2Panel6.TabIndex = 96;
			// 
			// btnApplyFilter
			// 
			this.btnApplyFilter.Animated = true;
			this.btnApplyFilter.BorderRadius = 5;
			this.btnApplyFilter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnApplyFilter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnApplyFilter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnApplyFilter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnApplyFilter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
			this.btnApplyFilter.ForeColor = System.Drawing.Color.White;
			this.btnApplyFilter.Location = new System.Drawing.Point(784, 3);
			this.btnApplyFilter.Name = "btnApplyFilter";
			this.btnApplyFilter.Size = new System.Drawing.Size(123, 35);
			this.btnApplyFilter.TabIndex = 0;
			this.btnApplyFilter.Text = "Áp dụng";
			this.btnApplyFilter.Click += new System.EventHandler(this.btnApplyFilter_Click);
			// 
			// guna2Panel1
			// 
			this.guna2Panel1.Controls.Add(this.cbTableName);
			this.guna2Panel1.Location = new System.Drawing.Point(50, 50);
			this.guna2Panel1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.guna2Panel1.Name = "guna2Panel1";
			this.guna2Panel1.Size = new System.Drawing.Size(910, 41);
			this.guna2Panel1.TabIndex = 97;
			// 
			// cbTableName
			// 
			this.cbTableName.BackColor = System.Drawing.Color.Transparent;
			this.cbTableName.BorderRadius = 5;
			this.cbTableName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbTableName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbTableName.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbTableName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.cbTableName.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.cbTableName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
			this.cbTableName.ItemHeight = 30;
			this.cbTableName.Location = new System.Drawing.Point(0, 2);
			this.cbTableName.Margin = new System.Windows.Forms.Padding(0);
			this.cbTableName.Name = "cbTableName";
			this.cbTableName.Size = new System.Drawing.Size(245, 36);
			this.cbTableName.TabIndex = 98;
			this.cbTableName.SelectedIndexChanged += new System.EventHandler(this.cbTableName_SelectedIndexChanged);
			// 
			// ProductFilter
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Margin = new System.Windows.Forms.Padding(0);
			this.Name = "ProductFilter";
			this.Size = new System.Drawing.Size(1011, 600);
			this.Load += new System.EventHandler(this.ProductFilter_Load);
			this.Content.ResumeLayout(false);
			this.Content.PerformLayout();
			this.guna2Panel6.ResumeLayout(false);
			this.guna2Panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.LinkLabel lbBack;
		private System.Windows.Forms.FlowLayoutPanel flpFilterControl;
		private Guna.UI2.WinForms.Guna2Panel guna2Panel6;
		private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
		private Guna.UI2.WinForms.Guna2ComboBox cbTableName;
		private Guna.UI2.WinForms.Guna2Button btnApplyFilter;
	}
}
