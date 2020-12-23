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
        int ctrl = 0;
        int figureNow = 1;
        static int index = 0; //кол-во нарисованных кругов
        static int razmer = 20;
        Storage sklad = new Storage(razmer);

        class Figures
        {
            public Color color = Color.Black;
            public Color fillColor = Color.White;
            public Figures()
            {

            }
            ~Figures()
            {

            }
        }

        class Ellipse : Figures
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

        class Rectangle : Figures
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

        class Triangle : Figures
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


        class Line : Figures
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

            public void addObject(int index, ref Figures object1, int count, ref int indexin)
            {
                while (objects[index] != null)
                {
                    index = (index + 1) % count;
                }
                objects[index] = object1;
                indexin = index;
            }

            public void deleteObject(int index)
            {
                objects[index] = null;
                index--;
            }

            public bool checkEmpty(int index)
            {   // Проверяет занято ли место хранилище
                if (objects[index] == null)
                    return true;
                else return false;
            }

            public int fill(int size)
            { // Определяет кол-во занятых мест в хранилище
                int countFilled = 0;
                for (int i = 0; i < size; ++i)
                    if (!checkEmpty(i))
                        ++countFilled;
                return countFilled;
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
            Figures figure = new Figures();
            switch (figureNow)
            {   // В зависимости какая фигура выбрана
                case 0:
                    return;
                case 1:
                    figure = new Ellipse(e.X, e.Y);
                    break;
                case 2:
                    figure = new Rectangle(e.X, e.Y);
                    break;
            }
            //Проверка на наличие фигуры на данных координатах
            int c = checkFigure(ref sklad, 20, e.X - 25, e.Y - 25);
            if (c != -1)
            {   // Если на этом месте уже нарисована фигура
                if (Control.ModifierKeys == Keys.Control)
                {   // Если нажат ctrl, то выделяем несколько объектов
                    if (ctrl == 0)
                    {
                        paintFigure(Color.Navy, 4, ref sklad, indexin);
                        ctrl = 1;
                    }
                    // Вызываем функцию отрисовки фигуры  
                    paintFigure(Color.Red, 4, ref sklad, c);
                }
                else
                {   // Иначе выделяем только один объект
                    // Снимаем выделение у всех объектов хранилища
                    removeSelectFigure(ref sklad);
                    paintFigure(Color.Red, 4, ref sklad, c);
                }
                return;
            }
            // Добавляем фигуру в хранилище   
            sklad.addObject(index, ref figure, 20, ref indexin);
            // Снимаем выделение у всех объектов хранилища
            removeSelectFigure(ref sklad);
            paintFigure(Color.Red, 4, ref sklad, indexin);
            ++index;
            ctrl = 0;
        }

        private void paintFigure(Color color, int size, ref Storage storage, int index)
        {   // Рисует фигуру на панели          
            // Объявляем объект - карандаш, которым будем рисовать контур
            Pen pen = new Pen(color, size);
            SolidBrush figurefillcolor;
            if (!storage.checkEmpty(index))
            {
                storage.objects[index].color = color;
                figurefillcolor = new SolidBrush(storage.objects[index].fillColor);
                if (storage.objects[index] as Ellipse != null)
                {   // Если в хранилище круг
                    Ellipse circle = storage.objects[index] as Ellipse;
                    panelPaint.CreateGraphics().DrawEllipse(pen, circle.x - 25, circle.y - 25, 50, 50);
                    panelPaint.CreateGraphics().FillEllipse( figurefillcolor, circle.x - 25, circle.y - 25, 50, 50);
                }
               
                    else
                    {
                        if (storage.objects[index] as Rectangle != null)
                        {   // Если в хранилище квадрат
                            Rectangle square = storage.objects[index] as Rectangle;
                            panelPaint.CreateGraphics().DrawRectangle(pen, square.x - 25, square.y - 25, 50, 50);
                            panelPaint.CreateGraphics().FillRectangle(figurefillcolor, square.x - 25, square.y - 25, 50, 50);
                        }
                    }
                
            }
        }

        private int checkFigure(ref Storage storage, int size, int x, int y)
        {   // Проверяет есть ли уже фигура с такими же координатами в хранилище
            if (storage.fill(size) != 0)
            {
                for (int i = 0; i < size; ++i)
                {
                    if (!storage.checkEmpty(i))
                    {   // Если под i индексом в хранилище есть объект
                        if (storage.objects[i] as Ellipse != null)
                        {   // Если в хранилище круг
                            Ellipse ellipse = storage.objects[i] as Ellipse;
                            if (((x - ellipse.x - 25) * (x - ellipse.x - 25) + (y - ellipse.y - 25) * (y - ellipse.y - 25)) < (50 * 50))
                                return i;
                        }
                            else
                            {
                                if (storage.objects[i] as Rectangle != null)
                                {   // Если в хранилище квадрат
                                    Rectangle rectangle = storage.objects[i] as Rectangle;
                                    if (rectangle.x <= x && x <= (rectangle.x + 25) && rectangle.y <= y && y <= (rectangle.y + 25))
                                    return i;
                                }
                            }
                    }
                }
            }
            return -1;
        }

        private void removeSelectFigure(ref Storage storage)
        {   // Снимает выделение у всех элементов хранилища
            for (int i = 0; i < 20; ++i)
            {
                if (!storage.checkEmpty(i))
                {   // Вызываем функцию отрисовки круга
                    paintFigure(Color.Black, 5, ref sklad, i);
                }
            }
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
