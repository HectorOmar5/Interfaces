using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuadrado cuadrado = new Cuadrado();
            cuadrado.nombre = "Cuadrado";
            cuadrado.L = 5d;
            Triangulo triangulo = new Triangulo();
            triangulo.nombre = "Triangulo";
            triangulo.bases = 6d;
            triangulo.lado = 12d;

            IFigura[] figuras = new IFigura[2];
            figuras[0] = cuadrado;
            figuras[1] = triangulo;

            foreach (IFigura f in figuras)
            {
                //f.area();
                //f.perimetro();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"Nombre:{f.nombre}");                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              
                Console.WriteLine(f.area());
                Console.WriteLine(f.perimetro());
                
                Console.ReadKey();
            }
        }
    }
}
