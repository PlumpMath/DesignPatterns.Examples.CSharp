using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Creational.AbstractFactory
{
    //Producto concreto
    public class Guitarra: Instrumento
    {
        public override string Tocar()
        {
            return "tocando la guitarra";
        }
    }
}
