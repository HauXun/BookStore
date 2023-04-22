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
	public class ProductDAL
	{
		private static ProductDAL instance;

		public static ProductDAL Instance
		{
			get
			{
				if (instance == null)
					instance = new ProductDAL();
				return instance;
			}
			private set => instance = value;
		}

		/// <summary>
		/// Sản phẩm bán chạy nhất
		/// </summary>
		/// <returns></returns>
		public DataTable TheBestSellter()
		{
			string query = "EXEC dbo.USP_TheBestSellter";
			DataTable data = DataProvider.Instance.ExcuteQuery(query);
			return data;
		}

		/// <summary>
		/// Lấy danh sách sản phẩm
		/// </summary>
		/// <returns></returns>
		public DataTable GetAllProduct()
		{
			string query = "EXEC dbo.USP_GetAllProduct";
			DataTable data = DataProvider.Instance.ExcuteQuery(query);
			return data;
		}

		/// <summary>
		/// Lấy sản phẩm theo mã
		/// </summary>
		/// <param name="maSP"></param>
		/// <returns></returns>
		public DataTable GetProductByID(string maSP)
		{
			string query = "EXEC dbo.USP_GetProductByID @MaSP";
			DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { maSP });
			return data;
		}

		/// <summary>
		/// Hủy sản phẩm theo mã
		/// </summary>
		/// <param name="maSP"></param>
		/// <returns></returns>
		public int CancleProductByID(string maSP)
		{
			string query = "EXEC dbo.USP_CancleProductByID @MaSP";
			return DataProvider.Instance.ExcuteNonQuery(query, new object[] { maSP });
		}

		/// <summary>
		/// Tìm sản phẩm
		/// </summary>
		/// <param name="keyword"></param>
		/// <returns></returns>
		public DataTable SearchProduct(string keyword)
		{
			string query = "EXEC dbo.USP_SearchProduct @keyword";
			return DataProvider.Instance.ExcuteQuery(query, new object[] { keyword });
		}

		/// <summary>
		/// Thêm văn phòng phẩm
		/// </summary>
		/// <param name="propertiesQueryParameters"></param>
		/// <param name="sanPham"></param>
		/// <returns></returns>
		public int InsertVPP(string propertiesQueryParameters, SanPham sanPham)
		{
			string query = "EXEC dbo.USP_InsertVPP " + propertiesQueryParameters;
			return DataProvider.Instance.ExcuteNonQuery(query, new object[]
			{
				sanPham.TenSP,
				sanPham.ThuongHieu,
				sanPham.DVT,
				sanPham.Gia
			});
		}

		/// <summary>
		/// Thêm sách
		/// </summary>
		/// <param name="propertiesQueryParameters"></param>
		/// <param name="sanPham"></param>
		/// <param name="sach"></param>
		/// <returns></returns>
		public int InsertSach(string propertiesQueryParameters, SanPham sanPham, Sach sach)
		{
			string query = "EXEC dbo.USP_InsertSach " + propertiesQueryParameters;
			return DataProvider.Instance.ExcuteNonQuery(query, new object[]
			{
				sanPham.TenSP,
				sanPham.ThuongHieu,
				sanPham.DVT,
				sanPham.Gia,
				sach.TacGia,
				sach.NamXB,
				sach.NhaXB
			});
		}

		/// <summary>
		/// Thêm bút
		/// </summary>
		/// <param name="propertiesQueryParameters"></param>
		/// <param name="sanPham"></param>
		/// <param name="but"></param>
		/// <returns></returns>
		public int InsertBut(string propertiesQueryParameters, SanPham sanPham, But but)
		{
			string query = "EXEC dbo.USP_InsertBut " + propertiesQueryParameters;
			return DataProvider.Instance.ExcuteNonQuery(query, new object[]
			{
				sanPham.TenSP,
				sanPham.ThuongHieu,
				sanPham.DVT,
				sanPham.Gia,
				but.MauSac,
				but.ChatLieu,
				but.MauMuc
			});
		}

		/// <summary>
		/// Thêm thiết bị điện tử
		/// </summary>
		/// <param name="propertiesQueryParameters"></param>
		/// <param name="sanPham"></param>
		/// <param name="thietBiDienTu"></param>
		/// <returns></returns>
		public int InsertTBDT(string propertiesQueryParameters, SanPham sanPham, ThietBiDienTu thietBiDienTu)
		{
			string query = "EXEC dbo.USP_InsertTBDT " + propertiesQueryParameters;
			return DataProvider.Instance.ExcuteNonQuery(query, new object[]
			{
				sanPham.TenSP,
				sanPham.ThuongHieu,
				sanPham.DVT,
				sanPham.Gia,
				thietBiDienTu.MauSac,
				thietBiDienTu.ChatLieu,
				thietBiDienTu.BaoHanh,
				thietBiDienTu.ThongSoKiThuat
			});
		}
	}
}
