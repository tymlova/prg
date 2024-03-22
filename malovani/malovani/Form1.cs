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

        private void buttonDelete_Click(object sender, EventArgs e)//smazani kreseb
        {
            panel1.Refresh();
        }

        //KRESLENI MYSI NA PANEL
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

        private void Form1_Load(object sender, EventArgs e) //omylem, bojim se smazat aby se neco nepokazilo
        {
        }

        private void buttonWhite_Click(object sender, EventArgs e) //nastaveni barvy pera na bilou
        {
            pen.Color = Color.White;
            brush = new SolidBrush(Color.White);  
        }
        private void buttonYellow_Click(object sender, EventArgs e)//nastaveni barvy pera na zlutou
        {
            pen.Color = Color.Yellow;
            brush = new SolidBrush(Color.Yellow);
        }

        private void buttonOrange_Click(object sender, EventArgs e)//nastaveni barvy pera na oranzovou
        {
            pen.Color = Color.Orange;
            brush = new SolidBrush(Color.Orange);
        }

        private void buttonRed_Click(object sender, EventArgs e)//nastaveni barvy pera na cervenou
        {
            pen.Color = Color.Red;
            brush = new SolidBrush(Color.Red);
        }

        private void buttonBlue_Click(object sender, EventArgs e)//nastaveni barvy pera na modrou
        {
            pen.Color = Color.Blue;
            brush = new SolidBrush(Color.Blue);
        }

        private void buttonGreen_Click(object sender, EventArgs e)//nastaveni barvy pera na zelenou
        {
            pen.Color = Color.ForestGreen;
            brush = new SolidBrush(Color.ForestGreen);
        }

        private void buttonPurple_Click(object sender, EventArgs e)//nastaveni barvy pera na fialovou
        {
            pen.Color = Color.DarkViolet;
            brush = new SolidBrush(Color.DarkViolet);
        }

        private void buttonBlack_Click(object sender, EventArgs e)//nastaveni barvy pera na cernou
        {
            pen.Color = Color.Black;
            brush = new SolidBrush(Color.Black);
        }

        private void toolStripMenuW3_Click(object sender, EventArgs e)//nastaveni tloustky pera na 3
        {
            pen.Width = 3;
        }

        private void toolStripMenuW5_Click(object sender, EventArgs e)//nastaveni tloustky pera na 5
        {
            pen.Width = 5;
        }

        private void toolStripMenuW10_Click(object sender, EventArgs e)//nastaveni tloustky pera na 10 
        {
            pen.Width = 10;
        }

        private void toolStripMenuW15_Click(object sender, EventArgs e)//nastaveni tloustky pera na 15
        {
            pen.Width = 15;
        }

        private void toolStripMenuW20_Click(object sender, EventArgs e)//nastaveni tloustky pera na 20
        {
            pen.Width = 20;
        }

        private void buttonColorDialog_Click(object sender, EventArgs e)//nastaveni barvy pera na libovolnou barvu
        {
            colorDialog1.ShowDialog();
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pen.Color = colorDialog1.Color;
                brush = new SolidBrush(colorDialog1.Color);
            }
        }

        private void buttonDrawEllipse_Click(object sender, EventArgs e)//vykresluje obrys elipsy
        {
            int eX = Convert.ToInt32(textBoxEllipseX.Text); //e = elipsa, X = souradnice x, Y = souradnice y, W = sirka, H = vyska
            int eY = Convert.ToInt32(textBoxEllipseY.Text);
            int eW = Convert.ToInt32(textBoxEllipseW.Text);
            int eH = Convert.ToInt32(textBoxEllipseH.Text);
            g.DrawEllipse(pen, eX, eY, eW, eH);
        }

        private void buttonDrawRectangle_Click(object sender, EventArgs e)//vykresluje obrys obdelniku
        {
            int rX = Convert.ToInt32(textBoxRectangleX.Text);//r = rectangle, X = souradnice x, Y = souradnice y, W = sirka, H = vyska
            int rY = Convert.ToInt32(textBoxRectangleY.Text);
            int rW = Convert.ToInt32(textBoxRectangleW.Text);
            int rH = Convert.ToInt32(textBoxRectangleH.Text);
            g.DrawRectangle(pen, rX, rY, rW, rH);
        }

        private void buttonFillEllipse_Click(object sender, EventArgs e)//vykresluje elipsu s vyplni
        {
            int eX = Convert.ToInt32(textBoxEllipseX.Text); //e = elipsa, X = souradnice x, Y = souradnice y, W = sirka, H = vyska
            int eY = Convert.ToInt32(textBoxEllipseY.Text);
            int eW = Convert.ToInt32(textBoxEllipseW.Text);
            int eH = Convert.ToInt32(textBoxEllipseH.Text);
            g.FillEllipse(brush, eX, eY, eW, eH);
        }

        private void buttonFillRectangle_Click(object sender, EventArgs e)//vykresluje obdelnik s vyplni
        {
            int rX = Convert.ToInt32(textBoxRectangleX.Text);//r = rectangle, X = souradnice x, Y = souradnice y, W = sirka, H = vyska
            int rY = Convert.ToInt32(textBoxRectangleY.Text);
            int rW = Convert.ToInt32(textBoxRectangleW.Text);
            int rH = Convert.ToInt32(textBoxRectangleH.Text);
            g.FillRectangle(brush, rX, rY, rW, rH);
        }

        private void timer1_Tick(object sender, EventArgs e) //timer ve kterem se generuji nahodne obrazce (elipsa, obdelnik, cara a napis)
        {
            Random rnd = new Random();
            int shape = rnd.Next(0, 5); // generuje cislo, ktere odpovida tvaru ve switchi

            int width = rnd.Next(0, 400); //sirka obrazce
            int height = rnd.Next(0, 400); //vyska obrazce

            int x = rnd.Next(0, panel1.Width); //souradnice x pro objekty
            int y = rnd.Next(0, panel1.Height);//souradnice y pro objekty

            int x2 = rnd.Next(0, panel1.Width); //souradnice konecneho bodu cary
            int y2 = rnd.Next(0, panel1.Height);//souradnice konecneho bodu cary

            string napis = "hello there";
            int filled = rnd.Next(0, 2); //rozhoduje zda obrazec bude mit vypln

            Color color = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256)); //generovani nahodne barvy obrazce
            Pen pen = new Pen(color, rnd.Next(0,40));

            switch (shape)
            {
                case 1: //vykresleni elipsy
                    if (filled == 0) //obrys
                    {
                        g.DrawEllipse(pen, x, y, width, height);
                    }
                    else //s vyplni
                    {
                        Brush brushE = new SolidBrush(color);
                        g.FillEllipse(brushE, x, y, width, height);
                    }
                    break;
                case 2: //vykresleni obdelniku
                    if (filled == 0)//obrys
                    {
                        g.DrawRectangle(pen, x, y, width, height);
                    }
                    else //s vyplni
                    {
                        Brush brushR = new SolidBrush(color);
                        g.FillRectangle(brushR, x, y, width, height);
                    }
                    break;
                case 3: //vykresleni cary
                    g.DrawLine(pen, x, y, x2, y2);
                    break;
                case 4: //vykresleni napisu
                    Font font = new Font("Arial", 20);
                    Brush brush = new SolidBrush(color);
                    g.DrawString(napis, font, brush, x, y);
                    break;
                default:
                    break;
            }
         }

        private void buttonSurpriseStart_Click(object sender, EventArgs e)//tlacitko zapinajici timer u vykreslovani nahodnych obrazcu
        {
            timer1.Enabled = true;
        }

        private void buttonSurpriseStop_Click(object sender, EventArgs e) //tlacitko zastavujici timer u vykreslovani nahodnych obrazcu
        {
            timer1.Enabled = false;
        }

        private void buttonAddImage_Click(object sender, EventArgs e) //pridani obrazku do pozadi, nejak jsem neprisla na to jestli se da do panelu vlozit jen obrazek, slo mi bohuzel jen pozadi
        {
            openFileDialog1.ShowDialog(); //vyhledavani fotky pomoci dialogu
            string filePath = openFileDialog1.FileName; //cesta k obrazku
            panel1.BackgroundImage = Image.FromFile(filePath);
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void buttonDrawLine_Click(object sender, EventArgs e) //kresleni usecky
        {
            int x1 = Convert.ToInt32(textBoxLineX1.Text);
            int y1 = Convert.ToInt32(textBoxLineY1.Text);
            int x2 = Convert.ToInt32(textBoxLineX2.Text);
            int y2 = Convert.ToInt32(textBoxLineY2.Text);
            g.DrawLine(pen, x1,y1, x2, y2);
        }
    }
}
