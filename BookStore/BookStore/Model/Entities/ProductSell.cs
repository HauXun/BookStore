using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Model.Entities
{
	public class ProductSell
	{
		public int MaSP { get; set; }
		public string TenSP { get; set; }
		public int SoLuong { get; set; }
		public float TongTien { get; set; }

		public ProductSell()
		{

		}

		public ProductSell(DataRow row)
		{
			MaSP = (int)row["MaSP"];
			TenSP = row["TenSP"].ToString();
			SoLuong = (int)row["SoLuong"];
			if (row.Table.Columns.Count == 4)
				TongTien = float.Parse(row["TongTien"].ToString());
		}
	}
}
