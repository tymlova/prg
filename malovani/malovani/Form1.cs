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
        Point lastPoint = Point.Empty;
        bool isMouseDown = new Boolean();
        Graphics g;
        //int a = 2;

        Pen pen = new Pen(Color.Black, 2);
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
            lastPoint = e.Location;
            isMouseDown = true;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
            lastPoint = Point.Empty;
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                g.DrawLine(pen, lastPoint, e.Location);
                g.SmoothingMode = SmoothingMode.AntiAlias;
            }
            
        }
    }
}
