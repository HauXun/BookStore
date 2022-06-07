using BookStore.Extensions;
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
	public class ProductBLL
	{
		private static ProductBLL instance;

		public static ProductBLL Instance
		{
			get
			{
				if (instance == null)
					instance = new ProductBLL();
				return instance;
			}
			private set => instance = value;
		}

		/// <summary>
		/// Sản phẩm bán chạy nhất
		/// </summary>
		/// <returns></returns>
		public List<ProductBestSellter> TheBestSellter()
		{
			DataTable data = ProductDAL.Instance.TheBestSellter();
			if (data.Rows.Count > 0)
			{
				List<ProductBestSellter> result = new List<ProductBestSellter>();
				foreach (DataRow row in data.Rows)
				{
					result.Add(new ProductBestSellter(row));
				}
				return result;
			}
			return null;
		}

		/// <summary>
		/// Lấy danh sách sản phẩm
		/// </summary>
		/// <returns></returns>
		public DataTable GetAllProduct()
		{
			DataTable data = ProductDAL.Instance.GetAllProduct();
			return data;
		}

		/// <summary>
		/// Lấy sản phẩm theo mã
		/// </summary>
		/// <param name="maSP"></param>
		/// <returns></returns>
		public DataTable GetProductByID(string maSP)
		{
			DataTable data = ProductDAL.Instance.GetProductByID(maSP);
			return data;
		}

		/// <summary>
		/// Hủy sản phẩm theo mã
		/// </summary>
		/// <param name="maSP"></param>
		/// <returns></returns>
		public int CancleProductByID(string maSP)
		{
			return ProductDAL.Instance.CancleProductByID(maSP);
		}

		/// <summary>
		/// Tìm sản phẩm
		/// </summary>
		/// <param name="keyword"></param>
		/// <returns></returns>
		public DataTable SearchProduct(string keyword)
		{
			return ProductDAL.Instance.SearchProduct(keyword);
		}

		/// <summary>
		/// Thêm văn phòng phẩm
		/// </summary>
		/// <param name="propertiesQueryParameters"></param>
		/// <param name="sanPham"></param>
		/// <returns></returns>
		public int InsertVPP(string propertiesQueryParameters, SanPham sanPham)
		{
			return ProductDAL.Instance.InsertVPP(propertiesQueryParameters, sanPham)
;		}

		/// <summary>
		/// Thêm sách
		/// </summary>
		/// <param name="propertiesQueryParameters"></param>
		/// <param name="sanPham"></param>
		/// <param name="sach"></param>
		/// <returns></returns>
		public int InsertSach(string propertiesQueryParameters, SanPham sanPham, Sach sach)
		{
			return ProductDAL.Instance.InsertSach(propertiesQueryParameters, sanPham, sach);
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
			return ProductDAL.Instance.InsertBut(propertiesQueryParameters, sanPham, but);
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
			return ProductDAL.Instance.InsertTBDT(propertiesQueryParameters, sanPham, thietBiDienTu);
		}
	}
}
