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
	public class InsightBLL
	{
		private static InsightBLL instance;

		public static InsightBLL Instance
		{
			get
			{
				if (instance == null)
					instance = new InsightBLL();
				return instance;
			}
			private set => instance = value;
		}

		/// <summary>
		/// Tỉ lệ khách hàng
		/// </summary>
		/// <returns></returns
		public string[] CustomerRate()
		{
			DataTable data = InsightDAL.Instance.CustomerRate();
			DataRow row = data.Rows[0];

			return new string[] 
			{ 
				row["SLKhachHangTuanNay"].ToString(), 
				row["SLKhachHangTuanTruoc"].ToString(),
				row["TiLe"].ToString()
			};
		}

		/// <summary>
		/// Tỉ lệ sản phẩm bán được
		/// </summary>
		/// <param name="startDate"></param>
		/// <param name="endDate"></param>
		/// <returns></returns>
		public string[] ProductSoldRate(DateTime? startDate = null, DateTime? endDate = null)
		{
			DataTable data = InsightDAL.Instance.ProductSoldRate(startDate, endDate);
			DataRow row = data.Rows[0];

			return new string[] 
			{ 
				row["SLSPTuanNay"].ToString(), 
				row["SLSPTuanTruoc"].ToString(),
				row["TiLe"].ToString(),
				row["RatioOnTotal"].ToString()
			};
		}

		/// <summary>
		/// Tỉ lệ sản phẩm nhập
		/// </summary>
		/// <param name="startDate"></param>
		/// <param name="endDate"></param>
		/// <returns></returns>
		public string[] ProductImportedRate(DateTime? startDate = null, DateTime? endDate = null)
		{
			DataTable data = InsightDAL.Instance.ProductImportedRate(startDate, endDate);
			DataRow row = data.Rows[0];

			return new string[] 
			{ 
				row["SLSPTuanNay"].ToString(), 
				row["SLSPTuanTruoc"].ToString(),
				row["TiLe"].ToString(),
				row["RatioOnTotal"].ToString()
			};
		}

		/// <summary>
		/// Tỉ lệ doanh thu
		/// </summary>
		/// <param name="startDate"></param>
		/// <param name="endDate"></param>
		/// <returns></returns>
		public string[] RevenueRate(DateTime? startDate = null, DateTime? endDate = null)
		{
			DataTable data = InsightDAL.Instance.RevenueRate(startDate, endDate);
			DataRow row = data.Rows[0];

			return new string[] 
			{ 
				row["DoanhThuTuanNay"].ToString(), 
				row["DoanhThuTuanTruoc"].ToString(),
				row["TiLe"].ToString(),
				row["RatioOnTotal"].ToString()
			};
		}

		/// <summary>
		/// Thống kê doanh thu trong tuần
		/// </summary>
		/// <returns></returns>
		public DataTable RevenueStatisticsInWeek()
		{
			return InsightDAL.Instance.RevenueStatisticsInWeek();
		}

		/// <summary>
		/// Giảm giá trong tuần
		/// </summary>
		/// <returns></returns>
		public string[] SalesInWeek()
		{
			DataTable data = InsightDAL.Instance.SalesInWeek();
			DataRow row = data.Rows[0];

			return new string[]
			{
				row["Sach"].ToString(),
				row["But"].ToString(),
				row["ThietBiDienTu"].ToString(),
				row["VanPhongPham"].ToString()
			};
		}

		/// <summary>
		/// Số lượng sản phầm tồn
		/// </summary>
		/// <returns></returns>
		public string[] ProductStock()
		{
			DataTable data = InsightDAL.Instance.ProductStock();
			DataRow row = data.Rows[0];

			return new string[]
			{
				row["Sach"].ToString(),
				row["ThietBiDienTu"].ToString(),
				row["VanPhongPham"].ToString()
			};
		}

		/// <summary>
		/// Giao dịch nhiều nhất
		/// </summary>
		/// <returns></returns>
		public List<HoaDon> TheMostTransaction()
		{
			DataTable data = InsightDAL.Instance.TheMostTransaction();
			List<HoaDon> result = new List<HoaDon>();
			foreach (DataRow row in data.Rows)
			{
				result.Add(new HoaDon(row));
			}
			return result;
		}
	}
}
