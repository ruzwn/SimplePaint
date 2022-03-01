using System.Drawing;

namespace SimplePaint.Tools
{
	public class MyRectangle : Tool
	{
		public override void Draw(Graphics gr, Point endPoint, bool isFill)
		{
			if (endPoint.X < MouseDownPoint.X)
			{
				StartPoint.X = endPoint.X;
				endPoint.X = MouseDownPoint.X;
			}

			if (endPoint.Y < MouseDownPoint.Y)
			{
				StartPoint.Y = endPoint.Y;
				endPoint.Y = MouseDownPoint.Y;
			}

			var dx = endPoint.X - StartPoint.X;
			var dy = endPoint.Y - StartPoint.Y;

			if (isFill)
			{
				var brush = new SolidBrush(ForeColor);
				gr.FillRectangle(brush, StartPoint.X, StartPoint.Y, dx, dy);
			}
			else
			{
				var pen = new Pen(ForeColor, PenWidth);
				gr.DrawRectangle(pen, StartPoint.X, StartPoint.Y, dx, dy);
			}
		}
	}
}