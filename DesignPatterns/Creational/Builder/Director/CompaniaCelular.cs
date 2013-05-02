using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Creational.Builder
{
    /// <summary>
    /// Director
    /// </summary>
    public class CompaniaCelular
    {
        /// <summary>
        /// Especifica el algoritmo de pasos abstractos de construcción del objeto Celular
        /// </summary>
        /// <param name="celularBuilder"></param>
        public void Construir(CelularBuilder celularBuilder)
        {
            celularBuilder.Celular = new Celular();

            celularBuilder.ConstruirPantalla();
            celularBuilder.ConstruirTeclado();
            celularBuilder.ConstruirCargador();
        }
    }
}
