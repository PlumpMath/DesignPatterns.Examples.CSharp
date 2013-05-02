using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DesignPatterns.Behavioral.Command
{
    public partial class CommandFormCliente : Form
    {
        //Invocador
        DesignPatterns.Behavioral.Command.Menu menu;

        //Receptor
        ContenedorTexto contenedorTexto;

        public CommandFormCliente()
        {
            InitializeComponent();

            contenedorTexto = new ContenedorTexto();
            menu = new DesignPatterns.Behavioral.Command.Menu(contenedorTexto);
        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            contenedorTexto.Texto = txt.Text;

            txt.Text = menu.EjecutarOpcion(Opciones.Copiar);
        }

        private void btnCortar_Click(object sender, EventArgs e)
        {
            contenedorTexto.Texto = txt.Text;

            txt.Text = menu.EjecutarOpcion(Opciones.Cortar);
        }

        private void btnPegar_Click(object sender, EventArgs e)
        {
            contenedorTexto.Texto = txt.Text;

            txt.Text += menu.EjecutarOpcion(Opciones.Pegar);
        }

        private void btnDeshacer_Click(object sender, EventArgs e)
        {
            txt.Text = menu.Deshacer();
        }
    }
}
