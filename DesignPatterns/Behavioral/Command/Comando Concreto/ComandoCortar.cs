using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Behavioral.Command
{
    public class ComandoCortar : Comando
    {
        ContenedorTexto _receptor;

        public ComandoCortar(ContenedorTexto contenedorTexto)
        {
            _receptor = contenedorTexto;
        }

        public override string Ejecutar()
        {
            _receptor.Cortar();
            return _receptor.Texto;
        }
    }
}
