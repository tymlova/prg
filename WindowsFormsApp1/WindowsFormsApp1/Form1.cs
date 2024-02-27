using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_SizeChanged(object sender, EventArgs e)
        {
            Random rnd = new Random();
            cudlitko.BackColor = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0,255));
            //cudlitko.BackColor = BackColor;
        }

        private void cudlitko_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            cudlitko.Size = new System.Drawing.Size(rnd.Next(20,500),rnd.Next(20,500));
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            cudlitko.Size = new System.Drawing.Size(64,59);
        }
    }
}
