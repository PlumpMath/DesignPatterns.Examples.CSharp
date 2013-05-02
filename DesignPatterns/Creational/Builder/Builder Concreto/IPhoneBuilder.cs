using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Creational.Builder
{
    /// <summary>
    /// Builder concreto
    /// </summary>
    class IPhoneBuilder : CelularBuilder
    {
        public override void ConstruirPantalla()
        {
            Celular.Pantalla = new Pantalla("Pantalla de iPhone");
        }

        public override void ConstruirTeclado()
        {
            Celular.Teclado = new Teclado("Teclado touch de iPhone");
        }

        public override void ConstruirCargador()
        {
            Celular.Cargador = new Cargador("Cargador blanco de iPhone");
        }
    }
}
