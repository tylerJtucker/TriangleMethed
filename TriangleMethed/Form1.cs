using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace TriangleMethed
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            Pen drawPen = new Pen(Color.Red);
            DrawTriangle(drawPen, 60, 20, 190, 10, 150, 200);
        }

        public void DrawTriangle(Pen drawPen, int x1, int y1, int x2, int y2, int x3, int y3)
        {
            Graphics g = this.CreateGraphics();

            g.DrawLine(drawPen, x1, y1, x2, y2);
            g.DrawLine(drawPen, x2, y2, x3, y3);
            g.DrawLine(drawPen, x3, y3, x1, y1);
        }
    }
}
