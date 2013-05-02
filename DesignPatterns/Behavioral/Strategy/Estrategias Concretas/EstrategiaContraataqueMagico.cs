using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Behavioral.Strategy
{
    class EstrategiaContraataqueMagico : EstrategiaContraataque
    {
        public override string Contraatacar(Pelea pelea)
        {
            //Hacer algo con el contexto

            return "Hechizo";
        }
    }
}
