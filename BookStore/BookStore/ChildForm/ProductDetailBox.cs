using System;
using Guna.UI2.WinForms;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Windows.Media;
using BookStore.Partial;

namespace BookStore.ChildForm
{
	public partial class ProductDetailBox : UserControl
	{

		private int column;
		public TableLayoutPanel tableBox;
		private Guna2Panel pnlBox3;
		private Guna2Panel pnlDetail3;
		private Label lbTitleDetail3;
		private Guna2Panel pnlBox2;
		private Guna2Panel pnlDetail2;
		private Label lbTitleDetail2;
		private Guna2Panel pnlBox1;
		private Guna2Panel pnlDetail1;
		private Label lbTitleDetail1;
		private List<string> listColumn;

		public int Column { get => column; set => column = value; }
		public List<string> ListColumn
		{
			get => listColumn;
			set
			{
				listColumn = value;
				Modifies(value);
			}
		}

		public ProductDetailBox()
		{
			InitializeComponent();
			Column = this.tableBox.Controls.Count;
		}

		private void Modifies(List<string> listColumn)
		{
			lbTitleDetail1.Text = lbTitleDetail2.Text = lbTitleDetail3.Text = string.Empty;
			int columnCount = listColumn.Count;

			for (int i = 0; i < columnCount; i++)
			{
				switch (i)
				{
					case 0:
						ProductInfoTextBox box = new ProductInfoTextBox();
						box.tbInput.Name = Name = RandomString(20, true);
						lbTitleDetail1.Text = listColumn[i];
						pnlDetail1.Controls.Add(box.tbInput);
						Session.ListInputTextBox.Add(new Tuple<Label, Guna2TextBox>(lbTitleDetail1, box.tbInput));
						break;
					case 1:
						ProductInfoTextBox box2 = new ProductInfoTextBox();
						box2.tbInput.Name = Name = RandomString(20, true);
						lbTitleDetail2.Text = listColumn[i];
						pnlDetail2.Controls.Add(box2.tbInput);
						Session.ListInputTextBox.Add(new Tuple<Label, Guna2TextBox>(lbTitleDetail2, box2.tbInput));
						break;
					case 2:
						ProductInfoTextBox box3 = new ProductInfoTextBox();
						box3.tbInput.Name = Name = RandomString(20, true);
						lbTitleDetail3.Text = listColumn[i];
						pnlDetail3.Controls.Add(box3.tbInput);
						Session.ListInputTextBox.Add(new Tuple<Label, Guna2TextBox>(lbTitleDetail3, box3.tbInput));
						break;
				}
			}
		}

		public string RandomString(int size, bool lowerCase = false)
		{

			Random _random = new Random();
			var builder = new StringBuilder(size);

			char offset = lowerCase ? 'a' : 'A';
			const int lettersOffset = 26; // A...Z or a..z: length = 26  

			for (var i = 0; i < size; i++)
			{
				var @char = (char)_random.Next(offset, offset + lettersOffset);
				builder.Append(@char);
			}

			return lowerCase ? builder.ToString().ToLower() : builder.ToString();
		}

		private void InitializeComponent()
		{
			this.tableBox = new System.Windows.Forms.TableLayoutPanel();
			this.pnlBox3 = new Guna.UI2.WinForms.Guna2Panel();
			this.pnlDetail3 = new Guna.UI2.WinForms.Guna2Panel();
			this.lbTitleDetail3 = new System.Windows.Forms.Label();
			this.pnlBox2 = new Guna.UI2.WinForms.Guna2Panel();
			this.pnlDetail2 = new Guna.UI2.WinForms.Guna2Panel();
			this.lbTitleDetail2 = new System.Windows.Forms.Label();
			this.pnlBox1 = new Guna.UI2.WinForms.Guna2Panel();
			this.pnlDetail1 = new Guna.UI2.WinForms.Guna2Panel();
			this.lbTitleDetail1 = new System.Windows.Forms.Label();
			this.tableBox.SuspendLayout();
			this.pnlBox3.SuspendLayout();
			this.pnlDetail3.SuspendLayout();
			this.pnlBox2.SuspendLayout();
			this.pnlDetail2.SuspendLayout();
			this.pnlBox1.SuspendLayout();
			this.pnlDetail1.SuspendLayout();
			this.SuspendLayout();
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
			this.tableBox.Size = new System.Drawing.Size(930, 33);
			this.tableBox.TabIndex = 99;
			// 
			// pnlBox3
			// 
			this.pnlBox3.AutoSize = true;
			this.pnlBox3.Controls.Add(this.pnlDetail3);
			this.pnlBox3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlBox3.Location = new System.Drawing.Point(620, 0);
			this.pnlBox3.Margin = new System.Windows.Forms.Padding(0);
			this.pnlBox3.Name = "pnlBox3";
			this.pnlBox3.Size = new System.Drawing.Size(310, 33);
			this.pnlBox3.TabIndex = 100;
			// 
			// pnlDetail3
			// 
			this.pnlDetail3.AutoSize = true;
			this.pnlDetail3.Controls.Add(this.lbTitleDetail3);
			this.pnlDetail3.Location = new System.Drawing.Point(10, 5);
			this.pnlDetail3.Margin = new System.Windows.Forms.Padding(10, 5, 0, 0);
			this.pnlDetail3.Name = "pnlDetail3";
			this.pnlDetail3.Size = new System.Drawing.Size(292, 25);
			this.pnlDetail3.TabIndex = 113;
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
			this.pnlBox2.Size = new System.Drawing.Size(310, 33);
			this.pnlBox2.TabIndex = 99;
			// 
			// pnlDetail2
			// 
			this.pnlDetail2.AutoSize = true;
			this.pnlDetail2.Controls.Add(this.lbTitleDetail2);
			this.pnlDetail2.Location = new System.Drawing.Point(10, 5);
			this.pnlDetail2.Margin = new System.Windows.Forms.Padding(10, 5, 10, 0);
			this.pnlDetail2.Name = "pnlDetail2";
			this.pnlDetail2.Size = new System.Drawing.Size(289, 25);
			this.pnlDetail2.TabIndex = 113;
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
			this.pnlBox1.Size = new System.Drawing.Size(310, 33);
			this.pnlBox1.TabIndex = 97;
			// 
			// pnlDetail1
			// 
			this.pnlDetail1.AutoSize = true;
			this.pnlDetail1.Controls.Add(this.lbTitleDetail1);
			this.pnlDetail1.Location = new System.Drawing.Point(1, 5);
			this.pnlDetail1.Margin = new System.Windows.Forms.Padding(0, 5, 10, 0);
			this.pnlDetail1.Name = "pnlDetail1";
			this.pnlDetail1.Size = new System.Drawing.Size(299, 25);
			this.pnlDetail1.TabIndex = 115;
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
			// ProductDetailBox
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.tableBox);
			this.Margin = new System.Windows.Forms.Padding(0);
			this.Name = "ProductDetailBox";
			this.Size = new System.Drawing.Size(930, 33);
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
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}