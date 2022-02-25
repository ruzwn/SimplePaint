using System;
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
			Tool.BackColor = foreColorButton.BackColor;
			Tool.PenWidth = (int) penWidthButton.Value;
			_painter = new Painter(canvasPanel.ClientSize);
		}

		readonly Painter _painter;

		bool _foreColorButtonClickedLast = true;

		bool _mousePressed;

		private void foreColorButton_Click(object sender, EventArgs e)
		{
			_foreColorButtonClickedLast = true;
		}

		private void backColorButton_Click(object sender, EventArgs e)
		{
			_foreColorButtonClickedLast = false;
		}

		private void blackButton_Click(object sender, EventArgs e)
		{
			var button = (Button) sender;
			if (_foreColorButtonClickedLast)
				foreColorButton.BackColor = button.BackColor;
			else
				backColorButton.BackColor = button.BackColor;
		}

		private void colorDialogButton_Click(object sender, EventArgs e)
		{
			var colorDialog = new ColorDialog();
			colorDialog.ShowDialog();
			if (_foreColorButtonClickedLast)
				foreColorButton.BackColor = colorDialog.Color;
			else
				backColorButton.BackColor = colorDialog.Color;
		}

		private void pencilButton_Click(object sender, EventArgs e)
		{
			_painter.CurrentToolType = Painter.ToolType.Pencil;
		}

		private void eraserButton_Click(object sender, EventArgs e)
		{
			_painter.CurrentToolType = Painter.ToolType.Eraser;
		}

		private void pipetteButton_Click(object sender, EventArgs e)
		{
			_painter.CurrentToolType = Painter.ToolType.Pipette;
		}

		private void textButton_Click(object sender, EventArgs e)
		{

		}

		private void fillButton_Click(object sender, EventArgs e)
		{

		}

		private void lineButton_Click(object sender, EventArgs e)
		{
			_painter.CurrentToolType = Painter.ToolType.Line;
		}

		private void ovalButton_Click(object sender, EventArgs e)
		{

		}

		private void rectangleButton_Click(object sender, EventArgs e)
		{
			_painter.CurrentToolType = Painter.ToolType.Rectangle;
		}

		private void arrowButton_Click(object sender, EventArgs e)
		{

		}

		private void triangleButton_Click(object sender, EventArgs e)
		{

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
			
		}

		private void openButton_Click(object sender, EventArgs e)
		{

		}

		private void canvasPanel_MouseDown(object sender, MouseEventArgs e)
		{
			_mousePressed = true;
			_painter.DrawStart(e.Location);
		}

		private void canvasPanel_MouseUp(object sender, MouseEventArgs e)
		{
			_mousePressed = false;
			if (_painter.CurrentToolType == Painter.ToolType.Pipette)
				foreColorButton.BackColor = _painter.DrawEnd(e.Location);
			_painter.DrawEnd(e.Location);
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
			if (_painter == null)
				return;
			_painter.ImageSize = canvasPanel.ClientSize;
		}

		private void clearCanvasButton_Click(object sender, EventArgs e)
		{
			_painter.Clear(canvasPanel.CreateGraphics());
		}
	}
}