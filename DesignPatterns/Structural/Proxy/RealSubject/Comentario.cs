using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Structural.Proxy
{
    public class Comentario
    {
        public string Texto { get; set; }
        public DateTime Fecha { get; set;  }
        public bool Aprobado { get; set; }

        public Comentario(string texto)
        {
            Texto = texto;
            Fecha = DateTime.Now;
            Aprobado = false;
        }
    }
}
