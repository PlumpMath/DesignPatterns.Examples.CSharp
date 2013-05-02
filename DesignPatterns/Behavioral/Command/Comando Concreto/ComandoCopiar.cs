using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DesignPatterns.Behavioral.Command
{
    public class ComandoCopiar: Comando
    {
        ContenedorTexto _receptor;

        public ComandoCopiar(ContenedorTexto contenedorTexto)
        {
            _receptor = contenedorTexto;
        }

        public override string Ejecutar()
        {
            _receptor.Copiar();
            return _receptor.Texto;
        }
    }
}
