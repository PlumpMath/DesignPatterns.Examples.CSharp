using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Structural.Observer
{
    public class Calculadora
    {
        protected double _resultado;
        protected List<IEtiquetaObserver> _observadores;

        public Calculadora()
        {
            _observadores = new List<IEtiquetaObserver>();
        }

        public void AgregarObservador(IEtiquetaObserver observador)
        {
            _observadores.Add(observador);
        }

        public void RemoverObservador(IEtiquetaObserver observador)
        {
            _observadores.Remove(observador);
        }

        public double Resultado
        {
            get
            {
                return _resultado;
            }
        }
    }
}
