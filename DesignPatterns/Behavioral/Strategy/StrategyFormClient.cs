using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DesignPatterns.Behavioral.Strategy
{
    public partial class StrategyFormClient : Form
    {
        //Contexto para las extrategias
        Pelea _pelea;

        public StrategyFormClient()
        {
            _pelea = new Pelea();
            InitializeComponent();
        }

        //El cliente debe conocer la estrategia para poder cambiarla
        private void btnAtacarMagia_Click(object sender, EventArgs e)
        {
            //Setea dinámicamente el comportamiento (estrategia) al contexto de la pelea
            _pelea.DefinirEstrategiaContraataque(new EstrategiaContraataqueMagico());

            lblEstrategiaContraataque.Text = _pelea.Contraatacar();
        }

        //El cliente debe conocer la estrategia para poder cambiarla
        private void btnAtacarGolpe_Click(object sender, EventArgs e)
        {
            //Setea dinámicamente el comportamiento (estrategia) al contexto de la pelea
            _pelea.DefinirEstrategiaContraataque(new EstrategiaContraataqueFisico());

            lblEstrategiaContraataque.Text = _pelea.Contraatacar();
        }

        //El cliente debe conocer la estrategia para poder cambiarla
        private void btnAtacarArma_Click(object sender, EventArgs e)
        {
            //Setea dinámicamente el comportamiento (estrategia) al contexto de la pelea
            _pelea.DefinirEstrategiaContraataque(new EstrategiaContraataqueBelico());

            lblEstrategiaContraataque.Text = _pelea.Contraatacar();
        }
    }
}
