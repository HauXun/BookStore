using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore.Extensions.Popup
{
	public static class ControlExtensions
	{
		public static Bitmap ControlToImage(this Control control)
		{
			Bitmap controlImage = new Bitmap(control.Width, control.Height);
			control.DrawToBitmap(controlImage, new Rectangle(0, 0, control.Width, control.Height));
			return controlImage;
		}

		public static Bitmap FormClientAreaToImage(this Form form)
		{
			using (Bitmap frmImage = form.ControlToImage())
			{
				Point origin = form.PointToScreen(new Point(0, 0));
				int diffx = origin.X - form.Left;
				int diffy = origin.Y - form.Top;

				int clientAreaWidth = form.ClientSize.Width;
				int clientAreaHeight = form.ClientSize.Height;
				Bitmap clientAreaImage = null;

				if (clientAreaHeight > 0 && clientAreaWidth > 0)
				{
					clientAreaImage = new Bitmap(clientAreaWidth, clientAreaHeight);
					using (Graphics gr = Graphics.FromImage(clientAreaImage))
					{
						gr.DrawImage(frmImage, 0, 0,
							new Rectangle(diffx, diffy, clientAreaWidth, clientAreaHeight),
							GraphicsUnit.Pixel);
					}
				}
				return clientAreaImage;
			}
		}
	}
}
