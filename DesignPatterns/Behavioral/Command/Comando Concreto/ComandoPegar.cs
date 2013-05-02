using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Behavioral.Command
{
    public class ComandoPegar : Comando
    {
        ContenedorTexto _receptor;

        public ComandoPegar(ContenedorTexto contenedorTexto)
        {
            _receptor = contenedorTexto;
        }

        public override string Ejecutar()
        {
            _receptor.Pegar();
            return _receptor.Texto;
        }
    }
}
