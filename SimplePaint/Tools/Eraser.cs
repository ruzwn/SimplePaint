using System.Drawing;
using System.Drawing.Drawing2D;

namespace SimplePaint.Tools
{
	public class Eraser : Tool
	{
		public override void Draw(Graphics gr, Point endPoint, bool isFill)
		{
			var pen = new Pen(BackColor, PenWidth);
			pen.StartCap = pen.EndCap = LineCap.Round;
			gr.SmoothingMode = SmoothingMode.AntiAlias;
			gr.DrawLine(pen, StartPoint, endPoint);
			StartPoint = endPoint;
		}
	}
}