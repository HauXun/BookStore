using BookStore.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Model.DataAccessLayer
{
	public class InsightDAL
	{
		private static InsightDAL instance;

		public static InsightDAL Instance
		{
			get
			{
				if (instance == null)
					instance = new InsightDAL();
				return instance;
			}
			private set => instance = value;
		}
		
		/// <summary>
		/// Tỉ lệ khách hàng
		/// </summary>
		/// <returns></returns>
		public DataTable CustomerRate()
		{
			string query = "EXEC dbo.USP_CustomerRate";
			DataTable data = DataProvider.Instance.ExcuteQuery(query);
			return data;
		}

		/// <summary>
		/// Tỉ lệ sản phẩm bán được
		/// </summary>
		/// <param name="startDate"></param>
		/// <param name="endDate"></param>
		/// <returns></returns>
		public DataTable ProductSoldRate(DateTime? startDate = null, DateTime? endDate = null)
		{
			string query = "EXEC dbo.USP_ProductSoldRate @StartDate , @EndDate";
			if (startDate == null && endDate == null)
			{
				query = "EXEC dbo.USP_ProductSoldRate NULL , NULL";
			}
			DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { startDate, endDate });
			return data;
		}

		/// <summary>
		/// Tỉ lệ sản phẩm nhập
		/// </summary>
		/// <param name="startDate"></param>
		/// <param name="endDate"></param>
		/// <returns></returns>
		public DataTable ProductImportedRate(DateTime? startDate = null, DateTime? endDate = null)
		{
			string query = "EXEC dbo.USP_ProductImportedRate @StartDate , @EndDate";
			if (startDate == null && endDate == null)
			{
				query = "EXEC dbo.USP_ProductImportedRate NULL , NULL";
			}
			DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { startDate, endDate });
			return data;
		}

		/// <summary>
		/// Tỉ lệ doanh thu
		/// </summary>
		/// <param name="startDate"></param>
		/// <param name="endDate"></param>
		/// <returns></returns>
		public DataTable RevenueRate(DateTime? startDate = null, DateTime? endDate = null)
		{
			string query = "EXEC dbo.USP_RevenueRate @StartDate , @EndDate";
			if (startDate == null && endDate == null)
			{
				query = "EXEC dbo.USP_RevenueRate NULL , NULL";
			}
			DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { startDate, endDate });
			return data;
		}

		/// <summary>
		/// Thống kê doanh thu trong tuần
		/// </summary>
		/// <returns></returns>
		public DataTable RevenueStatisticsInWeek()
		{
			string query = "EXEC dbo.USP_RevenueStatisticsInWeek";
			DataTable data = DataProvider.Instance.ExcuteQuery(query);
			return data;
		}

		/// <summary>
		/// Giảm giá trong tuần
		/// </summary>
		/// <returns></returns>
		public DataTable SalesInWeek()
		{
			string query = "EXEC dbo.USP_SalesInWeek";
			DataTable data = DataProvider.Instance.ExcuteQuery(query);
			return data;
		}

		/// <summary>
		/// Số lượng sản phầm tồn
		/// </summary>
		/// <returns></returns>
		public DataTable ProductStock()
		{
			string query = "EXEC dbo.USP_ProductStock";
			DataTable data = DataProvider.Instance.ExcuteQuery(query);
			return data;
		}

		/// <summary>
		/// Giao dịch nhiều nhất
		/// </summary>
		/// <returns></returns>
		public DataTable TheMostTransaction()
		{
			string query = "EXEC dbo.USP_TheMostTransaction";
			DataTable data = DataProvider.Instance.ExcuteQuery(query);
			return data;
		}
	}
}
