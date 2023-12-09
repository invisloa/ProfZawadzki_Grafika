using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProfZawadzki
{

	public partial class Form1 : Form
	{
		Bitmap bitmap;
		int x0, y0, x1, y1;
		private Bitmap tempBitmap;
		bool mouseDown = false;
		private Color _mySelectedColor = Color.Black;
		enum Tools
		{
			None,
			Line,
			Circle,
			Ellipse,
			Spiral
		}
		Tools tool = Tools.None;
		private readonly int _R = 10;

		private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
		{
			if (tool != Tools.None)
			{
				mouseDown = true;
				x0 = e.X;
				y0 = e.Y;
				tempBitmap = (Bitmap)bitmap.Clone(); // Create a copy of the bitmap for the preview
			}
		}


		private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
		{
			if (mouseDown)
			{
				x1 = e.X;
				y1 = e.Y;

				switch (tool)
				{
					case Tools.Line:
						MyGraphics.DrawLine(x0, y0, x1, y1, bitmap, pictureBox1, _mySelectedColor);
						break;
					case Tools.Circle:
						int R = (int)Math.Sqrt(Math.Pow(x1 - x0, 2) + Math.Pow(y1 - y0, 2));
						MyGraphics.DrawCircle(x0, y0, R, bitmap, pictureBox1, _mySelectedColor);
						break;
					case Tools.Ellipse:
						MyGraphics.DrawEllipse(x0, y0, Math.Abs(x1 - x0), Math.Abs(y1 - y0), bitmap, pictureBox1, _mySelectedColor);
						break;
					case Tools.Spiral:
						MyGraphics.DrawSpiral(x0, y0, Math.Abs(x1 - x0), 500, bitmap, pictureBox1, _mySelectedColor);
						break;
					default:
						break;
				}

				pictureBox1.Image = bitmap; // Update the picture box with the original bitmap.
				pictureBox1.Refresh(); // Refresh the PictureBox control.
				mouseDown = false;
			}
		}

		private void btnCircle_Click(object sender, EventArgs e)
		{
			tool = Tools.Circle;
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
			pictureBox1.Image = bitmap;
		}

		private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
		{
			if (mouseDown)
			{
				tempBitmap = (Bitmap)bitmap.Clone();
				int xCurrent = e.X;
				int yCurrent = e.Y;

				switch (tool)
				{
					case Tools.Line:
						MyGraphics.DrawLine(x0, y0, xCurrent, yCurrent, tempBitmap, pictureBox1, Color.Red);
						break;
					case Tools.Circle:
						int R = (int)Math.Sqrt(Math.Pow(xCurrent - x0, 2) + Math.Pow(yCurrent - y0, 2));
						MyGraphics.DrawCircle(x0, y0, R, tempBitmap, pictureBox1, Color.Red);
						break;
					case Tools.Ellipse:
						MyGraphics.DrawEllipse(x0, y0, Math.Abs(xCurrent - x0), Math.Abs(yCurrent - y0), tempBitmap, pictureBox1, Color.Red);
						break;
					case Tools.Spiral:
						MyGraphics.DrawSpiral(x0, y0, Math.Abs(xCurrent - x0), 500, tempBitmap, pictureBox1, Color.Red);
						break;
					default:
						break;
				}
				pictureBox1.Image = tempBitmap;
			}
		}

		private void btnEllipse_Click(object sender, EventArgs e)
		{
			tool = Tools.Ellipse;
		}

		private void BtnRed_Click(object sender, EventArgs e)
		{
			_mySelectedColor = Color.Red;
		}

		private void BtnGreen_Click(object sender, EventArgs e)
		{
			_mySelectedColor = Color.Green;

		}

		private void BtnBlue_Click(object sender, EventArgs e)
		{
			_mySelectedColor = Color.Blue;

		}

		private void BtnYellow_Click(object sender, EventArgs e)
		{
			_mySelectedColor = Color.Yellow;

		}

		private void BtnBlack_Click(object sender, EventArgs e)
		{
			_mySelectedColor = Color.Black;

		}

		private void BtnWhite_Click(object sender, EventArgs e)
		{
			_mySelectedColor = Color.White;

		}

		private void button2_Click(object sender, EventArgs e)
		{
			tool = Tools.Spiral;

		}

		public Form1()
		{

			InitializeComponent();
			bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			tool = Tools.None;
		}

		private void btnNone_Click(object sender, EventArgs e)
		{
			tool = Tools.Line;

		}
	}
}
