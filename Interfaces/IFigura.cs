﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
     interface IFigura 
    {
        string nombre { get; set; }
        double area();
        double perimetro();
    }
}
