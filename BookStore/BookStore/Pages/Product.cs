using BookStore.ChildForm;
using BookStore.Extensions;
using BookStore.Model.BusinessLogicLayer;
using BookStore.Model.Entities;
using BookStore.Partial;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore.Pages
{
	public partial class Product : UserControl
	{
		private bool isReFilter = true;
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
		Tuple<string, DataTable, DataTable> filterData;
		private int rowIndex = 0;

		public Tuple<string, DataTable, DataTable> FilterData
		{
			get => filterData;
			set
			{
				filterData = value;
				// Load thông tin vào sản phẩm dựa vào dữ liệu lọc
				LoadProductByFilter(value);
			}
		}

		private event EventHandler<NewProductDetails> newProductDetail;
		public event EventHandler<NewProductDetails> NewProductDetail
		{
			add
			{
				newProductDetail += value;
			}
			remove
			{
				newProductDetail -= value;
			}
		}

		public Product()
		{
			InitializeComponent();
			RoundedControls();
			Session.ReloadProductList = new Action(LoadProduct);
			SetStyle(ControlStyles.UserPaint, true);
			//((DataGridViewImageColumn)this.aDgvdata.Columns["Success"]).DefaultCellStyle.NullValue = imageList.Images[3];

			LoadData();
		}

		/// <summary>
		/// Sự kiện nhấn phím bất kì
		/// </summary>
		/// <param name="msg"></param>
		/// <param name="keyData"></param>
		/// <returns></returns>
		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			if (keyData == Keys.Enter)
			{
				tbSearch_IconRightClick(this, new EventArgs());
				return true;
			}
			return base.ProcessCmdKey(ref msg, keyData);
		}

		//Bo tròn góc các Control
		#region Rounded Controls

		/// <summary>
		/// Bo tròn control
		/// </summary>
		private void RoundedControls()
		{
			Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
			btnFilter.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, btnFilter.Width, btnFilter.Height, 5, 5));
			dgvData.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, dgvData.Width, dgvData.Height, 5, 5));
			btnNewProduct.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, btnNewProduct.Width, btnNewProduct.Height, 5, 5));
		}

		#endregion

		#region Methods

		/// <summary>
		/// Load dữ liệu
		/// </summary>
		private void LoadData()
		{
			try
			{
				ProductStock();
				TheBestSellter();
				LoadProduct();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Book Store",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		/// <summary>
		/// Số lượng tồn
		/// </summary>
		private void ProductStock()
		{
			string[] data = InsightBLL.Instance.ProductStock();
			double quota = 0;

			if (data != null && data.Length > 0)
			{
				int lengthChart = doughnutChartStock.Data.Count;
				for (int i = 0; i < lengthChart; i++)
				{
					doughnutChartStock.Data[i] = 0;
				}

				for (int i = 0; i < lengthChart; i++)
				{
					double value = double.Parse(data[i]);
					quota += value;
					doughnutChartStock.Data[i] = value;
				}
			}
			lbHeaderBox2Detail.Text = $"Tổng cộng: {quota} pcs";
			chartStock.Update(true);
		}

		/// <summary>
		/// Bán chạy nhất
		/// </summary>
		private void TheBestSellter()
		{
			int chartLineCount = chartHorizontalBestsellterProduct.Data.Count;
			List<ProductBestSellter> data = ProductBLL.Instance.TheBestSellter();

			if (data != null && data.Count > 0)
			{
				for (int i = 0; i < chartLineCount; i++)
				{
					chartHorizontalBestsellterProduct.Data[i] = 0;
					chartBestsellerProduct.Labels[i] = string.Empty;
				}

				for (int i = 0; i < chartLineCount; i++)
				{
					if (i >= 0 && i < data.Count)
					{
						string tenSP = data[i].TenSP;
						if (tenSP.Length > 30)
						{
							tenSP = tenSP.Substring(0, 30) + "...";
						}
						chartBestsellerProduct.Labels[i] = tenSP;
						chartHorizontalBestsellterProduct.Data[i] = data[i].SoLuongBan;
					}
				}
				lbHeaderBox1Detail.Text = $"Nhiều nhất: {data.Max(x => x.SoLuongBan)} pcs kể từ đầu tháng";
				chartBestsellerProduct.Update(true);
			}
		}

		/// <summary>
		/// Load danh sách sản phẩm vào datagridview
		/// </summary>
		private void LoadProduct()
		{
			dgvData.DataSource = ProductBLL.Instance.GetAllProduct();
		}

		/// <summary>
		/// Load danh sách sản phẩm bằng dữ liệu lọc
		/// </summary>
		/// <param name="data"></param>
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

		/// <summary>
		/// Hiển thi chi tiết sản phẩm
		/// </summary>
		/// <param name="rowIndex"></param>
		private void DetailProduct(int rowIndex)
		{
			if (dgvData.Rows.Count > 0)
			{
				DataGridViewRow row = dgvData.Rows[rowIndex];
				if (newProductDetail != null)
				{
					newProductDetail(this, new NewProductDetails(row.Cells["MaSP"].Value.ToString()));
				}
			}
		}

		#endregion

		#region Events

		private void Product_Load(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Sự kiện click đôi chuột
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
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

		private void tbSearch_Enter(object sender, EventArgs e)
		{
			tbSearch.Clear();
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

		#endregion

		/// <summary>
		/// Sự kiện click đôi vào ô dữ liệu trong datagridview
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0)
				return;
			rowIndex = e.RowIndex;
			DetailProduct(rowIndex);
		}

		/// <summary>
		/// Sự kiện cho các nút thông tin lọc
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
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

		/// <summary>
		/// Menustrip hủy sản phẩm
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void cancelProductCMS_Click(object sender, EventArgs e)
		{
			MessageBox.Show((sender as ToolStripMenuItem).Text);
			if (MessageBox.Show("Xác nhận xóa!", "Book Store",
				MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
			{
				try
				{
					int result = 0;
					foreach (DataGridViewRow item in dgvData.SelectedRows)
					{
						result = ProductBLL.Instance.CancleProductByID(item.Cells["MaSP"].Value.ToString());
					}
					if (result == 1)
					{
						MessageBox.Show("Sản phẩm được hủy thành công!", "Book Store",
							MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Book Store",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		/// <summary>
		/// Menu strip chi tiết sản phẩm
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void detailProductCMS_Click(object sender, EventArgs e)
		{
			DetailProduct(dgvData.CurrentCell.RowIndex);
		}
	}

	public class NewProductDetails : EventArgs
	{
		private ProductDetails details;

		public NewProductDetails(string maSP)
		{
			Details = new ProductDetails(maSP);
		}

		public ProductDetails Details { get => details; set => details = value; }
	}
}
