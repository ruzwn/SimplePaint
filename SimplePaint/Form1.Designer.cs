using System.ComponentModel;
using System.Windows.Forms;

namespace SimplePaint
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}

			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.canvasPanel = new System.Windows.Forms.Panel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.backColorButton = new System.Windows.Forms.Button();
			this.foreColorButton = new System.Windows.Forms.Button();
			this.colorDialogButton = new System.Windows.Forms.Button();
			this.pinkButton = new System.Windows.Forms.Button();
			this.fuchsiaButton = new System.Windows.Forms.Button();
			this.plumButton = new System.Windows.Forms.Button();
			this.indigoButton = new System.Windows.Forms.Button();
			this.blueButton = new System.Windows.Forms.Button();
			this.deepSkyBlutButton = new System.Windows.Forms.Button();
			this.aquaButton = new System.Windows.Forms.Button();
			this.greenButton = new System.Windows.Forms.Button();
			this.khakiButton = new System.Windows.Forms.Button();
			this.yellowButton = new System.Windows.Forms.Button();
			this.orangeButton = new System.Windows.Forms.Button();
			this.redButton = new System.Windows.Forms.Button();
			this.whiteButton = new System.Windows.Forms.Button();
			this.grayButton = new System.Windows.Forms.Button();
			this.blackButton = new System.Windows.Forms.Button();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.fillButton = new System.Windows.Forms.Button();
			this.textButton = new System.Windows.Forms.Button();
			this.pipetteButton = new System.Windows.Forms.Button();
			this.eraserButton = new System.Windows.Forms.Button();
			this.pencilButton = new System.Windows.Forms.Button();
			this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
			this.triangleButton = new System.Windows.Forms.Button();
			this.arrowButton = new System.Windows.Forms.Button();
			this.rectangleButton = new System.Windows.Forms.Button();
			this.ovalButton = new System.Windows.Forms.Button();
			this.lineButton = new System.Windows.Forms.Button();
			this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
			this.clearCanvasButton = new System.Windows.Forms.Button();
			this.openButton = new System.Windows.Forms.Button();
			this.penWidthButton = new System.Windows.Forms.NumericUpDown();
			this.saveAsButton = new System.Windows.Forms.Button();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.tableLayoutPanel4.SuspendLayout();
			this.tableLayoutPanel5.SuspendLayout();
			this.tableLayoutPanel6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) (this.penWidthButton)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(
				new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
			this.tableLayoutPanel1.ColumnStyles.Add(
				new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel1.Controls.Add(this.canvasPanel, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(
				new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1082, 622);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// canvasPanel
			// 
			this.canvasPanel.AutoScroll = true;
			this.canvasPanel.BackColor = System.Drawing.Color.White;
			this.canvasPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.canvasPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.canvasPanel.Location = new System.Drawing.Point(3, 3);
			this.canvasPanel.Name = "canvasPanel";
			this.canvasPanel.Size = new System.Drawing.Size(805, 616);
			this.canvasPanel.TabIndex = 0;
			this.canvasPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.canvasPanel_Paint);
			this.canvasPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvasPanel_MouseDown);
			this.canvasPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvasPanel_MouseMove);
			this.canvasPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvasPanel_MouseUp);
			this.canvasPanel.Resize += new System.EventHandler(this.canvasPanel_Resize);
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tableLayoutPanel2.ColumnCount = 1;
			this.tableLayoutPanel2.ColumnStyles.Add(
				new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 0, 2);
			this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel6, 0, 3);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(814, 3);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 5;
			this.tableLayoutPanel2.RowStyles.Add(
				new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel2.RowStyles.Add(
				new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel2.RowStyles.Add(
				new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutPanel2.RowStyles.Add(
				new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel2.RowStyles.Add(
				new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(265, 616);
			this.tableLayoutPanel2.TabIndex = 1;
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 4;
			this.tableLayoutPanel3.ColumnStyles.Add(
				new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel3.ColumnStyles.Add(
				new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel3.ColumnStyles.Add(
				new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel3.ColumnStyles.Add(
				new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanel3.Controls.Add(this.backColorButton, 2, 4);
			this.tableLayoutPanel3.Controls.Add(this.foreColorButton, 0, 4);
			this.tableLayoutPanel3.Controls.Add(this.colorDialogButton, 3, 3);
			this.tableLayoutPanel3.Controls.Add(this.pinkButton, 2, 3);
			this.tableLayoutPanel3.Controls.Add(this.fuchsiaButton, 1, 3);
			this.tableLayoutPanel3.Controls.Add(this.plumButton, 0, 3);
			this.tableLayoutPanel3.Controls.Add(this.indigoButton, 3, 2);
			this.tableLayoutPanel3.Controls.Add(this.blueButton, 2, 2);
			this.tableLayoutPanel3.Controls.Add(this.deepSkyBlutButton, 1, 2);
			this.tableLayoutPanel3.Controls.Add(this.aquaButton, 0, 2);
			this.tableLayoutPanel3.Controls.Add(this.greenButton, 3, 1);
			this.tableLayoutPanel3.Controls.Add(this.khakiButton, 2, 1);
			this.tableLayoutPanel3.Controls.Add(this.yellowButton, 1, 1);
			this.tableLayoutPanel3.Controls.Add(this.orangeButton, 0, 1);
			this.tableLayoutPanel3.Controls.Add(this.redButton, 3, 0);
			this.tableLayoutPanel3.Controls.Add(this.whiteButton, 2, 0);
			this.tableLayoutPanel3.Controls.Add(this.grayButton, 1, 0);
			this.tableLayoutPanel3.Controls.Add(this.blackButton, 0, 0);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 4);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 5;
			this.tableLayoutPanel3.RowStyles.Add(
				new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel3.RowStyles.Add(
				new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel3.RowStyles.Add(
				new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel3.RowStyles.Add(
				new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel3.RowStyles.Add(
				new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(257, 116);
			this.tableLayoutPanel3.TabIndex = 0;
			// 
			// backColorButton
			// 
			this.backColorButton.BackColor = System.Drawing.Color.White;
			this.tableLayoutPanel3.SetColumnSpan(this.backColorButton, 2);
			this.backColorButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.backColorButton.Location = new System.Drawing.Point(131, 95);
			this.backColorButton.Name = "backColorButton";
			this.backColorButton.Size = new System.Drawing.Size(123, 18);
			this.backColorButton.TabIndex = 17;
			this.backColorButton.UseVisualStyleBackColor = false;
			this.backColorButton.BackColorChanged += new System.EventHandler(this.backColorButton_BackColorChanged);
			this.backColorButton.Click += new System.EventHandler(this.backColorButton_Click);
			// 
			// foreColorButton
			// 
			this.foreColorButton.BackColor = System.Drawing.Color.Black;
			this.tableLayoutPanel3.SetColumnSpan(this.foreColorButton, 2);
			this.foreColorButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.foreColorButton.Location = new System.Drawing.Point(3, 95);
			this.foreColorButton.Name = "foreColorButton";
			this.foreColorButton.Size = new System.Drawing.Size(122, 18);
			this.foreColorButton.TabIndex = 16;
			this.foreColorButton.UseVisualStyleBackColor = false;
			this.foreColorButton.BackColorChanged += new System.EventHandler(this.foreColorButton_BackColorChanged);
			this.foreColorButton.Click += new System.EventHandler(this.foreColorButton_Click);
			// 
			// colorDialogButton
			// 
			this.colorDialogButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.colorDialogButton.Font = new System.Drawing.Font("Showcard Gothic", 9F,
				System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.colorDialogButton.Location = new System.Drawing.Point(195, 72);
			this.colorDialogButton.Name = "colorDialogButton";
			this.colorDialogButton.Size = new System.Drawing.Size(59, 17);
			this.colorDialogButton.TabIndex = 15;
			this.colorDialogButton.Text = "...";
			this.colorDialogButton.UseVisualStyleBackColor = true;
			this.colorDialogButton.Click += new System.EventHandler(this.colorDialogButton_Click);
			// 
			// pinkButton
			// 
			this.pinkButton.BackColor = System.Drawing.Color.Pink;
			this.pinkButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pinkButton.Location = new System.Drawing.Point(131, 72);
			this.pinkButton.Name = "pinkButton";
			this.pinkButton.Size = new System.Drawing.Size(58, 17);
			this.pinkButton.TabIndex = 14;
			this.pinkButton.UseVisualStyleBackColor = false;
			this.pinkButton.Click += new System.EventHandler(this.blackButton_Click);
			// 
			// fuchsiaButton
			// 
			this.fuchsiaButton.BackColor = System.Drawing.Color.Fuchsia;
			this.fuchsiaButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fuchsiaButton.Location = new System.Drawing.Point(67, 72);
			this.fuchsiaButton.Name = "fuchsiaButton";
			this.fuchsiaButton.Size = new System.Drawing.Size(58, 17);
			this.fuchsiaButton.TabIndex = 13;
			this.fuchsiaButton.UseVisualStyleBackColor = false;
			this.fuchsiaButton.Click += new System.EventHandler(this.blackButton_Click);
			// 
			// plumButton
			// 
			this.plumButton.BackColor = System.Drawing.Color.Plum;
			this.plumButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.plumButton.Location = new System.Drawing.Point(3, 72);
			this.plumButton.Name = "plumButton";
			this.plumButton.Size = new System.Drawing.Size(58, 17);
			this.plumButton.TabIndex = 12;
			this.plumButton.UseVisualStyleBackColor = false;
			this.plumButton.Click += new System.EventHandler(this.blackButton_Click);
			// 
			// indigoButton
			// 
			this.indigoButton.BackColor = System.Drawing.Color.Indigo;
			this.indigoButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.indigoButton.Location = new System.Drawing.Point(195, 49);
			this.indigoButton.Name = "indigoButton";
			this.indigoButton.Size = new System.Drawing.Size(59, 17);
			this.indigoButton.TabIndex = 11;
			this.indigoButton.UseVisualStyleBackColor = false;
			this.indigoButton.Click += new System.EventHandler(this.blackButton_Click);
			// 
			// blueButton
			// 
			this.blueButton.BackColor = System.Drawing.Color.Blue;
			this.blueButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.blueButton.Location = new System.Drawing.Point(131, 49);
			this.blueButton.Name = "blueButton";
			this.blueButton.Size = new System.Drawing.Size(58, 17);
			this.blueButton.TabIndex = 10;
			this.blueButton.UseVisualStyleBackColor = false;
			this.blueButton.Click += new System.EventHandler(this.blackButton_Click);
			// 
			// deepSkyBlutButton
			// 
			this.deepSkyBlutButton.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.deepSkyBlutButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.deepSkyBlutButton.Location = new System.Drawing.Point(67, 49);
			this.deepSkyBlutButton.Name = "deepSkyBlutButton";
			this.deepSkyBlutButton.Size = new System.Drawing.Size(58, 17);
			this.deepSkyBlutButton.TabIndex = 9;
			this.deepSkyBlutButton.UseVisualStyleBackColor = false;
			this.deepSkyBlutButton.Click += new System.EventHandler(this.blackButton_Click);
			// 
			// aquaButton
			// 
			this.aquaButton.BackColor = System.Drawing.Color.Aqua;
			this.aquaButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.aquaButton.Location = new System.Drawing.Point(3, 49);
			this.aquaButton.Name = "aquaButton";
			this.aquaButton.Size = new System.Drawing.Size(58, 17);
			this.aquaButton.TabIndex = 8;
			this.aquaButton.UseVisualStyleBackColor = false;
			this.aquaButton.Click += new System.EventHandler(this.blackButton_Click);
			// 
			// greenButton
			// 
			this.greenButton.BackColor = System.Drawing.Color.Green;
			this.greenButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.greenButton.Location = new System.Drawing.Point(195, 26);
			this.greenButton.Name = "greenButton";
			this.greenButton.Size = new System.Drawing.Size(59, 17);
			this.greenButton.TabIndex = 7;
			this.greenButton.UseVisualStyleBackColor = false;
			this.greenButton.Click += new System.EventHandler(this.blackButton_Click);
			// 
			// khakiButton
			// 
			this.khakiButton.BackColor = System.Drawing.Color.Khaki;
			this.khakiButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.khakiButton.Location = new System.Drawing.Point(131, 26);
			this.khakiButton.Name = "khakiButton";
			this.khakiButton.Size = new System.Drawing.Size(58, 17);
			this.khakiButton.TabIndex = 6;
			this.khakiButton.UseVisualStyleBackColor = false;
			this.khakiButton.Click += new System.EventHandler(this.blackButton_Click);
			// 
			// yellowButton
			// 
			this.yellowButton.BackColor = System.Drawing.Color.Yellow;
			this.yellowButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.yellowButton.Location = new System.Drawing.Point(67, 26);
			this.yellowButton.Name = "yellowButton";
			this.yellowButton.Size = new System.Drawing.Size(58, 17);
			this.yellowButton.TabIndex = 5;
			this.yellowButton.UseVisualStyleBackColor = false;
			this.yellowButton.Click += new System.EventHandler(this.blackButton_Click);
			// 
			// orangeButton
			// 
			this.orangeButton.BackColor = System.Drawing.Color.Orange;
			this.orangeButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.orangeButton.Location = new System.Drawing.Point(3, 26);
			this.orangeButton.Name = "orangeButton";
			this.orangeButton.Size = new System.Drawing.Size(58, 17);
			this.orangeButton.TabIndex = 4;
			this.orangeButton.UseVisualStyleBackColor = false;
			this.orangeButton.Click += new System.EventHandler(this.blackButton_Click);
			// 
			// redButton
			// 
			this.redButton.BackColor = System.Drawing.Color.Red;
			this.redButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.redButton.Location = new System.Drawing.Point(195, 3);
			this.redButton.Name = "redButton";
			this.redButton.Size = new System.Drawing.Size(59, 17);
			this.redButton.TabIndex = 3;
			this.redButton.UseVisualStyleBackColor = false;
			this.redButton.Click += new System.EventHandler(this.blackButton_Click);
			// 
			// whiteButton
			// 
			this.whiteButton.BackColor = System.Drawing.Color.White;
			this.whiteButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.whiteButton.Location = new System.Drawing.Point(131, 3);
			this.whiteButton.Name = "whiteButton";
			this.whiteButton.Size = new System.Drawing.Size(58, 17);
			this.whiteButton.TabIndex = 2;
			this.whiteButton.UseVisualStyleBackColor = false;
			this.whiteButton.Click += new System.EventHandler(this.blackButton_Click);
			// 
			// grayButton
			// 
			this.grayButton.BackColor = System.Drawing.Color.Gray;
			this.grayButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grayButton.Location = new System.Drawing.Point(67, 3);
			this.grayButton.Name = "grayButton";
			this.grayButton.Size = new System.Drawing.Size(58, 17);
			this.grayButton.TabIndex = 1;
			this.grayButton.UseVisualStyleBackColor = false;
			this.grayButton.Click += new System.EventHandler(this.blackButton_Click);
			// 
			// blackButton
			// 
			this.blackButton.BackColor = System.Drawing.Color.Black;
			this.blackButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.blackButton.ForeColor = System.Drawing.Color.Black;
			this.blackButton.Location = new System.Drawing.Point(3, 3);
			this.blackButton.Name = "blackButton";
			this.blackButton.Size = new System.Drawing.Size(58, 17);
			this.blackButton.TabIndex = 0;
			this.blackButton.UseVisualStyleBackColor = false;
			this.blackButton.Click += new System.EventHandler(this.blackButton_Click);
			// 
			// tableLayoutPanel4
			// 
			this.tableLayoutPanel4.ColumnCount = 5;
			this.tableLayoutPanel4.ColumnStyles.Add(
				new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel4.ColumnStyles.Add(
				new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel4.ColumnStyles.Add(
				new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel4.ColumnStyles.Add(
				new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel4.ColumnStyles.Add(
				new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel4.Controls.Add(this.fillButton, 4, 0);
			this.tableLayoutPanel4.Controls.Add(this.textButton, 3, 0);
			this.tableLayoutPanel4.Controls.Add(this.pipetteButton, 2, 0);
			this.tableLayoutPanel4.Controls.Add(this.eraserButton, 1, 0);
			this.tableLayoutPanel4.Controls.Add(this.pencilButton, 0, 0);
			this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel4.Location = new System.Drawing.Point(4, 127);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 1;
			this.tableLayoutPanel4.RowStyles.Add(
				new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel4.Size = new System.Drawing.Size(257, 55);
			this.tableLayoutPanel4.TabIndex = 1;
			// 
			// fillButton
			// 
			this.fillButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.fillButton.Location = new System.Drawing.Point(207, 3);
			this.fillButton.Name = "fillButton";
			this.fillButton.Size = new System.Drawing.Size(47, 49);
			this.fillButton.TabIndex = 4;
			this.fillButton.Text = "Fill";
			this.fillButton.UseVisualStyleBackColor = true;
			this.fillButton.Click += new System.EventHandler(this.fillButton_Click);
			// 
			// textButton
			// 
			this.textButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textButton.Location = new System.Drawing.Point(156, 3);
			this.textButton.Name = "textButton";
			this.textButton.Size = new System.Drawing.Size(45, 49);
			this.textButton.TabIndex = 3;
			this.textButton.Text = "Text";
			this.textButton.UseVisualStyleBackColor = true;
			this.textButton.Click += new System.EventHandler(this.textButton_Click);
			// 
			// pipetteButton
			// 
			this.pipetteButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pipetteButton.Location = new System.Drawing.Point(105, 3);
			this.pipetteButton.Name = "pipetteButton";
			this.pipetteButton.Size = new System.Drawing.Size(45, 49);
			this.pipetteButton.TabIndex = 2;
			this.pipetteButton.Text = "Pipette";
			this.pipetteButton.UseVisualStyleBackColor = true;
			this.pipetteButton.Click += new System.EventHandler(this.pipetteButton_Click);
			// 
			// eraserButton
			// 
			this.eraserButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.eraserButton.Location = new System.Drawing.Point(54, 3);
			this.eraserButton.Name = "eraserButton";
			this.eraserButton.Size = new System.Drawing.Size(45, 49);
			this.eraserButton.TabIndex = 1;
			this.eraserButton.Text = "Eraser";
			this.eraserButton.UseVisualStyleBackColor = true;
			this.eraserButton.Click += new System.EventHandler(this.eraserButton_Click);
			// 
			// pencilButton
			// 
			this.pencilButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pencilButton.Location = new System.Drawing.Point(3, 3);
			this.pencilButton.Name = "pencilButton";
			this.pencilButton.Size = new System.Drawing.Size(45, 49);
			this.pencilButton.TabIndex = 0;
			this.pencilButton.Text = "Pencil";
			this.pencilButton.UseVisualStyleBackColor = true;
			this.pencilButton.Click += new System.EventHandler(this.pencilButton_Click);
			// 
			// tableLayoutPanel5
			// 
			this.tableLayoutPanel5.ColumnCount = 5;
			this.tableLayoutPanel5.ColumnStyles.Add(
				new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel5.ColumnStyles.Add(
				new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel5.ColumnStyles.Add(
				new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel5.ColumnStyles.Add(
				new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel5.ColumnStyles.Add(
				new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel5.Controls.Add(this.triangleButton, 4, 0);
			this.tableLayoutPanel5.Controls.Add(this.arrowButton, 3, 0);
			this.tableLayoutPanel5.Controls.Add(this.rectangleButton, 2, 0);
			this.tableLayoutPanel5.Controls.Add(this.ovalButton, 1, 0);
			this.tableLayoutPanel5.Controls.Add(this.lineButton, 0, 0);
			this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel5.Location = new System.Drawing.Point(4, 189);
			this.tableLayoutPanel5.Name = "tableLayoutPanel5";
			this.tableLayoutPanel5.RowCount = 1;
			this.tableLayoutPanel5.RowStyles.Add(
				new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel5.Size = new System.Drawing.Size(257, 55);
			this.tableLayoutPanel5.TabIndex = 2;
			// 
			// triangleButton
			// 
			this.triangleButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.triangleButton.Location = new System.Drawing.Point(207, 3);
			this.triangleButton.Name = "triangleButton";
			this.triangleButton.Size = new System.Drawing.Size(47, 49);
			this.triangleButton.TabIndex = 4;
			this.triangleButton.Text = "Triangle";
			this.triangleButton.UseVisualStyleBackColor = true;
			this.triangleButton.Click += new System.EventHandler(this.triangleButton_Click);
			// 
			// arrowButton
			// 
			this.arrowButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.arrowButton.Location = new System.Drawing.Point(156, 3);
			this.arrowButton.Name = "arrowButton";
			this.arrowButton.Size = new System.Drawing.Size(45, 49);
			this.arrowButton.TabIndex = 3;
			this.arrowButton.Text = "Arrow";
			this.arrowButton.UseVisualStyleBackColor = true;
			this.arrowButton.Click += new System.EventHandler(this.arrowButton_Click);
			// 
			// rectangleButton
			// 
			this.rectangleButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rectangleButton.Location = new System.Drawing.Point(105, 3);
			this.rectangleButton.Name = "rectangleButton";
			this.rectangleButton.Size = new System.Drawing.Size(45, 49);
			this.rectangleButton.TabIndex = 2;
			this.rectangleButton.Text = "Rectangle";
			this.rectangleButton.UseVisualStyleBackColor = true;
			this.rectangleButton.Click += new System.EventHandler(this.rectangleButton_Click);
			// 
			// ovalButton
			// 
			this.ovalButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ovalButton.Location = new System.Drawing.Point(54, 3);
			this.ovalButton.Name = "ovalButton";
			this.ovalButton.Size = new System.Drawing.Size(45, 49);
			this.ovalButton.TabIndex = 1;
			this.ovalButton.Text = "Oval";
			this.ovalButton.UseVisualStyleBackColor = true;
			this.ovalButton.Click += new System.EventHandler(this.ovalButton_Click);
			// 
			// lineButton
			// 
			this.lineButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lineButton.Location = new System.Drawing.Point(3, 3);
			this.lineButton.Name = "lineButton";
			this.lineButton.Size = new System.Drawing.Size(45, 49);
			this.lineButton.TabIndex = 0;
			this.lineButton.Text = "Line";
			this.lineButton.UseVisualStyleBackColor = true;
			this.lineButton.Click += new System.EventHandler(this.lineButton_Click);
			// 
			// tableLayoutPanel6
			// 
			this.tableLayoutPanel6.ColumnCount = 2;
			this.tableLayoutPanel6.ColumnStyles.Add(
				new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel6.ColumnStyles.Add(
				new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel6.Controls.Add(this.clearCanvasButton, 1, 0);
			this.tableLayoutPanel6.Controls.Add(this.openButton, 1, 1);
			this.tableLayoutPanel6.Controls.Add(this.penWidthButton, 0, 0);
			this.tableLayoutPanel6.Controls.Add(this.saveAsButton, 0, 1);
			this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel6.Location = new System.Drawing.Point(4, 251);
			this.tableLayoutPanel6.Name = "tableLayoutPanel6";
			this.tableLayoutPanel6.RowCount = 2;
			this.tableLayoutPanel6.RowStyles.Add(
				new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel6.RowStyles.Add(
				new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel6.Size = new System.Drawing.Size(257, 116);
			this.tableLayoutPanel6.TabIndex = 3;
			// 
			// clearCanvasButton
			// 
			this.clearCanvasButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.clearCanvasButton.Location = new System.Drawing.Point(131, 3);
			this.clearCanvasButton.Name = "clearCanvasButton";
			this.clearCanvasButton.Size = new System.Drawing.Size(123, 52);
			this.clearCanvasButton.TabIndex = 0;
			this.clearCanvasButton.Text = "Clear";
			this.clearCanvasButton.UseVisualStyleBackColor = true;
			this.clearCanvasButton.Click += new System.EventHandler(this.clearCanvasButton_Click);
			// 
			// openButton
			// 
			this.openButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.openButton.Location = new System.Drawing.Point(131, 61);
			this.openButton.Name = "openButton";
			this.openButton.Size = new System.Drawing.Size(123, 52);
			this.openButton.TabIndex = 3;
			this.openButton.Text = "Open";
			this.openButton.UseVisualStyleBackColor = true;
			this.openButton.Click += new System.EventHandler(this.openButton_Click);
			// 
			// penWidthButton
			// 
			this.penWidthButton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.penWidthButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.penWidthButton.Increment = new decimal(new int[]
			{
				3,
				0,
				0,
				0
			});
			this.penWidthButton.Location = new System.Drawing.Point(3, 3);
			this.penWidthButton.Maximum = new decimal(new int[]
			{
				19,
				0,
				0,
				0
			});
			this.penWidthButton.Minimum = new decimal(new int[]
			{
				1,
				0,
				0,
				0
			});
			this.penWidthButton.Name = "penWidthButton";
			this.penWidthButton.ReadOnly = true;
			this.penWidthButton.Size = new System.Drawing.Size(122, 27);
			this.penWidthButton.TabIndex = 0;
			this.penWidthButton.Value = new decimal(new int[]
			{
				1,
				0,
				0,
				0
			});
			this.penWidthButton.ValueChanged += new System.EventHandler(this.penWidthButton_ValueChanged);
			// 
			// saveAsButton
			// 
			this.saveAsButton.Dock = System.Windows.Forms.DockStyle.Fill;
			this.saveAsButton.Location = new System.Drawing.Point(3, 61);
			this.saveAsButton.Name = "saveAsButton";
			this.saveAsButton.Size = new System.Drawing.Size(122, 52);
			this.saveAsButton.TabIndex = 1;
			this.saveAsButton.Text = "Save As";
			this.saveAsButton.UseVisualStyleBackColor = true;
			this.saveAsButton.Click += new System.EventHandler(this.saveAsButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1082, 622);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel4.ResumeLayout(false);
			this.tableLayoutPanel5.ResumeLayout(false);
			this.tableLayoutPanel6.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) (this.penWidthButton)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private TableLayoutPanel tableLayoutPanel1;
		private Panel canvasPanel;
		private TableLayoutPanel tableLayoutPanel2;
		private TableLayoutPanel tableLayoutPanel3;
		private Button backColorButton;
		private Button foreColorButton;
		private Button colorDialogButton;
		private Button pinkButton;
		private Button fuchsiaButton;
		private Button plumButton;
		private Button indigoButton;
		private Button blueButton;
		private Button deepSkyBlutButton;
		private Button aquaButton;
		private Button greenButton;
		private Button khakiButton;
		private Button yellowButton;
		private Button orangeButton;
		private Button redButton;
		private Button whiteButton;
		private Button grayButton;
		private Button blackButton;
		private TableLayoutPanel tableLayoutPanel4;
		private Button pencilButton;
		private Button fillButton;
		private Button textButton;
		private Button pipetteButton;
		private Button eraserButton;
		private TableLayoutPanel tableLayoutPanel5;
		private Button triangleButton;
		private Button arrowButton;
		private Button rectangleButton;
		private Button ovalButton;
		private Button lineButton;
		private TableLayoutPanel tableLayoutPanel6;
		private NumericUpDown penWidthButton;
		private Button openButton;
		private Button saveAsButton;
		private Button clearCanvasButton;
	}
}