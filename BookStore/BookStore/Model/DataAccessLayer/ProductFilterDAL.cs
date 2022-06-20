using BookStore.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Model.DataAccessLayer
{
	public class ProductFilterDAL
	{
		private static ProductFilterDAL instance;

		public static ProductFilterDAL Instance
		{
			get
			{
				if (instance == null)
					instance = new ProductFilterDAL();
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
			string query = "EXEC dbo.USP_TableProductName";
			DataTable data = DataProvider.Instance.ExcuteQuery(query);
			return data;
		}

		/// <summary>
		/// Lấy thông tin dữ liệu lọc
		/// </summary>
		/// <param name="tableName">Tên thực thể</param>
		/// <returns>Thông tin thuộc tính cần lọc</returns>
		public DataTable GetInfoProductFilter(string tableName)
		{
			string query = "EXEC dbo.USP_GetInfoProductFilter @TableName";
			DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { tableName });
			return data;
		}

		public DataTable GetColumnProductName(string tableName)
		{
			string query = "EXEC dbo.USP_GetColumnProductName @TableName";
			DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { tableName });
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
			string query = "dbo.USP_ProductFilter";
			DataTable data = new DataTable();
			using (SqlConnection connection = new SqlConnection(DataProvider.connectionString))
			{
				connection.Open();
				SqlCommand command = new SqlCommand(query, connection);
				command.CommandType = CommandType.StoredProcedure;
				command.Connection = connection;
				command.Parameters.AddWithValue("@Table_Name", tableName);
				command.Parameters.AddWithValue("@Table", table);
				SqlDataAdapter adapter = new SqlDataAdapter(command);
				adapter.Fill(data);
				connection.Dispose();
			}
			return data;
		}
	}
}
