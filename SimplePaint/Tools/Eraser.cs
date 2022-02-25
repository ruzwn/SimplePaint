using System.Drawing;

namespace SimplePaint.Tools
{
	public class Eraser : Tool
	{
		public override void Action(Graphics gr, Point endPoint)
		{
			var pen = new Pen(BackColor, PenWidth);
			gr.DrawLine(pen, StartPoint, endPoint);
			StartPoint = endPoint;
		}
	}
}