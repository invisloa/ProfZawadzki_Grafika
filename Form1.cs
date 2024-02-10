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

		// falling object
		private Timer animationTimer;
		private int fallingObjectX, fallingObjectY;
		private readonly int fallingObjectSize = 50; // Size of the falling object
		private readonly int fallingSpeed = 5; // Speed of the falling object
		private List<Ball> balls = new List<Ball>();
		private readonly Random random = new Random();
		private void UpdateBalls(object sender, EventArgs e)
		{
			bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height); // Clear the canvas

			foreach (var ball in balls)
			{
				ball.Move(bitmap.Size);
				MyGraphics.DrawCircle(ball.X, ball.Y, ball.Size, bitmap, pictureBox1, ball.Color); // Draw each ball
			}

			pictureBox1.Image = bitmap;
			pictureBox1.Refresh();
		}
		private void SpawnBalls(int count)
		{
			balls.Clear();
			for (int i = 0; i < count; i++)
			{
				int size = fallingObjectSize;
				int x = random.Next(size, pictureBox1.Width - size);
				int y = random.Next(size, pictureBox1.Height - size);
				int speedX = random.Next(-5, 6); // Random speed between -5 and 5
				int speedY = random.Next(-5, 6);
				Color color = _mySelectedColor; // or randomize the color if you prefer

				balls.Add(new Ball(x, y, speedX, speedY, size, color));
			}

			animationTimer.Start();
		}

		enum Tools
		{
			None,
			Line,
			Circle,
			Ellipse,
			Spiral,
			FallingObject
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
			if (tool == Tools.FallingObject)
			{
				fallingObjectX = e.X - fallingObjectSize / 2;
				fallingObjectY = e.Y - fallingObjectSize / 2;
				animationTimer.Start();
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
			animationTimer.Stop(); // Stop the animation
			balls.Clear(); // Clear the list of balls
			bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height); // Reset the bitmap
			pictureBox1.Image = bitmap; // Set the cleared bitmap to the PictureBox
			pictureBox1.Refresh(); // Refresh the PictureBox to show the cleared screen
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

		private void button3_Click(object sender, EventArgs e)
		{
			SpawnBalls(4); // Spawn 4 balls
		}
		public Form1()
		{

			InitializeComponent();
			bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);


			animationTimer = new Timer();
			animationTimer.Interval = 100; // Update every 100 milliseconds
			animationTimer.Tick += new EventHandler(UpdateBalls); // Use UpdateBalls instead of UpdateFallingObject
		}
		private void UpdateFallingObject(object sender, EventArgs e)
		{
			animationTimer.Interval = 0;
			if (fallingObjectY + fallingObjectSize < pictureBox1.Height)
			{
				fallingObjectY += fallingSpeed; // Move the object down
			}
			else
			{
				animationTimer.Stop(); // Stop the animation when the object reaches the bottom
			}

			bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height); // Clear the canvas
			MyGraphics.DrawCircle(fallingObjectX, fallingObjectY, fallingObjectSize, bitmap, pictureBox1, _mySelectedColor); // Draw the falling object
			pictureBox1.Image = bitmap;
			pictureBox1.Refresh();
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
	class Ball
	{
		public int X { get; set; }
		public int Y { get; set; }
		public int SpeedX { get; set; }
		public int SpeedY { get; set; }
		public int Size { get; set; }
		public Color Color { get; set; }

		public Ball(int x, int y, int speedX, int speedY, int size, Color color)
		{
			X = x;
			Y = y;
			SpeedX = speedX;
			SpeedY = speedY;
			Size = size;
			Color = color;
		}

		public void Move(Size canvasSize)
		{
			X += SpeedX;
			Y += SpeedY;

			// Check for canvas boundaries and reverse direction if needed
			if (X < 0 || X + Size > canvasSize.Width) SpeedX = -SpeedX;
			if (Y < 0 || Y + Size > canvasSize.Height) SpeedY = -SpeedY;
		}
	}

}
