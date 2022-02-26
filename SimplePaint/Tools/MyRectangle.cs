using System.Drawing;

namespace SimplePaint.Tools
{
	public class MyRectangle : Tool
	{
		public override void Action(Graphics gr, Point endPoint, bool isFill)
		{
			if (isFill)
			{
				var brush = new SolidBrush(ForeColor);
				gr.FillRectangle(brush, StartPoint.X, StartPoint.Y, endPoint.X - StartPoint.X, endPoint.Y - StartPoint.Y);
			}
			else
			{
				var pen = new Pen(ForeColor, PenWidth);
				gr.DrawRectangle(pen, StartPoint.X, StartPoint.Y, endPoint.X - StartPoint.X, endPoint.Y - StartPoint.Y);
			}
		}
	}
}