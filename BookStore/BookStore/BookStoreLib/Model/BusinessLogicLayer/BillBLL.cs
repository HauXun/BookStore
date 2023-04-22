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
	public class BillBLL
	{
		private static BillBLL instance;

		public static BillBLL Instance
		{
			get
			{
				if (instance == null)
					instance = new BillBLL();
				return instance;
			}
			private set => instance = value;
		}

		public int InsertBill(HoaDon hoaDon)
		{
			return int.Parse(BillDAL.Instance.InsertBill(hoaDon).ToString());
		}

		public int EditBill(HoaDon hoaDon)
		{
			return BillDAL.Instance.EditBill(hoaDon);
		}

		public int InsertBillDetail(ChiTietHoaDon chiTietHoaDon)
		{
			return BillDAL.Instance.InsertBillDetail(chiTietHoaDon);
		}

		public int DeleteBillDetail(int maHoaDon)
		{
			return BillDAL.Instance.DeleteBillDetail(maHoaDon);
		}

		/// <summary>
		/// Lấy thông tin các kiểu hóa đơn
		/// </summary>
		/// <returns></returns>
		public DataTable GetAllBillRole()
		{
			return BillDAL.Instance.GetAllBillRole();
		}
	}
}
