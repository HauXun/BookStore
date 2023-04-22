using BookStore.Extensions;
using BookStore.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Model.DataAccessLayer
{
	public class BillDAL
	{
		private static BillDAL instance;

		public static BillDAL Instance
		{
			get
			{
				if (instance == null)
					instance = new BillDAL();
				return instance;
			}
			private set => instance = value;
		}

		public object InsertBill(HoaDon hoaDon)
		{
			string query = "EXEC dbo.USP_InsertBill @NguoiBan , @NgayGiaoDich , @MaDT , @LoaiHoaDon , @GiamGia , @TongTien , @Status";
			return DataProvider.Instance.ExcuteScalar(query, new object[]
			{
				hoaDon.NguoiBan,
				hoaDon.NgayGiaoDich,
				hoaDon.MaDT,
				hoaDon.LoaiHoaDon,
				hoaDon.GiamGia,
				hoaDon.TongTien,
				hoaDon.Status
			});
		}

		public int EditBill(HoaDon hoaDon)
		{
			string query = "EXEC dbo.USP_EditBill @MaHoaDon , @NguoiBan , @MaDT , @GiamGia , @TongTien , @Status";
			return DataProvider.Instance.ExcuteNonQuery(query, new object[]
			{
				hoaDon.MaHoaDon,
				hoaDon.NguoiBan,
				hoaDon.MaDT,
				hoaDon.GiamGia,
				hoaDon.TongTien,
				hoaDon.Status
			});
		}

		public int InsertBillDetail(ChiTietHoaDon chiTietHoaDon)
		{
			string query = "EXEC dbo.USP_InsertBillDetail @MaHoaDon , @MaSP , @SoLuong , @Gia";
			return DataProvider.Instance.ExcuteNonQuery(query, new object[]
			{
				chiTietHoaDon.MaHoaDon,
				chiTietHoaDon.MaSP,
				chiTietHoaDon.SoLuong,
				chiTietHoaDon.Gia
			});
		}

		public int DeleteBillDetail(int maHoaDon)
		{
			string query = "EXEC dbo.USP_DeleteBillDetail @MaHoaDon";
			return DataProvider.Instance.ExcuteNonQuery(query, new object[] { maHoaDon });
		}

		/// <summary>
		/// Lấy thông tin các kiểu hóa đơn
		/// </summary>
		/// <returns></returns>
		public DataTable GetAllBillRole()
		{
			string query = "SELECT * FROM dbo.LoaiHoaDon";
			return DataProvider.Instance.ExcuteQuery(query);
		}

		public DataTable GetInvoiceDetail(int maHoaDon)
		{
			string query = "EXEC dbo.USP_GetInvoiceDetail @MaHoaDon";
			return DataProvider.Instance.ExcuteQuery(query, new object[] { maHoaDon });
		}

		public DataTable GetBillDetailByID(int maHoaDon)
		{
			string query = "EXEC dbo.USP_GetBillDetailByID @MaHoaDon";
			return DataProvider.Instance.ExcuteQuery(query, new object[] { maHoaDon });
		}
	}
}
