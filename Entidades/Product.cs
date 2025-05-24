using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Product:ProductBase
    {
        public double Precio { get; set; }
        public int Stock { get; set; }
    }
}
