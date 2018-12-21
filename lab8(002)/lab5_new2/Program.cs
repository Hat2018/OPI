using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5_new2
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
namespace lab5_new2
{
    /// <summary>
    /// Abstract Factory
    /// </summary>
    abstract class AbstractCanvas
    {
        public abstract void Create(Form1 f);
    }

    abstract class AbstractPen
    {
        public abstract void CreateP(Form1 f);

    }

    abstract class AbstractFactory
    {
        public abstract AbstractCanvas CreateCanvas();
        public abstract AbstractPen CreatePen();
    }

    class CircleCanvas : AbstractCanvas//круглый холст
    {
        public override void Create(Form1 f)
        {
            f.Circle_canv();
        }
    }

    class CirclePen : AbstractPen//круглая кисть 
    {
        public override void CreateP(Form1 f)
        {
            f.Circle_pen();
        }
    }

    class RectangleCanvas : AbstractCanvas//прямокутний холст
    {
        public override void Create(Form1 f)
        {
            f.Rect_canv();
        }

    }
    class RectanglePen : AbstractPen//прямокутная кисть 
    {
        public override void CreateP(Form1 f)
        {
            f.Rect_pen();
        }
    }
    //copy clone
    class CircleFactory : AbstractFactory
    {
        public override AbstractCanvas CreateCanvas()
        {
            return new CircleCanvas();
        }

        public override AbstractPen CreatePen()
        {
            return new CirclePen();
        }
    }

    class RectangleFactory : AbstractFactory
    {
        public override AbstractCanvas CreateCanvas()
        {
            return new RectangleCanvas();
        }

        public override AbstractPen CreatePen()
        {
            return new RectanglePen();
        }
    }
    ///
    class Client
    {
        private AbstractCanvas canvas;
        private AbstractPen pen;

        public Client(AbstractFactory factory)
        {
            canvas = factory.CreateCanvas();
            pen = factory.CreatePen();
        }

        public void Canvas(Form1 f)
        {
            canvas.Create(f);
        }

        public void Pen(Form1 f)
        {
            pen.CreateP(f);
        }
    }
    abstract class iFigure
    {
        public PictureBox pbox1, pbox2;
        public abstract iFigure Clone(iFigure result);
        public abstract iFigure Paste(iFigure result);
    }
    //copy circle & rectangle
    class CopyCircle : iFigure
    {
        public override iFigure Clone(iFigure result)
        {
            Clipboard.SetDataObject(result.pbox1.Image);
            return result;
        }

        public override iFigure Paste(iFigure result)
        {
            IDataObject iData = Clipboard.GetDataObject();
            if (iData.GetDataPresent(DataFormats.Bitmap))
            {
                result.pbox1.Image = (Bitmap)iData.GetData(DataFormats.Bitmap);
            }
            return result;
        }

    }

    class CopyRectangle : iFigure
    {
        public override iFigure Clone(iFigure result)
        {
            Clipboard.SetDataObject(result.pbox2.Image, true);
            return result;
        }

        public override iFigure Paste(iFigure result)
        {
            IDataObject iData = Clipboard.GetDataObject();
            if (iData.GetDataPresent(DataFormats.Bitmap))
            {
                result.pbox2.Image = (Bitmap)iData.GetData(DataFormats.Bitmap);
            }
            return result;
        }
    }

}