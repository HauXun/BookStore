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

	public partial class DoiTac
    {
        public string MaDT { get; set; }
        public string TenDT { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }

		public DoiTac()
		{

		}

		public DoiTac(string maDT, string tenDT, string diaChi, string sDT)
		{
			MaDT = maDT;
			TenDT = tenDT;
			DiaChi = diaChi;
			SDT = sDT;
		}

		public DoiTac(DataRow row)
		{
			MaDT = row["MaDT"].ToString();
			TenDT = row["TenDT"].ToString();
			DiaChi = row["DiaChi"].ToString();
			SDT = row["SDT"].ToString();
		}
	}
}