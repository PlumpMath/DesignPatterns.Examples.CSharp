using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Behavioral.Strategy
{
    public class Pelea
    {
        EstrategiaContraataque _estrategiaContraataque;

        public void DefinirEstrategiaContraataque(EstrategiaContraataque nuevaEstrategia)
        {
            this._estrategiaContraataque = nuevaEstrategia;
        }

        public string Contraatacar()
        {
            return _estrategiaContraataque.Contraatacar(this);
        }
    }
}
