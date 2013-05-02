using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DesignPatterns.Structural.Decorator
{
    public partial class DecoratorFormClient : Form
    {
        //El objetivo el ejercicio es crear un objeto PersonajeNormal o un objeto PersonajeVolador (decorado), y tratarlos indistintamente desde el cliente.
        Personaje _personaje;

        public DecoratorFormClient()
        {
            InitializeComponent();
        }

        public void HabilitarBotonera()
        {
           
        }

        public void DeshabilitarBotonera()
        {
           
        }

        private void btnCrearPersonajeNormal_Click(object sender, EventArgs e)
        {
            _personaje = new PersonajeNormal();
            lblPersonaje.Text = "Normal";
        }

        private void btnCrearPersonajeVolador_Click(object sender, EventArgs e)
        {
            _personaje = new PersonajeVolador();

            HabilitarBotonera();
            lblPersonaje.Text = "Volador";
        }       

        private void btnEjecutarHabilidades_Click(object sender, EventArgs e)
        {           
            MessageBox.Show(_personaje.EjecutarHabilidad());
        }
    }
}
