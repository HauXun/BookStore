using BookStore.ChildForm;
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

namespace BookStore.Pages
{
	public partial class Insight : UserControl
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

		public Insight()
		{
			InitializeComponent();

			SettingControls();
			pnlBSIWp1Cover.Parent = btnBSIWp1;
			pnlBSIWp2Cover.Parent = btnBSIWp2;
			pnlBSIWp3Cover.Parent = btnBSIWp3;
			pnlBSIWp4Cover.Parent = btnBSIWp4;
			LoadData();
		}

		/// <summary>
		/// Bo tròn góc các Control
		/// </summary>
		private void SettingControls()
		{
			//Rounded Form
			Region = System.Drawing.Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
		}

		private void LoadData()
		{
			try
			{
				CustomerRate();
				ProductSoldRate();
				ProductImportedRate();
				RevenueRate();
				RevenueStatisticsInWeek();
				SalesInWeek();
				ProductStock();
				TheMostTransaction();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Book Store",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		#region Header

		/// <summary>
		/// Tỉ lệ khách hàng trong tuần
		/// </summary>
		private void CustomerRate()
		{
			string[] data = InsightBLL.Instance.CustomerRate();
			if (data != null && data.Length > 0)
			{
				lbHeaderBoxValue1.Text = data[0];
				btnHeaderLastweekValue1.Text = $"Tuần trước {data[1]}";
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
		/// Tỉ lệ bán trong tuần
		/// </summary>
		private void ProductSoldRate()
		{
			string[] data = InsightBLL.Instance.ProductSoldRate();
			if (data != null)
			{
				lbHeaderBoxValue2.Text = data[0];
				btnHeaderLastweekValue2.Text = $"Tuần trước {data[1]}";
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
		/// Tỉ lệ nhập trong tuần
		/// </summary>
		private void ProductImportedRate()
		{
			string[] data = InsightBLL.Instance.ProductImportedRate();
			if (data != null)
			{
				lbHeaderBoxValue3.Text = data[0];
				btnHeaderLastweekValue3.Text = $"Tuần trước {data[1]}";
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
		/// Tỉ lệ doanh thu trong tuần
		/// </summary>
		private void RevenueRate()
		{
			string[] data = InsightBLL.Instance.RevenueRate();
			if (data != null)
			{
				lbHeaderBoxValue4.Text = data[0];
				btnHeaderLastweekValue4.Text = $"Tuần trước {data[1]}";
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

		#region Details

		/// <summary>
		/// Thống kê doanh thu theo tuần
		/// </summary>
		private void RevenueStatisticsInWeek()
		{
			DataTable data = InsightBLL.Instance.RevenueStatisticsInWeek();
			int lengthChart = chartBarRevenue.Data.Count;

			for (int i = 0; i < lengthChart; i++)
			{
				chartBarRevenue.Data[i] = 0;
			}

			lengthChart = data.Rows.Count;
			for (int i = 0; i < lengthChart; i++)
			{
				DataRow row = data.Rows[i];
				int index = (int)row["NgayThu"];
				chartBarRevenue.Data[index] = (double)row["TongTien"];
			}

			chartBody.Update(true);
		}

		/// <summary>
		/// Bán trong tuần
		/// </summary>
		private void SalesInWeek()
		{
			string[] data = InsightBLL.Instance.SalesInWeek();
			
			if (data != null && data.Length > 0)
			{
				lbBSIWp1Value.Text = data[0];
				lbBSIWp2Value.Text = data[1];
				lbBSIWp3Value.Text = data[2];
				lbBSIWp4Value.Text = data[3];
			}
		}

		/// <summary>
		/// Số lượng tồn
		/// </summary>
		private void ProductStock()
		{
			string[] data = InsightBLL.Instance.ProductStock();
			
			if (data != null && data.Length > 0)
			{
				lbBodyClassifyMark1.Text = $"{data[0]} pcs";
				lbBodyClassifyMark2.Text = $"{data[1]} pcs";
				lbBodyClassifyMark3.Text = $"{data[2]} pcs";
			}
		}

		/// <summary>
		/// Giao dịch nhiều nhất tuần
		/// </summary>
		private void TheMostTransaction()
		{
			List<HoaDon> data = InsightBLL.Instance.TheMostTransaction();

			lbBTP1DateValue.Text = data[0].NgayGiaoDich.Day.ToString();
			lbBTP1DateText.Text = data[0].NgayGiaoDich.DayOfWeek.ToString().Substring(0, 3);
			lbBTP1DetailTitle.Text = data[0].MaHoaDon.ToString();
			lbBTP1PriceCost.Text = $"Thành tiền: {data[0].TongTien}";
			lbBTP1PriceTime.Text = data[0].NgayGiaoDich.ToShortTimeString();

			lbBTP2DateValue.Text = data[1].NgayGiaoDich.Day.ToString();
			lbBTP2DateText.Text = data[1].NgayGiaoDich.DayOfWeek.ToString().Substring(0, 3);
			lbBTP2DetailTitle.Text = data[1].MaHoaDon.ToString();
			lbBTP2PriceCost.Text = $"Thành tiền: {data[1].TongTien}";
			lbBTP2PriceTime.Text = data[1].NgayGiaoDich.ToShortTimeString();
		}

		#endregion

		private void Insight_Load(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// Chi tiết hóa đơn giao dịch nhiều nhất tuần
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnBTP1DetailsLink_Click(object sender, EventArgs e)
		{
			if (newBillDetail != null)
			{
				InvoiceDetail invoice = BillBLL.Instance.GetInvoiceDetail(int.Parse(lbBTP1DetailTitle.Text));
				newBillDetail(this, new InvokeInvoiceDetail(invoice));
			}
		}

		/// <summary>
		/// Chi tiết hóa đơn giao dịch nhiều nhất tuần
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnBTP2DetailsLink_Click(object sender, EventArgs e)
		{
			if (newBillDetail != null)
			{
				InvoiceDetail invoice = BillBLL.Instance.GetInvoiceDetail(int.Parse(lbBTP2DetailTitle.Text));
				newBillDetail(this, new InvokeInvoiceDetail(invoice));
			}
		}
	}
}
