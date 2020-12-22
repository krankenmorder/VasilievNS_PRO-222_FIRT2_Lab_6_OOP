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
        int indexin = 0;
        static int index = 0; //кол-во нарисованных кругов
        static int razmer = 10;
        Storage sklad = new Storage(razmer);

        class Figures
        {
            public Figures()
            {
                
            }
            ~Figures()
            {

            }
        }

        class Ellipse: Figures
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

        class Rectangle: Figures
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

        class Triangle: Figures
        {
            public int x1, x2, x3, y1, y2, y3;
            public Triangle()
            {
                x1 = 0;
                x2 = 0;
                x3 = 0;
                y1 = 0;
                y2 = 0;
                y3 = 0;
            }
            public Triangle(int x1, int y1, int x2, int y2, int x3, int y3)
            {
                this.x1 = x1;
                this.y1 = y1;
                this.x2 = x2;
                this.y2 = y2;
                this.x3 = x3;
                this.y3 = y3;
            }
            ~Triangle()
            {

            }
        }


        class Line: Figures
        {
            public int x1, y1, x2, y2;
            public Line()
            {
                x1 = 0;
                y1 = 0;
                x2 = 0;
                y2 = 0;
            }
            public Line(int x1, int y1, int x2, int y2)
            {
                this.x1 = x1;
                this.y1 = y1;
                this.x2 = x2;
                this.y2 = y2;
            }
            ~Line()
            {

            }
        }

        class Storage
        {
            public Figures[] objects;
            public Storage(int count)
            {
                objects = new Figures[count];
                
                for (int i = 0; i < count; i++)
                {
                    objects[i] = null;
                }
            }

            public void addObject(int index, ref Figures object1, ref int indexin)
            {
                objects[index] = object1;
                indexin = index;
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

            Figures figure = new Figures();

            if (radioButtonEllipse.Checked == true)
            {
                figure = new Ellipse(e.X, e.Y);
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
                figure = new Rectangle(e.X, e.Y);

                chooseColor();
                switch (color)
                {
                    case 1:
                        panelPaint.CreateGraphics().DrawRectangle(red, e.X - 25, e.Y - 25, 50, 50);
                        panelPaint.CreateGraphics().FillRectangle(fillRed, e.X - 25, e.Y - 25, 50, 50);
                        break;
                    case 2:
                        panelPaint.CreateGraphics().DrawRectangle(orange, e.X - 25, e.Y - 25, 50, 50);
                        panelPaint.CreateGraphics().FillRectangle(fillOrange, e.X - 25, e.Y - 25, 50, 50);
                        break;
                    case 3:
                        panelPaint.CreateGraphics().DrawRectangle(yellow, e.X - 25, e.Y - 25, 50, 50);
                        panelPaint.CreateGraphics().FillRectangle(fillYellow, e.X - 25, e.Y - 25, 50, 50);
                        break;
                    case 4:
                        panelPaint.CreateGraphics().DrawRectangle(green, e.X - 25, e.Y - 25, 50, 50);
                        panelPaint.CreateGraphics().FillRectangle(fillGreen, e.X - 25, e.Y - 25, 50, 50);
                        break;
                }
            }
            if (radioButtonTriangle.Checked == true)
            {
                PointF point1 = new PointF(e.X - 25, e.Y + 25);
                PointF point2 = new PointF(e.X + 25, e.Y + 25);
                PointF point3 = new PointF(e.X, e.Y - 25);
                PointF[] trianglePoints = {point1, point2, point3};

                figure = new Triangle(e.X - 25, e.Y + 25, e.X + 25, e.Y + 25, e.X, e.Y - 25);

                chooseColor();
                switch (color)
                {
                    case 1:
                        panelPaint.CreateGraphics().DrawPolygon(red, trianglePoints);
                        panelPaint.CreateGraphics().FillPolygon(fillRed, trianglePoints);
                        break;
                    case 2:
                        panelPaint.CreateGraphics().DrawPolygon(orange, trianglePoints);
                        panelPaint.CreateGraphics().FillPolygon(fillOrange, trianglePoints);
                        break;
                    case 3:
                        panelPaint.CreateGraphics().DrawPolygon(yellow, trianglePoints);
                        panelPaint.CreateGraphics().FillPolygon(fillYellow, trianglePoints);
                        break;
                    case 4:
                        panelPaint.CreateGraphics().DrawPolygon(green, trianglePoints);
                        panelPaint.CreateGraphics().FillPolygon(fillGreen, trianglePoints);
                        break;
                }
            }
            if (radioButtonLine.Checked == true)
            {
                figure = new Line(e.X - 25, e.Y, e.X + 25, e.Y);
                chooseColor();
                switch (color)
                {
                    case 1:
                        panelPaint.CreateGraphics().DrawLine(red, e.X - 25, e.Y, e.X + 25, e.Y);
                        break;
                    case 2:
                        panelPaint.CreateGraphics().DrawLine(orange, e.X - 25, e.Y, e.X + 25, e.Y);
                        break;
                    case 3:
                        panelPaint.CreateGraphics().DrawLine(yellow, e.X - 25, e.Y, e.X + 25, e.Y);
                        break;
                    case 4:
                        panelPaint.CreateGraphics().DrawLine(green, e.X - 25, e.Y, e.X + 25, e.Y);
                        break;
                }
            }
            sklad.addObject(index, ref figure, ref indexin);
            index++;

        }

        private void panelPaint_MouseMove(object sender, MouseEventArgs e)
        {
            labelCoords.Text = "Координаты мыши: " + e.X.ToString() + " " + e.Y.ToString();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            labelCoords.Text = "Координаты мыши: 0 0";
        }


    }
}
