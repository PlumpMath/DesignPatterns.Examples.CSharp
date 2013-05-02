using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DesignPatterns.Structural.Proxy
{
    //El cliente solo tiene visibilidad del Proxy. Es el Proxy el que controla el acceso al objeto real (Foro).
    //El objeto "Comentario" es solo un objeto de negocio irrelevante para el patrón en este caso.

    public partial class ProxyFormClient : Form
    {
        ProxyForo proxyForo;
        Comentario comentario;

        private void IniciarControles()
        {
            btnAprobar.Enabled = false;
            txtComentario.Enabled = true;
            btnPostear.Enabled = true;
        }

        private void LockearControles()
        {
            btnAprobar.Enabled = true;
            btnPostear.Enabled = false;
            txtComentario.Enabled = false;
        }

        public ProxyFormClient()
        {
            InitializeComponent();
            IniciarControles();      

            proxyForo = new ProxyForo();
        }

        private void btnPostear_Click(object sender, EventArgs e)
        {            
            comentario = proxyForo.PostearComentario(txtComentario.Text);

            LockearControles();           
        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            try
            {
                proxyForo.AprobarComentario(comentario);
            }
            catch (Exception ex)
            {
                lblError.Text = ex.Message;
            }
        }
    }
}
