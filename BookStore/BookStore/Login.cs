using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using BookStore.Model.BusinessLogicLayer;
using BookStore.Model.Entities;
using BookStore.Partial;

namespace BookStore
{
	public partial class Login : Form
	{
		public Login()
		{
			InitializeComponent();

			// Bo tròn control
			GetRounded();
		}

		#region Methods

		/// <summary>
		/// Bo tròn các control
		/// </summary>
		private void GetRounded()
		{
			Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, Width, Height, 10, 10));
			btnExit.Region = Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, btnExit.Width, btnExit.Height, 6, 6));
		}

		/// <summary>
		/// Kiểm tra toàn vẹn dữ liệu nhập
		/// </summary>
		/// <returns></returns>
		private bool IsValidUser()
		{
			// Kiểm tra xem thông tin hợp lệ chưa?
			// Xóa bỏ những thông báo lỗi nếu có
			errorProviderWar.SetError(tbUsername, "");
			errorProviderWar.SetError(tbPassword, "");

			// Kiểm tra	tên đăng nhập không được để trống
			if (tbUsername.Text.Trim().Equals(""))
			{
				// Báo lỗi nếu sai
				errorProviderWar.SetError(tbUsername, "Tên đăng nhập\nkhông được để trống!");
				return false;
			}

			// Kiểm tra mật khẩu không được để trống
			if (tbPassword.Text.Trim().Equals(""))
			{
				errorProviderWar.SetError(tbPassword, "Mật khẩu không được để trống!");
				return false;
			}
			return true;
		}

		#endregion

		#region Events

		private void btnLogin_Click(object sender, EventArgs e)
		{
			// Lấy thông tin từ giao diện
			string username = tbUsername.Text.Trim();
			string password = tbPassword.Text.Trim();
			Taikhoan user = new Taikhoan();

			// Kiểm tra đầu vào
			if (!IsValidUser())
				return;

			// Kiểm tra tài khoản đăng nhập:
			// Kết nối tới cơ sở dữ liệu
			try
			{
				// Lấy thông tin tài khoản từ dữ liệu nhập
				user = AccountBLL.Instance.GetAccount(username, password);
				if (user != null)
				{
					pControl.Visible = btnLogin.Enabled = false;
					//Task.Run(() =>
					Thread th = new Thread(() =>
					{
						using (BookShop frm = new BookShop())
						{
							frm.Account = user;
							frm.Shown += Frm_Shown;
							frm.FormClosed += Frm_FormClosed;
							Thread.Sleep(200);
							frm.ShowDialog();
							frm.Close();
							frm.Dispose();
						}
					});
					th.SetApartmentState(ApartmentState.STA);
					th.Start();
				}
				else
				{
					//  Thông  báo lỗi nếu sai
					MessageBox.Show("Tài khoản hoặc mật khẩu không đúng. Vui lòng kiểm tra lại!",
				   "Book Store", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Có lỗi phát sinh. Vui lòng kiểm tra lại!\n{ex.Message}",
				"Book Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Frm_FormClosed(object sender, FormClosedEventArgs e)
		{
			this.BeginInvoke((MethodInvoker)delegate
			{
				pControl.Visible = btnLogin.Enabled = true;
				tbUsername.Text = string.Empty;
				tbPassword.Text = string.Empty;
				this.Show();
				this.Activate();
			});
		}

		private void Frm_Shown(object sender, EventArgs e)
		{
			this.BeginInvoke((MethodInvoker)delegate
			{
				this.Hide();
			});
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Close();
		}

		protected override void OnClosing(CancelEventArgs e)
		{
			if (MessageBox.Show("Thoát chương trình!", "Book Store",
				MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
			{
				e.Cancel = true;
			}
			base.OnClosing(e);
		}

		private void btnLogin_Enter(object sender, EventArgs e)
		{
			background.Focus();
		}

		#endregion
	}
}
