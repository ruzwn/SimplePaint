using System.Drawing;
using System.Drawing.Drawing2D;

namespace SimplePaint.Tools
{
	public class Pencil : Tool
	{
		public override void Draw(Graphics gr, Point endPoint, bool isFill)
		{
			var pen = new Pen(ForeColor, PenWidth);
			pen.StartCap = pen.EndCap = LineCap.Round;
			gr.SmoothingMode = SmoothingMode.AntiAlias;
			gr.DrawLine(pen, StartPoint, endPoint);
			StartPoint = endPoint;
		}
	}
}