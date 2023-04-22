using System;
using System.Drawing;
using System.Windows.Forms;

namespace BookStore.ChildForm
{
	public partial class FilterCheckBox : UserControl
	{
		public Guna.UI2.WinForms.Guna2CheckBox checkBox;

		public FilterCheckBox()
		{
			InitializeComponent();
		}

		private void InitializeComponent()
		{
			this.checkBox = new Guna.UI2.WinForms.Guna2CheckBox();
			this.SuspendLayout();
			// 
			// checkBox
			// 
			this.checkBox.Animated = true;
			this.checkBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.checkBox.CheckedState.BorderRadius = 0;
			this.checkBox.CheckedState.BorderThickness = 0;
			this.checkBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.checkBox.Cursor = System.Windows.Forms.Cursors.Hand;
			this.checkBox.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.checkBox.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
			this.checkBox.ForeColor = System.Drawing.Color.Gray;
			this.checkBox.Location = new System.Drawing.Point(0, 0);
			this.checkBox.Name = "checkBox";
			this.checkBox.Size = new System.Drawing.Size(220, 22);
			this.checkBox.TabIndex = 0;
			this.checkBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			this.checkBox.UncheckedState.BorderRadius = 0;
			this.checkBox.UncheckedState.BorderThickness = 0;
			this.checkBox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
			this.checkBox.MouseEnter += new System.EventHandler(this.checkBox_MouseEnter);
			this.checkBox.MouseLeave += new System.EventHandler(this.checkBox_MouseLeave);
			// 
			// FilterCheckBox
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.checkBox);
			this.Name = "FilterCheckBox";
			this.Size = new System.Drawing.Size(220, 22);
			this.ResumeLayout(false);

		}

		private void checkBox_MouseEnter(object sender, EventArgs e)
		{
			(sender as Guna.UI2.WinForms.Guna2CheckBox).ForeColor = System.Drawing.Color.Silver;
		}

		private void checkBox_MouseLeave(object sender, EventArgs e)
		{
			(sender as Guna.UI2.WinForms.Guna2CheckBox).ForeColor = System.Drawing.Color.Gray;
		}
	}
}