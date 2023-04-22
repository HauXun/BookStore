using System;
using System.Drawing;
using System.Windows.Forms;

namespace BookStore.ChildForm
{
	public partial class ProductInfoTextBox : UserControl
	{
		public Guna.UI2.WinForms.Guna2TextBox tbInput;

		public ProductInfoTextBox()
		{
			InitializeComponent();
		}

		private void InitializeComponent()
		{
			this.tbInput = new Guna.UI2.WinForms.Guna2TextBox();
			this.SuspendLayout();
			// 
			// tbInput
			// 
			this.tbInput.Animated = true;
			this.tbInput.BorderRadius = 5;
			this.tbInput.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.tbInput.DefaultText = "";
			this.tbInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.tbInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.tbInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.tbInput.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.tbInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbInput.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.tbInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.tbInput.Location = new System.Drawing.Point(0, 0);
			this.tbInput.Margin = new System.Windows.Forms.Padding(0);
			this.tbInput.Name = "tbInput";
			this.tbInput.PasswordChar = '\0';
			this.tbInput.PlaceholderText = "";
			this.tbInput.SelectedText = "";
			this.tbInput.Size = new System.Drawing.Size(299, 36);
			this.tbInput.TabIndex = 0;
			// 
			// ProductInfoTextBox
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.tbInput);
			this.Name = "ProductInfoTextBox";
			this.Size = new System.Drawing.Size(299, 36);
			this.ResumeLayout(false);

		}
	}
}