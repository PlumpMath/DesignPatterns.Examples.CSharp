﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Creational.FactoryMethod
{
    //Producto abstracto
    public abstract class Instrumento
    {
        public abstract string Tocar();
    }
}
