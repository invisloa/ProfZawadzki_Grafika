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
		bool mouseDown = false;
		enum Tools
		{
			None,
			Line,
			Circle
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
			}
		}

		private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
		{
			x1 = e.X;
			y1 = e.Y;
			if (tool != Tools.None && mouseDown == true)
			{

				switch (tool)
				{
					case Tools.Line:
						MyGraphics.DrawLine(x0, y0, x1, y1, bitmap, pictureBox1, Color.Red);
						break;
					// Add other cases as needed
					case Tools.Circle:
						MyGraphics.DrawCircle(x0,y0, _R, bitmap, pictureBox1, Color.Blue);
						break;

					default:
						break;

				}
				pictureBox1.Refresh();

				mouseDown = false;
			}
		}

		private void btnCircle_Click(object sender, EventArgs e)
		{
			tool = Tools.Circle;
		}

		public Form1()
		{

			InitializeComponent();
			bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);

		}

		private void button1_Click(object sender, EventArgs e)
		{
			tool = Tools.Line;
		}

		private void btnNone_Click(object sender, EventArgs e)
		{
			tool = Tools.None;
		}
	}
}
