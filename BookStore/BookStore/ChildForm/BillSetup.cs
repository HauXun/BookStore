using BookStore.Extensions.Popup;
using BookStore.Model.BusinessLogicLayer;
using BookStore.Model.Entities;
using BookStore.Partial;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore.ChildForm
{
	public partial class BillSetup : ModelPopup
	{
		private string maDTChange;
		private int maHoaDon;
		private bool isNbill = false;
		private bool isEdit = false;

		public bool IsNbill
		{
			get => isNbill;
			set
			{
				isNbill = value;
				LoadCustomer(value);
			}
		}

		private DoiTac doiTacRespone;
		public DoiTac DoiTacRespone
		{
			get => doiTacRespone;
			set
			{
				doiTacRespone = value;
				LoadCustomer(isNbill);
			}
		}

		private Taikhoan account;
		public Taikhoan Account { get => account; set => account = value; }

		private event EventHandler<InvokeInvoiceDetail> newBillDetail;
		public event EventHandler<InvokeInvoiceDetail> NewBillDetail
		{
			add
			{
				newBillDetail += value;
			}
			remove
			{
				newBillDetail -= value;
			}
		}

		private BillRowBox rowBox;
		public BillRowBox RowBox
		{
			get => rowBox;
			set
			{
				if (value != null)
				{
					rowBox = value;
					AddRowBox(value);
				}
			}
		}

		public BillSetup(Taikhoan account) : base()
		{
			InitializeComponent();
			Account = account;
			Content.Region = System.Drawing.Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, Content.Width, Content.Height, 15, 15));
			btnDownload.Region = System.Drawing.Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, btnDownload.Width, btnDownload.Height, 5, 5));
			btnPrint.Region = System.Drawing.Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, btnPrint.Width, btnPrint.Height, 5, 5));
			btnAdditionalProduct.Region = System.Drawing.Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, btnAdditionalProduct.Width, btnAdditionalProduct.Height, 5, 5));
		}

		public BillSetup(InvoiceDetail invoice, Taikhoan account)
		{
			InitializeComponent();
			Account = account;
			DoiTac doiTac = CustomerBLL.Instance.GetDoiTacByInfo(invoice.TenKhachHang, invoice.DiaChi, invoice.SDT);
			DoiTacRespone = doiTac;
			maHoaDon = invoice.MaHoaDon;
			lbTotalPriceValue.Text = invoice.TongTienHang;
			nudDiscountValue.Value = invoice.GiamGia;
			lbTotalPaymentValue.Text = invoice.TongThanhToan;
			cbStatus.Checked = invoice.Status;
			isEdit = true;
			foreach (BillRowBox box in invoice.ListOfBillRow)
			{
				box.LbTotalPrice.TextChanged += LbTotalPrice_TextChanged;
				box.tsmiXoa.Click += TsmiXoa_Click;
				flpRowDetailBox.Controls.Add(box);
			}
		}

		private void LoadCustomer(bool isNBill = false, List<DoiTac> doiTac = null)
		{
			List<DoiTac> doiTacs = doiTac;
			if (doiTac == null)
			{
				doiTacs = CustomerBLL.Instance.GetAllCustomer(isNBill);
				if (isNBill)
				{
					lbCustomer.Text = "Đối tác/ Nhà cung cấp:";
				}
				else
				{
					lbCustomer.Text = "Khách hàng:";
				}
			}
			doiTacs.Select(x => { x.TenDT = $"{x.TenDT} - {x.DiaChi}"; return x; }).ToList();
			cbCustomer.DisplayMember = "TenDT";
			cbCustomer.ValueMember = "MaDT";
			cbCustomer.DataSource = doiTacs;
			if (doiTacRespone != null)
			{
				doiTacRespone.TenDT = $"{doiTacRespone.TenDT} - {doiTacRespone.DiaChi}";
				tbSDT.Text = doiTacRespone.SDT;
				cbCustomer.SelectedIndex = cbCustomer.FindString(doiTacRespone.TenDT);
				doiTacRespone = null;
			}
		}

		private void AddRowBox(BillRowBox rowBox)
		{
			foreach (var row in flpRowDetailBox.Controls)
			{
				if (row is BillRowBox)
				{
					Tuple<string, int> data = ((row as BillRowBox).Tag as Tuple<string, int>);
					if (data.Item1.Equals((rowBox.Tag as Tuple<string, int>).Item1))
					{
						var slBan = rowBox.NudProductAmount.Value + 1;
						if (data.Item2 < slBan)
						{
							MessageBox.Show("Số lượng sản phẩm không đủ để giao dịch!", "Thông báo!",
								MessageBoxButtons.OK, MessageBoxIcon.Warning);
							return;
						}
						(row as BillRowBox).NudProductAmount.Value++;
						return;
					}
				}
			}
			rowBox.LbTotalPrice.TextChanged += LbTotalPrice_TextChanged;
			rowBox.NudPrice.ValueChanged += NudPrice_ValueChanged;
			rowBox.NudProductAmount.ValueChanged += NudPrice_ValueChanged;
			rowBox.tsmiXoa.Click += TsmiXoa_Click;
			flpRowDetailBox.Controls.Add(rowBox);
		}

		private void NudPrice_ValueChanged(object sender, EventArgs e)
		{
			BillRowBox rowBox = (BillRowBox)GetParent<BillRowBox>(sender as Guna.UI2.WinForms.Guna2NumericUpDown);
			if ((rowBox.Tag as Tuple<string, int>).Item2 < rowBox.NudProductAmount.Value)
			{
				MessageBox.Show("Số lượng sản phẩm không đủ để giao dịch!", "Thông báo!",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				rowBox.NudProductAmount.Value = rowBox.PreAmountValue;
				return;
			}
			rowBox.PreAmountValue = rowBox.NudProductAmount.Value;
			rowBox.LbTotalPrice.Text = (rowBox.NudPrice.Value * rowBox.NudProductAmount.Value).ToString();
		}

		/// <summary>
		/// Kiểm tra toàn vẹn dữ liệu nhập
		/// </summary>
		/// <returns></returns>
		private bool IsValidInfo()
		{
			// Kiểm tra xem thông tin hợp lệ chưa?
			// Xóa bỏ những thông báo lỗi nếu có
			errorProviderWar.SetError(tbSDT, "");
			errorProviderWar.SetError(cbCustomer, "");
			errorProviderWar.SetError(cbPayments, "");

			// Kiểm tra	tên khách hàng không được để trống
			if (tbSDT.Text.Trim().Equals(""))
			{
				errorProviderWar.SetError(tbSDT, "Tên khách hàng/ Công ty/ Đối tác\nkhông được để trống!");
				return false;
			}

			// Kiểm tra hình thức thanh toán đã chọn chưa
			if (cbPayments.Text.Trim().Equals("") || cbPayments.SelectedIndex == -1)
			{
				errorProviderWar.SetError(cbPayments, "Vui lòng chọn hình thức thanh toán!");
				return false;
			}

			// Kiểm tra hình thức hóa đơn đã chọn chưa
			if (cbCustomer.Text.Trim().Equals("") || cbCustomer.SelectedIndex == -1)
			{
				errorProviderWar.SetError(cbCustomer, "Vui lòng chọn khách hàng thanh toán!");
				return false;
			}
			return true;
		}

		private void GetFinalInfoPrice()
		{
			float totalPrice = 0;
			foreach (var row in flpRowDetailBox.Controls)
			{
				if (row is BillRowBox)
				{
					totalPrice += float.Parse((row as BillRowBox).LbTotalPrice.Text);
				}
			}
			lbTotalPriceValue.Text = totalPrice.ToString();
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

		private List<BillRowBox> GetAllBillRowBox()
		{
			List<BillRowBox> billRowBoxes = new List<BillRowBox>();
			foreach (var row in flpRowDetailBox.Controls)
			{
				if (row is BillRowBox)
				{
					billRowBoxes.Add((BillRowBox)row);
				}
			}
			return billRowBoxes;
		}

		private void TsmiXoa_Click(object sender, EventArgs e)
		{
			flpRowDetailBox.Controls.Remove((BillRowBox)((ContextMenuStrip)(sender as ToolStripMenuItem).Owner).SourceControl);
		}

		private void LbTotalPrice_TextChanged(object sender, EventArgs e)
		{
			GetFinalInfoPrice();
		}

		private void btnCancle_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Hủy thao tác này!", "Book Store",
					MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
				this.dialogResult = DialogResult.Cancel;
		}

		private void lbDiscountValue_ValueChanged(object sender, EventArgs e)
		{
			float totalPrice = float.Parse(lbTotalPriceValue.Text);
			lbTotalPaymentValue.Text = (totalPrice - (float)nudDiscountValue.Value).ToString();
		}

		private void lbTotalPriceValue_TextChanged(object sender, EventArgs e)
		{
			lbDiscountValue_ValueChanged(null, null);
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			// Kiểm tra đầu vào
			if (!IsValidInfo())
				return;

			try
			{
				if (MessageBox.Show("Bạn có chắc muốn lưu thông tin hóa đơn này", "Book Store",
						MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
				{
					HoaDon hoaDon = new HoaDon(
						account.IDAccount,
						DateTime.Now,
						maDTChange,
						isNbill ? "NBill" : "XBill",
						nudDiscountValue.Value,
						double.Parse(lbTotalPaymentValue.Text),
						cbStatus.Checked);
					if (!isEdit)
					{
						maHoaDon = BillBLL.Instance.InsertBill(hoaDon);
						InsertBillDetail(maHoaDon, GetAllBillRowBox());
					}
					else
					{
						hoaDon.MaHoaDon = maHoaDon;
						BillBLL.Instance.EditBill(hoaDon);
						BillBLL.Instance.DeleteBillDetail(maHoaDon);
						InsertBillDetail(maHoaDon, GetAllBillRowBox());
					}
					InvoiceDetail invoiceDetail = new InvoiceDetail(
						maHoaDon,
						(cbCustomer.SelectedItem as DoiTac).TenDT.Split('-')[0].TrimEnd(),
						(cbCustomer.SelectedItem as DoiTac).DiaChi,
						tbSDT.Text,
						account.HoTen,
						isNbill ? "Hóa đơn nhập hàng" : "Hóa đơn bán hàng",
						DateTime.Now.ToString(),
						cbPayments.SelectedItem.ToString(),
						lbTotalPriceValue.Text,
						nudDiscountValue.Value,
						lbTotalPaymentValue.Text,
						tbNote.Text,
						cbStatus.Checked,
						GetAllBillRowBox()
						);
					if (newBillDetail != null)
					{
						newBillDetail(this, new InvokeInvoiceDetail(invoiceDetail));
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Book Store",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void InsertBillDetail(int maHoaDon, List<BillRowBox> chitietHoaDon)
		{
			foreach (BillRowBox rowBox in chitietHoaDon)
			{
				BillBLL.Instance.InsertBillDetail(new ChiTietHoaDon()
				{
					MaHoaDon = maHoaDon,
					MaSP = int.Parse(rowBox.Tag.ToString()),
					Gia = decimal.ToDouble(rowBox.NudPrice.Value),
					SoLuong = decimal.ToInt16(rowBox.NudProductAmount.Value)
				});
			}
		}

		private void BillSetup_Load(object sender, EventArgs e)
		{
			LoadCustomer(isNbill);
		}

		private void cbCustomer_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbCustomer.SelectedValue != null)
			{
				maDTChange = cbCustomer.SelectedValue.ToString();
				tbSDT.Text = (cbCustomer.SelectedItem as DoiTac).SDT;
			}
		}

		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			if (keyData == Keys.Enter)
			{
				SearchCustomer();
				return true;
			}
			return base.ProcessCmdKey(ref msg, keyData);
		}

		private void SearchCustomer()
		{
			try
			{
				List<DoiTac> data;
				string keyword = tbSDT.Text;
				if (string.IsNullOrEmpty(tbSDT.Text))
					keyword = string.Empty;

				data = CustomerBLL.Instance.SearchDoiTac(keyword, isNbill);
				LoadCustomer(isNbill, data);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Tìm kiếm thất bại! " + ex.Message, "Book Store",
			   MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void tbSDT_MouseLeave(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(tbSDT.Text))
			{
				tbSDT.PlaceholderText = "Nhập số điện thoại ...";
			}
		}

		private void tbSDT_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			tbSDT.Clear();
		}
	}

	public class InvokeInvoiceDetail : EventArgs
	{
		private InvoiceDetail details;

		public InvokeInvoiceDetail(InvoiceDetail newInvoice)
		{
			Details = newInvoice;
		}

		public InvoiceDetail Details { get => details; set => details = value; }
	}
}
