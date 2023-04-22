using BookStore.Model.DataAccessLayer;
using BookStore.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Model.BusinessLogicLayer
{
	public class AnalysisBLL
	{
		private static AnalysisBLL instance;

		public static AnalysisBLL Instance
		{
			get
			{
				if (instance == null)
					instance = new AnalysisBLL();
				return instance;
			}
			private set => instance = value;
		}

		public string[] BillRate(DateTime? startDate = null, DateTime? endDate = null)
		{
			DataTable data = AnalysisDAL.Instance.BillRate(startDate, endDate);
			DataRow row = data.Rows[0];

			return new string[]
			{
				row["SLHoaDonTuanNay"].ToString(),
				row["SLHoaDonTuantruoc"].ToString(),
				row["TiLe"].ToString(),
				row["RatioOnTotal"].ToString()
			};
		}

		/// <summary>
		/// Sản phẩm bán chạy nhất
		/// </summary>
		/// <param name="startDate"></param>
		/// <param name="endDate"></param>
		/// <returns></returns>
		public List<ProductSell> Bestseller(DateTime? startDate = null, DateTime? endDate = null)
		{
			DataTable data = AnalysisDAL.Instance.Bestseller(startDate, endDate);
			List<ProductSell> result = new List<ProductSell>();
			foreach (DataRow row in data.Rows)
			{
				result.Add(new ProductSell(row));
			}
			return result;
		}

		public List<ProductSell> Sellslowly(DateTime? startDate = null, DateTime? endDate = null)
		{
			DataTable data = AnalysisDAL.Instance.Sellslowly(startDate, endDate);
			List<ProductSell> result = new List<ProductSell>();
			foreach (DataRow row in data.Rows)
			{
				result.Add(new ProductSell(row));
			}
			return result;
		}

		public List<ProductSell> Unsold(DateTime? startDate = null, DateTime? endDate = null)
		{
			DataTable data = AnalysisDAL.Instance.Unsold(startDate, endDate);
			List<ProductSell> result = new List<ProductSell>();
			foreach (DataRow row in data.Rows)
			{
				result.Add(new ProductSell(row));
			}
			return result;
		}

		/// <summary>
		/// Doanh thu theo sản phẩm
		/// </summary>
		/// <param name="startDate"></param>
		/// <param name="endDate"></param>
		/// <returns></returns>
		public List<ProductSell> RevenueByProduct(DateTime? startDate = null, DateTime? endDate = null)
		{
			DataTable data = AnalysisDAL.Instance.RevenueByProduct(startDate, endDate);
			List<ProductSell> result = new List<ProductSell>();
			foreach (DataRow row in data.Rows)
			{
				result.Add(new ProductSell(row));
			}
			return result;
		}

		/// <summary>
		/// Thống kê doanh thu theo giai đoạn
		/// </summary>
		/// <param name="startDate"></param>
		/// <param name="endDate"></param>
		/// <returns></returns>
		public DataTable RevenueStatisticsInThisStages(DateTime? startDate = null, DateTime? endDate = null)
		{
			return AnalysisDAL.Instance.RevenueStatisticsInThisStages(startDate, endDate);
		}

		/// <summary>
		/// Thống kê doanh thu theo giai đoạn trước đó
		/// </summary>
		/// <param name="startDate"></param>
		/// <param name="endDate"></param>
		/// <returns></returns>
		public DataTable RevenueStatisticsInPreviousStages(DateTime? startDate = null, DateTime? endDate = null)
		{
			return AnalysisDAL.Instance.RevenueStatisticsInPreviousStages(startDate, endDate);
		}

		public DataTable BillRole()
		{
			return AnalysisDAL.Instance.BillRole();
		}

		public List<HoaDon> InvoiceDetails(string loaiHoaDon = "NULL", DateTime? startDate = null, DateTime? endDate = null)
		{
			DataTable data = AnalysisDAL.Instance.InvoiceDetails(loaiHoaDon, startDate, endDate);
			List<HoaDon> result = new List<HoaDon>();
			foreach (DataRow row in data.Rows)
			{
				result.Add(new HoaDon(row));
			}
			return result;
		}

		public DataTable InvoiceStatisticalAnalysis(DateTime? startDate = null, DateTime? endDate = null)
		{
			return AnalysisDAL.Instance.InvoiceStatisticalAnalysis(startDate, endDate);
		}

		/// <summary>
		/// Lấy hóa đơn theo sản phẩm
		/// </summary>
		/// <param name="maSP"></param>
		/// <param name="startDate"></param>
		/// <param name="endDate"></param>
		/// <returns></returns>
		public List<HoaDon> GetBillProductByID(string maSP, DateTime? startDate = null, DateTime? endDate = null)
		{
			DataTable data = AnalysisDAL.Instance.GetBillProductByID(maSP, startDate, endDate);
			List<HoaDon> result = new List<HoaDon>();
			foreach (DataRow row in data.Rows)
			{
				result.Add(new HoaDon(row, data));
			}
			return result;
		}

		/// <summary>
		/// Lấy thông tin hóa đơn theo kiểu hóa đơn
		/// </summary>
		/// <param name="loaiHoaDon"></param>
		/// <returns></returns>
		public List<HoaDon> InvoiceDetailsByRole(string loaiHoaDon)
		{
			DataTable data = AnalysisDAL.Instance.InvoiceDetailsByRole(loaiHoaDon);
			List<HoaDon> result = new List<HoaDon>();
			foreach (DataRow row in data.Rows)
			{
				result.Add(new HoaDon(row));
			}
			return result;
		}

		public List<HoaDon> InvoiceDetailsByStages(DateTime startDate, DateTime endDate)
		{
			DataTable data = AnalysisDAL.Instance.InvoiceDetailsByStages(startDate, endDate);
			List<HoaDon> result = new List<HoaDon>();
			foreach (DataRow row in data.Rows)
			{
				result.Add(new HoaDon(row));
			}
			return result;
		}

		public List<HoaDon> InvoiceDetailsByPeriodPrice(float startPrice, float endPrice)
		{
			DataTable data = AnalysisDAL.Instance.InvoiceDetailsByPeriodPrice(startPrice, endPrice);
			List<HoaDon> result = new List<HoaDon>();
			foreach (DataRow row in data.Rows)
			{
				result.Add(new HoaDon(row));
			}
			return result;
		}

		public List<HoaDon> SearchBill(string keyword)
		{
			DataTable data = AnalysisDAL.Instance.SearchBill(keyword);
			List<HoaDon> result = new List<HoaDon>();
			foreach (DataRow row in data.Rows)
			{
				result.Add(new HoaDon(row));
			}
			return result;
		}
	}
}
