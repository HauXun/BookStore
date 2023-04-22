using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace BookStore.Extensions.Popup
{
	[ToolboxItem(false)]
#if DEBUG
	public class ModelPopup : UserControl
	{
#else
	public abstract class ModelPopup : UserControl
	{
#endif
		private Form ownerForm;
		protected Panel Content;

		public DialogResult dialogResult { get; set; } = DialogResult.None;

		public DialogResult ShowDialog()
		{
			ShowPopup();
			this.Focus();
			while (this.dialogResult == DialogResult.None)
			{
				Thread.Sleep(4);
				Application.DoEvents();
			}
			ClosePopup();
			return this.dialogResult;
		}

		public ModelPopup()
		{
			InitializeComponent();
			SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint, true);
			this.DoubleBuffered = true;
		}

		public virtual void Init(Form ownerForm)
		{
			this.Name = "PopupControl";
			this.AutoScaleMode = AutoScaleMode.Inherit;
			this.BackColor = Color.Transparent;
			this.BackgroundImageLayout = ImageLayout.Zoom;
			this.ownerForm = ownerForm;
			this.ownerForm.Resize += OwnerForm_Resize;
		}

		private void OwnerForm_Resize(object sender, EventArgs e)
		{
			this.ownerForm.Refresh();
			this.Hide();
			DrawPopupBackground();
			RepositionContent();
			this.Show();
			this.ownerForm.Refresh();
		}

		private void RepositionContent()
		{
			this.Content.Left = (ownerForm.ClientSize.Width - this.Content.Width) / 2;
			this.Content.Top = (ownerForm.ClientSize.Height - this.Content.Height) / 2;
			this.Refresh();
		}

		public void ShowPopup()
		{
			DrawPopupBackground();
			this.Dock = DockStyle.Fill;
			this.Controls.Add(Content);
			RepositionContent();
			Content.BringToFront();
			ownerForm.Controls.Add(this);
			this.BringToFront();
		}

		public void ClosePopup()
		{
			this.ownerForm.Controls.Remove(this);
			this.Content.Dispose();
			this.BackgroundImage.Dispose();
			this.Dispose();
			GC.Collect();
		}

		private void DrawPopupBackground()
		{
			this.BackgroundImage = ownerForm.FormClientAreaToImage();
			if (this.BackgroundImage != null)
			{
				using (Graphics gr = Graphics.FromImage(this.BackgroundImage))
				{
					using (Brush br = new SolidBrush(Color.FromArgb(90, Color.Black)))
					{
						gr.FillRectangle(br, 0, 0, this.BackgroundImage.Width, this.BackgroundImage.Height);
					}
				}
			}
		}

		private void InitializeComponent()
		{
			this.Content = new Panel();
			this.SuspendLayout();
			// 
			// Content
			// 
			this.Content.BackColor = Color.White;
			this.Content.Location = new Point(0, 0);
			this.Content.Name = "Content";
			this.Content.Size = new Size(82, 82);
			this.Content.TabIndex = 1;
			// 
			// ModelPopup
			// 
			this.Controls.Add(this.Content);
			this.Name = "ModelPopup";
			this.Size = new Size(352, 225);
			this.ResumeLayout(false);
		}
	}
}
