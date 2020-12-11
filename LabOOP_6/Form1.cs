using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabOOP_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class Ellipse
        {
            private string name = "Ellipse";
            public int x, y;
            public Ellipse()
            {
                x = 0;
                y = 0;
                name = "Ellipse";
            }
            public Ellipse(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
            ~Ellipse() 
            {

            }
        }

        class Rectangle
        {
            private string name = "Rectangle";
            public int x, y;
            public Rectangle()
            {
                x = 0;
                y = 0;
                name = "Rectangle";
            }
            public Rectangle(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
            ~Rectangle()
            {

            }
        }

        class Triangle
        {
            private string name = "Triangle";
            public int x, y, z;
            public Triangle()
            {
                x = 0;
                y = 0;
                z = 0;
                name = "Triangle";
            }
            public Triangle(int x, int y, int z)
            {
                this.x = x;
                this.y = y;
                this.z = z;
            }
            ~Triangle()
            {

            }
        }


        class Line
        {
            private string name = "Line";
            public int x, y;
            public Line()
            {
                x = 0;
                y = 0;
                name = "Line";
            }
            public Line(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
            ~Line()
            {

            }
        }

        class Storage
        {
            public Ellipse[] ellipses;
            public Rectangle[] rectangles;
            public Triangle[] triangles;
            public Line[] lines;
        }
    }
}
