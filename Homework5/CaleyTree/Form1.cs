﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CaleyTree
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (graphics == null) graphics = this.CreateGraphics();
            drawATree(16, 210, 310, 100, -Math.PI / 2);
        }
        private Graphics graphics;
        double th1 = 60 * Math.PI / 180;
        double th2 = 60 * Math.PI / 180;
        double per1 = 0.7;
        double per2 = 0.5;
        void drawATree(int n, double x0, double y0, double leng, double th)
        {
            if (n == 0)
                return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);
            drawLine(x0, y0, x1, y1);
            drawATree(n - 1, x1, y1, per1 * leng, th - th1);
            drawATree(n - 1, x1, y1, per2 * leng, th + th2);
        }
        void drawLine(double x0, double y0, double x1, double y1)
        {
            graphics.DrawLine(
                Pens.Blue,
                (int)x0, (int)y0, (int)x1, (int)y1);
        }
    }
}
