//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookStore.Model.Entities
{
	using System;
	using System.Collections.Generic;
	using System.Data;

	public partial class HoaDon
	{
		public int? MaHoaDon { get; set; }
		public string NguoiBan { get; set; }
		public System.DateTime NgayGiaoDich { get; set; }
		public string MaDT { get; set; }
		public string LoaiHoaDon { get; set; }
		public decimal GiamGia { get; set; }
		public double TongTien { get; set; }
		public bool Status { get; set; }

		public HoaDon()
		{

		}

		public HoaDon(DataRow row, DataTable data = null)
		{
			MaHoaDon = (int)row["MaHoaDon"];
			if (data != null && data.Columns.Contains("NguoiBan"))
				NguoiBan = row["NguoiBan"].ToString();
			NgayGiaoDich = Convert.ToDateTime(row["NgayGiaoDich"]);
			MaDT = row["MaDT"].ToString();
			LoaiHoaDon = row["LoaiHoaDon"].ToString();
			GiamGia = decimal.Parse(row["GiamGia"].ToString());
			TongTien = (double)row["TongTien"];
			if (data != null && data.Columns.Contains("Status"))
				Status = (bool)row["Status"];
		}

		public HoaDon(string nguoiBan, DateTime ngayGiaoDich, string maDT, string loaiHoaDon, decimal giamGia,
			double tongTien, bool status = false, int? maHoaDon = null)
		{
			MaHoaDon = maHoaDon;
			NguoiBan = nguoiBan;
			NgayGiaoDich = ngayGiaoDich;
			MaDT = maDT;
			LoaiHoaDon = loaiHoaDon;
			GiamGia = giamGia;
			TongTien = tongTien;
			Status = status;
		}
	}
}
