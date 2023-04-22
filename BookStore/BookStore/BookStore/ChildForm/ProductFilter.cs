using BookStore.Extensions.Popup;
using BookStore.Model.BusinessLogicLayer;
using BookStore.Partial;
using System;
using System.Collections;
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
	public partial class ProductFilter : ModelPopup
	{
		private event EventHandler<NewDataFilter> dataFilterResults;
		public event EventHandler<NewDataFilter> DataFilterResults
		{
			add
			{
				dataFilterResults += value;
			}
			remove
			{
				dataFilterResults -= value;
			}
		}

		public ProductFilter() : base()
		{
			InitializeComponent();
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

		private void GetInfoProductFilter(string tableName)
		{
			flpFilterControl.Controls.Clear();
			DataTable data = ProductFilterBLL.Instance.GetInfoProductFilter(tableName);

			if (data.Rows.Count > 0)
			{
				int columnCount = data.Rows[0].Table.Columns.Count;
				List<Tuple<string, List<string>>> listColumnData = new List<Tuple<string, List<string>>>();

				for (int i = 0; i < columnCount; i++)
				{
					Tuple<string, List<string>> tupleColumnData;
					string columnName = data.Columns[i].ToString();
					DataTable dataColumn = data.AsEnumerable().GroupBy(row => row.Field<string>(columnName)).Select(group => group.First()).CopyToDataTable();
					tupleColumnData = new Tuple<string, List<string>>(columnName,
						dataColumn.AsEnumerable().Select(p => p.Field<string>(columnName)).ToList());
					listColumnData.Add(tupleColumnData);
				}

				Session.DataFilter = new List<Tuple<string, string, string>>();
				FilterDetailBox filterDetailBox = new FilterDetailBox();
				int listColumnCount = listColumnData.Count;
				int limitColumn = filterDetailBox.Column;
				var rowCount = Math.Ceiling((float)listColumnCount / limitColumn);
				for (int i = 0; i < rowCount; i++)
				{
					List<Tuple<string, List<string>>> listToInput;
					if (listColumnCount > limitColumn)
					{
						listToInput = listColumnData.GetRange(0, limitColumn);
						listColumnData.RemoveRange(0, limitColumn);
					}
					else
					{
						listToInput = listColumnData.GetRange(0, listColumnCount);
						listColumnData.RemoveRange(0, listColumnCount);
					}
					listColumnCount -= limitColumn;
					flpFilterControl.Controls.Add(new FilterDetailBox() { ListColumnData = listToInput }.tableBox);
				}
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

		private void ProductFilter_Load(object sender, EventArgs e)
		{
			LoadData();
		}

		private void cbTableName_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbTableName.SelectedValue != null)
			{
				GetInfoProductFilter(cbTableName.SelectedValue.ToString());
			}
		}

		private void btnApplyFilter_Click(object sender, EventArgs e)
		{
			string tableFilter = cbTableName.SelectedValue.ToString();
			if (Session.DataFilter.Count > 0 && !string.IsNullOrEmpty(tableFilter))
			{
				DataTable data = Session.ConvertToDataTable(Session.DataFilter);
				DataTable results = ProductFilterBLL.Instance.ProductFilter(tableFilter, data);
				if (dataFilterResults != null && results != null)
				{
					dataFilterResults(this, new NewDataFilter(tableFilter, data, results));
				}
				this.dialogResult = DialogResult.Cancel;
			}
		}
	}

	public class NewDataFilter : EventArgs
	{
		private DataTable dataFilter;
		private DataTable dataFilterResults;
		private string tableFilter;

		public NewDataFilter(string tableFilter, DataTable dataFilter, DataTable dataFilterResults)
		{
			DataFilter = dataFilter;
			DataFilterResults = dataFilterResults;
			TableFilter = tableFilter;
		}

		public DataTable DataFilter { get => dataFilter; set => dataFilter = value; }
		public DataTable DataFilterResults { get => dataFilterResults; set => dataFilterResults = value; }
		public string TableFilter { get => tableFilter; set => tableFilter = value; }
	}
}
