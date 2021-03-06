﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DesignPatterns.Behavioral.Command
{
    //Clase receptora. Sobre la cual se realizará la accion. Esta clase es la que realiza verdaderamente la acción a ejecutar.
    public class ContenedorTexto
    {
        public string Texto { get; set; }

        public void Copiar()
        {
            Clipboard.SetText(Texto, TextDataFormat.Text);            
        }

        public void Pegar()
        {
            Texto = Clipboard.GetText();
        }

        public void Cortar()
        {
            Clipboard.SetText(Texto, TextDataFormat.Text);
            Texto = string.Empty;
        }

    }
}
