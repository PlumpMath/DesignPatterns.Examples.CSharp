using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Structural.Bridge
{
    public abstract class ReproductorMultimediaImplementador
    {
        public abstract string IniciarControlador();
        public abstract string IniciarResolucion();
        public abstract string Reproducir();    
    }
}
