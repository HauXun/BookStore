using BookStore.Model.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Model.BusinessLogicLayer
{
	public class ProductFilterBLL
	{
		private static ProductFilterBLL instance;

		public static ProductFilterBLL Instance
		{
			get
			{
				if (instance == null)
					instance = new ProductFilterBLL();
				return instance;
			}
			private set => instance = value;
		}

		/// <summary>
		/// Lấy thông tin tên bảng của các thực thể
		/// </summary>
		/// <returns></returns>
		public DataTable TableProductName()
		{
			DataTable data = ProductFilterDAL.Instance.TableProductName();
			return data;
		}

		/// <summary>
		/// Lấy thông tin dữ liệu lọc
		/// </summary>
		/// <param name="tableName">Tên thực thể</param>
		/// <returns>Thông tin thuộc tính cần lọc</returns>
		public DataTable GetInfoProductFilter(string tableName)
		{
			DataTable data = ProductFilterDAL.Instance.GetInfoProductFilter(tableName);
			return data;
		}

		public DataTable GetColumnProductName(string tableName)
		{
			DataTable data = ProductFilterDAL.Instance.GetColumnProductName(tableName);
			return data;
		}

		/// <summary>
		/// Lọc sản phẩm
		/// </summary>
		/// <param name="tableName">Tên thực thể</param>
		/// <param name="table">Dữ liệu cần lọc theo</param>
		/// <returns>Dữ liệu trả về sau khi lọc</returns>
		public DataTable ProductFilter(string tableName, DataTable table)
		{
			return ProductFilterDAL.Instance.ProductFilter(tableName, table);
		}
	}
}
