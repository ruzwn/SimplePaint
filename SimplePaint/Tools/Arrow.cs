using System.Drawing;
using System.Drawing.Drawing2D;

namespace SimplePaint.Tools
{
	public class Arrow : Tool
	{
		public override void Draw(Graphics gr, Point endPoint, bool isFill)
		{
			var pen = new Pen(ForeColor, PenWidth);
			pen.EndCap = LineCap.ArrowAnchor;
			gr.DrawLine(pen, StartPoint, endPoint);
		}
	}
}