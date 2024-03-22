using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace malovani
{
    public partial class Form1 : Form
    {
        
        bool isMouseDown = false;
        Graphics g;
        int x = -1;
        int y = -1;
        
        Pen pen = new Pen(Color.Black, 3);
        Brush brush = new SolidBrush(Color.Black);
        public Form1()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();
            
            
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            panel1.Refresh();
        }

        

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            isMouseDown = true;
            x = e.X;
            y = e.Y;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
            x = -1;
            y = -1;
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            
            if (isMouseDown && x != -1 && y != -1)
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.DrawLine(pen, new Point(x,y),e.Location);
                x = e.X;
                y = e.Y;
               

            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonWhite_Click(object sender, EventArgs e)
        {
            pen.Color = Color.White;
            brush = new SolidBrush(Color.White);
            
        }
        private void buttonYellow_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Yellow;
            brush = new SolidBrush(Color.Yellow);
        }

        private void buttonOrange_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Orange;
            brush = new SolidBrush(Color.Orange);
        }

        private void buttonRed_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Red;
            brush = new SolidBrush(Color.Red);
        }

        private void buttonBlue_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Blue;
            brush = new SolidBrush(Color.Blue);
        }

        private void buttonGreen_Click(object sender, EventArgs e)
        {
            pen.Color = Color.ForestGreen;
            brush = new SolidBrush(Color.ForestGreen);
        }

        private void buttonPurple_Click(object sender, EventArgs e)
        {
            pen.Color = Color.DarkViolet;
            brush = new SolidBrush(Color.DarkViolet);
        }

        private void buttonBlack_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Black;
            brush = new SolidBrush(Color.Black);
        }

        private void toolStripMenuW3_Click(object sender, EventArgs e)
        {
            pen.Width = 3;
        }

        private void toolStripMenuW5_Click(object sender, EventArgs e)
        {
            pen.Width = 5;
        }

        private void toolStripMenuW10_Click(object sender, EventArgs e)
        {
            pen.Width = 10;
        }

        private void toolStripMenuW15_Click(object sender, EventArgs e)
        {
            pen.Width = 15;
        }

        private void toolStripMenuW20_Click(object sender, EventArgs e)
        {
            pen.Width = 20;
        }

        private void buttonColorDialog_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pen.Color = colorDialog1.Color;
                brush = new SolidBrush(colorDialog1.Color);
            }
        }

        private void buttonDrawEllipse_Click(object sender, EventArgs e)
        {
            int eX = Convert.ToInt32(textBoxEllipseX.Text);
            int eY = Convert.ToInt32(textBoxEllipseY.Text);
            int eW = Convert.ToInt32(textBoxEllipseW.Text);
            int eH = Convert.ToInt32(textBoxEllipseH.Text);

            g.DrawEllipse(pen, eX, eY, eW, eH);
        }

        private void buttonDrawRectangle_Click(object sender, EventArgs e)
        {
            int eX = Convert.ToInt32(textBoxRectangleX.Text);
            int eY = Convert.ToInt32(textBoxRectangleY.Text);
            int eW = Convert.ToInt32(textBoxRectangleW.Text);
            int eH = Convert.ToInt32(textBoxRectangleH.Text);

            g.DrawRectangle(pen, eX, eY, eW, eH);
        }

        private void buttonFillEllipse_Click(object sender, EventArgs e)
        {
            int eX = Convert.ToInt32(textBoxEllipseX.Text);
            int eY = Convert.ToInt32(textBoxEllipseY.Text);
            int eW = Convert.ToInt32(textBoxEllipseW.Text);
            int eH = Convert.ToInt32(textBoxEllipseH.Text);

            g.FillEllipse(brush, eX, eY, eW, eH);
        }

        private void buttonFillRectangle_Click(object sender, EventArgs e)
        {
            int eX = Convert.ToInt32(textBoxRectangleX.Text);
            int eY = Convert.ToInt32(textBoxRectangleY.Text);
            int eW = Convert.ToInt32(textBoxRectangleW.Text);
            int eH = Convert.ToInt32(textBoxRectangleH.Text);

            g.FillRectangle(brush, eX, eY, eW, eH);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int shape = rnd.Next(0, 4);

            int width = rnd.Next(0, 121);
            int height = rnd.Next(0, 121);

            int x = rnd.Next(0, panel1.Width);
            int y = rnd.Next(0, panel1.Height);

            int x2 = rnd.Next(0, panel1.Width);
            int y2 = rnd.Next(0, panel1.Height);

            string napis = "hello there";

            int filled = rnd.Next(0, 2);

            Color color = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
            Pen pen = new Pen(color, rnd.Next(0,40));
            switch (shape)
            {
                case 1:
                    if (filled == 0)
                    {
                        g.DrawEllipse(pen, x, y, width, height);
                    }
                    else
                    {
                        Brush brushE = new SolidBrush(color);
                        g.FillEllipse(brushE, x, y, width, height);
                    }

                    break;
                case 2:
                    if (filled == 0)
                    {
                        g.DrawRectangle(pen, x, y, width, height);
                    }
                    else
                    {
                        Brush brushR = new SolidBrush(color);
                        g.FillRectangle(brushR, x, y, width, height);
                    }
                    break;
                case 3:
                    g.DrawLine(pen, x, y, x2, y2);
                    break;
                case 4:
                    Font font = new Font("Arial", 20);
                    Brush brush = new SolidBrush(color);
                    g.DrawString(napis, font, brush, x, y);
                    break;
                default:
                    break;
            }
         }

        private void buttonSurpriseStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void buttonSurpriseStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
    }
}
