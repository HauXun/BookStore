using BookStore.Extensions;
using System;
using System.Collections.Generic;
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

		public object InsertDoiTac(string tenDT, string diaChi, string sdt)
		{
			string query = "EXEC dbo.USP_InsertDoiTac @TenDT , @DiaChi , @SDT";
			return DataProvider.Instance.ExcuteScalar(query, new object[] { tenDT, diaChi, sdt });
		}
	}
}
