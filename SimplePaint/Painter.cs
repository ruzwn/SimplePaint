using System.Collections.Generic;
using System.Drawing;
using SimplePaint.Tools;

namespace SimplePaint
{
	public class Painter
	{
		Bitmap _image;
		Dictionary<ToolType, Tool> _tools;
		bool _isFill;

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

		public Bitmap Image
		{
			get => _image;
			set => _image = value;
		}
		
		Tool _currentTool;

		public Size ImageSize
		{
			get => _image.Size;
			set
			{
				if (value.Width <= 0 || value.Height <= 0)
					return;
				var img = new Bitmap(value.Width, value.Height);
				var imgGr = Graphics.FromImage(img);
				
				// gets image with black background when try to save image (if clear button not clicked)
				imgGr.Clear(Color.White);
				
				imgGr.DrawImage(_image, 0, 0);
				_image = img;
			}
		}

		public Painter(Size size)
		{
			InitializeTools();
			_image = new Bitmap(size.Width, size.Height);
			
			// gets image with black background when try to save image (if clear button not clicked)
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
				{ToolType.Line, new Line()},
				{ToolType.Rectangle, new MyRectangle()},
				//...
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
			_currentTool.Action(gr, endPoint, _isFill);
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