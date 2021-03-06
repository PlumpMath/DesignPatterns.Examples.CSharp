﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DesignPatterns.Creational.AbstractFactory
{
    public enum TipoInstrumento
    {
        Guitarra = 1, 
        Piano = 2
    }

    public partial class AbstractFactoryFormCliente : Form
    {
        public AbstractFactoryFormCliente()
        {
            InitializeComponent();
        }        

        private void button1_Click(object sender, EventArgs e)
        {
            //El único que conoce el tipo del factory es el boton que lo llama
            Ejecutor(new PianoFactory());
        }       

        private void button2_Click(object sender, EventArgs e)
        {
            //El único que conoce el tipo del factory es el boton que lo llama
            Ejecutor(new GuitarraFactory());
        }

        //Ejecutor, desconoce los tipos concretos
        public void Ejecutor(InstrumentoFactory factory)
        {
            Instrumento instrumento = factory.Crear();
            MessageBox.Show(instrumento.Tocar());
        }
    }    
}
