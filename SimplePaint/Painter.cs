using System.Collections.Generic;
using System.Drawing;
using SimplePaint.Tools;

namespace SimplePaint
{
	public class Painter
	{
		
		Bitmap _image;
		Dictionary<ToolType, Tool> _tools;
		ToolType _currentToolType;
		Tool _currentTool;
		bool _isFill;

		public ToolType CurrentToolType
		{
			get => _currentToolType;
			set
			{
				_currentToolType = value;
				_currentTool = _tools[_currentToolType];
			}
		}

		public Bitmap Image
		{
			get => _image;
			set => _image = value;
		}

		public Size ImageSize
		{
			set
			{
				if (value.Width <= 0 || value.Height <= 0)
					return;
				
				var img = new Bitmap(value.Width, value.Height);
				var imgGr = Graphics.FromImage(img);
				
				imgGr.Clear(Color.White);
				imgGr.DrawImage(_image, 0, 0);
				_image = img;
			}
		}

		public Painter(Size size)
		{
			InitializeTools();
			_image = new Bitmap(size.Width, size.Height);
			var imgGr = Graphics.FromImage(_image);
			imgGr.Clear(Color.White);
		}

		void InitializeTools()
		{
			_tools = new Dictionary<ToolType, Tool>
			{
				{ToolType.Pencil, new Pencil()},
				{ToolType.Eraser, new Eraser()},
				{ToolType.Pipette, new Pipette()},
				{ToolType.Text, new Text()},
				{ToolType.Line, new Line()},
				{ToolType.Oval, new Oval()},
				{ToolType.Rectangle, new MyRectangle()},
				{ToolType.Arrow, new Arrow()},
				{ToolType.Triangle, new Triangle()}
			};
			_currentToolType = ToolType.Pencil;
			_currentTool = _tools[_currentToolType];
		}

		public void DrawStart(Point position, bool isFill)
		{
			_currentTool.StartPoint = position;
			_isFill = isFill;
		}

		public Color DrawEnd(Point endPoint)
		{
			var imgGr = Graphics.FromImage(_image);
			Draw(imgGr, endPoint);
			
			if (_currentToolType == ToolType.Pipette)
			{
				var pipette = (Pipette) _currentTool;
				return pipette.GetColorFromImage(_image, endPoint);
			}

			return Color.White;
		}

		void Draw(Graphics gr, Point endPoint)
		{
			_currentTool.Draw(gr, endPoint, _isFill);
		}

		public void Preview(Graphics gr, Point endPoint)
		{ 
			switch (CurrentToolType)
			{
				case ToolType.Pipette:
					break;
				case ToolType.Pencil:
				case ToolType.Eraser:
					Draw(Graphics.FromImage(_image), endPoint);
					gr.DrawImage(_image, 0, 0);
					break;
				default:
					var img = (Bitmap) _image.Clone();
					var imgGr = Graphics.FromImage(img);
					imgGr.Clear(Color.White);
					imgGr.DrawImage(_image, 0, 0);
					Draw(imgGr, endPoint);
					gr.DrawImage(img, 0, 0);
					break;
			}
		}

		public void Paint(Graphics gr)
		{
			gr.DrawImage(_image, 0, 0);
		}

		public void Clear(Graphics gr)
		{
			var imgGr = Graphics.FromImage(_image);
			imgGr.Clear(Color.White);
			gr.Clear(Color.White);
		}
	}
}