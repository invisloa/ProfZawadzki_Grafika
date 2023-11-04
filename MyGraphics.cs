using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ProfZawadzki
{
	public class MyGraphics
	{
		public static void DrawLine(int x0, int y0, int x1, int y1, Bitmap bitmap, PictureBox pictureBox, Color color)
		{
			int width = pictureBox.Width - 1;
			int height = pictureBox.Height - 1;

			// Horizontal line
			if (y0 == y1)
			{
				int xli = x0;
				int dxi = x0 < x1 ? 1 : -1;
				while (xli != x1)
				{
					if ((xli >= 0) && (xli <= width) && (y0 >= 0) && (y0 <= height))
					{
						bitmap.SetPixel(xli, y0, color);
					}
					xli += dxi;
				}
				pictureBox.Image = bitmap;
				return;
			}

			// Vertical line
			if (x0 == x1)
			{
				int yli = y0;
				int dyi = y0 < y1 ? 1 : -1;
				while (yli != y1)
				{
					if ((x0 >= 0) && (x0 <= width) && (yli >= 0) && (yli <= height))
					{
						bitmap.SetPixel(x0, yli, color);
					}
					yli += dyi;
				}
				pictureBox.Image = bitmap;
				return;
			}

			int dl;




			// slope line
			float xi =x0, yi =y0;
			//m wspolczynnik kierunkowy
			float m = (float)(y1 - y0) / (x1 - x0);
			float dx, dy;
			if(Math.Abs(x1-x0) >= Math.Abs(y1-y0))
			{
				dx = x0<x1 ? 1 : -1;
				dy = m * dx;
				dl = Math.Abs(x1 - x0);
			}
			else
			{
				dy = y0<y1 ? 1 : -1;
				dx = dy/m;
				dl = Math.Abs(y1- y0);
			}
			for (int i = 0; i < dl; i++)
			{
				if (xi > 1 && xi < width && yi > 1 && yi < height)
				{
					bitmap.SetPixel((int)xi, (int)yi, color);
				}

				xi += dx;yi += dy;
			}
		}



		public static void DrawCircle(int xc, int yc, int radius, Bitmap bitmap, PictureBox pictureBox, Color color)
		{
			int x = -radius;
			int y = 0;
			int err = 2 - 2 * radius;       // err is a part of Bresenham's circle algorithm

			do
			{
				// Set the pixels, checking the boundaries of the bitmap
				DrawPixelIfPossible(xc - x, yc + y, bitmap, color);
				DrawPixelIfPossible(xc - y, yc - x, bitmap, color);
				DrawPixelIfPossible(xc + x, yc - y, bitmap, color);
				DrawPixelIfPossible(xc + y, yc + x, bitmap, color);

				int r = err;
				if (r <= y) err += ++y * 2 + 1;
				if (r > x || err > y) err += ++x * 2 + 1;

			} while (x < 0);

			pictureBox.Image = bitmap;
		}

		// Helper method to set a pixel if it's within the bitmap's boundaries
		private static void DrawPixelIfPossible(int x, int y, Bitmap bitmap, Color color)
		{
			if (x >= 0 && x < bitmap.Width && y >= 0 && y < bitmap.Height)
			{
				bitmap.SetPixel(x, y, color);
			}
		}

		public static void DrawEllipse(int xc, int yc, int width, int height, Bitmap bitmap, PictureBox pictureBox, Color color)
		{
			if (width <= 0 || height <= 0)
			{
				// Optionally handle the error: throw an exception, return, log a message, etc.
				return;
			}

			int a2 = width * width;
			int b2 = height * height;
			int fa2 = 4 * a2, fb2 = 4 * b2;
			int x, y, sigma;

			for (x = 0, y = height, sigma = 2 * b2 + a2 * (1 - 2 * height); b2 * x <= a2 * y; x++)
			{
				DrawPixelIfPossible(xc + x, yc + y, bitmap, color);
				DrawPixelIfPossible(xc - x, yc + y, bitmap, color);
				DrawPixelIfPossible(xc + x, yc - y, bitmap, color);
				DrawPixelIfPossible(xc - x, yc - y, bitmap, color);
				if (sigma >= 0)
				{
					sigma += fa2 * (1 - y);
					y--;
				}
				sigma += b2 * ((4 * x) + 6);
			}

			for (x = width, y = 0, sigma = 2 * a2 + b2 * (1 - 2 * width); a2 * y <= b2 * x; y++)
			{
				DrawPixelIfPossible(xc + x, yc + y, bitmap, color);
				DrawPixelIfPossible(xc - x, yc + y, bitmap, color);
				DrawPixelIfPossible(xc + x, yc - y, bitmap, color);
				DrawPixelIfPossible(xc - x, yc - y, bitmap, color);
				if (sigma >= 0)
				{
					sigma += fb2 * (1 - x);
					x--;
				}
				sigma += a2 * ((4 * y) + 6);
			}
			pictureBox.Image = bitmap;
		}

		public static void DrawSpiral(int xc, int yc, int turns, int stepSize, Bitmap bitmap, PictureBox pictureBox, Color color)
		{
			double theta = 0;
			double dTheta = 2 * Math.PI / (stepSize * turns);
			int radius = 0;

			for (int i = 0; i < stepSize * turns; i++)
			{
				int x = xc + (int)(radius * Math.Cos(theta));
				int y = yc + (int)(radius * Math.Sin(theta));

				DrawPixelIfPossible(x, y, bitmap, color);

				radius += 1;
				theta += dTheta;
			}

			pictureBox.Image = bitmap;
		}

	}
}
