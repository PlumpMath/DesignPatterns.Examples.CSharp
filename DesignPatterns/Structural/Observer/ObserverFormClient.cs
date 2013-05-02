using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DesignPatterns.Structural.Observer
{
    public partial class ObserverFormClient : Form
    {
         Sumador _calculadora;    

         IEtiquetaObserver etiqueta1;
         IEtiquetaObserver etiqueta2;
         IEtiquetaObserver etiqueta3; 

        public ObserverFormClient()
        {
            InitializeComponent();

            //Se instancia el sujeto concreto
            this._calculadora = new Sumador();

            //Se instancian los observadores
            etiqueta1 = new Etiqueta();
            etiqueta2 = new Etiqueta();
            etiqueta3 = new Etiqueta();

            //Se agregan los observadores al sujeto
            this._calculadora.AgregarObservador(etiqueta1);
            this._calculadora.AgregarObservador(etiqueta2);
            this._calculadora.AgregarObservador(etiqueta3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _calculadora.Sumar(Convert.ToDouble(txt1.Text), Convert.ToDouble(txt2.Text));

            lblTotal1.Text = etiqueta1.Valor.ToString();
            lblTotal2.Text = etiqueta2.Valor.ToString();
            lblTotal3.Text = etiqueta3.Valor.ToString();
        }     
    }
}
