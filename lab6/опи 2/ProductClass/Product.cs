using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace опи_2.ProductClass
{
    class Product
    {
        public string readyText;

        public void Add(string part)
        {
            readyText += part;
        }
    }
}
