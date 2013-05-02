using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Behavioral.State
{   
    abstract class EstadoCuenta
    {
        //El estado de cuenta conoce a la cuenta corriente
        public CuentaCorriente cuentaCorriente { get; set; }   
        public double Saldo { get; set; }        

        public abstract void Depositar(double importe);
        public abstract void Extraer(double importe);        
    }
}
