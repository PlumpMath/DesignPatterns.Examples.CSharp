using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DesignPatterns.Structural.Adapter
{
    public partial class AdapterClientForm : Form
    {
        /// <summary>
        /// Convierte la interface de una clase (GPS) a otra clase utilizada por el cliente (Dispositivo)
        /// </summary>
        public AdapterClientForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //El cliente instancia a la subclase adapter.
            Dispositivo movil = new DispositivoConGPS();
            MessageBox.Show(movil.MostrarGEOLocalizacion());
        }
    }
}
