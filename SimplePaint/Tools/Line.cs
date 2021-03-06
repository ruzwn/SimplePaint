using System.Drawing;

namespace SimplePaint.Tools
{
	public class Line : Tool
	{
		public override void Draw(Graphics gr, Point endPoint, bool isFill)
		{
			var pen = new Pen(ForeColor, PenWidth);
			gr.DrawLine(pen, StartPoint, endPoint);
		}
	}
}