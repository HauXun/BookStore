using BookStore.ChildForm;
using BookStore.Model.BusinessLogicLayer;
using BookStore.Model.Entities;
using BookStore.Pages;
using BookStore.Partial;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
	public partial class BookShop : Form
	{
		#region Fields
		private Type getFilter;
		AddToBill addToBill;
		BillSetup billSetup;
		AccountPopup accountPopup;
		private Color mainColor = Color.FromArgb(83, 107, 190);
		private Taikhoan account;
		public Taikhoan Account
		{
			get => account;
			set
			{
				account = value;
				ChangeRole(account.RoleID);

				// Khởi tạo các tabpage
				PushControl(account.RoleID);

				// Bo tròn các control và khởi tạo các sự kiện của các tabpage
				SettingControls();
			}
		}

		#endregion

		#region Constructor

		public BookShop()
		{
			InitializeComponent();
		}

		#endregion

		// -------------- Set color for background gradient ---------------
		protected override void OnPaintBackground(PaintEventArgs e)
		{
			Rectangle rectangle = ClientRectangle;
			if (rectangle.IsEmpty)
				return;
			if (rectangle.Width == 0 || rectangle.Height == 0)
				return;
			using (LinearGradientBrush brush = new LinearGradientBrush(rectangle, Color.White, Color.FromArgb(187, 202, 255), 125F))
			{
				e.Graphics.FillRectangle(brush, rectangle);
			}
		}

		#region CustomMode

		/// <summary>
		/// Chức năng tắt và thu nhỏ Form
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		#region ControlBox

		private void btnMinimized_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		private void btnThoat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		protected override void OnClosing(CancelEventArgs e)
		{
			if (MessageBox.Show("Thoát chương trình!", "Book Store",
				MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
			{
				e.Cancel = true;
			}
			//if (Application.MessageLoop == true)
			//{
			//	Application.Exit();
			//}
			//else
			//{
			//	Environment.Exit(1);
			//}
			else
			{
				this.Dispose();
				base.OnClosing(e);
			}
		}

		#endregion


		#region Drag Form

		/// <summary>
		/// Chức năng di chuyển Form bằng thanh ControlBox
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void pnlControlBox_MouseDown(object sender, MouseEventArgs e)
		{
			Session.ReleaseCapture();
			Session.SendMessage(this.Handle, 0x112, 0xf012, 0);
		}

		#endregion


		#endregion

		/// <summary>
		/// Bo tròn góc các Control
		/// </summary>
		private void SettingControls()
		{
			//Rounded Form
			Region = System.Drawing.Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
			bP.Region = System.Drawing.Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, bP.Width, bP.Height, 15, 15));
			pnlForm.Region = System.Drawing.Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, pnlForm.Width, pnlForm.Height, 15, 15));
			bP.TabPages[0].Region = System.Drawing.Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, bP.TabPages[0].Width, bP.TabPages[0].Height, 15, 15));

			CreateButtonBorderRadius(pnlMenu.Controls, 6);

			CreateButtonBorderRadius(flpTool.Controls, 6);

			CreateButtonBorderRadius(pnlAdminControl.Controls, 6);

			Subscribe(account.RoleID);
		}

		private void CreateButtonBorderRadius(Control.ControlCollection collection, int radius)
		{
			foreach (Control control in collection)
			{
				if (control is IconButton)
				{
					IconButton button = control as IconButton;
					button.Region = System.Drawing.Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, button.Width, button.Height, radius, radius));
				}
			}
		}

		/// <summary>
		/// Đăng kí sự kiện cho các Button
		/// </summary>
		private void Subscribe(string roleID)
		{
			//// Sự kiện trên BookShop Form
			switch (roleID)
			{
				case "admin":
					this.productUC.NewProductDetail += ProductUC_NewProductDetail;
					this.analysisUC.NewProductDetail += ProductUC_NewProductDetail;
					this.analysisUC.NewBillDetail += AnalysisUC_NewBillDetail;
					this.productUC.btnFilter.Click += BtnFilter_Click;
					this.productUC.btnNewProduct.Click += BtnNewProduct_Click;
					this.billUC.NewBillsDetails += BillUC_NewBillsDetails;
					this.insightUC.NewBillDetail += AnalysisUC_NewBillDetail;
					break;
				case "staff":
					this.billUC.NewBillsDetails += BillUC_NewBillsDetails;
					break;
			}
		}

		/// <summary>
		/// Phân quyền tài khoản
		/// </summary>
		/// <param name="roleID"></param>
		private void ChangeRole(string roleID)
		{
			switch (roleID)
			{
				case "admin":
					pnlAdminControl.Enabled = pnlAdminControl.Visible = true;
					this.bP.SetPage((int)Session.TabPage.Inighst);
					break;
				case "staff":
					pnlAdminControl.Enabled = pnlAdminControl.Visible = false;
					this.bP.SetPage((int)Session.TabPage.Bill);
					break;
			}
			usernameLabel.Text = Account.HoTen;
		}

		/// <summary>
		/// Đẩy các control form vào trong tabpages
		/// </summary>
		private void PushControl(string roleID)
		{
			switch (roleID)
			{
				case "admin":
					this.insightUC = new Insight();
					this.billUC = new Bill();
					this.productUC = new Product();
					this.analysisUC = new Analysis();

					/////////////////////////////////////////////////////////////////////
					///
					// 
					// insightUC
					// 
					this.insightUC.Dock = System.Windows.Forms.DockStyle.Fill;
					this.insightUC.Name = "insightUC";
					this.insightUC.TabIndex = 0;
					///
					// 
					// billUC
					// 
					this.billUC.Dock = System.Windows.Forms.DockStyle.Fill;
					this.billUC.Name = "billUC";
					this.billUC.TabIndex = 0;
					// 
					// productUC
					// 
					this.productUC.Dock = System.Windows.Forms.DockStyle.Fill;
					this.productUC.Name = "productUC";
					this.productUC.TabIndex = 0;
					// 
					// analysisUC
					// 
					this.analysisUC.Dock = System.Windows.Forms.DockStyle.Fill;
					this.analysisUC.Name = "analysisUC";
					this.analysisUC.TabIndex = 0;

					//////////////////////////////////////////////////////////////////////

					this.tPInsight.Controls.Add(this.insightUC);
					this.tPBill.Controls.Add(this.billUC);
					this.tPProduct.Controls.Add(this.productUC);
					this.tPAnalysis.Controls.Add(this.analysisUC);
					break;
				case "staff":
					this.billUC = new Bill();

					///
					// 
					// billUC
					// 
					this.billUC.Dock = System.Windows.Forms.DockStyle.Fill;
					this.billUC.Name = "billUC";
					this.billUC.TabIndex = 0;

					this.tPBill.Controls.Add(this.billUC);
					break;
			}
		}

		/// <summary>
		/// Hàm tìm control cha được xác định trước
		/// </summary>
		/// <typeparam name="T">Trả về kiểu T nếu cha của control là T</typeparam>
		/// <typeparam name="T2">Trả về kiểu T2 nếu cha của control là T2</typeparam>
		/// <param name="control"></param>
		/// <returns>Một control theo kiểu cho trước</returns>
		private static object GetParent<T, T2>(Control control)
		{
			while (control.Parent != null)
			{
				if (control.Parent is T)
				{
					return (T)(object)control.Parent;
				}

				if (control.Parent is T2)
				{
					return (T2)(object)control.Parent;
				}
				control = control.Parent;
			}
			return null;
		}

		/// <summary>
		/// Chuyển qua tab product
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnProduct_Click(object sender, EventArgs e)
		{
			this.bP.SetPage((int)Session.TabPage.Product);
		}

		/// <summary>
		/// Chuyển qua tab anylysis
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnAnalysis_Click(object sender, EventArgs e)
		{
			this.bP.SetPage((int)Session.TabPage.Analysis);
		}

		/// <summary>
		/// Chuyển qua tab insight
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnInsight_Click(object sender, EventArgs e)
		{
			this.bP.SetPage((int)Session.TabPage.Inighst);
		}

		/// <summary>
		/// Chuyển qua tab bill
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnBill_Click(object sender, EventArgs e)
		{
			this.bP.SetPage((int)Session.TabPage.Bill);
		}

		/// <summary>
		/// Mở popup form quản lý nhân viên
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnAccount_Click(object sender, EventArgs e)
		{
			accountPopup = new AccountPopup();
			accountPopup.btnNewStaff.Click += BtnNewStaff_Click;
			accountPopup.Init(this);
			pnlControlBox.Hide();
			accountPopup.ShowDialog();
			pnlControlBox.Show();
		}

		/// <summary>
		/// Thêm sản phẩm mới
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnNewProduct_Click(object sender, EventArgs e)
		{
			NewProduct newProduct = new NewProduct();
			newProduct.Init(this);
			pnlControlBox.Hide();
			newProduct.ShowDialog();
			pnlControlBox.Show();
		}

		/// <summary>
		/// Lọc sản phẩm
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnFilter_Click(object sender, EventArgs e)
		{
			var tmp = GetParent<Product, AddToBill>(sender as IconButton);
			getFilter = tmp.GetType();
			ProductFilter productFilter = new ProductFilter();
			// Nhả ra dữ liệu sau khi lọc thông qua sự kiện
			productFilter.DataFilterResults += ProductFilter_DataFilterResults;
			productFilter.Init(this);
			pnlControlBox.Hide();
			productFilter.ShowDialog();
			if (!getFilter.Name.Equals("AddToBill"))
				pnlControlBox.Show();
		}

		/// <summary>
		/// Nhả ra dữ liệu sau khi lọc thông qua sự kiện
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ProductFilter_DataFilterResults(object sender, NewDataFilter e)
		{
			switch (getFilter.Name)
			{
				case "Product":
					this.productUC.FilterData = new Tuple<string, DataTable, DataTable>
						(e.TableFilter, e.DataFilter, e.DataFilterResults);
					break;
				case "AddToBill":
					addToBill.FilterData = new Tuple<string, DataTable, DataTable>
						(e.TableFilter, e.DataFilter, e.DataFilterResults);
					break;
			}
		}

		/// <summary>
		/// Tạo tài khoản mới
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnNewStaff_Click(object sender, EventArgs e)
		{
			NewAccountPopup newStaffPopup = new NewAccountPopup();
			newStaffPopup.Init(this);
			if (newStaffPopup.ShowDialog() == DialogResult.OK)
			{
				// Kiểm tra khởi tạo tài khoản thành công hay không
				if (AccountBLL.Instance.CreateAccount(newStaffPopup.Respone) > 0)
				{
					// Tài khoản luôn được active khi vừa khởi tạo
					newStaffPopup.Respone.Active = true;
					MessageBox.Show("Thêm tài khoản thành công !", "Book Store",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);

					// Cập nhật tài khoản vừa khởi tạo vào danh sách hiện hành
					accountPopup.Account = newStaffPopup.Respone;
				}
			}
		}

		/// <summary>
		/// Popup chi tiết thông tin sản phẩm
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ProductUC_NewProductDetail(object sender, NewProductDetails e)
		{
			e.Details.Init(this);
			pnlControlBox.Hide();
			e.Details.ShowDialog();
			pnlControlBox.Show();
		}

		/// <summary>
		/// Popup chi tiết hoá đơn
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BillUC_NewBillsDetails(object sender, NewBillsDetails e)
		{
			e.Details.NewBillDetail += Bills_NewBillDetail;
			e.Details.btnEditBill.Click += BtnEditBill_Click;
			e.Details.Init(this);
			pnlControlBox.Hide();
			e.Details.ShowDialog();
			pnlControlBox.Show();
		}

		private void BtnEditBill_Click(object sender, EventArgs e)
		{
			var tmp = GetParent<Bills, BillSetup>(sender as IconButton);
			if (tmp is Bills)
			{
				(tmp as Bills).dialogResult = DialogResult.Cancel;
			}
		}

		/// <summary>
		/// Popup khởi tạo hóa đơn
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnSalesBill_Click(object sender, EventArgs e)
		{
			billSetup = new BillSetup(account);
			InitBillSetup();
		}

		private void btnImportBill_Click(object sender, EventArgs e)
		{
			billSetup = new BillSetup(account)
			{
				IsNbill = true
			};
			InitBillSetup();
		}

		private void InitBillSetup()
		{
			// Gắn sự kiện thêm sản phẩm vào hóa đơn
			billSetup.btnAdditionalProduct.Click += BtnAdditionalProduct_Click;
			// Xuất thông tin hóa đơn sau khi khởi tạo hóa đơn xong
			billSetup.NewBillDetail += BillSetup_NewBillDetail;
			billSetup.tbSDT.IconRightClick += TbSDT_IconRightClick;
			billSetup.Init(this);
			pnlControlBox.Hide();
			billSetup.ShowDialog();
			pnlControlBox.Show();
		}

		private void TbSDT_IconRightClick(object sender, EventArgs e)
		{
			var tmp = GetParent<BillSetup, NewDoiTacKhachHang>(sender as Guna.UI2.WinForms.Guna2TextBox);
			NewDoiTacKhachHang newDoiTac = new NewDoiTacKhachHang();
			newDoiTac.Init(this);
			if (newDoiTac.ShowDialog() == DialogResult.OK)
			{
				// Kiểm tra khởi tạo đối tác khách hàng thành công hay không
				if (tmp is BillSetup)
				{
					DoiTac doiTac = CustomerBLL.Instance.InsertDoiTac(
					newDoiTac.Respone.TenDT,
					newDoiTac.Respone.DiaChi,
					newDoiTac.Respone.SDT,
					(tmp as BillSetup).IsNbill);
					if (doiTac != null)
					{
						MessageBox.Show("Thêm Đối tác - Khách hàng thành công !", "Book Store",
						MessageBoxButtons.OK, MessageBoxIcon.Warning);
						billSetup.DoiTacRespone = doiTac;
					}
				}
			}
		}

		/// <summary>
		/// Thông tin chi tiết hóa đơn sau khi khởi tạo
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BillSetup_NewBillDetail(object sender, InvokeInvoiceDetail e)
		{
			Bills bills = new Bills(e.Details);
			bills.NewBillDetail += Bills_NewBillDetail;
			bills.btnEditBill.Click += BtnEditBill_Click;
			bills.Init(this);
			if (sender is BillSetup)
				(sender as BillSetup).dialogResult = DialogResult.Cancel;
			pnlControlBox.Hide();
			bills.ShowDialog();
			pnlControlBox.Show();
		}

		/// <summary>
		/// Thông tin chi tiết hóa đơn từ page analysis
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void AnalysisUC_NewBillDetail(object sender, InvokeInvoiceDetail e)
		{
			Bills bills = new Bills(e.Details);
			bills.NewBillDetail += Bills_NewBillDetail;
			bills.btnEditBill.Click += BtnEditBill_Click;
			bills.Init(this);
			if (sender is BillSetup)
				(sender as BillSetup).dialogResult = DialogResult.Cancel;
			pnlControlBox.Hide();
			bills.ShowDialog();
			pnlControlBox.Show();
		}

		private void Bills_NewBillDetail(object sender, InvokeInvoiceDetail e)
		{
			billSetup = new BillSetup(e.Details, account)
			{
				IsNbill = e.Details.LoaiHoaDon.Equals("NBill") ? true : false
			};
			InitBillSetup();
		}

		/// <summary>
		/// Thêm sản phẩm vào hóa đơn khởi tạo
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BtnAdditionalProduct_Click(object sender, EventArgs e)
		{
			addToBill = new AddToBill();
			// Lọc sản phẩm
			addToBill.btnFilter.Click += BtnFilter_Click;
			addToBill.Init(this);
			addToBill.ShowDialog();
			billSetup.RowBox = Session.BillRowBox;
		}
	}
}
