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

	public partial class Taikhoan
    {
        public string IDAccount { get; set; }
        public string Password { get; set; }
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public string SDT { get; set; }
        public bool Active { get; set; }
        public string RoleID { get; set; }

		public Taikhoan()
		{

		}

        public Taikhoan(DataRow row)
        {
            IDAccount = row["IDAccount"].ToString();
            HoTen = row["HoTen"].ToString();
            DiaChi = row["DiaChi"].ToString();
            SDT = row["SDT"].ToString();
            Active = (bool)row["Active"];
            RoleID = row["RoleID"].ToString();
        }
    }
}