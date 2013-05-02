using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Structural.Observer
{
    public interface IEtiquetaObserver
    {
        double Valor { get; set; }
        void Actualizar(Calculadora calculadora);
    }
}
