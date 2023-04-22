using BookStore.Model.BusinessLogicLayer;
using BookStore.Model.DataAccessLayer;
using BookStore.Model.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BS_xUnit.Bill
{
    public class BillTest
    {
        AnalysisBLL analysisBLL = new AnalysisBLL();
        BillBLL billBLL = new BillBLL();
        HoaDon hoaDon = new HoaDon();
        #region Test Func
        // Dùng cho trường hợp không có tham số
        //[Fact]
        [Fact]
        public void Insert()
        {
            var hoaDon = new HoaDon {NguoiBan="admin",NgayGiaoDich=new DateTime(2023,04,19),MaDT="K0003",LoaiHoaDon="XBill",GiamGia=0,TongTien=165000,Status=true};
            var res = BillBLL.Instance.InsertBill(hoaDon);
            Assert.Equal(209,res);
        }

        [Fact]
        public void Edit()
        {
            var hoaDon = new HoaDon {MaHoaDon=97, NguoiBan = "admin", NgayGiaoDich = new DateTime(2023, 04,26), MaDT = "K0003", LoaiHoaDon = "XBill", GiamGia = 0, TongTien = 165000, Status = true };
            var res=BillBLL.Instance.EditBill(hoaDon);
            Assert.Equal(1, res);
        }

        //[Fact]
        //public void Delete() 
        //{
        //    // Tạo đối tượng ChiTietHoaDon
        //    var chiTietHoaDon = new ChiTietHoaDon { MaHoaDon = 56, MaSP = 16, SoLuong = 1, Gia = 50000 };

        //    // Thêm đối tượng ChiTietHoaDon vào cơ sở dữ liệu
        //    var result = BillBLL.Instance.InsertBillDetail(chiTietHoaDon);

        //    // Kiểm tra giá trị trả về của phương thức
        //    Assert.Equal(1, result);

        //}
        #endregion
    }
}
