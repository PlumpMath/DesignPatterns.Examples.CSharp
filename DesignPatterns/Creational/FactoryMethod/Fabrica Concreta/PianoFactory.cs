using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Creational.FactoryMethod
{
    public class PianoFactory:InstrumentoFactory
    {
        public override Instrumento Crear()
        {
            return new Piano();
        }
    }
}
