using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using опи_2.Builder;

namespace опи_2.Director
{// абстрактный класс RtfReader. Выполняет функцию директора при чтении rtf и конвертации файла html.
    class RtfReader
    {
        readonly TextConverter converter; // builder

        public RtfReader(TextConverter builder)
        {
            this.converter = builder;
        }

        public void BuildText(string text)
        {
            converter.GetText(text);
        }
    }
}
