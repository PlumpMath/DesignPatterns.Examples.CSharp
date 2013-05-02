using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Creational.Builder
{
    /// <summary>
    /// Builder abstracto
    /// </summary>
    public abstract class CelularBuilder
    {
        //El builder abstracto es el que va a contener el objeto que se construya
        public Celular Celular;

        public abstract void ConstruirPantalla();
        public abstract void ConstruirTeclado();
        public abstract void ConstruirCargador();
    }
}
