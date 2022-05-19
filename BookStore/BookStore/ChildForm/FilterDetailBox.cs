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
	public partial class FilterDetailBox : UserControl
	{
		public TableLayoutPanel tableBox;
		private Guna2Panel pnlBox4;
		private Guna2Panel pnlDetail4;
		private Label lbTitleDetail4;
		private Guna2Panel pnlBox3;
		private Guna2Panel pnlDetail3;
		private Label lbTitleDetail3;
		private Guna2Panel pnlBox2;
		private Guna2Panel pnlDetail2;
		private Label lbTitleDetail2;
		private Guna2Panel pnlBox1;
		private Guna2Panel pnlDetail1;
		private Label lbTitleDetail1;

		private int column;
		private List<Tuple<string, List<string>>> listColumnData;

		public int Column { get => column; set => column = value; }
		public List<Tuple<string, List<string>>> ListColumnData
		{
			get => listColumnData;
			set
			{
				listColumnData = value;
				Modifies(value);
			}
		}

		public FilterDetailBox()
		{
			InitializeComponent();
			Column = this.tableBox.Controls.Count;
		}

		private void Modifies(List<Tuple<string, List<string>>> listColumnData)
		{
			lbTitleDetail1.Text = lbTitleDetail2.Text = lbTitleDetail3.Text = lbTitleDetail4.Text = string.Empty;
			int columnCount = listColumnData.Count;
			string[] multiColumnName;
			string columnName;
			string columnNameFilter;
			for (int i = 1; i <= columnCount; i++)
			{
				switch (i)
				{
					case 1:
						multiColumnName = listColumnData[0].Item1.Split(',');
						if (multiColumnName.Length > 1)
						{
							columnName = multiColumnName[0];
							columnNameFilter = multiColumnName[1];
						}
						else
						{
							columnName = multiColumnName[0];
							columnNameFilter = multiColumnName[0];
						}
						lbTitleDetail1.Text = columnName;
						foreach (var item in listColumnData[0].Item2)
						{
							FilterCheckBox box = new FilterCheckBox();
							box.checkBox.Name = RandomString(20, true);
							box.checkBox.Text = item;
							box.checkBox.Tag = new Tuple<string, string, string>(columnNameFilter, item, columnName);
							box.checkBox.CheckedChanged += CheckBox_CheckedChanged;
							pnlDetail1.Controls.Add(box.checkBox);
						}
						break;
					case 2:
						multiColumnName = listColumnData[1].Item1.Split(',');
						if (multiColumnName.Length > 1)
						{
							columnName = multiColumnName[0];
							columnNameFilter = multiColumnName[1];
						}
						else
						{
							columnName = multiColumnName[0];
							columnNameFilter = multiColumnName[0];
						}
						lbTitleDetail2.Text = columnName;
						foreach (var item in listColumnData[1].Item2)
						{
							FilterCheckBox box = new FilterCheckBox();
							box.checkBox.Name = RandomString(20, true);
							box.checkBox.Text = item;
							box.checkBox.Tag = new Tuple<string, string, string>(columnNameFilter, item, columnName);
							box.checkBox.CheckedChanged += CheckBox_CheckedChanged;
							pnlDetail2.Controls.Add(box.checkBox);
						}
						break;
					case 3:
						multiColumnName = listColumnData[2].Item1.Split(',');
						if (multiColumnName.Length > 1)
						{
							columnName = multiColumnName[0];
							columnNameFilter = multiColumnName[1];
						}
						else
						{
							columnName = multiColumnName[0];
							columnNameFilter = multiColumnName[0];
						}
						lbTitleDetail3.Text = columnName;
						foreach (var item in listColumnData[2].Item2)
						{
							FilterCheckBox box = new FilterCheckBox();
							box.checkBox.Name = RandomString(20, true);
							box.checkBox.Text = item;
							box.checkBox.Tag = new Tuple<string, string, string>(columnNameFilter, item, columnName);
							box.checkBox.CheckedChanged += CheckBox_CheckedChanged;
							pnlDetail3.Controls.Add(box.checkBox);
						}
						break;
					case 4:
						multiColumnName = listColumnData[3].Item1.Split(',');
						if (multiColumnName.Length > 1)
						{
							columnName = multiColumnName[0];
							columnNameFilter = multiColumnName[1];
						}
						else
						{
							columnName = multiColumnName[0];
							columnNameFilter = multiColumnName[0];
						}
						lbTitleDetail4.Text = columnName;
						foreach (var item in listColumnData[3].Item2)
						{
							FilterCheckBox box = new FilterCheckBox();
							box.checkBox.Name = RandomString(20, true);
							box.checkBox.Text = item;
							box.checkBox.Tag = new Tuple<string, string, string>(columnNameFilter, item, columnName);
							box.checkBox.CheckedChanged += CheckBox_CheckedChanged;
							pnlDetail4.Controls.Add(box.checkBox);
						}
						break;
				}
			}
		}

		private void CheckBox_CheckedChanged(object sender, EventArgs e)
		{
			Guna2CheckBox checkBox = sender as Guna2CheckBox;
			if (checkBox.Checked)
			{
				Session.DataFilter.Add(checkBox.Tag as Tuple<string, string, string>);
			}
			else
			{
				Session.DataFilter.Remove(checkBox.Tag as Tuple<string, string, string>);
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
			this.pnlBox4 = new Guna.UI2.WinForms.Guna2Panel();
			this.pnlDetail4 = new Guna.UI2.WinForms.Guna2Panel();
			this.lbTitleDetail4 = new System.Windows.Forms.Label();
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
			this.pnlBox4.SuspendLayout();
			this.pnlDetail4.SuspendLayout();
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
			this.tableBox.ColumnCount = 4;
			this.tableBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableBox.Controls.Add(this.pnlBox4, 3, 0);
			this.tableBox.Controls.Add(this.pnlBox3, 2, 0);
			this.tableBox.Controls.Add(this.pnlBox2, 1, 0);
			this.tableBox.Controls.Add(this.pnlBox1, 0, 0);
			this.tableBox.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableBox.Location = new System.Drawing.Point(0, 0);
			this.tableBox.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.tableBox.Name = "tableBox";
			this.tableBox.RowCount = 1;
			this.tableBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableBox.Size = new System.Drawing.Size(902, 30);
			this.tableBox.TabIndex = 97;
			// 
			// pnlBox4
			// 
			this.pnlBox4.AutoSize = true;
			this.pnlBox4.Controls.Add(this.pnlDetail4);
			this.pnlBox4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlBox4.Location = new System.Drawing.Point(675, 0);
			this.pnlBox4.Margin = new System.Windows.Forms.Padding(0);
			this.pnlBox4.Name = "pnlBox4";
			this.pnlBox4.Size = new System.Drawing.Size(227, 30);
			this.pnlBox4.TabIndex = 100;
			// 
			// pnlDetail4
			// 
			this.pnlDetail4.AutoSize = true;
			this.pnlDetail4.Controls.Add(this.lbTitleDetail4);
			this.pnlDetail4.Location = new System.Drawing.Point(2, 5);
			this.pnlDetail4.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
			this.pnlDetail4.Name = "pnlDetail4";
			this.pnlDetail4.Size = new System.Drawing.Size(220, 25);
			this.pnlDetail4.TabIndex = 113;
			// 
			// lbTitleDetail4
			// 
			this.lbTitleDetail4.Dock = System.Windows.Forms.DockStyle.Top;
			this.lbTitleDetail4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.lbTitleDetail4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(69)))));
			this.lbTitleDetail4.Location = new System.Drawing.Point(0, 0);
			this.lbTitleDetail4.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.lbTitleDetail4.Name = "lbTitleDetail4";
			this.lbTitleDetail4.Size = new System.Drawing.Size(220, 25);
			this.lbTitleDetail4.TabIndex = 96;
			this.lbTitleDetail4.Text = "Thương hiệu";
			// 
			// pnlBox3
			// 
			this.pnlBox3.AutoSize = true;
			this.pnlBox3.Controls.Add(this.pnlDetail3);
			this.pnlBox3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlBox3.Location = new System.Drawing.Point(450, 0);
			this.pnlBox3.Margin = new System.Windows.Forms.Padding(0);
			this.pnlBox3.Name = "pnlBox3";
			this.pnlBox3.Size = new System.Drawing.Size(225, 30);
			this.pnlBox3.TabIndex = 99;
			// 
			// pnlDetail3
			// 
			this.pnlDetail3.AutoSize = true;
			this.pnlDetail3.Controls.Add(this.lbTitleDetail3);
			this.pnlDetail3.Location = new System.Drawing.Point(1, 5);
			this.pnlDetail3.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
			this.pnlDetail3.Name = "pnlDetail3";
			this.pnlDetail3.Size = new System.Drawing.Size(220, 25);
			this.pnlDetail3.TabIndex = 113;
			// 
			// lbTitleDetail3
			// 
			this.lbTitleDetail3.Dock = System.Windows.Forms.DockStyle.Top;
			this.lbTitleDetail3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.lbTitleDetail3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(69)))));
			this.lbTitleDetail3.Location = new System.Drawing.Point(0, 0);
			this.lbTitleDetail3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.lbTitleDetail3.Name = "lbTitleDetail3";
			this.lbTitleDetail3.Size = new System.Drawing.Size(220, 25);
			this.lbTitleDetail3.TabIndex = 98;
			this.lbTitleDetail3.Text = "DVT";
			// 
			// pnlBox2
			// 
			this.pnlBox2.AutoSize = true;
			this.pnlBox2.Controls.Add(this.pnlDetail2);
			this.pnlBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlBox2.Location = new System.Drawing.Point(225, 0);
			this.pnlBox2.Margin = new System.Windows.Forms.Padding(0);
			this.pnlBox2.Name = "pnlBox2";
			this.pnlBox2.Size = new System.Drawing.Size(225, 30);
			this.pnlBox2.TabIndex = 98;
			// 
			// pnlDetail2
			// 
			this.pnlDetail2.AutoSize = true;
			this.pnlDetail2.Controls.Add(this.lbTitleDetail2);
			this.pnlDetail2.Location = new System.Drawing.Point(1, 5);
			this.pnlDetail2.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
			this.pnlDetail2.Name = "pnlDetail2";
			this.pnlDetail2.Size = new System.Drawing.Size(220, 25);
			this.pnlDetail2.TabIndex = 114;
			// 
			// lbTitleDetail2
			// 
			this.lbTitleDetail2.Dock = System.Windows.Forms.DockStyle.Top;
			this.lbTitleDetail2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.lbTitleDetail2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(69)))));
			this.lbTitleDetail2.Location = new System.Drawing.Point(0, 0);
			this.lbTitleDetail2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.lbTitleDetail2.Name = "lbTitleDetail2";
			this.lbTitleDetail2.Size = new System.Drawing.Size(220, 25);
			this.lbTitleDetail2.TabIndex = 99;
			this.lbTitleDetail2.Text = "Tác giả";
			// 
			// pnlBox1
			// 
			this.pnlBox1.AutoSize = true;
			this.pnlBox1.Controls.Add(this.pnlDetail1);
			this.pnlBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlBox1.Location = new System.Drawing.Point(0, 0);
			this.pnlBox1.Margin = new System.Windows.Forms.Padding(0);
			this.pnlBox1.Name = "pnlBox1";
			this.pnlBox1.Size = new System.Drawing.Size(225, 30);
			this.pnlBox1.TabIndex = 97;
			// 
			// pnlDetail1
			// 
			this.pnlDetail1.AutoSize = true;
			this.pnlDetail1.Controls.Add(this.lbTitleDetail1);
			this.pnlDetail1.Location = new System.Drawing.Point(1, 5);
			this.pnlDetail1.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
			this.pnlDetail1.Name = "pnlDetail1";
			this.pnlDetail1.Size = new System.Drawing.Size(220, 25);
			this.pnlDetail1.TabIndex = 115;
			// 
			// lbTitleDetail1
			// 
			this.lbTitleDetail1.Dock = System.Windows.Forms.DockStyle.Top;
			this.lbTitleDetail1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.lbTitleDetail1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(67)))), ((int)(((byte)(69)))));
			this.lbTitleDetail1.Location = new System.Drawing.Point(0, 0);
			this.lbTitleDetail1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.lbTitleDetail1.Name = "lbTitleDetail1";
			this.lbTitleDetail1.Size = new System.Drawing.Size(220, 25);
			this.lbTitleDetail1.TabIndex = 98;
			this.lbTitleDetail1.Text = "Năm xuất bản";
			// 
			// FilterDetailBox
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.tableBox);
			this.Margin = new System.Windows.Forms.Padding(0);
			this.Name = "FilterDetailBox";
			this.Size = new System.Drawing.Size(902, 30);
			this.tableBox.ResumeLayout(false);
			this.tableBox.PerformLayout();
			this.pnlBox4.ResumeLayout(false);
			this.pnlBox4.PerformLayout();
			this.pnlDetail4.ResumeLayout(false);
			this.pnlBox3.ResumeLayout(false);
			this.pnlBox3.PerformLayout();
			this.pnlDetail3.ResumeLayout(false);
			this.pnlBox2.ResumeLayout(false);
			this.pnlBox2.PerformLayout();
			this.pnlDetail2.ResumeLayout(false);
			this.pnlBox1.ResumeLayout(false);
			this.pnlBox1.PerformLayout();
			this.pnlDetail1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}