using System.Drawing;

namespace SimplePaint.Tools
{
	public class MyRectangle : Tool
	{
		public override void Action(Graphics gr, Point endPoint)
		{
			var pen = new Pen(ForeColor, PenWidth);
			gr.DrawRectangle(pen, StartPoint.X, StartPoint.Y, StartPoint.X + endPoint.X, StartPoint.Y + endPoint.Y);
		}
	}
}