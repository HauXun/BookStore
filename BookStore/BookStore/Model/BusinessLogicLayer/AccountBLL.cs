using BookStore.Model.DataAccessLayer;
using BookStore.Model.Entities;
using System.Data;

namespace BookStore.Model.BusinessLogicLayer
{
	public class AccountBLL
	{
		private static AccountBLL instance;

		public static AccountBLL Instance
		{
			get
			{
				if (instance == null)
					instance = new AccountBLL();
				return instance;
			}
			private set => instance = value;
		}

		public Taikhoan GetAccount(string idAccount, string password)
		{
			return AccountDAL.Instance.GetAccount(idAccount, password);
		}

		public int CreateAccount(Taikhoan taikhoan)
		{
			return AccountDAL.Instance.CreateAccount(taikhoan);
		}

		public int CancleAccount(string name, string sdt)
		{
			return AccountDAL.Instance.CancleAccount(name, sdt);
		}

		public int ResetPassword(string idAccount)
		{
			return AccountDAL.Instance.ResetPassword(idAccount);
		}

		public DataTable GetAllAccount()
		{
			return AccountDAL.Instance.GetAllAccount();
		}

		public DataTable GetAllAccountRole()
		{
			return AccountDAL.Instance.GetAllAccountRole();
		}
	}
}
