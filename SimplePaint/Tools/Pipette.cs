using System.Drawing;

namespace SimplePaint.Tools
{
	public class Pipette : Tool
	{
		public override void Action(Graphics gr, Point endPoint)
		{
		}

		public Color GetColorFromImage(Bitmap img, Point endPoint)
		{
			return img.GetPixel(endPoint.X, endPoint.Y);
		}
	}
}