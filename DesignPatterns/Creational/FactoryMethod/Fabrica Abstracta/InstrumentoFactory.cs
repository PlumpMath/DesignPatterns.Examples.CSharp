using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Creational.FactoryMethod
{
    public abstract class InstrumentoFactory
    {
        public abstract Instrumento Crear();        
    }
}
