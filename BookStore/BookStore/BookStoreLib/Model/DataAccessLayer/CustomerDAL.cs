using BookStore.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Model.DataAccessLayer
{
	public class CustomerDAL
	{
		private static CustomerDAL instance;

		public static CustomerDAL Instance
		{
			get
			{
				if (instance == null)
					instance = new CustomerDAL();
				return instance;
			}
			private set => instance = value;
		}

		public DataTable GetAllCustomer(bool isCustomer = true)
		{
			string query = "SELECT * FROM dbo.DoiTac WHERE MaDT LIKE 'K%'";
			if (isCustomer)
			{
				query = "SELECT * FROM dbo.DoiTac WHERE MaDT LIKE 'C%'";
			}
			return DataProvider.Instance.ExcuteQuery(query);
		}

		public DataTable InsertDoiTac(string tenDT, string diaChi, string sdt, bool isCustomer = true)
		{
			string query = "EXEC dbo.USP_InsertDoiTac @TenDT , @DiaChi , @SDT , @isCustomer";
			return DataProvider.Instance.ExcuteQuery(query, new object[] { tenDT, diaChi, sdt, isCustomer });
		}

		public DataTable SearchDoiTac(string keyword, bool isCustomer = true)
		{
			string query = $"USP_SearchDoiTac @keyword , @isCustomer";
			return DataProvider.Instance.ExcuteQuery(query, new object[] { keyword, isCustomer });
		}

		public DataTable GetDoiTacByInfo(string tenDT, string diaChi, string sdt)
		{
			string query = "EXEC dbo.USP_GetDoiTacByInfo @TenDT , @DiaChi , @SDT";
			return DataProvider.Instance.ExcuteQuery(query, new object[] { tenDT, diaChi, sdt });
		}
	}
}
