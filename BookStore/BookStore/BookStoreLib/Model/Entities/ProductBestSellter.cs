using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Model.Entities
{
	public class ProductBestSellter
	{
		public int MaSP { get; set; }
		public string TenSP { get; set; }
		public int SoLuongBan { get; set; }

		public ProductBestSellter()
		{

		}

		public ProductBestSellter(DataRow row)
		{
			MaSP = (int)row["MaSP"];
			TenSP = row["TenSP"].ToString();
			SoLuongBan = (int)row["SoLuongBan"];
		}
	}
}
