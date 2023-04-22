using BookStore.Extensions.Popup;
using BookStore.Model.Entities;
using BookStore.Partial;
using System;
using System.Windows.Forms;

namespace BookStore.ChildForm
{
	public partial class NewDoiTacKhachHang : ModelPopup
	{
		public DoiTac Respone { get; set; }
		public NewDoiTacKhachHang() : base()
		{
			InitializeComponent();
			Content.Region = System.Drawing.Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, Content.Width, Content.Height, 15, 15));
		}

		private bool IsValidInfo()
		{
			// Kiểm tra xem thông tin hợp lệ chưa?
			// Xóa bỏ những thông báo lỗi nếu có
			errorProviderWar.SetError(tbName, "");
			errorProviderWar.SetError(tbAdress, "");
			errorProviderWar.SetError(tbSDT, "");

			// Kiểm tra	tên nhân viên không được để trống
			if (tbName.Text.Trim().Equals(""))
			{
				errorProviderWar.SetError(tbName, "Tên đối tác không được để trống!");
				return false;
			}

			// Kiểm tra địa chỉ không được để trống
			if (tbAdress.Text.Trim().Equals(""))
			{
				errorProviderWar.SetError(tbAdress, "Địa chỉ đối tác\nkhông được để trống!");
				return false;
			}

			// Kiểm tra sdt không được để trống
			if (tbSDT.Text.Trim().Equals(""))
			{
				errorProviderWar.SetError(tbSDT, "Số điện thoại đối tác\nkhông được để trống!");
				return false;
			}
			
			return true;
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			if (!IsValidInfo())
				return;
			
			if (MessageBox.Show("Tạo đối tác này", "Book Store",
			   MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
			{
				this.Respone = new DoiTac();
				this.Respone.TenDT = tbName.Text;
				this.Respone.DiaChi = tbAdress.Text;
				this.Respone.SDT = tbSDT.Text;
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
	}
}
