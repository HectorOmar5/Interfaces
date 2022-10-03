using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Triangulo : IFigura
    {
        public double altura {get
            {
                double h = (Math.Sqrt(lado * lado) - (bases * bases) / 4);
                return h;
            }  }
        public double lado { get; set; }
        public string nombre { get; set; }
        public double bases { get; set; }
        public double area()
        {
            return bases * altura / 2;
        }

        public double perimetro()
        {
            return (lado * 2) + bases;
        }
    }
}
