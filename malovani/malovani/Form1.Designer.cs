namespace malovani
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonWhite = new System.Windows.Forms.Button();
            this.buttonOrange = new System.Windows.Forms.Button();
            this.buttonColorDialog = new System.Windows.Forms.Button();
            this.buttonRed = new System.Windows.Forms.Button();
            this.buttonPurple = new System.Windows.Forms.Button();
            this.buttonGreen = new System.Windows.Forms.Button();
            this.buttonBlue = new System.Windows.Forms.Button();
            this.buttonBlack = new System.Windows.Forms.Button();
            this.buttonYellow = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuW3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuW5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuW10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuW15 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuW20 = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxEllipseX = new System.Windows.Forms.TextBox();
            this.textBoxEllipseY = new System.Windows.Forms.TextBox();
            this.textBoxEllipseW = new System.Windows.Forms.TextBox();
            this.textBoxEllipseH = new System.Windows.Forms.TextBox();
            this.textBoxRectangleX = new System.Windows.Forms.TextBox();
            this.textBoxRectangleY = new System.Windows.Forms.TextBox();
            this.textBoxRectangleW = new System.Windows.Forms.TextBox();
            this.textBoxRectangleH = new System.Windows.Forms.TextBox();
            this.buttonDrawEllipse = new System.Windows.Forms.Button();
            this.buttonDrawRectangle = new System.Windows.Forms.Button();
            this.buttonFillEllipse = new System.Windows.Forms.Button();
            this.buttonFillRectangle = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.buttonSurpriseStart = new System.Windows.Forms.Button();
            this.buttonSurpriseStop = new System.Windows.Forms.Button();
            this.buttonAddImage = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBoxLineX1 = new System.Windows.Forms.TextBox();
            this.textBoxLineY1 = new System.Windows.Forms.TextBox();
            this.textBoxLineX2 = new System.Windows.Forms.TextBox();
            this.textBoxLineY2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.buttonDrawLine = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(12, 174);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1127, 627);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Red;
            this.buttonDelete.Location = new System.Drawing.Point(12, 12);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(90, 58);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "Delete drawing";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonWhite
            // 
            this.buttonWhite.BackColor = System.Drawing.Color.White;
            this.buttonWhite.Location = new System.Drawing.Point(1024, 10);
            this.buttonWhite.Name = "buttonWhite";
            this.buttonWhite.Size = new System.Drawing.Size(55, 23);
            this.buttonWhite.TabIndex = 2;
            this.buttonWhite.UseVisualStyleBackColor = false;
            this.buttonWhite.Click += new System.EventHandler(this.buttonWhite_Click);
            // 
            // buttonOrange
            // 
            this.buttonOrange.BackColor = System.Drawing.Color.Orange;
            this.buttonOrange.Location = new System.Drawing.Point(1024, 64);
            this.buttonOrange.Name = "buttonOrange";
            this.buttonOrange.Size = new System.Drawing.Size(55, 23);
            this.buttonOrange.TabIndex = 3;
            this.buttonOrange.UseVisualStyleBackColor = false;
            this.buttonOrange.Click += new System.EventHandler(this.buttonOrange_Click);
            // 
            // buttonColorDialog
            // 
            this.buttonColorDialog.Location = new System.Drawing.Point(1024, 120);
            this.buttonColorDialog.Name = "buttonColorDialog";
            this.buttonColorDialog.Size = new System.Drawing.Size(112, 23);
            this.buttonColorDialog.TabIndex = 4;
            this.buttonColorDialog.Text = "Your color";
            this.buttonColorDialog.UseVisualStyleBackColor = true;
            this.buttonColorDialog.Click += new System.EventHandler(this.buttonColorDialog_Click);
            // 
            // buttonRed
            // 
            this.buttonRed.BackColor = System.Drawing.Color.Red;
            this.buttonRed.Location = new System.Drawing.Point(1024, 92);
            this.buttonRed.Name = "buttonRed";
            this.buttonRed.Size = new System.Drawing.Size(55, 23);
            this.buttonRed.TabIndex = 5;
            this.buttonRed.UseVisualStyleBackColor = false;
            this.buttonRed.Click += new System.EventHandler(this.buttonRed_Click);
            // 
            // buttonPurple
            // 
            this.buttonPurple.BackColor = System.Drawing.Color.DarkViolet;
            this.buttonPurple.Location = new System.Drawing.Point(1085, 65);
            this.buttonPurple.Name = "buttonPurple";
            this.buttonPurple.Size = new System.Drawing.Size(56, 23);
            this.buttonPurple.TabIndex = 6;
            this.buttonPurple.UseVisualStyleBackColor = false;
            this.buttonPurple.Click += new System.EventHandler(this.buttonPurple_Click);
            // 
            // buttonGreen
            // 
            this.buttonGreen.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonGreen.Location = new System.Drawing.Point(1085, 35);
            this.buttonGreen.Name = "buttonGreen";
            this.buttonGreen.Size = new System.Drawing.Size(54, 23);
            this.buttonGreen.TabIndex = 7;
            this.buttonGreen.UseVisualStyleBackColor = false;
            this.buttonGreen.Click += new System.EventHandler(this.buttonGreen_Click);
            // 
            // buttonBlue
            // 
            this.buttonBlue.BackColor = System.Drawing.Color.Blue;
            this.buttonBlue.Location = new System.Drawing.Point(1084, 10);
            this.buttonBlue.Name = "buttonBlue";
            this.buttonBlue.Size = new System.Drawing.Size(55, 23);
            this.buttonBlue.TabIndex = 8;
            this.buttonBlue.UseVisualStyleBackColor = false;
            this.buttonBlue.Click += new System.EventHandler(this.buttonBlue_Click);
            // 
            // buttonBlack
            // 
            this.buttonBlack.BackColor = System.Drawing.Color.Black;
            this.buttonBlack.Location = new System.Drawing.Point(1085, 93);
            this.buttonBlack.Name = "buttonBlack";
            this.buttonBlack.Size = new System.Drawing.Size(54, 22);
            this.buttonBlack.TabIndex = 9;
            this.buttonBlack.UseVisualStyleBackColor = false;
            this.buttonBlack.Click += new System.EventHandler(this.buttonBlack_Click);
            // 
            // buttonYellow
            // 
            this.buttonYellow.BackColor = System.Drawing.Color.Yellow;
            this.buttonYellow.Location = new System.Drawing.Point(1024, 35);
            this.buttonYellow.Name = "buttonYellow";
            this.buttonYellow.Size = new System.Drawing.Size(55, 23);
            this.buttonYellow.TabIndex = 10;
            this.buttonYellow.UseVisualStyleBackColor = false;
            this.buttonYellow.Click += new System.EventHandler(this.buttonYellow_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(805, 35);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(85, 25);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuW3,
            this.toolStripMenuW5,
            this.toolStripMenuW10,
            this.toolStripMenuW15,
            this.toolStripMenuW20});
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(73, 22);
            this.toolStripDropDownButton1.Text = "pen width";
            // 
            // toolStripMenuW3
            // 
            this.toolStripMenuW3.Name = "toolStripMenuW3";
            this.toolStripMenuW3.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuW3.Text = "3";
            this.toolStripMenuW3.Click += new System.EventHandler(this.toolStripMenuW3_Click);
            // 
            // toolStripMenuW5
            // 
            this.toolStripMenuW5.Name = "toolStripMenuW5";
            this.toolStripMenuW5.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuW5.Text = "5";
            this.toolStripMenuW5.Click += new System.EventHandler(this.toolStripMenuW5_Click);
            // 
            // toolStripMenuW10
            // 
            this.toolStripMenuW10.Name = "toolStripMenuW10";
            this.toolStripMenuW10.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuW10.Text = "10";
            this.toolStripMenuW10.Click += new System.EventHandler(this.toolStripMenuW10_Click);
            // 
            // toolStripMenuW15
            // 
            this.toolStripMenuW15.Name = "toolStripMenuW15";
            this.toolStripMenuW15.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuW15.Text = "15";
            this.toolStripMenuW15.Click += new System.EventHandler(this.toolStripMenuW15_Click);
            // 
            // toolStripMenuW20
            // 
            this.toolStripMenuW20.Name = "toolStripMenuW20";
            this.toolStripMenuW20.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuW20.Text = "20";
            this.toolStripMenuW20.Click += new System.EventHandler(this.toolStripMenuW20_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Draw ellipse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(548, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Draw Rectangle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "input coordinate x";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "input coordinate y";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(473, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "input coordinate x";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(473, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "input coordinate y";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(166, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "input width";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(166, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "input height";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(473, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "input width";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(473, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "input height";
            // 
            // textBoxEllipseX
            // 
            this.textBoxEllipseX.Location = new System.Drawing.Point(263, 40);
            this.textBoxEllipseX.Name = "textBoxEllipseX";
            this.textBoxEllipseX.Size = new System.Drawing.Size(100, 20);
            this.textBoxEllipseX.TabIndex = 15;
            // 
            // textBoxEllipseY
            // 
            this.textBoxEllipseY.Location = new System.Drawing.Point(263, 73);
            this.textBoxEllipseY.Name = "textBoxEllipseY";
            this.textBoxEllipseY.Size = new System.Drawing.Size(100, 20);
            this.textBoxEllipseY.TabIndex = 15;
            // 
            // textBoxEllipseW
            // 
            this.textBoxEllipseW.Location = new System.Drawing.Point(263, 102);
            this.textBoxEllipseW.Name = "textBoxEllipseW";
            this.textBoxEllipseW.Size = new System.Drawing.Size(100, 20);
            this.textBoxEllipseW.TabIndex = 15;
            // 
            // textBoxEllipseH
            // 
            this.textBoxEllipseH.Location = new System.Drawing.Point(263, 130);
            this.textBoxEllipseH.Name = "textBoxEllipseH";
            this.textBoxEllipseH.Size = new System.Drawing.Size(100, 20);
            this.textBoxEllipseH.TabIndex = 15;
            // 
            // textBoxRectangleX
            // 
            this.textBoxRectangleX.Location = new System.Drawing.Point(570, 40);
            this.textBoxRectangleX.Name = "textBoxRectangleX";
            this.textBoxRectangleX.Size = new System.Drawing.Size(100, 20);
            this.textBoxRectangleX.TabIndex = 15;
            // 
            // textBoxRectangleY
            // 
            this.textBoxRectangleY.Location = new System.Drawing.Point(570, 73);
            this.textBoxRectangleY.Name = "textBoxRectangleY";
            this.textBoxRectangleY.Size = new System.Drawing.Size(100, 20);
            this.textBoxRectangleY.TabIndex = 15;
            // 
            // textBoxRectangleW
            // 
            this.textBoxRectangleW.Location = new System.Drawing.Point(570, 102);
            this.textBoxRectangleW.Name = "textBoxRectangleW";
            this.textBoxRectangleW.Size = new System.Drawing.Size(100, 20);
            this.textBoxRectangleW.TabIndex = 15;
            // 
            // textBoxRectangleH
            // 
            this.textBoxRectangleH.Location = new System.Drawing.Point(570, 130);
            this.textBoxRectangleH.Name = "textBoxRectangleH";
            this.textBoxRectangleH.Size = new System.Drawing.Size(100, 20);
            this.textBoxRectangleH.TabIndex = 15;
            // 
            // buttonDrawEllipse
            // 
            this.buttonDrawEllipse.Location = new System.Drawing.Point(369, 38);
            this.buttonDrawEllipse.Name = "buttonDrawEllipse";
            this.buttonDrawEllipse.Size = new System.Drawing.Size(75, 55);
            this.buttonDrawEllipse.TabIndex = 16;
            this.buttonDrawEllipse.Text = "Draw Ellipse (outline)";
            this.buttonDrawEllipse.UseVisualStyleBackColor = true;
            this.buttonDrawEllipse.Click += new System.EventHandler(this.buttonDrawEllipse_Click);
            // 
            // buttonDrawRectangle
            // 
            this.buttonDrawRectangle.Location = new System.Drawing.Point(688, 38);
            this.buttonDrawRectangle.Name = "buttonDrawRectangle";
            this.buttonDrawRectangle.Size = new System.Drawing.Size(94, 55);
            this.buttonDrawRectangle.TabIndex = 17;
            this.buttonDrawRectangle.Text = "Draw Rectangle (outline)";
            this.buttonDrawRectangle.UseVisualStyleBackColor = true;
            this.buttonDrawRectangle.Click += new System.EventHandler(this.buttonDrawRectangle_Click);
            // 
            // buttonFillEllipse
            // 
            this.buttonFillEllipse.Location = new System.Drawing.Point(369, 102);
            this.buttonFillEllipse.Name = "buttonFillEllipse";
            this.buttonFillEllipse.Size = new System.Drawing.Size(75, 48);
            this.buttonFillEllipse.TabIndex = 18;
            this.buttonFillEllipse.Text = "Draw filled Ellipse";
            this.buttonFillEllipse.UseVisualStyleBackColor = true;
            this.buttonFillEllipse.Click += new System.EventHandler(this.buttonFillEllipse_Click);
            // 
            // buttonFillRectangle
            // 
            this.buttonFillRectangle.Location = new System.Drawing.Point(688, 101);
            this.buttonFillRectangle.Name = "buttonFillRectangle";
            this.buttonFillRectangle.Size = new System.Drawing.Size(94, 49);
            this.buttonFillRectangle.TabIndex = 19;
            this.buttonFillRectangle.Text = "Draw filled Rectangle";
            this.buttonFillRectangle.UseVisualStyleBackColor = true;
            this.buttonFillRectangle.Click += new System.EventHandler(this.buttonFillRectangle_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(57, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Surprise";
            // 
            // buttonSurpriseStart
            // 
            this.buttonSurpriseStart.BackColor = System.Drawing.Color.LightGreen;
            this.buttonSurpriseStart.Location = new System.Drawing.Point(15, 96);
            this.buttonSurpriseStart.Name = "buttonSurpriseStart";
            this.buttonSurpriseStart.Size = new System.Drawing.Size(61, 48);
            this.buttonSurpriseStart.TabIndex = 21;
            this.buttonSurpriseStart.Text = "Start";
            this.buttonSurpriseStart.UseVisualStyleBackColor = false;
            this.buttonSurpriseStart.Click += new System.EventHandler(this.buttonSurpriseStart_Click);
            // 
            // buttonSurpriseStop
            // 
            this.buttonSurpriseStop.BackColor = System.Drawing.Color.LightCoral;
            this.buttonSurpriseStop.Location = new System.Drawing.Point(82, 96);
            this.buttonSurpriseStop.Name = "buttonSurpriseStop";
            this.buttonSurpriseStop.Size = new System.Drawing.Size(61, 47);
            this.buttonSurpriseStop.TabIndex = 22;
            this.buttonSurpriseStop.Text = "Stop";
            this.buttonSurpriseStop.UseVisualStyleBackColor = false;
            this.buttonSurpriseStop.Click += new System.EventHandler(this.buttonSurpriseStop_Click);
            // 
            // buttonAddImage
            // 
            this.buttonAddImage.Location = new System.Drawing.Point(805, 102);
            this.buttonAddImage.Name = "buttonAddImage";
            this.buttonAddImage.Size = new System.Drawing.Size(70, 47);
            this.buttonAddImage.TabIndex = 23;
            this.buttonAddImage.Text = "Image";
            this.buttonAddImage.UseVisualStyleBackColor = true;
            this.buttonAddImage.Click += new System.EventHandler(this.buttonAddImage_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(802, 85);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Add background";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBoxLineX1
            // 
            this.textBoxLineX1.Location = new System.Drawing.Point(932, 31);
            this.textBoxLineX1.Name = "textBoxLineX1";
            this.textBoxLineX1.Size = new System.Drawing.Size(66, 20);
            this.textBoxLineX1.TabIndex = 0;
            // 
            // textBoxLineY1
            // 
            this.textBoxLineY1.Location = new System.Drawing.Point(932, 56);
            this.textBoxLineY1.Name = "textBoxLineY1";
            this.textBoxLineY1.Size = new System.Drawing.Size(66, 20);
            this.textBoxLineY1.TabIndex = 0;
            // 
            // textBoxLineX2
            // 
            this.textBoxLineX2.Location = new System.Drawing.Point(932, 82);
            this.textBoxLineX2.Name = "textBoxLineX2";
            this.textBoxLineX2.Size = new System.Drawing.Size(66, 20);
            this.textBoxLineX2.TabIndex = 0;
            // 
            // textBoxLineY2
            // 
            this.textBoxLineY2.Location = new System.Drawing.Point(932, 108);
            this.textBoxLineY2.Name = "textBoxLineY2";
            this.textBoxLineY2.Size = new System.Drawing.Size(66, 20);
            this.textBoxLineY2.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(908, 35);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(18, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "x1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(908, 62);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(18, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "y1";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(908, 86);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(18, 13);
            this.label15.TabIndex = 25;
            this.label15.Text = "x2";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(908, 111);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(18, 13);
            this.label16.TabIndex = 25;
            this.label16.Text = "y2";
            // 
            // buttonDrawLine
            // 
            this.buttonDrawLine.Location = new System.Drawing.Point(911, 134);
            this.buttonDrawLine.Name = "buttonDrawLine";
            this.buttonDrawLine.Size = new System.Drawing.Size(87, 23);
            this.buttonDrawLine.TabIndex = 0;
            this.buttonDrawLine.Text = "Draw line";
            this.buttonDrawLine.UseVisualStyleBackColor = true;
            this.buttonDrawLine.Click += new System.EventHandler(this.buttonDrawLine_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(945, 11);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(27, 13);
            this.label17.TabIndex = 26;
            this.label17.Text = "Line";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 813);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.buttonDrawLine);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBoxLineY2);
            this.Controls.Add(this.textBoxLineX2);
            this.Controls.Add(this.textBoxLineY1);
            this.Controls.Add(this.textBoxLineX1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.buttonSurpriseStop);
            this.Controls.Add(this.buttonAddImage);
            this.Controls.Add(this.buttonSurpriseStart);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.buttonFillRectangle);
            this.Controls.Add(this.buttonFillEllipse);
            this.Controls.Add(this.buttonDrawRectangle);
            this.Controls.Add(this.buttonDrawEllipse);
            this.Controls.Add(this.textBoxRectangleH);
            this.Controls.Add(this.textBoxEllipseH);
            this.Controls.Add(this.textBoxRectangleW);
            this.Controls.Add(this.textBoxEllipseW);
            this.Controls.Add(this.textBoxRectangleY);
            this.Controls.Add(this.textBoxEllipseY);
            this.Controls.Add(this.textBoxRectangleX);
            this.Controls.Add(this.textBoxEllipseX);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.buttonYellow);
            this.Controls.Add(this.buttonBlack);
            this.Controls.Add(this.buttonBlue);
            this.Controls.Add(this.buttonGreen);
            this.Controls.Add(this.buttonPurple);
            this.Controls.Add(this.buttonRed);
            this.Controls.Add(this.buttonColorDialog);
            this.Controls.Add(this.buttonOrange);
            this.Controls.Add(this.buttonWhite);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonWhite;
        private System.Windows.Forms.Button buttonOrange;
        private System.Windows.Forms.Button buttonColorDialog;
        private System.Windows.Forms.Button buttonRed;
        private System.Windows.Forms.Button buttonPurple;
        private System.Windows.Forms.Button buttonGreen;
        private System.Windows.Forms.Button buttonBlue;
        private System.Windows.Forms.Button buttonBlack;
        private System.Windows.Forms.Button buttonYellow;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuW3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuW5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuW10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuW15;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuW20;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxEllipseX;
        private System.Windows.Forms.TextBox textBoxEllipseY;
        private System.Windows.Forms.TextBox textBoxEllipseW;
        private System.Windows.Forms.TextBox textBoxEllipseH;
        private System.Windows.Forms.TextBox textBoxRectangleX;
        private System.Windows.Forms.TextBox textBoxRectangleY;
        private System.Windows.Forms.TextBox textBoxRectangleW;
        private System.Windows.Forms.TextBox textBoxRectangleH;
        private System.Windows.Forms.Button buttonDrawEllipse;
        private System.Windows.Forms.Button buttonDrawRectangle;
        private System.Windows.Forms.Button buttonFillEllipse;
        private System.Windows.Forms.Button buttonFillRectangle;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonSurpriseStart;
        private System.Windows.Forms.Button buttonSurpriseStop;
        private System.Windows.Forms.Button buttonAddImage;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBoxLineX1;
        private System.Windows.Forms.TextBox textBoxLineY1;
        private System.Windows.Forms.TextBox textBoxLineX2;
        private System.Windows.Forms.TextBox textBoxLineY2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button buttonDrawLine;
        private System.Windows.Forms.Label label17;
    }
}

