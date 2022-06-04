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
	public class CustomerBLL
	{
		private static CustomerBLL instance;

		public static CustomerBLL Instance
		{
			get
			{
				if (instance == null)
					instance = new CustomerBLL();
				return instance;
			}
			private set => instance = value;
		}

		public List<DoiTac> GetAllCustomer(bool isCustomer = true)
		{
			DataTable data = CustomerDAL.Instance.GetAllCustomer(isCustomer);
			List<DoiTac> results = new List<DoiTac>();
			foreach (DataRow row in data.Rows)
			{
				results.Add(new DoiTac(row));
			}
			return results;
		}

		public DoiTac InsertDoiTac(string tenDT, string diaChi, string sdt, bool isCustomer = true)
		{
			return new DoiTac(CustomerDAL.Instance.InsertDoiTac(tenDT, diaChi, sdt, isCustomer).Rows[0]);
		}

		public List<DoiTac> SearchDoiTac(string keyword, bool isCustomer = true)
		{
			DataTable data = CustomerDAL.Instance.SearchDoiTac(keyword, isCustomer);
			List<DoiTac> results = new List<DoiTac>();
			foreach (DataRow row in data.Rows)
			{
				results.Add(new DoiTac(row));
			}
			return results;
		}

		public DoiTac GetDoiTacByInfo(string tenDT, string diaChi, string sdt)
		{
			return new DoiTac(CustomerDAL.Instance.GetDoiTacByInfo(tenDT, diaChi, sdt).Rows[0]);
		}
	}
}
