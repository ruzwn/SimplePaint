using System.Drawing;

namespace SimplePaint.Tools
{
	public class Oval : Tool
	{
		public override void Action(Graphics gr, Point endPoint)
		{
			var pen = new Pen(ForeColor, PenWidth);
			
		}
	}
}