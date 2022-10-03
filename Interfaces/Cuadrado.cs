using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Cuadrado : IFigura
    {
        public double L { get; set; }
        public string nombre { get; set; }

        public double area()
        {
            return L * L;
            
        }
        public double perimetro()
        {
            return 4 * L;
        }
    }
}
