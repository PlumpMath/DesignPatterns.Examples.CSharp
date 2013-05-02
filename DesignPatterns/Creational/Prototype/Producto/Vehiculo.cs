using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Creational.Prototype
{
    public class Vehiculo: PrototipoVehiculo
    {
        private int _numeroRuedas;
        private int _numeroPuertas;
        
        public int NumeroRuedas
        {
            get
            {
                return _numeroRuedas;
            }
            set
            {
                _numeroRuedas = value;
            }
        }

        public int NumeroPuertas
        {
            get
            {
                return _numeroPuertas;
            }
            set
            {
                _numeroPuertas = value;
            }
        }

        /// <summary>
        /// Clona al objeto que estará en el diccionario del gestor de prototipos
        /// </summary>
        /// <returns></returns>
        public override Vehiculo Clonar()
        {
            return (Vehiculo)this.MemberwiseClone();
        }
    }
}
