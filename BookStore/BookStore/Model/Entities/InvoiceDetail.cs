using BookStore.ChildForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Model.Entities
{
	public class InvoiceDetail
	{
		public string MaHoaDon { get; set; }
		public string TenKhachHang { get; set; }
		public string DiaChi { get; set; }
		public string SDT { get; set; }
		public string ThoiGian { get; set; }
		public string HinhThucThanhToan { get; set; }
		public string TongTienHang { get; set; }
		public decimal GiamGia { get; set; }
		public string TongThanhToan { get; set; }
		public string Note { get; set; }
		public List<BillRowBox> ListOfBillRow { get; set; }

		public InvoiceDetail()
		{

		}

		public InvoiceDetail(string maHoaDon, string tenKhachHang, string diaChi, string SDT, string thoiGian,
			string hinhThucThanhToan, string tongTienHang, decimal giamGia, string tongThanhToan, string note, List<BillRowBox> listOfBillRow = null)
		{
			MaHoaDon = maHoaDon;
			TenKhachHang = tenKhachHang;
			DiaChi = diaChi;
			this.SDT = SDT;
			ThoiGian = thoiGian;
			HinhThucThanhToan = hinhThucThanhToan;
			TongTienHang = tongTienHang;
			GiamGia = giamGia;
			TongThanhToan = tongThanhToan;
			Note = note;
			if (listOfBillRow != null)
				ListOfBillRow = listOfBillRow;
		}
	}
}
