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

        int color = 0;
        static int razmer = 10;
        Storage storage = new Storage(razmer);

        class Ellipse
        {
            public int x, y;
            public Ellipse()
            {
                x = 0;
                y = 0;
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
            public int x, y;
            public Rectangle()
            {
                x = 0;
                y = 0;
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
            public int x, y, z;
            public Triangle()
            {
                x = 0;
                y = 0;
                z = 0;
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
            public int x, y;
            public Line()
            {
                x = 0;
                y = 0;
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

            public Storage(int count)
            {
                ellipses = new Ellipse[count];
                rectangles = new Rectangle[count];
                triangles = new Triangle[count];
                lines = new Line[count];

                for (int i = 0; i < count; i++)
                {
                    ellipses[i] = null;
                    rectangles[i] = null;
                    triangles[i] = null;
                    lines[i] = null;

                }
            }

            ~Storage()
            {

            }
        }

        public void chooseColor()
        {
            if (radioButtonRed.Checked == true) //красный
            {
                color = 1;
            }
            if (radioButtonOrange.Checked == true) //оранжевый
            {
                color = 2;
            }
            if (radioButtonYellow.Checked == true) //жёлтый
            {
                color = 3;
            }
            if (radioButtonGreen.Checked == true) //зелёный
            {
                color = 4;
            }
        }

        public void createEllipse() { 
        }

        private void panelPaint_MouseClick(object sender, MouseEventArgs e)
        {
            Pen red = new Pen(Color.Red, 5);
            SolidBrush fillRed = new SolidBrush(Color.Red);
            Pen orange = new Pen(Color.Orange, 5);
            SolidBrush fillOrange = new SolidBrush(Color.Orange);
            Pen yellow = new Pen(Color.Yellow, 5);
            SolidBrush fillYellow = new SolidBrush(Color.Yellow);
            Pen green = new Pen(Color.Lime, 5);
            SolidBrush fillGreen = new SolidBrush(Color.Lime);
            if (radioButtonEllipse.Checked == true)
            {
                Ellipse krug = new Ellipse(e.X - 25, e.Y - 25);
                RectangleF ellipse_rectangle = new RectangleF(e.X - 25, e.Y - 25, 50, 50);
                chooseColor();
                switch (color)
                {
                    case 1:
                        panelPaint.CreateGraphics().DrawEllipse(red, ellipse_rectangle);
                        panelPaint.CreateGraphics().FillEllipse(fillRed, ellipse_rectangle);
                        break;
                    case 2:
                        panelPaint.CreateGraphics().DrawEllipse(orange, ellipse_rectangle);
                        panelPaint.CreateGraphics().FillEllipse(fillOrange, ellipse_rectangle);
                        break;
                    case 3:
                        panelPaint.CreateGraphics().DrawEllipse(yellow, ellipse_rectangle);
                        panelPaint.CreateGraphics().FillEllipse(fillYellow, ellipse_rectangle);
                        break;
                    case 4:
                        panelPaint.CreateGraphics().DrawEllipse(green, ellipse_rectangle);
                        panelPaint.CreateGraphics().FillEllipse(fillGreen, ellipse_rectangle);
                        break;
                }
            }
            if (radioButtonRectangle.Checked == true)
            {
                Rectangle kvadrat = new Rectangle(e.X - 25, e.Y - 25);
                //Rectangle rectangle = new Rectangle(e.X - 25, e.Y - 25, 50, 50);
                chooseColor();
                switch (color)
                {
                    case 1:
                        panelPaint.CreateGraphics().DrawRectangle(red, e.X - 25, e.Y - 25, 50, 50);
                        break;
                    case 2:
                        panelPaint.CreateGraphics().DrawRectangle(orange, e.X - 25, e.Y - 25, 50, 50);
                        break;
                    case 3:
                        panelPaint.CreateGraphics().DrawRectangle(yellow, e.X - 25, e.Y - 25, 50, 50);
                        break;
                    case 4:
                        panelPaint.CreateGraphics().DrawRectangle(green, e.X - 25, e.Y - 25, 50, 50);
                        break;
                }
            }
        }
    }
}
