using BookStore.ChildForm;
using Bunifu.UI.WinForms;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace BookStore.Partial
{
	public static class Session
	{
		public static Action ReloadProductList;
		public static BillRowBox BillRowBox;
		public static List<Tuple<string, string, string>> DataFilter = new List<Tuple<string, string, string>>();
		public static List<Tuple<Label, Guna2TextBox>> ListInputTextBox = new List<Tuple<Label, Guna2TextBox>>();

		public enum TabPage
		{
			Inighst = 0,
			Bill,
			Analysis,
			Product,
		}

		//Bo tròn góc các Control
		#region Rounded Form
		[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
		public static extern IntPtr CreateRoundRectRgn
		(
			int nLeftRect,     // x-coordinate of upper-left corner
			int nTopRect,      // y-coordinate of upper-left corner
			int nRightRect,    // x-coordinate of lower-right corner
			int nBottomRect,   // y-coordinate of lower-right corner
			int nWidthEllipse, // width of ellipse
			int nHeightEllipse // height of ellipse
		);
		#endregion

		//Chức năng di chuyển Form bằng thanh ControlBox
		#region Drag Form
		[DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
		public extern static void ReleaseCapture();

		[DllImport("user32.dll", EntryPoint = "SendMessage")]
		public extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
		#endregion

		public static List<T> ConvertDataTable<T>(DataTable dt)
		{
			List<T> data = new List<T>();
			foreach (DataRow row in dt.Rows)
			{
				T item = GetItem<T>(row);
				data.Add(item);
			}
			return data;
		}

		private static T GetItem<T>(DataRow dr)
		{
			Type temp = typeof(T);
			T obj = Activator.CreateInstance<T>();

			foreach (DataColumn column in dr.Table.Columns)
			{
				foreach (PropertyInfo pro in temp.GetProperties())
				{
					if (pro.Name == column.ColumnName)
						pro.SetValue(obj, dr[column.ColumnName], null);
					else
						continue;
				}
			}
			return obj;
		}

		public static DataTable ConvertToDataTable<T>(IList<T> data)
		{
			PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
			DataTable table = new DataTable();
			foreach (PropertyDescriptor prop in properties)
			{
				table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
			}
			foreach (T item in data)
			{
				DataRow row = table.NewRow();
				foreach (PropertyDescriptor prop in properties)
				{
					row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
				}
				table.Rows.Add(row);
			}
			return table;
		}


		/// <summary>  
		/// Method for changing the opacity of an image  
		/// </summary>  
		/// <param name="image">image to set opacity on</param>  
		/// <param name="opacity">percentage of opacity</param>  
		/// <returns></returns>  
		public static Image SetImageOpacity(Image image, float opacity)
		{
			//create a Bitmap the size of the image provided  
			Bitmap bmp = new Bitmap(image.Width, image.Height);

			//create a graphics object from the image  
			using (Graphics gfx = Graphics.FromImage(bmp))
			{

				//create a color matrix object  
				ColorMatrix matrix = new ColorMatrix();

				//set the opacity  
				matrix.Matrix33 = opacity;

				//create image attributes  
				ImageAttributes attributes = new ImageAttributes();

				//set the color(opacity) of the image  
				attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

				//now draw the image  
				gfx.DrawImage(image, new Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, attributes);
			}
			return bmp;
		}
	}
}
