using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Creational.AbstractFactory
{
    //Fabrica concreta
    public class PianoFactory: InstrumentoFactory
    {
        public override Instrumento Crear()
        {
            return new Piano();
        }
    }
}
