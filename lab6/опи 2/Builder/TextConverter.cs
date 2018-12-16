using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using опи_2.ProductClass;

namespace опи_2.Builder
{// абстрактный строитель 
    interface TextConverter
    {
        void GetText(string text);
        string ConvertBold(string str);
        string ConvertItalic(string str);
        string ConvertUnderline(string str);
        string ConvertText(string str);
        string Paragraph(string str);
        void Reset();
        Product GetProduct();
    }
}
