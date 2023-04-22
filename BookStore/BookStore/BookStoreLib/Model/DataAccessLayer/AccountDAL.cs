using BookStore.Extensions;
using BookStore.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Model.DataAccessLayer
{
	public class AccountDAL
	{
		private static AccountDAL instance;

		public static AccountDAL Instance
		{
			get
			{
				if (instance == null)
					instance = new AccountDAL();
				return instance;
			}
			private set => instance = value;
		}

		public Taikhoan GetAccount(string idAccount, string password)
		{
			byte[] temp = ASCIIEncoding.ASCII.GetBytes(password);
			byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);

			string pass = string.Join("", hasData);

			string query = "EXEC dbo.USP_GetAccount @IDAccount , @Password";
			DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { idAccount, pass });
			foreach (DataRow item in data.Rows)
			{
				return new Taikhoan(item);
			}
			return null;
		}

		public int CreateAccount(Taikhoan taikhoan)
		{
			string query = "EXEC dbo.USP_CreateAccount @HoTen , @DiaChi , @SDT , @RoleID";
			return DataProvider.Instance.ExcuteNonQuery(query, new object[]
			{
				taikhoan.HoTen, 
				taikhoan.DiaChi,
				taikhoan.SDT,
				taikhoan.RoleID,
			});
		}

		public int CancleAccount(string name, string sdt)
		{
			string query = "EXEC dbo.USP_CancleAccount @Name , @SDT";
			return DataProvider.Instance.ExcuteNonQuery(query, new object[] { name, sdt });
		}

		public int ResetPassword(string idAccount)
		{
			string query = "EXEC dbo.USP_ResetPassword @IDAccount";
			return DataProvider.Instance.ExcuteNonQuery(query, new object[] { idAccount });
		}

		public DataTable GetAllAccount()
		{
			string query = "SELECT * FROM dbo.Taikhoan";
			return DataProvider.Instance.ExcuteQuery(query);
		}

		public DataTable GetAllAccountRole()
		{
			string query = "SELECT * FROM dbo.UserRole";
			return DataProvider.Instance.ExcuteQuery(query);
		}
	}
}
