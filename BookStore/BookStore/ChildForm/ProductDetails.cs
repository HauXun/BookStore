using BookStore.Extensions.Popup;
using BookStore.Model.BusinessLogicLayer;
using BookStore.Model.Entities;
using BookStore.Partial;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore.ChildForm
{
	public partial class ProductDetails : ModelPopup
	{
		bool accessLoad = false;
		DateTime timePrevious = DateTime.Now.AddDays(-7);
		DateTime timeNow = DateTime.Now;
		public string MaSP { get; set; }

		public ProductDetails(string maSP) : base()
		{
			InitializeComponent();
			MaSP = maSP;
			btnDeleteProduct.Region = System.Drawing.Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, btnDeleteProduct.Width, btnDeleteProduct.Height, 15, 15));
		}

		private void LoadData()
		{
			try
			{
				GetProductDetail();
				GetBillProductByID(accessLoad, dpkHeader1.Value, dpkHeader2.Value);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Book Store",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void GetProductDetail()
		{
			DataTable data = ProductBLL.Instance.GetProductByID(MaSP);
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

		private void GetBillProductByID(bool accessLoad = true, DateTime? startDate = null, DateTime? endDate = null)
		{
			List<HoaDon> billListDetail = AnalysisBLL.Instance.GetBillProductByID(MaSP, startDate, endDate);
			if (billListDetail != null && billListDetail.Count > 0 && accessLoad)
			{
				flpBillsBoxDetails.Controls.Clear();
				foreach (HoaDon item in billListDetail)
				{
					flpBillsBoxDetails.Controls.Add(new BillDetailBox(
						item.NgayGiaoDich.Day.ToString(),
						item.NgayGiaoDich.DayOfWeek.ToString().Substring(0, 3),
						item.MaHoaDon.ToString(),
						$"Thành tiền: {item.TongTien}",
						item.NgayGiaoDich.ToShortTimeString(),
						Color.FromArgb(199, 220, 223),
						Color.White,
						Color.White,
						Color.WhiteSmoke));
				}
			}
		}

		private void lbBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.dialogResult = DialogResult.Cancel;
		}

		private void ProductDetails_Load(object sender, EventArgs e)
		{
			LoadData();
			dpkHeader1.Value = timePrevious;
			dpkHeader2.Value = timeNow;
			accessLoad = true;
		}

		private void lbBack_MouseEnter(object sender, EventArgs e)
		{
			(sender as LinkLabel).LinkBehavior = LinkBehavior.SystemDefault;
		}

		private void lbBack_MouseLeave(object sender, EventArgs e)
		{
			(sender as LinkLabel).LinkBehavior = LinkBehavior.NeverUnderline;
		}

		private void dpkHeader1_onValueChanged(object sender, EventArgs e)
		{
			try
			{
				GetBillProductByID(accessLoad, dpkHeader1.Value, dpkHeader2.Value);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Book Store",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnDeleteProduct_Click(object sender, EventArgs e)
		{
			try
			{
				if (ProductBLL.Instance.CancleProductByID(MaSP) > 0)
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
}
