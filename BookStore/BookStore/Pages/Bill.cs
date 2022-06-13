using BookStore.ChildForm;
using BookStore.Model.BusinessLogicLayer;
using BookStore.Model.Entities;
using BookStore.Partial;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore.Pages
{
	public partial class Bill : UserControl
	{
		DateTime timePrevious = DateTime.Now.AddDays(-7);
		DateTime timeNow = DateTime.Now;
		private event EventHandler<NewBillsDetails> newBillsDetails;
		public event EventHandler<NewBillsDetails> NewBillsDetails
		{
			add
			{
				newBillsDetails += value;
			}
			remove
			{
				newBillsDetails -= value;
			}
		}

		public Bill()
		{
			InitializeComponent();
			SettingControls(); 

			BillRole();
			dpkHeader1.Value = timePrevious;
			dpkHeader2.Value = timeNow;
		}

		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			if (keyData == Keys.Enter)
			{
				tbSearch_IconRightClick(this, null);
				return true;
			}
			return base.ProcessCmdKey(ref msg, keyData);
		}

		/// <summary>
		/// Bo tròn góc các Control
		/// </summary>
		private void SettingControls()
		{
			//Rounded Form
			Region = System.Drawing.Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
			btnPriceApply.Region = System.Drawing.Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, btnPriceApply.Width, btnPriceApply.Height, 5, 5));
		}

		/// <summary>
		/// Load các kiểu hóa đơn
		/// </summary>
		private void BillRole()
		{
			DataTable data = AnalysisBLL.Instance.BillRole();
			if (data.Rows.Count > 0)
			{
				DataRow row = data.NewRow();
				row["TenLoaiHD"] = "Tất cả";
				row["MaLoaiHD"] = "NULL";
				data.Rows.InsertAt(row, 0);

				cbBillRole.DisplayMember = "TenLoaiHD";
				cbBillRole.ValueMember = "MaLoaiHD";
				cbBillRole.DataSource = data;
			}
		}

		/// <summary>
		/// Load danh sách các hóa đơn
		/// </summary>
		/// <param name="data"></param>
		private void GetInfoBillDetail(List<HoaDon> data)
		{
			flpBillRow.Controls.Clear();

			lbTotalBill.Text = $"Số lượng hóa đơn: {data.Count}";
			lbTotalBillPrice.Text = $"Tổng trị giá hóa đơn: {data.Sum(x => x.TongTien)}";

			if (data.Count > 0)
			{
				MultiBillRowBox multiBillRowBox = new MultiBillRowBox();
				int listColumnCount = data.Count;
				int limitColumn = multiBillRowBox.Column;
				var rowCount = Math.Ceiling((float)listColumnCount / limitColumn);
				for (int i = 0; i < rowCount; i++)
				{
					List<HoaDon> listToInput;
					if (listColumnCount > limitColumn)
					{
						listToInput = data.GetRange(0, limitColumn);
						data.RemoveRange(0, limitColumn);
					}
					else
					{
						listToInput = data.GetRange(0, listColumnCount);
						data.RemoveRange(0, listColumnCount);
					}
					listColumnCount -= limitColumn;
					MultiBillRowBox multiBillRow = new MultiBillRowBox()
					{ ListColumnData = listToInput };
					multiBillRow.NewBillDetail += MultiBillRow_NewBillDetail;
					flpBillRow.Controls.Add(multiBillRow);
				}
			}
		}

		/// <summary>
		/// Hóa đơn theo kiểu
		/// </summary>
		/// <param name="loaiHoaDon"></param>
		public void InvoiceDetailsByRole(string loaiHoaDon)
		{
			List<HoaDon> data = AnalysisBLL.Instance.InvoiceDetailsByRole(loaiHoaDon);
			GetInfoBillDetail(data);
		}

		/// <summary>
		/// Hóa đơn theo giai đoạn
		/// </summary>
		/// <param name="startDate"></param>
		/// <param name="endDate"></param>
		public void InvoiceDetailsByStages(DateTime startDate, DateTime endDate)
		{
			List<HoaDon> data = AnalysisBLL.Instance.InvoiceDetailsByStages(startDate, endDate);
			GetInfoBillDetail(data);
		}

		/// <summary>
		/// Hóa đơn theo khoản giá
		/// </summary>
		/// <param name="startPrice"></param>
		/// <param name="endPrice"></param>
		public void InvoiceDetailsByPeriodPrice(float startPrice, float endPrice)
		{
			List<HoaDon> data = AnalysisBLL.Instance.InvoiceDetailsByPeriodPrice(startPrice, endPrice);
			GetInfoBillDetail(data);
		}

		//public void SearchBill(string keyword)
		//{
		//	List<HoaDon> data = AnalysisBLL.Instance.SearchBill(keyword);
		//	GetInfoBillDetail(data);
		//}

		/// <summary>
		/// Kiểm tra thông tin giá nhập
		/// </summary>
		/// <returns></returns>
		private bool IsValidPriceCheck()
		{
			errorProviderWar.SetError(btnPriceApply, "");

			if (string.IsNullOrEmpty(tbPeriodPrice1.Text) || string.IsNullOrEmpty(tbPeriodPrice2.Text))
			{
				errorProviderWar.SetError(btnPriceApply, "Số điện thoại không được để trống!");
				return false;
			}
			else
			{
				if (IsSpaceCharacters(tbPeriodPrice1.Text) || IsSpaceCharacters(tbPeriodPrice2.Text))
				{
					errorProviderWar.SetError(btnPriceApply, "Số điện thoại không\nđược chứa khoảng trắng!");
					return false;
				}
				else
				{
					if (!IsDigit(tbPeriodPrice1.Text) || !IsDigit(tbPeriodPrice2.Text))
					{
						errorProviderWar.SetError(btnPriceApply, "Số điện thoại không được\nchứa ký tự khác ngoài số!");
						return false;
					}
				}
			}
			return true;
		}

		private bool IsSpaceCharacters(string input) => input.Any(char.IsWhiteSpace);

		private bool IsDigit(string input) => input.All(char.IsDigit);

		private void MultiBillRow_NewBillDetail(object sender, InvokeInvoiceDetail e)
		{
			if (newBillsDetails != null)
			{
				newBillsDetails(this, new NewBillsDetails(e.Details));
			}
		}

		private void Bill_Load(object sender, EventArgs e)
		{
		}

		private void cbBillRole_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				if (cbBillRole.SelectedValue != null)
					InvoiceDetailsByRole(cbBillRole.SelectedValue.ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Book Store",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnPriceApply_Click(object sender, EventArgs e)
		{
			if (!IsValidPriceCheck())
				return;

			float price1 = float.Parse(tbPeriodPrice1.Text);
			float price2 = float.Parse(tbPeriodPrice2.Text);
			InvoiceDetailsByPeriodPrice(price1, price2);
		}

		private void dpkHeader1_onValueChanged(object sender, EventArgs e)
		{
			try
			{
				if (cbBillRole.SelectedValue != null)
					InvoiceDetailsByStages(dpkHeader1.Value, dpkHeader2.Value);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Book Store",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void tbSearch_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			tbSearch.Clear();
		}

		private void tbSearch_MouseLeave(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(tbSearch.Text))
			{
				tbSearch.PlaceholderText = "Tìm kiếm hóa đơn/ Khách hàng ...";
			}
		}

		private void tbSearch_Enter(object sender, EventArgs e)
		{
			tbSearch.Clear();
		}

		private void tbSearch_IconRightClick(object sender, EventArgs e)
		{
			try
			{
				string keyword = tbSearch.Text;
				if (string.IsNullOrEmpty(tbSearch.Text))
					keyword = string.Empty;

				List<HoaDon> data = AnalysisBLL.Instance.SearchBill(keyword);
				GetInfoBillDetail(data);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Tìm kiếm thất bại! " + ex.Message, "Book Store",
			   MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}

	public class NewBillsDetails : EventArgs
	{
		private Bills details;

		public NewBillsDetails(InvoiceDetail invoice)
		{
			Details = new Bills(invoice);
		}

		public Bills Details { get => details; set => details = value; }
	}
}
