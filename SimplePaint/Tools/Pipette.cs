using System.Drawing;

namespace SimplePaint.Tools
{
	public class Pipette : Tool
	{
		public override void Draw(Graphics gr, Point endPoint, bool isFill)
		{
		}

		public Color GetColorFromImage(Bitmap img, Point endPoint)
		{
			return img.GetPixel(endPoint.X, endPoint.Y);
		}
	}
}