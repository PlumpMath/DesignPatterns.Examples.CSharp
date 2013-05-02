using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Creational.Builder
{
    /// <summary>
    /// Componente del objeto complejo Celular
    /// </summary>
    public class Teclado
    {
        string _caracteristicas;
        public Teclado(string caracteristicas)
        {
            this._caracteristicas = caracteristicas;
        }

        public string MostrarCaracteristicas()
        {
            return this._caracteristicas;
        }
    }
}
