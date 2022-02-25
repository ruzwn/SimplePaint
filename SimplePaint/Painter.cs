using System.Collections.Generic;
using System.Drawing;
using SimplePaint.Tools;

namespace SimplePaint
{
	public class Painter
	{
		Bitmap _image;
		Dictionary<ToolType, Tool> _tools;

		public enum ToolType
		{
			Pencil,
			Eraser,
			Pipette,
			Text,
			Fill,
			Line,
			Oval,
			Rectangle,
			Arrow,
			Triangle
		}

		ToolType _currentToolType;
		public ToolType CurrentToolType
		{
			get => _currentToolType;
			set
			{
				_currentToolType = value;
				_currentTool = _tools[_currentToolType];
			}
		}
		
		Tool _currentTool;

		public Size ImageSize
		{
			get => _image.Size;
			set
			{
				var img = new Bitmap(value.Width, value.Height);
				var imgGr = Graphics.FromImage(img);
				imgGr.DrawImage(_image, 0, 0);
				_image = img;
			}
		}

		public Painter(Size size)
		{
			InitializeTools();
			_image = new Bitmap(size.Width, size.Height);
		}

		void InitializeTools()
		{
			_tools = new Dictionary<ToolType, Tool>
			{
				{ToolType.Pencil, new Pencil()},
				{ToolType.Eraser, new Eraser()},
				{ToolType.Pipette, new Pipette()},
				{ToolType.Line, new Line()},
				{ToolType.Rectangle, new MyRectangle()},
				// ...
			};
			_currentToolType = ToolType.Pencil;
			_currentTool = _tools[_currentToolType];
		}

		public void DrawStart(Point position)
		{
			_currentTool.StartPoint = position;
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
			_currentTool.Action(gr, endPoint);
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