﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Creational.FactoryMethod
{
    public class Piano : Instrumento
    {
        public override string Tocar()
        {
            return "tocando el piano";
        }
    }
}


