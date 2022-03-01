using System;
using System.Drawing;

namespace SimplePaint.Tools
{
	public class Triangle : Tool
	{
		public override void Draw(Graphics gr, Point endPoint, bool isFill)
		{
			var sideLengt = Math.Sqrt(
				Math.Pow(StartPoint.X - endPoint.X, 2)
				+ Math.Pow(StartPoint.Y - endPoint.Y, 2));
			var y = Math.Sqrt(3) / 2f * sideLengt;
			var x = (StartPoint.X + endPoint.X) / 2f + Math.Sqrt(3) / 2 * (StartPoint.Y - endPoint.Y);
			var point = new Point((int) x, (int) y);
			if (isFill)
			{
				var brush = new SolidBrush(ForeColor);
				gr.FillPolygon(brush, new[] {StartPoint, point, endPoint});
			}
			else
			{
				var pen = new Pen(ForeColor, PenWidth);
				gr.DrawPolygon(pen, new[] {StartPoint, point, endPoint});
			}
		}
	}
}