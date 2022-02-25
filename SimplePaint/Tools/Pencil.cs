using System.Drawing;

namespace SimplePaint.Tools
{
	public class Pencil : Tool
	{
		public override void Action(Graphics gr, Point endPoint)
		{
			var pen = new Pen(ForeColor, PenWidth);
			gr.DrawLine(pen, StartPoint, endPoint);
			StartPoint = endPoint;
		}
	}
}