using BookStore.ChildForm;
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

		public InvoiceDetail GetInvoiceDetail(int maHoaDon)
		{
			DataTable data = BillDAL.Instance.GetInvoiceDetail(maHoaDon);
			DataRow row = data.Rows[0];
			return new InvoiceDetail()
			{
				MaHoaDon = int.Parse(row["MaHoaDon"].ToString()),
				TenKhachHang = row["TenKhachHang"].ToString(),
				DiaChi = row["DiaChi"].ToString(),
				SDT = row["SDT"].ToString(),
				NguoiBan = row["HoTen"].ToString(),
				LoaiHoaDon = row["LoaiHoaDon"].ToString(),
				ThoiGian = row["ThoiGian"].ToString(),
				TongTienHang = row["TongTienHang"].ToString(),
				GiamGia = decimal.Parse(row["GiamGia"].ToString()),
				TongThanhToan = row["TongThanhToan"].ToString(),
				Status = (bool)row["Status"],
				ListOfBillRow = GetBillDetailByID(maHoaDon)
			};
		}

		public List<BillRowBox> GetBillDetailByID(int maHoaDon)
		{
			DataTable data = BillDAL.Instance.GetBillDetailByID(maHoaDon);
			List<BillRowBox> result = new List<BillRowBox>();
			foreach (DataRow row in data.Rows)
			{
				result.Add(new BillRowBox(
					row["TenSP"].ToString(),
					decimal.Parse(row["Gia"].ToString()),
					Convert.ToByte(row["SoLuong"].ToString()))
				{
					Tag = new Tuple<string, int>(row["MaSP"].ToString(), int.Parse(row["SoLuongTon"].ToString()))
				});
			}
			return result;
		}
	}
}
