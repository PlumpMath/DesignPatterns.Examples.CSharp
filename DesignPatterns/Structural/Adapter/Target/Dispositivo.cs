using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Structural.Adapter
{
    public class Dispositivo
    {
        public virtual string MostrarGEOLocalizacion()
        {
            return string.Empty;
        }
    }
}
