using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fractal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void drawF(int x,int y, int len,int angle,PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            double x1, y1;
            x1 = x + len * Math.Sin(angle * Math.PI / 360.0) * 1.8;
            y1 = y + len * Math.Cos(Math.PI / 360.0) * 1.6;
            g.DrawLine(new Pen(Color.Green), x, y, (int)x1, (int)y1);
            if(len>2)
            {
                drawF((int)x1, (int)y1, (int)(len / 1.9), angle / 2 + 70, e);
                drawF((int)x1, (int)y1, (int)(len / 1.9), angle / 2 - 70, e);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            drawF(panel1.Width / 2, -400, 250, 0, e);
        }
    }
}
