using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5_three_
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
namespace lab5_three_
{
    abstract class AbstractFactory
    {
        public abstract Canvas CreateCanvas();
        public abstract Brush CreateBrush();
    }
    class ConcreteFactory1 : AbstractFactory
    {
        public override Canvas CreateCanvas()
        {
            return new Circle();
        }


        public override Brush CreateBrush()
        {
            return new CircleBrush();
        }
    }
    class ConcreteFactory2 : AbstractFactory
    {
        public override Canvas CreateCanvas()
        {
            return new Rectan();
        }


        public override Brush CreateBrush()//кисть
        {
            return new RectBrush();
        }
    }

    abstract class Canvas//холст
    {
        public abstract void SetName();

    }

    abstract class Brush
    {
        public Pen pen;
        public abstract void SetBrush();

    }

    class Circle : Canvas
    {
        public Form2 newForm;

        public override void SetName()
        {
            newForm.Text = "Circle";

        }
    }

    class CircleBrush : Brush
    {
        static Color currentColor = Color.Black;
        static int size = 5;
        Pen pen = new Pen(currentColor, size);

        public override void SetBrush()
        {

        }
    }

    class Rectan : Canvas
    {
        public Form1 newForm;


        public override void SetName()
        {
            newForm.Text = "Rectangue";

        }
        RectBrush rectBrush = new RectBrush();

        public void active(Rectan rectan)
        {
            rectan.SetName();
            rectan.newForm.Show();
        }

    }

    class RectBrush : Brush
    {
        static Color currentColor = Color.Black;
        static int size = 5;

        public override void SetBrush()
        {
        }
    }


}