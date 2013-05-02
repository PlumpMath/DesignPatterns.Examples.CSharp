using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace DesignPatterns.Creational.Prototype
{
    /// <summary>
    /// Gestiona los prototipos disponibles en un diccionario
    /// </summary>
    public class GestorPrototiposVehiculo
    {
        //Propiedades
        private Dictionary<string, Vehiculo> _vehiculos;
        public Dictionary<string, Vehiculo> Vehiculos
        {
            get
            {
                return _vehiculos;
            }
        }

        //Constructor
        public GestorPrototiposVehiculo()
        {
            _vehiculos = new Dictionary<string, Vehiculo>();
        }

        /// <summary>
        /// Agrega un nuevo prototipo
        /// </summary>
        /// <param name="clave"></param>
        /// <param name="numeroRuedas"></param>
        /// <param name="numeroPuertas"></param>
        public void AgregarPrototipo(string clave, int numeroRuedas, int numeroPuertas)
        {
            Vehiculo vehiculo = new Vehiculo();
            
            vehiculo.NumeroRuedas = numeroRuedas;
            vehiculo.NumeroPuertas = numeroPuertas;

            this._vehiculos.Add(clave, vehiculo);
        }       
    }
}
