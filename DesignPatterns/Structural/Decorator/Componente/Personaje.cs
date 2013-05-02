using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DesignPatterns.Structural.Decorator
{
    public abstract class Personaje
    {
        public virtual string EjecutarHabilidad()
        {
            throw new Exception("No implementado");
        }
    }
}
