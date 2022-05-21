using BookStore.Extensions.Popup;
using BookStore.Model.BusinessLogicLayer;
using BookStore.Partial;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace BookStore.ChildForm
{
	public partial class AddToBill : ModelPopup
	{
		private bool isReFilter = true;
		private int rowIndex = 0;
		private string preSP;
		Color[] filterColor = new Color[]
		{
			Color.FromArgb(100, 224, 224, 224),
			Color.FromArgb(100, 255, 255, 192),
			Color.FromArgb(100, 255, 192, 255),
			Color.FromArgb(100, 192, 255, 192),
			Color.FromArgb(100, 255, 192, 192),
			Color.FromArgb(100, 192, 255, 255),
			Color.FromArgb(100, 255, 224, 192)
		};
		private Tuple<string, DataTable, DataTable> filterData;

		public string MaSanPham { get; set; }
		public string TenSanPham { get; set; }
		public decimal GiaSP { get; set; }
		public int SLTon { get; set; }

		public Tuple<string, DataTable, DataTable> FilterData
		{
			get => filterData;
			set
			{
				filterData = value;
				LoadProductByFilter(value);
			}
		}

		public AddToBill() : base()
		{
			InitializeComponent();
			SettingControls();
		}

		/// <summary>
		/// Bo tròn góc các Control
		/// </summary>
		private void SettingControls()
		{
			//Rounded Form
			Content.Region = System.Drawing.Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, Content.Width, Content.Height, 15, 15));
			dgvData.Region = System.Drawing.Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, dgvData.Width, dgvData.Height, 5, 5));
			btnFilter.Region = System.Drawing.Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, btnFilter.Width, btnFilter.Height, 5, 5));
			btnAddToBill.Region = System.Drawing.Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, btnAddToBill.Width, btnAddToBill.Height, 5, 5));
		}

		private void LoadData()
		{
			try
			{
				LoadProduct();
				DetailProduct(rowIndex);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Book Store",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void LoadProductByFilter(Tuple<string, DataTable, DataTable> data)
		{
			if (isReFilter)
			{
				flpFilter.Controls.Clear();
				int rowCount = data.Item2.Rows.Count;
				for (int i = 0; i < rowCount; i++)
				{
					Random rnd = new Random();
					int index = rnd.Next(0, filterColor.Length);
					Guna.UI2.WinForms.Guna2Button button = new Guna.UI2.WinForms.Guna2Button();
					button.BorderRadius = 5;
					button.AutoSize = true;
					button.Cursor = System.Windows.Forms.Cursors.Hand;
					button.FillColor = filterColor[index];
					button.Font = new System.Drawing.Font("Tahoma", 10F);
					button.ForeColor = System.Drawing.Color.DimGray;
					button.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
					button.Name = $"{data.Item2.Rows[i]["Item1"]} {i}";
					button.Text = $"{data.Item2.Rows[i]["Item3"]}: {data.Item2.Rows[i]["Item2"]}      x";
					button.Tag = new Tuple<string, string, string>(
						data.Item2.Rows[i]["Item1"].ToString(),
						data.Item2.Rows[i]["Item2"].ToString(),
						data.Item2.Rows[i]["Item3"].ToString()
						);
					button.Click += Button_Click;

					flpFilter.Controls.Add(button);
				}
			}

			dgvData.DataSource = data.Item3;
			isReFilter = true;
		}

		private void ClearDetailProduct()
		{
			int controlCount = flpDetailProduct.Controls.Count;
			for (int i = controlCount - 1; i > 11; i--)
			{
				flpDetailProduct.Controls.RemoveAt(i);
			}
		}

		private void DetailProduct(int rowIndex)
		{
			if (dgvData.Rows.Count > 0)
			{
				DataGridViewRow rowCell = dgvData.Rows[rowIndex];
				MaSanPham = rowCell.Cells["MaSP"].Value.ToString();
				TenSanPham = rowCell.Cells["TenSP"].Value.ToString();
				GiaSP = decimal.Parse(rowCell.Cells["Gia"].Value.ToString());
				SLTon = int.Parse(rowCell.Cells["SoLuongTon"].Value.ToString());

				if (!MaSanPham.Equals(preSP))
				{
					ClearDetailProduct();
					DataTable data = ProductBLL.Instance.GetProductByID(MaSanPham);
					if (data != null && data.Rows.Count > 0)
					{
						string[] multiColumnName;
						string columnName;
						string columnNameFilter;

						DataRow row = data.Rows[0];
						lbIDProductDetail.Text = row["MaSP"].ToString();
						data.Columns.Remove("MaSP");
						lbProductNameDetail.Text = row["TenSP"].ToString();
						data.Columns.Remove("TenSP");
						lbProductBrandDetail.Text = row["ThuongHieu"].ToString();
						data.Columns.Remove("ThuongHieu");
						lbProductStockDetail.Text = row["SoLuongTon"].ToString();
						data.Columns.Remove("SoLuongTon");
						lbInitProductDetail.Text = row["DVT"].ToString();
						data.Columns.Remove("DVT");
						lbGiaDetail.Text = row["Gia"].ToString();
						data.Columns.Remove("Gia");

						int dataColumnCount = data.Columns.Count;
						for (int i = 0; i < dataColumnCount; i++)
						{
							multiColumnName = data.Columns[i].ColumnName.Split(',');
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
							Label title = new Label();
							title.BackColor = System.Drawing.Color.Transparent;
							title.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
							title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(85)))));
							title.Location = new System.Drawing.Point(0, 0);
							title.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
							title.Name = columnNameFilter;
							title.Size = new System.Drawing.Size(370, 19);
							title.TabIndex = 71;
							title.Text = $"{columnName}:";

							Label detail = new Label();
							detail.AutoSize = true;
							detail.BackColor = System.Drawing.Color.Transparent;
							detail.Font = new System.Drawing.Font("Segoe UI", 11F);
							detail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(85)))));
							detail.Location = new System.Drawing.Point(0, 24);
							detail.Margin = new System.Windows.Forms.Padding(0, 0, 0, 5);
							detail.Name = $"{columnNameFilter}Detail";
							detail.Size = new System.Drawing.Size(370, 19);
							detail.TabIndex = 75;
							detail.Text = row[data.Columns[i].ColumnName.ToString()].ToString();
							detail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

							flpDetailProduct.Controls.Add(title);
							flpDetailProduct.Controls.Add(detail);
						}
					}
				}
				preSP = MaSanPham;
			}
		}

		private void LoadProduct()
		{
			dgvData.DataSource = ProductBLL.Instance.GetAllProduct();
		}

		private void Button_Click(object sender, EventArgs e)
		{
			Guna.UI2.WinForms.Guna2Button button = sender as Guna.UI2.WinForms.Guna2Button;
			if (Session.DataFilter.Count > 0)
			{
				Session.DataFilter.Remove((Tuple<string, string, string>)button.Tag);
				flpFilter.Controls.Remove(button);
				DataTable data = Session.ConvertToDataTable(Session.DataFilter);
				DataTable results = ProductFilterBLL.Instance.ProductFilter(FilterData.Item1, data);
				isReFilter = false;
				FilterData = new Tuple<string, DataTable, DataTable>(FilterData.Item1, data, results);
			}
		}

		private void lbBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.dialogResult = DialogResult.Cancel;
			Session.BillRowBox = null;
		}

		private void AddToBill_Load(object sender, EventArgs e)
		{
			LoadData();
		}

		private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0)
				return;
			rowIndex = e.RowIndex;
			DetailProduct(rowIndex);
		}

		private void btnAddToBill_Click(object sender, EventArgs e)
		{
			if (SLTon == 0)
			{
				MessageBox.Show("Số lượng sản phẩm không đủ để giao dịch!", "Thông báo!",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			Session.BillRowBox = new BillRowBox(TenSanPham, GiaSP, 1)
			{
				Dock = DockStyle.Bottom,
				Tag = new Tuple<string, int>(MaSanPham, SLTon)
			};
			this.dialogResult = DialogResult.Cancel;
		}

		private void lbBack_MouseEnter(object sender, EventArgs e)
		{
			(sender as LinkLabel).LinkBehavior = LinkBehavior.SystemDefault;
		}

		private void lbBack_MouseLeave(object sender, EventArgs e)
		{
			(sender as LinkLabel).LinkBehavior = LinkBehavior.NeverUnderline;
		}

		private void tbSearch_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			tbSearch.Clear();
		}

		private void tbSearch_MouseLeave(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(tbSearch.Text))
			{
				tbSearch.PlaceholderText = "Nhập từ khóa ...";
			}
		}

		private void tbSearch_IconRightClick(object sender, EventArgs e)
		{
			try
			{
				DataTable data;
				string keyword = tbSearch.Text;
				if (string.IsNullOrEmpty(tbSearch.Text))
					keyword = string.Empty;

				data = ProductBLL.Instance.SearchProduct(keyword);
				dgvData.DataSource = data;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Tìm kiếm thất bại! " + ex.Message, "Book Store",
			   MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void tbSearch_Enter(object sender, EventArgs e)
		{
			tbSearch.Clear();
		}
	}
}
