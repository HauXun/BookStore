using BookStore.Extensions.Popup;
using BookStore.Model.BusinessLogicLayer;
using BookStore.Model.Entities;
using BookStore.Partial;
using FontAwesome.Sharp;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace BookStore.ChildForm
{
	public partial class AccountPopup : ModelPopup
	{
		private Taikhoan account;

		public Taikhoan Account
		{
			get => account;
			set
			{
				account = value;
				NewStaff(value);
			}
		}

		public AccountPopup() : base()
		{
			InitializeComponent();
			SettingControls();
			LoadAccount();
		}

		/// <summary>
		/// Bo tròn góc các Control
		/// </summary>
		private void SettingControls()
		{
			//Rounded Form
			Content.Region = System.Drawing.Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, Content.Width, Content.Height, 15, 15));
			btnNewStaff.Region = System.Drawing.Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, btnNewStaff.Width, btnNewStaff.Height, 5, 5));
		}

		private void LoadAccount()
		{
			DataTable data = AccountBLL.Instance.GetAllAccount();
			foreach (DataRow row in data.Rows)
			{
				Taikhoan taikhoan = new Taikhoan(row);
				NewStaff(taikhoan);
			}
			lbTotalStaff.Text = $"Account: {flpDetailsStaff.Controls.Count}";
		}

		private void NewStaff(Taikhoan taikhoan)
		{
			AccountRowBox staffRowBox = new AccountRowBox(taikhoan);
			staffRowBox.iconActive.Click += IconActive_Click;
			flpDetailsStaff.Controls.Add(staffRowBox);
		}

		private static object GetParent<T>(Control control)
		{
			while (control.Parent != null)
			{
				if (control.Parent is T)
				{
					return (T)(object)control.Parent;
				}
				control = control.Parent;
			}
			return null;
		}

		private void IconActive_Click(object sender, EventArgs e)
		{
			AccountRowBox staffRowBox = (AccountRowBox)GetParent<AccountRowBox>(sender as IconButton);
			AccountBLL.Instance.CancleAccount(staffRowBox.Taikhoan.HoTen, staffRowBox.Taikhoan.SDT);
			staffRowBox.Taikhoan.Active = !staffRowBox.Taikhoan.Active;
			if (staffRowBox.Taikhoan.Active)
			{
				staffRowBox.iconActive.IconColor = Color.Lime;
			}
			else if (!staffRowBox.Taikhoan.Active)
			{
				staffRowBox.iconActive.IconColor = Color.Red;
			}
		}

		private void btnClosePopup_Click(object sender, EventArgs e)
		{
			this.dialogResult = DialogResult.Cancel;
		}

		private void lbResetPassword_MouseLeave(object sender, EventArgs e)
		{
			(sender as LinkLabel).LinkBehavior = LinkBehavior.NeverUnderline;
		}

		private void lbResetPassword_MouseEnter(object sender, EventArgs e)
		{
			(sender as LinkLabel).LinkBehavior = LinkBehavior.SystemDefault;
		}
	}
}
