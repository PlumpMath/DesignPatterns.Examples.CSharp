using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Behavioral.TemplateMethod
{
    public class SMS: Mensaje
    {
        public override string EncenderDispositivo()
        {
            return "Prendiendo el celular...";
        }

        public override string EscribirMensaje()
        {
            return "Tecleando el mensaje...";
        }

        public override string EnviarMensaje()
        {
            return "Presionando el botón verde...";
        }
    }
}
