using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using SimplePaint.Tools;

namespace SimplePaint
{
	partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			Tool.ForeColor = foreColorButton.BackColor;
			Tool.BackColor = backColorButton.BackColor;
			Tool.PenWidth = (int) penWidthButton.Value;
			_painter = new Painter(canvasPanel.ClientSize);
		}

		readonly Painter _painter;

		bool _backColorButtonClickedLast;
		
		bool _mousePressed;

		private void foreColorButton_Click(object sender, EventArgs e)
		{
			_backColorButtonClickedLast = true;
		}

		private void backColorButton_Click(object sender, EventArgs e)
		{
			_backColorButtonClickedLast = false;
		}

		private void blackButton_Click(object sender, EventArgs e)
		{
			var button = (Button) sender;
			if (_backColorButtonClickedLast)
				foreColorButton.BackColor = button.BackColor;
			else
				backColorButton.BackColor = button.BackColor;
		}

		private void colorDialogButton_Click(object sender, EventArgs e)
		{
			var colorDialog = new ColorDialog();
			colorDialog.ShowDialog();
			if (_backColorButtonClickedLast)
				foreColorButton.BackColor = colorDialog.Color;
			else
				backColorButton.BackColor = colorDialog.Color;
		}

		private void pencilButton_Click(object sender, EventArgs e)
		{
			_painter.CurrentToolType = ToolType.Pencil;
		}

		private void eraserButton_Click(object sender, EventArgs e)
		{
			_painter.CurrentToolType = ToolType.Eraser;
		}

		private void pipetteButton_Click(object sender, EventArgs e)
		{
			_painter.CurrentToolType = ToolType.Pipette;
		}

		private void textButton_Click(object sender, EventArgs e)
		{
			_painter.CurrentToolType = ToolType.Text;
		}

		private void fillButton_Click(object sender, EventArgs e)
		{
			
		}

		private void lineButton_Click(object sender, EventArgs e)
		{
			_painter.CurrentToolType = ToolType.Line;
		}

		private void ovalButton_Click(object sender, EventArgs e)
		{
			_painter.CurrentToolType = ToolType.Oval;
		}

		private void rectangleButton_Click(object sender, EventArgs e)
		{
			_painter.CurrentToolType = ToolType.Rectangle;
		}

		private void arrowButton_Click(object sender, EventArgs e)
		{
			_painter.CurrentToolType = ToolType.Arrow;
		}

		private void triangleButton_Click(object sender, EventArgs e)
		{
			_painter.CurrentToolType = ToolType.Triangle;
		}

		private void penWidthButton_ValueChanged(object sender, EventArgs e)
		{
			Tool.PenWidth = (int) penWidthButton.Value;
		}

		private void foreColorButton_BackColorChanged(object sender, EventArgs e)
		{
			Tool.ForeColor = foreColorButton.BackColor;
		}

		private void backColorButton_BackColorChanged(object sender, EventArgs e)
		{
			Tool.BackColor = backColorButton.BackColor;
		}

		private void saveAsButton_Click(object sender, EventArgs e)
		{
			var image = _painter.Image;
			var saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = @"PNG (*.png)|*.png|JPEG (*.jpeg)|*.jpeg";
			var result = saveFileDialog.ShowDialog();
			if (result == DialogResult.OK)
			{
				var fileStream = saveFileDialog.OpenFile();
				image.Save(fileStream, ImageFormat.Jpeg);
				fileStream.Close();
			}
		}

		private void openButton_Click(object sender, EventArgs e)
		{
			var openFileDialog = new OpenFileDialog();
			var result = openFileDialog.ShowDialog();
			if (result == DialogResult.OK)
			{
				var fileName = openFileDialog.FileName;
				_painter.Image = new Bitmap(fileName);
				_painter.Paint(canvasPanel.CreateGraphics());
				// ...
			}
		}

		private void canvasPanel_MouseDown(object sender, MouseEventArgs e)
		{
			_mousePressed = true;
			Tool.MouseDownPoint = e.Location;
			switch (e.Button)
			{
				case MouseButtons.Left:
					_painter.DrawStart(e.Location, false);
					break;
				case MouseButtons.Right:
					_painter.DrawStart(e.Location, true);
					break;
			}
		}

		private void canvasPanel_MouseUp(object sender, MouseEventArgs e)
		{
			_mousePressed = false;
			//Tool.MouseDownPoint = Point.Empty;
			if (_painter.CurrentToolType == ToolType.Pipette)
				foreColorButton.BackColor = _painter.DrawEnd(e.Location);
			else
				_painter.DrawEnd(e.Location);
			//canvasPanel.Update();
		}

		private void canvasPanel_MouseMove(object sender, MouseEventArgs e)
		{
			if (_mousePressed)
				_painter.Preview(canvasPanel.CreateGraphics(), e.Location);
		}

		private void canvasPanel_Paint(object sender, PaintEventArgs e)
		{
			_painter.Paint(canvasPanel.CreateGraphics());
		}

		private void canvasPanel_Resize(object sender, EventArgs e)
		{
			if (_painter != null)
				_painter.ImageSize = canvasPanel.ClientSize;
		}

		private void clearCanvasButton_Click(object sender, EventArgs e)
		{
			_painter.Clear(canvasPanel.CreateGraphics());
		}
	}
}