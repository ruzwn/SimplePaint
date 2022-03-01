using System.Drawing;

namespace SimplePaint.Tools
{
	public abstract class Tool
	{
		public static Color ForeColor;
		public static Color BackColor;
		public static int PenWidth;
		public Point StartPoint;
		public static Point MouseDownPoint;

		// public Pen Pen
		// {
		// 	get => _pen;
		// 	set => 
		// }
		
		public abstract void Draw(Graphics gr, Point endPoint, bool isFill);
	}
}