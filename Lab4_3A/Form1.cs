using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_3A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Hide();
            Pen myPen = new Pen(Color.Black, 2);
            Graphics g = Graphics.FromHwnd(pictureBox1.Handle);
            Point point1 = new Point(50, 50);
            Point point2 = new Point(100, 50);
            Point point3 = new Point(150, 100);
            Point point4 = new Point(75, 125);
            Point point5 = new Point(2, 100);
            Point[] curvePoints =
                     {
                 point1,
                 point2,
                 point3,
                 point4,
                 point5
                 };
            g.DrawPolygon(myPen, curvePoints);

            Point Dpoint1 = new Point(600, 20);
            Point Dpoint2 = new Point(650, 100);
            Point Dpoint3 = new Point(550, 100);
            Point Dpoint4 = new Point(600, 180);
            Point[] curvePoints2 =
                 {
                 Dpoint1,
                 Dpoint2,
                 Dpoint4,
                 Dpoint3
             };
            g.DrawPolygon(myPen, curvePoints2);

            Point Cpoint1 = new Point(200, 175);
            Point Cpoint2 = new Point(175, 200);
            Point Cpoint3 = new Point(275, 200);
            Point Cpoint4 = new Point(300, 175);
            Point Cpoint5 = new Point(300, 275);
            Point Cpoint6 = new Point(275, 300);
            Point Cpoint7 = new Point(175, 300);
            Point Cpoint8 = new Point(175, 200);
            Point Cpoint9 = new Point(275, 200);
            Point Cpoint10 = new Point(275, 300);
            Point Cpoint11 = new Point(275, 200);
            Point Cpoint12 = new Point(300, 175);
            Point[] curvePoints3 =
                 {
                 Cpoint1,
                 Cpoint2,
                 Cpoint3,
                 Cpoint4,
                 Cpoint5,
                 Cpoint6,
                 Cpoint7,
                 Cpoint8,
                 Cpoint9,
                 Cpoint10,
                 Cpoint11,
                 Cpoint12
             };
            g.DrawPolygon(myPen, curvePoints3);

            Brush brSolid = new SolidBrush(Color.Blue);
            g.FillPie(brSolid, 0, 0, 300, 300, 285, 75);

        }
    }
}
