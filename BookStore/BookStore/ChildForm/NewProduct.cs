using BookStore.Extensions.Popup;
using BookStore.Model.BusinessLogicLayer;
using BookStore.Model.Entities;
using BookStore.Partial;
using Guna.UI2.WinForms;
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
	public partial class NewProduct : ModelPopup
	{
		List<string> columnsName;
		public NewProduct() : base()
		{
			InitializeComponent();
			Content.Region = System.Drawing.Region.FromHrgn(Session.CreateRoundRectRgn(0, 0, Content.Width, Content.Height, 15, 15));
		}

		private void LoadData()
		{
			try
			{
				GetAllProductTable();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Book Store",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void GetAllProductTable()
		{
			DataTable data = ProductFilterBLL.Instance.TableProductName();
			if (data.Rows.Count > 0)
			{
				cbTableName.DisplayMember = "Table_Display";
				cbTableName.ValueMember = "Table_Name";
				cbTableName.DataSource = data;
			}
		}

		private void ClearDetailBox()
		{
			int rowCount = flpInputControl.Controls.Count;
			for (int i = rowCount - 1; i >= 1; i--)
			{
				flpInputControl.Controls.RemoveAt(i);
			}
		}

		private void GetInfoProductInput(string tableName)
		{
			ClearDetailBox();
			DataTable data = ProductFilterBLL.Instance.GetColumnProductName(tableName);

			if (data.Rows.Count > 0)
			{
				List<string> columnsName = new List<string>(data.Rows[0][0].ToString().Split(','));

				this.columnsName = new List<string>(columnsName);

				Session.ListInputTextBox = new List<Tuple<Label, Guna2TextBox>>();
				ProductDetailBox productDetailBox = new ProductDetailBox();
				int listColumnCount = columnsName.Count;
				int limitColumn = productDetailBox.Column;
				var rowCount = Math.Ceiling((float)listColumnCount / limitColumn);
				for (int i = 0; i < rowCount; i++)
				{
					List<string> listToInput;
					if (listColumnCount > limitColumn)
					{
						listToInput = columnsName.GetRange(0, limitColumn);
						columnsName.RemoveRange(0, limitColumn);
					}
					else
					{
						listToInput = columnsName.GetRange(0, listColumnCount);
						columnsName.RemoveRange(0, listColumnCount);
					}
					listColumnCount -= limitColumn;
					flpInputControl.Controls.Add(new ProductDetailBox() { ListColumn = listToInput }.tableBox);
				}
			}
			SetValidInfo();
		}

		private void SetValidInfo()
		{
			errorProviderWar.SetError(lbTitleDetail1, "");
			errorProviderWar.SetError(lbTitleDetail2, "");
			errorProviderWar.SetError(lbTitleDetail3, "");

			if (Session.ListInputTextBox != null && Session.ListInputTextBox.Count > 0)
			{
				foreach (var item in Session.ListInputTextBox)
				{
					errorProviderWar.SetError(item.Item1, "");
				}
			}
		}

		private bool IsValidInfo()
		{
			SetValidInfo();
			if (Session.ListInputTextBox != null && Session.ListInputTextBox.Count > 0)
			{
				if (string.IsNullOrEmpty(tbProductName.Text))
				{
					errorProviderWar.SetError(lbTitleDetail1, $"{lbTitleDetail1.Text} không được để trống!");
					return false;
				}
				if (string.IsNullOrEmpty(tbBrand.Text))
				{
					errorProviderWar.SetError(lbTitleDetail2, $"{lbTitleDetail2.Text} không được để trống!");
					return false;
				}
				if (string.IsNullOrEmpty(tbUnit.Text))
				{
					errorProviderWar.SetError(lbTitleDetail3, $"{lbTitleDetail3.Text} không được để trống!");
					return false;
				}
				foreach (var item in Session.ListInputTextBox)
				{
					if (string.IsNullOrEmpty(item.Item2.Text))
					{
						errorProviderWar.SetError(item.Item1, $"{item.Item1} không được để trống!");
						return false;
					}
				}
			}
			return true;
		}

		public string NonUnicode(string text)
		{
			string[] arr1 = new string[] { "á", "à", "ả", "ã", "ạ", "â", "ấ", "ầ", "ẩ", "ẫ", "ậ", "ă", "ắ", "ằ", "ẳ", "ẵ", "ặ",
			"đ",
			"é","è","ẻ","ẽ","ẹ","ê","ế","ề","ể","ễ","ệ",
			"í","ì","ỉ","ĩ","ị",
			"ó","ò","ỏ","õ","ọ","ô","ố","ồ","ổ","ỗ","ộ","ơ","ớ","ờ","ở","ỡ","ợ",
			"ú","ù","ủ","ũ","ụ","ư","ứ","ừ","ử","ữ","ự",
			"ý","ỳ","ỷ","ỹ","ỵ",};
			string[] arr2 = new string[] { "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a",
			"d",
			"e","e","e","e","e","e","e","e","e","e","e",
			"i","i","i","i","i",
			"o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o",
			"u","u","u","u","u","u","u","u","u","u","u",
			"y","y","y","y","y",};
			for (int i = 0; i < arr1.Length; i++)
			{
				text = text.Replace(arr1[i], arr2[i]);
				text = text.Replace(arr1[i].ToUpper(), arr2[i].ToUpper());
			}
			return text;
		}

		private string GetPropertiesName()
		{
			List<string> propertiesQuery = new List<string>()
			{
				"@Tensanpham",
				"@Thuonghieu",
				"@Donvitinh"
			};
			foreach (string column in columnsName)
			{
				propertiesQuery.Add($"@{NonUnicode(column).Replace(" ", "")}");
			}
			return string.Join(" , ", propertiesQuery);
		}

		private static T GetTypeOfList<T>(ref SanPham sanPham)
		{
			Type type = typeof(T);
			dynamic obj = (T)Activator.CreateInstance(typeof(T));
			//T tmp = (T)Convert.ChangeType((T)a, typeof(T));

			if (obj != null)
			{
				foreach (var item in Session.ListInputTextBox)
				{
					switch (type.Name)
					{
						case "But":
							switch (item.Item1.Text)
							{
								case "Màu sắc":
									obj.MauSac = item.Item2.Text;
									break;
								case "Chất liệu":
									obj.ChatLieu = item.Item2.Text;
									break;
								case "Màu mực":
									obj.MauMuc = item.Item2.Text;
									break;
								case "Giá":
									sanPham.Gia = double.Parse(item.Item2.Text);
									break;
							}
							break;
						case "Sach":
							switch (item.Item1.Text)
							{
								case "Tác giả":
									obj.TacGia = item.Item2.Text;
									break;
								case "Năm xuất bản":
									obj.NamXB = item.Item2.Text;
									break;
								case "Nhà xuất bản":
									obj.NhaXB = item.Item2.Text;
									break;
								case "Giá":
									sanPham.Gia = double.Parse(item.Item2.Text);
									break;
							}
							break;
						case "ThietBiDienTu":
							switch (item.Item1.Text)
							{
								case "Màu sắc":
									obj.MauSac = item.Item2.Text;
									break;
								case "Chất liệu":
									obj.ChatLieu = item.Item2.Text;
									break;
								case "Bảo hành":
									obj.BaoHanh = item.Item2.Text;
									break;
								case "Thông số kĩ thuật":
									obj.ThongSoKiThuat = item.Item2.Text;
									break;
								case "Giá":
									sanPham.Gia = double.Parse(item.Item2.Text);
									break;
							}
							break;
					}
				}
			}

			return obj != null ? obj : null;
		}

		private void NewProduct_Load(object sender, EventArgs e)
		{
			LoadData();
		}

		private void cbTableName_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbTableName.SelectedValue != null)
			{
				GetInfoProductInput(cbTableName.SelectedValue.ToString());
			}
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			if (!IsValidInfo())
				return;

			int result = 0;
			string propertiesQueryParameters = GetPropertiesName();

			SanPham sanPham = new SanPham();
			sanPham.TenSP = tbProductName.Text;
			sanPham.ThuongHieu = tbBrand.Text;
			sanPham.DVT = tbUnit.Text;

			if (cbTableName.SelectedValue != null)
			{
				switch (cbTableName.SelectedValue.ToString())
				{
					case "But":
						But but = GetTypeOfList<But>(ref sanPham);
						result = ProductBLL.Instance.InsertBut(propertiesQueryParameters, sanPham, but);
						break;
					case "Sach":
						Sach sach = GetTypeOfList<Sach>(ref sanPham);
						result = ProductBLL.Instance.InsertSach(propertiesQueryParameters, sanPham, sach);
						break;
					case "ThietBiDienTu":
						ThietBiDienTu thietBiDienTu = GetTypeOfList<ThietBiDienTu>(ref sanPham);
						result = ProductBLL.Instance.InsertTBDT(propertiesQueryParameters, sanPham, thietBiDienTu);
						break;
					default:
						sanPham.Gia = double.Parse(Session.ListInputTextBox[0].Item2.Text);
						result = ProductBLL.Instance.InsertVPP(propertiesQueryParameters, sanPham);
						break;
				}
			}

			if (result > 0)
			{
				MessageBox.Show("Thêm mới sản phẩm thành công!", "Book Store",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
				Session.ReloadProductList?.Invoke();
				this.dialogResult = DialogResult.Cancel;
			}
			else
			{
				MessageBox.Show("Thêm mới sản phẩm không thành công! Vui lòng kiển tra lại.", "Book Store",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void lbBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.dialogResult = DialogResult.Cancel;
		}

		private void lbBack_MouseEnter(object sender, EventArgs e)
		{
			(sender as LinkLabel).LinkBehavior = LinkBehavior.SystemDefault;
		}

		private void lbBack_MouseLeave(object sender, EventArgs e)
		{
			(sender as LinkLabel).LinkBehavior = LinkBehavior.NeverUnderline;
		}
	}
}
