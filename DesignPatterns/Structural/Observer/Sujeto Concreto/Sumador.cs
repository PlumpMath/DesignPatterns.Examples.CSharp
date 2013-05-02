using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Structural.Observer
{
    public class Sumador: Calculadora
    {
        public Sumador(): base()
        {            
        }

        /// <summary>
        /// Cuando el modelo (Sumador/Calculadora) cambia de estado, se notifican a todos sus observadores para que cambien su estado tambien
        /// </summary>
        /// <param name="valor1"></param>
        /// <param name="valor2"></param>
        public void Sumar(double valor1, double valor2)
        {
            this._resultado = valor1 + valor2;

            NotificarObservadores();
        }

        public void NotificarObservadores()
        {
            //Observador = etiqueta
            foreach (IEtiquetaObserver observador in this._observadores)
            {
                observador.Actualizar(this);
            }
        }
    }
}
