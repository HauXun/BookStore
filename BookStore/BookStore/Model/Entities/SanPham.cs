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
    
    public partial class SanPham
    {
        public int MaSP { get; set; }
        public string TenSP { get; set; }
        public string DVT { get; set; }
        public int SoLuongTon { get; set; }
        public double Gia { get; set; }
        public string ThuongHieu { get; set; }
		public bool Cancellation { get; set; }
	}
}
