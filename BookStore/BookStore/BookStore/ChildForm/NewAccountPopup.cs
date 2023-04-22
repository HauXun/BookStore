using BookStore.Extensions.Popup;
using BookStore.Model.BusinessLogicLayer;
using BookStore.Model.Entities;
using BookStore.Partial;
using System;
using System.Data;
using System.Windows.Forms;

namespace BookStore.ChildForm
{
	public partial class NewAccountPopup : ModelPopup
	{
		public Taikhoan Respone { get; set; }
		public NewAccountPopup() : base()
		{
			InitializeComponent();
			Content.Region = System.Drawing.Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, Content.Width, Content.Height, 15, 15));
		}

		private bool IsValidInfo()
		{
			// Kiểm tra xem thông tin hợp lệ chưa?
			// Xóa bỏ những thông báo lỗi nếu có
			errorProviderWar.SetError(tbName, "");
			errorProviderWar.SetError(tbAddress, "");
			errorProviderWar.SetError(tbSDT, "");
			errorProviderWar.SetError(cbRole, "");

			// Kiểm tra	tên nhân viên không được để trống
			if (tbName.Text.Trim().Equals(""))
			{
				errorProviderWar.SetError(tbName, "Họ tên không được để trống!");
				return false;
			}

			if (tbAddress.Text.Trim().Equals(""))
			{
				errorProviderWar.SetError(tbAddress, "Địa chỉ tài khoản\nkhông được để trống!");
				return false;
			}

			if (cbRole.SelectedIndex == -1)
			{
				errorProviderWar.SetError(tbAddress, "Vui lòng chọn vai trò\nđảm nhiệm của tài khoản!");
				return false;
			}

			// Kiểm tra sdt không được để trống
			if (tbSDT.Text.Trim().Equals(""))
			{
				errorProviderWar.SetError(tbSDT, "Số điện thoại tài khoản\nkhông được để trống!");
				return false;
			}
			
			return true;
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			if (!IsValidInfo())
				return;
			
			if (MessageBox.Show("Tạo tài khoản này", "Book Store",
			   MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
			{
				this.Respone = new Taikhoan();
				this.Respone.HoTen = tbName.Text;
				this.Respone.DiaChi = tbAddress.Text;
				this.Respone.SDT = tbSDT.Text;
				this.Respone.RoleID = cbRole.SelectedValue.ToString();
				this.dialogResult = DialogResult.OK;
			}
		}

		private void lbBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.dialogResult = DialogResult.Cancel;
		}

		private void lbBack_MouseLeave(object sender, EventArgs e)
		{
			(sender as LinkLabel).LinkBehavior = LinkBehavior.NeverUnderline;
		}

		private void lbBack_MouseEnter(object sender, EventArgs e)
		{
			(sender as LinkLabel).LinkBehavior = LinkBehavior.SystemDefault;
		}

		private void NewStaffPopup_Load(object sender, EventArgs e)
		{
			DataTable data = AccountBLL.Instance.GetAllAccountRole();
			cbRole.DisplayMember = "RoleName";
			cbRole.ValueMember = "RoleID";
			cbRole.DataSource = data;
		}
	}
}
