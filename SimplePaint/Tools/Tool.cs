using System.Drawing;

namespace SimplePaint.Tools
{
	public abstract class Tool
	{
		public static Color ForeColor;
		public static Color BackColor;
		public static int PenWidth;
		public Point StartPoint;
		
		public abstract void Action(Graphics gr, Point endPoint, bool isFill);
	}
}