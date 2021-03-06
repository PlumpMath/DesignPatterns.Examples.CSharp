﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Behavioral.State
{
    class CuentaCorriente
    {
        //La cuenta corriente conoce al estado de cuenta
        public EstadoCuenta EstadoCuenta;
        public double saldo;

        public CuentaCorriente()
        {
            this.EstadoCuenta = new Normal(this);
        }

        public void SetEstado(EstadoCuenta estado)
        {
            this.EstadoCuenta = estado;
        }

        public void Depositar(double importe)
        {
            this.EstadoCuenta.Depositar(importe);
        }

        public void Extraer(double importe)
        {
            this.EstadoCuenta.Extraer(importe);
        }
    }
}
