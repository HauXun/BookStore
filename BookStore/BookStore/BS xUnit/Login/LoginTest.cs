using BookStore.Model.BusinessLogicLayer;
using BookStore.Model.DataAccessLayer;
using BookStore.Model.Entities;
using System.ComponentModel;
using System.Data;

namespace BS_xUnit.Login
{
    public class LoginTest
    {
        Taikhoan taikhoan = new Taikhoan();
        [Theory]
        [InlineData("admin", "0")]
        public void Login(string username, string password)
        {
            Assert.True(!username.IsNullOrEmpty() && !password.IsNullOrEmpty() && !username.IsSpaceCharacters() && !password.IsSpaceCharacters());
            taikhoan = AccountBLL.Instance.GetAccount(username, password);
            Assert.Equal("admin", taikhoan.IDAccount);
            Assert.Equal("0", "0");
        }

       
        [Theory]
        [InlineData("Sòu đời 123", "0852987191")]
        [InlineData("Triệu Trọng Hậu", "0852987191")]
        public void CancelAccount(string name, string sdt)
        {
            Assert.True(!name.IsNullOrEmpty() && !sdt.IsNullOrEmpty() && !sdt.IsSpaceCharacters());
            int active = AccountBLL.Instance.CancleAccount(name, sdt);
            Assert.Equal(1, active);
        }

        [Theory]
        [InlineData("admin")]
        [InlineData("S0001")]
        public void ResetPassword(string IdAccount)
        {
            if(!IdAccount.IsNullOrEmpty() && !IdAccount.IsSpaceCharacters())
            {
                int success = AccountBLL.Instance.ResetPassword(IdAccount);
                Assert.Equal(1, success);
            }
        }

        [Fact]
        public void CreateAccount()
        {
            Taikhoan taikhoan = new Taikhoan { IDAccount = "admin2", Password = "3", HoTen = "Abc", DiaChi = "83 Nguyễn Công Trứ, Phường 2, TP.Đà Lạt, Lâm Đồng",
                SDT = "0852987191", Active = true, RoleID = "staff" };
            Assert.True(!taikhoan.HoTen.IsNullOrEmpty() && !taikhoan.HoTen.IsSpaceCharacters() &&
                !taikhoan.IDAccount.IsNullOrEmpty() && !taikhoan.IDAccount.IsSpaceCharacters()
                && !taikhoan.Password.IsNullOrEmpty() && !taikhoan.Password.IsSpaceCharacters()
                 && !taikhoan.DiaChi.IsNullOrEmpty()
                  && !taikhoan.SDT.IsNullOrEmpty()
                   && (!taikhoan.Active.Equals(true) || !taikhoan.Active.Equals(false))
                    && !taikhoan.RoleID.IsNullOrEmpty() && !taikhoan.RoleID.IsSpaceCharacters());
            var result=AccountBLL.Instance.CreateAccount(taikhoan);
            Assert.Equal(1, result);
        }

        [Fact]
        public void TestGetAllAccount()
        {
            AccountDAL accountDAL = new AccountDAL();
            DataTable result = accountDAL.GetAllAccount();
            Assert.NotNull(result);
            Assert.IsType<DataTable>(result);
            Assert.NotEmpty(result.Rows);
        }

        [Fact]
        public void TestGetAllAccountRole()
        {
            AccountDAL accountDAL = new AccountDAL();
            DataTable result = accountDAL.GetAllAccountRole();
            Assert.NotNull(result);
            Assert.IsType<DataTable>(result);
            Assert.NotEmpty(result.Rows);
        }
    }
}