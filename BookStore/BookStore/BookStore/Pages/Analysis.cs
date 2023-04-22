using BookStore.ChildForm;
using BookStore.Model.BusinessLogicLayer;
using BookStore.Model.Entities;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore.Pages
{
	public partial class Analysis : UserControl
	{
		private event EventHandler<InvokeInvoiceDetail> newBillDetail;
		public event EventHandler<InvokeInvoiceDetail> NewBillDetail
		{
			add
			{
				newBillDetail += value;
			}
			remove
			{
				newBillDetail -= value;
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
		private bool accessLoad = false;
		DateTime timePrevious = DateTime.Now.AddDays(-7);
		DateTime timeNow = DateTime.Now;

		public Analysis()
		{
			InitializeComponent();

			BillRole();
			pnlBSIWp1Cover.Parent = btnSellBox1Title;
			pnlBSIWp2Cover.Parent = btnSellBox2Title;
			pnlBSIWp3Cover.Parent = btnSellBox3Title;
			chartRevenue.Parent = pnlChartRevenue;
			LoadData(accessLoad);
			dpkHeader1.Value = dpkSell1.Value = dpkRevenue1.Value = dpkBills1.Value = timePrevious;
			accessLoad = true;
			dpkHeader2.Value = dpkSell2.Value = dpkRevenue2.Value = dpkBills2.Value = timeNow;
		}

		private void LoadData(bool accessLoad = true)
		{
			try
			{
				if (accessLoad)
				{
					BillRate();
					RevenueRate();
					ProductRate();
					ConsumptionRate();
					Bestseller();
					Sellslowly();
					Unsold();
					RevenueByProduct();
					InvoiceDetails();
					InvoiceStatisticalAnalysis();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Book Store",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		#region Rate

		/// <summary>
		/// Tỉ lệ hoá đơn trong tuần
		/// </summary>
		private void BillRate(DateTime? startDate = null, DateTime? endDate = null)
		{
			string[] data = AnalysisBLL.Instance.BillRate(startDate, endDate);
			if (data != null)
			{
				lbHeaderBoxValue1.Text = data[0];
				btnHeaderLaststagesValue1.Text = $"Giai đoạn trước {data[1]}";
				cpHBCircleValue1.Value = (int)Convert.ToDouble(data[3]);

				if (float.Parse(data[2]) < 0)
				{
					pnlHeaderBoxPercent1.FillColor =
					pnlHeaderBoxPercent1.FillColor2 =
					pnlHeaderBoxPercent1.FillColor3 =
					pnlHeaderBoxPercent1.FillColor4 = Color.FromArgb(255, 240, 240);
					lbHeaderBoxPercent1.ForeColor = Color.FromArgb(255, 61, 61);
					lbHeaderBoxPercent1.Text = $"{data[2]}%";
				}
				else
				{
					pnlHeaderBoxPercent1.FillColor =
					pnlHeaderBoxPercent1.FillColor2 =
					pnlHeaderBoxPercent1.FillColor3 =
					pnlHeaderBoxPercent1.FillColor4 = Color.FromArgb(237, 251, 247);
					lbHeaderBoxPercent1.ForeColor = Color.FromArgb(107, 220, 190);
					lbHeaderBoxPercent1.Text = $"+{data[2]}%";
				}
			}
		}

		/// <summary>
		/// Tỉ lệ doanh thu trong tuần
		/// </summary>
		private void RevenueRate(DateTime? startDate = null, DateTime? endDate = null)
		{
			string[] data = InsightBLL.Instance.RevenueRate(startDate, endDate);
			if (data != null)
			{
				lbHeaderBoxValue2.Text = data[0];
				btnHeaderLaststagesValue2.Text = $"Giai đoạn trước {data[1]}";
				cpHBCircleValue2.Value = (int)Convert.ToDouble(data[3]);

				if (float.Parse(data[2]) < 0)
				{
					pnlHeaderBoxPercent2.FillColor =
					pnlHeaderBoxPercent2.FillColor2 =
					pnlHeaderBoxPercent2.FillColor3 =
					pnlHeaderBoxPercent2.FillColor4 = Color.FromArgb(255, 240, 240);
					lbHeaderBoxPercent2.ForeColor = Color.FromArgb(255, 61, 61);
					lbHeaderBoxPercent2.Text = $"{data[2]}%";
				}
				else
				{
					pnlHeaderBoxPercent2.FillColor =
					pnlHeaderBoxPercent2.FillColor2 =
					pnlHeaderBoxPercent2.FillColor3 =
					pnlHeaderBoxPercent2.FillColor4 = Color.FromArgb(237, 251, 247);
					lbHeaderBoxPercent2.ForeColor = Color.FromArgb(107, 220, 190);
					lbHeaderBoxPercent2.Text = $"+{data[2]}%";
				}
			}
		}

		/// <summary>
		/// Tỉ lệ sản phẩm trong tuần
		/// </summary>
		private void ProductRate(DateTime? startDate = null, DateTime? endDate = null)
		{
			string[] data = InsightBLL.Instance.ProductImportedRate(startDate, endDate);
			if (data != null)
			{
				lbHeaderBoxValue3.Text = data[0];
				btnHeaderLaststagesValue3.Text = $"Giai đoạn trước {data[1]}";
				cpHBCircleValue3.Value = (int)Convert.ToDouble(data[3]);

				if (float.Parse(data[2]) < 0)
				{
					pnlHeaderBoxPercent3.FillColor =
					pnlHeaderBoxPercent3.FillColor2 =
					pnlHeaderBoxPercent3.FillColor3 =
					pnlHeaderBoxPercent3.FillColor4 = Color.FromArgb(255, 240, 240);
					lbHeaderBoxPercent3.ForeColor = Color.FromArgb(255, 61, 61);
					lbHeaderBoxPercent3.Text = $"{data[2]}%";
				}
				else
				{
					pnlHeaderBoxPercent3.FillColor =
					pnlHeaderBoxPercent3.FillColor2 =
					pnlHeaderBoxPercent3.FillColor3 =
					pnlHeaderBoxPercent3.FillColor4 = Color.FromArgb(237, 251, 247);
					lbHeaderBoxPercent3.ForeColor = Color.FromArgb(107, 220, 190);
					lbHeaderBoxPercent3.Text = $"+{data[2]}%";
				}
			}
		}

		/// <summary>
		/// Tỉ lệ tiêu thụ trong tuần
		/// </summary>
		private void ConsumptionRate(DateTime? startDate = null, DateTime? endDate = null)
		{
			string[] data = InsightBLL.Instance.ProductSoldRate(startDate, endDate);
			if (data != null)
			{
				lbHeaderBoxValue4.Text = data[0];
				btnHeaderLaststagesValue4.Text = $"Giai đoạn trước {data[1]}";
				cpHBCircleValue4.Value = (int)Convert.ToDouble(data[3]);

				if (float.Parse(data[2]) < 0)
				{
					pnlHeaderBoxPercent4.FillColor =
					pnlHeaderBoxPercent4.FillColor2 =
					pnlHeaderBoxPercent4.FillColor3 =
					pnlHeaderBoxPercent4.FillColor4 = Color.FromArgb(255, 240, 240);
					lbHeaderBoxPercent4.ForeColor = Color.FromArgb(255, 61, 61);
					lbHeaderBoxPercent4.Text = $"{data[2]}%";
				}
				else
				{
					pnlHeaderBoxPercent4.FillColor =
					pnlHeaderBoxPercent4.FillColor2 =
					pnlHeaderBoxPercent4.FillColor3 =
					pnlHeaderBoxPercent4.FillColor4 = Color.FromArgb(237, 251, 247);
					lbHeaderBoxPercent4.ForeColor = Color.FromArgb(107, 220, 190);
					lbHeaderBoxPercent4.Text = $"+{data[2]}%";
				}
			}
		}

		#endregion

		#region ProductSaleRate

		/// <summary>
		/// Bán chạy nhất
		/// </summary>
		/// <param name="startDate"></param>
		/// <param name="endDate"></param>
		private void Bestseller(DateTime? startDate = null, DateTime? endDate = null)
		{
			List<ProductSell> data = AnalysisBLL.Instance.Bestseller(startDate, endDate);
			flpSellBox1.Controls.Clear();
			foreach (ProductSell item in data)
			{
				ProductSalableBox product = new ProductSalableBox(
					item.TenSP.Length > 25 ? item.TenSP.Substring(0, 25) + "..." : item.TenSP,
					$"Bán được: {item.SoLuong}",
					Color.FromArgb(237, 251, 247),
					Color.White,
					Color.FromArgb(237, 251, 247),
					Color.WhiteSmoke);
				product.btnFoward.Tag = item.MaSP;
				product.btnFoward.Click += BtnFoward_Click;
				flpSellBox1.Controls.Add(product);
			}
		}

		/// <summary>
		/// Bán chậm
		/// </summary>
		/// <param name="startDate"></param>
		/// <param name="endDate"></param>
		private void Sellslowly(DateTime? startDate = null, DateTime? endDate = null)
		{
			List<ProductSell> data = AnalysisBLL.Instance.Sellslowly(startDate, endDate);
			flpSellBox2.Controls.Clear();
			foreach (ProductSell item in data)
			{
				ProductSalableBox product = new ProductSalableBox(
					item.TenSP.Length > 25 ? item.TenSP.Substring(0, 25) + "..." : item.TenSP,
					$"Bán được: {item.SoLuong}",
					Color.FromArgb(10, 255, 255, 192),
					Color.White,
					Color.FromArgb(10, 255, 255, 192),
					Color.WhiteSmoke);
				product.btnFoward.Tag = item.MaSP;
				product.btnFoward.Click += BtnFoward_Click;
				flpSellBox2.Controls.Add(product);
			}
		}

		/// <summary>
		/// Không bán được
		/// </summary>
		/// <param name="startDate"></param>
		/// <param name="endDate"></param>
		private void Unsold(DateTime? startDate = null, DateTime? endDate = null)
		{
			List<ProductSell> data = AnalysisBLL.Instance.Unsold(startDate, endDate);
			flpSellBox3.Controls.Clear();
			foreach (ProductSell item in data)
			{
				ProductSalableBox product = new ProductSalableBox(
						item.TenSP.Length > 25 ? item.TenSP.Substring(0, 25) + "..." : item.TenSP,
						$"Bán được: {item.SoLuong}",
						Color.FromArgb(255, 240, 240),
						Color.White,
						Color.FromArgb(255, 240, 240),
						Color.WhiteSmoke);
				product.btnFoward.Tag = item.MaSP;
				product.btnFoward.Click += BtnFoward_Click;
				flpSellBox3.Controls.Add(product);
			}
		}

		#endregion

		#region Revenue

		/// <summary>
		/// Doanh thu theo sản phẩm
		/// </summary>
		/// <param name="startDate"></param>
		/// <param name="endDate"></param>
		private void RevenueByProduct(DateTime? startDate = null, DateTime? endDate = null)
		{
			List<ProductSell> data = AnalysisBLL.Instance.RevenueByProduct(startDate, endDate);
			flpRB2_Details.Controls.Clear();
			foreach (ProductSell item in data)
			{
				RevenueDetailBox detailBox = new RevenueDetailBox(
					item.TenSP.Length > 25 ? item.TenSP.Substring(0, 25) + "..." : item.TenSP,
					$"Thành tiền: {item.TongTien}",
					$"Bán: {item.SoLuong}",
					Color.FromArgb(199, 220, 223),
					Color.White,
					Color.White,
					Color.WhiteSmoke);
				detailBox.btnFoward.Tag = item.MaSP;
				detailBox.btnFoward.Click += BtnFoward_Click;
				flpRB2_Details.Controls.Add(detailBox);
			}
		}

		/// <summary>
		/// Biểu đồ thống kê doanh thu
		/// </summary>
		/// <param name="startDate"></param>
		/// <param name="endDate"></param>
		private void RevenueStatistics(DateTime? startDate = null, DateTime? endDate = null)
		{
			DataTable thisStages = AnalysisBLL.Instance.RevenueStatisticsInThisStages(startDate, endDate);
			DataTable preStages = AnalysisBLL.Instance.RevenueStatisticsInPreviousStages(startDate, endDate);

			int thisStagesLength = thisStages.Rows.Count;
			int preStagesLength = preStages.Rows.Count;
			int lengthLabels = (thisStagesLength > preStagesLength) ? thisStagesLength : preStagesLength;

			chartRevenue.Labels = new string[lengthLabels];
			chartBarNewRevenue.Data = new List<double>();
			chartBarPreviousRevenue.Data = new List<double>();

			lbRB1_Detail.Text = $"Trị giá doanh thu giai đoạn: {thisStages.Compute("SUM(TongTien)", string.Empty)}";

			for (int i = 0; i < lengthLabels; i++)
			{
				chartBarNewRevenue.Data.Add(0);
				chartBarPreviousRevenue.Data.Add(0);
			}

			for (int i = 0; i < lengthLabels; i++)
			{
				if (i < thisStagesLength)
					chartBarNewRevenue.Data[i] = (double)thisStages.Rows[i]["TongTien"];

				if (i < preStagesLength)
					chartBarPreviousRevenue.Data[i] = (double)preStages.Rows[i]["TongTien"];

				if (i < thisStagesLength && i < preStagesLength)
				{
					chartRevenue.Labels[i] = "".PadLeft(10) + $"(Day {Convert.ToDateTime(preStages.Rows[i]["NgayGiaoDich"]).Day}/{Convert.ToDateTime(preStages.Rows[i]["NgayGiaoDich"]).Month}" +
					$" - Day {Convert.ToDateTime(thisStages.Rows[i]["NgayGiaoDich"]).Day}/{Convert.ToDateTime(thisStages.Rows[i]["NgayGiaoDich"]).Month})";
				}
				else
				{
					if (i < thisStagesLength)
						chartRevenue.Labels[i] = "".PadLeft(10) + $"(Day {Convert.ToDateTime(thisStages.Rows[i]["NgayGiaoDich"]).Day}/{Convert.ToDateTime(thisStages.Rows[i]["NgayGiaoDich"]).Month})";

					if (i < preStagesLength)
						chartRevenue.Labels[i] = "".PadLeft(10) + $"(Day {Convert.ToDateTime(preStages.Rows[i]["NgayGiaoDich"]).Day}/{Convert.ToDateTime(preStages.Rows[i]["NgayGiaoDich"]).Month})";
				}
			}

			chartRevenue.Update(true);
		}

		#endregion

		#region Bill

		private void BillRole()
		{
			DataTable data = AnalysisBLL.Instance.BillRole();
			if (data.Rows.Count > 0)
			{
				DataRow row = data.NewRow();
				row["TenLoaiHD"] = "Tất cả";
				row["MaLoaiHD"] = "NULL";
				data.Rows.InsertAt(row, 0);

				cbBillRole.DisplayMember = "TenLoaiHD";
				cbBillRole.ValueMember = "MaLoaiHD";
				cbBillRole.DataSource = data;
			}
		}

		/// <summary>
		/// Chi tiết thông tin hóa đơn
		/// </summary>
		/// <param name="loaiHoaDon"></param>
		/// <param name="startDate"></param>
		/// <param name="endDate"></param>
		private void InvoiceDetails(string loaiHoaDon = "NULL", DateTime? startDate = null, DateTime? endDate = null)
		{
			List<HoaDon> data = AnalysisBLL.Instance.InvoiceDetails(loaiHoaDon, startDate, endDate);
			flpBillsBox2_Details.Controls.Clear();
			foreach (HoaDon item in data)
			{
				BillDetailBox detailBox = new BillDetailBox(
					item.NgayGiaoDich.Day.ToString(),
					item.NgayGiaoDich.DayOfWeek.ToString().Substring(0, 3),
					item.MaHoaDon.ToString(),
					$"Thành tiền: {item.TongTien}",
					item.NgayGiaoDich.ToShortTimeString(),
					Color.FromArgb(199, 220, 223),
					Color.White,
					Color.White,
					Color.WhiteSmoke);
				detailBox.btnFoward.Tag = item.MaHoaDon;
				detailBox.btnFoward.Click += BtnFoward_Click1;
				flpBillsBox2_Details.Controls.Add(detailBox);
			}
		}

		/// <summary>
		/// Biểu đồ thống kê hóa đơn
		/// </summary>
		/// <param name="startDate"></param>
		/// <param name="endDate"></param>
		private void InvoiceStatisticalAnalysis(DateTime? startDate = null, DateTime? endDate = null)
		{
			DataTable data = AnalysisBLL.Instance.InvoiceStatisticalAnalysis(startDate, endDate);
			int lengthLabels = data.Rows.Count;

			chartBills.Labels = new string[lengthLabels];
			chartLineBills.Data = new List<double>();
			chartLineConsume.Data = new List<double>();

			lbBillsBox1_Detail.Text = $"Tổng mức hóa đơn: {data.Compute("SUM(MucHoaDon)", string.Empty)} bills";

			for (int i = 0; i < lengthLabels; i++)
			{
				chartLineBills.Data.Add(0);
				chartLineConsume.Data.Add(0);
			}

			for (int i = 0; i < lengthLabels; i++)
			{
				chartLineBills.Data[i] = (int)data.Rows[i]["MucHoaDon"];

				chartLineConsume.Data[i] = (int)data.Rows[i]["TongSoLuongSP"];

				chartBills.Labels[i] = $"({data.Rows[i]["NgayGiaoDich"]})";
			}

			chartBills.Update(true);
		}

		#endregion

		private void Analysis_Load(object sender, EventArgs e)
		{
		}

		private void BtnFoward_Click(object sender, EventArgs e)
		{
			if (newProductDetail != null)
			{
				newProductDetail(this, new NewProductDetails((sender as IconButton).Tag.ToString()));
			}
		}

		private void BtnFoward_Click1(object sender, EventArgs e)
		{
			if (newBillDetail != null)
			{
				int maHoaDon = int.Parse((sender as IconButton).Tag.ToString());
				InvoiceDetail invoice = BillBLL.Instance.GetInvoiceDetail(maHoaDon);
				newBillDetail(this, new InvokeInvoiceDetail(invoice));
			}
		}

		private void dpkHeader1_onValueChanged(object sender, EventArgs e)
		{
			try
			{
				if (accessLoad)
				{
					BillRate(dpkHeader1.Value, dpkHeader2.Value);
					RevenueRate(dpkHeader1.Value, dpkHeader2.Value);
					ProductRate(dpkHeader1.Value, dpkHeader2.Value);
					ConsumptionRate(dpkHeader1.Value, dpkHeader2.Value);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Book Store",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void dpkSell1_onValueChanged(object sender, EventArgs e)
		{
			try
			{
				if (accessLoad)
				{
					Bestseller(dpkSell1.Value, dpkSell2.Value);
					Sellslowly(dpkSell1.Value, dpkSell2.Value);
					Unsold(dpkSell1.Value, dpkSell2.Value);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Book Store",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void dpkRevenue1_onValueChanged(object sender, EventArgs e)
		{
			try
			{
				if (accessLoad)
				{
					RevenueStatistics(dpkRevenue1.Value, dpkRevenue2.Value);
					RevenueByProduct(dpkRevenue1.Value, dpkRevenue2.Value);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Book Store",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void dpkBills1_onValueChanged(object sender, EventArgs e)
		{
			try
			{
				if (accessLoad)
				{
					InvoiceStatisticalAnalysis(dpkBills1.Value, dpkBills2.Value);
					if (cbBillRole.SelectedValue != null)
						InvoiceDetails(cbBillRole.SelectedValue.ToString(), dpkBills1.Value, dpkBills2.Value);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Book Store",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void cbBillRole_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				if (cbBillRole.SelectedValue != null && accessLoad)
					InvoiceDetails(cbBillRole.SelectedValue.ToString(), dpkBills1.Value, dpkBills2.Value);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Book Store",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
