using BookStore.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Model.DataAccessLayer
{
	public class AnalysisDAL
	{
		private static AnalysisDAL instance;

		public static AnalysisDAL Instance
		{
			get
			{
				if (instance == null)
					instance = new AnalysisDAL();
				return instance;
			}
			private set => instance = value;
		}

		public DataTable BillRate(DateTime? startDate = null, DateTime? endDate = null)
		{
			string query = "EXEC dbo.USP_BillRate @StartDate , @EndDate";
			if (startDate == null && endDate == null)
			{
				query = "EXEC dbo.USP_BillRate NULL , NULL";
			}
			DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] {startDate, endDate});
			return data;
		}

		/// <summary>
		/// Sản phẩm bán chạy nhất
		/// </summary>
		/// <param name="startDate"></param>
		/// <param name="endDate"></param>
		/// <returns></returns>
		public DataTable Bestseller(DateTime? startDate = null, DateTime? endDate = null)
		{
			string query = "EXEC dbo.USP_Bestseller @StartDate , @EndDate";
			if (startDate == null && endDate == null)
			{
				query = "EXEC dbo.USP_Bestseller NULL , NULL";
			}
			DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] {startDate, endDate});
			return data;
		}

		public DataTable Sellslowly(DateTime? startDate = null, DateTime? endDate = null)
		{
			string query = "EXEC dbo.USP_Sellslowly @StartDate , @EndDate";
			if (startDate == null && endDate == null)
			{
				query = "EXEC dbo.USP_Sellslowly NULL , NULL";
			}
			DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] {startDate, endDate});
			return data;
		}

		public DataTable Unsold(DateTime? startDate = null, DateTime? endDate = null)
		{
			string query = "EXEC dbo.USP_Unsold @StartDate , @EndDate";
			if (startDate == null && endDate == null)
			{
				query = "EXEC dbo.USP_Unsold NULL , NULL";
			}
			DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] {startDate, endDate});
			return data;
		}

		/// <summary>
		/// Doanh thu theo sản phẩm
		/// </summary>
		/// <param name="startDate"></param>
		/// <param name="endDate"></param>
		/// <returns></returns>
		public DataTable RevenueByProduct(DateTime? startDate = null, DateTime? endDate = null)
		{
			string query = "EXEC dbo.USP_RevenueByProduct @StartDate , @EndDate";
			if (startDate == null && endDate == null)
			{
				query = "EXEC dbo.USP_RevenueByProduct NULL , NULL";
			}
			DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] {startDate, endDate});
			return data;
		}

		/// <summary>
		/// Thống kê doanh thu theo giai đoạn
		/// </summary>
		/// <param name="startDate"></param>
		/// <param name="endDate"></param>
		/// <returns></returns>
		public DataTable RevenueStatisticsInThisStages(DateTime? startDate = null, DateTime? endDate = null)
		{
			string query = "EXEC dbo.USP_RevenueStatisticsInThisStages @StartDate , @EndDate";
			if (startDate == null && endDate == null)
			{
				query = "EXEC dbo.USP_RevenueStatisticsInThisStages NULL , NULL";
			}
			DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { startDate, endDate });
			return data;
		}

		/// <summary>
		/// Thống kê doanh thu theo giai đoạn trước đó
		/// </summary>
		/// <param name="startDate"></param>
		/// <param name="endDate"></param>
		/// <returns></returns>
		public DataTable RevenueStatisticsInPreviousStages(DateTime? startDate = null, DateTime? endDate = null)
		{
			string query = "EXEC dbo.USP_RevenueStatisticsInPreviousStages @StartDate , @EndDate";
			if (startDate == null && endDate == null)
			{
				query = "EXEC dbo.USP_RevenueStatisticsInPreviousStages NULL , NULL";
			}
			DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { startDate, endDate });
			return data;
		}

		public DataTable BillRole()
		{
			string query = "SELECT * FROM dbo.LoaiHoaDon";
			DataTable data = DataProvider.Instance.ExcuteQuery(query);
			return data;
		}

		public DataTable InvoiceDetails(string loaiHoaDon = "NULL", DateTime? startDate = null, DateTime? endDate = null)
		{
			string query = "EXEC dbo.USP_InvoiceDetails @LoaiHoaDon , @StartDate , @EndDate";
			object[] parameter = new object[] { loaiHoaDon, startDate, endDate };
			if (!loaiHoaDon.Equals("NULL"))
			{
				if (startDate == null && endDate == null)
					query = "EXEC dbo.USP_InvoiceDetails @LoaiHoaDon , NULL , NULL";
			}
			if (loaiHoaDon.Equals("NULL"))
			{
				if (startDate == null && endDate == null)
				{
					query = "EXEC dbo.USP_InvoiceDetails NULL , NULL , NULL";
					parameter = null;
				}
				if (startDate != null && endDate != null)
				{
					query = "EXEC dbo.USP_InvoiceDetails NULL , @StartDate , @EndDate";
					parameter = new object[] { startDate, endDate };
				}
			}
			DataTable data = DataProvider.Instance.ExcuteQuery(query, parameter);
			return data;
		}

		public DataTable InvoiceStatisticalAnalysis(DateTime? startDate = null, DateTime? endDate = null)
		{
			string query = "EXEC dbo.USP_InvoiceStatisticalAnalysis @StartDate , @EndDate";
			if (startDate == null && endDate == null)
			{
				query = "EXEC dbo.USP_InvoiceStatisticalAnalysis NULL , NULL";
			}
			DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { startDate, endDate });
			return data;
		}

		/// <summary>
		/// Lấy hóa đơn theo sản phẩm
		/// </summary>
		/// <param name="maSP"></param>
		/// <param name="startDate"></param>
		/// <param name="endDate"></param>
		/// <returns></returns>
		public DataTable GetBillProductByID(string maSP, DateTime? startDate = null, DateTime? endDate = null)
		{
			string query = "EXEC dbo.USP_GetBillProductByID @MaSP , @StartDate , @EndDate";
			if (startDate == null && endDate == null)
			{
				query = "EXEC dbo.USP_GetBillProductByID @MaSP , NULL , NULL";
			}
			DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { maSP, startDate, endDate });
			return data;
		}

		/// <summary>
		/// Lấy thông tin hóa đơn theo kiểu hóa đơn
		/// </summary>
		/// <param name="loaiHoaDon"></param>
		/// <returns></returns>
		public DataTable InvoiceDetailsByRole(string loaiHoaDon)
		{
			string query = "EXEC dbo.USP_InvoiceDetailsByRole @LoaiHoaDon";
			DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { loaiHoaDon });
			return data;
		}

		public DataTable InvoiceDetailsByStages(DateTime startDate, DateTime endDate)
		{
			string query = "EXEC dbo.USP_InvoiceDetailsByStages @StartDate , @EndDate";
			DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { startDate, endDate });
			return data;
		}

		public DataTable InvoiceDetailsByPeriodPrice(float startPrice, float endPrice)
		{
			string query = "EXEC dbo.USP_InvoiceDetailsByPeriodPrice @StartPrice , @EndPrice";
			DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { startPrice, endPrice });
			return data;
		}

		public DataTable SearchBill(string keyword)
		{
			string query = "EXEC dbo.USP_SearchBill @keyword";
			DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { keyword });
			return data;
		}
	}
}
