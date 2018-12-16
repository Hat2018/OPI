using System;
using System.Windows.Forms;
/* Фабричный метод (Factory Method) - это паттерн, который определяет интерфейс для создания 
 * объектов некоторого класса, но непосредственное решение о том, объект какого класса создавать
 * происходит в подклассах. То есть паттерн предполагает, что базовый класс делегирует создание 
 * объектов классам-наследникам.
 abstract предоставляет интерфейс для создания семейств взаимосвязанных объектов с 
 определенными интерфейсами без указания конкретных типов данных объектов.*/

namespace WindowsFormsApplication1
{
    abstract class Abstract { } //абстрактный класс 

    class ImageDocument : Abstract //реализация конкретного класа (наследник)
    {
        public PictureBox pBox;
    }

    abstract class OperationWithImage //абстрактный класс
    {
        abstract public ImageDocument operation(ImageDocument imgDoc);
    }

    class OpenImage : OperationWithImage// наследники
    {

        public override ImageDocument operation(ImageDocument imgDoc)//открывает изображение 
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Image files (*.BMP, *.JPG, *.GIF)|*.bmp;*.jpg;*.gif";//формати

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
               // try { 
                System.IO.FileStream fs = new System.IO.FileStream(openDialog.FileName, System.IO.FileMode.Open);
                System.Drawing.Image img = System.Drawing.Image.FromStream(fs);
                fs.Close();
                imgDoc.pBox.Size = img.Size;
                imgDoc.pBox.Image = img;
                   
                //}
               // catch (Exception)
                //{ MessageBox.Show("Error"); }
            }
            return imgDoc;
        }
    }

    class ClearImage : OperationWithImage//наследники
    {
        public override ImageDocument operation(ImageDocument imgDoc)//очистка изображения 
        {
            imgDoc.pBox.Image = null;
            return imgDoc;
        }
    }

}
