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
		public Form1()
		{

			InitializeComponent();
			bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);

		}

		private void button1_Click(object sender, EventArgs e)
		{
			MyGraphics.DrawLine(30, 80, 220, 80, bitmap, pictureBox1, Color.Black);
			MyGraphics.DrawLine(30, 200, 30, 80, bitmap, pictureBox1, Color.Black);
		}

	}
}
