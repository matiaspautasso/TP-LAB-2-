using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrySamuraiVsNinja
{
    public partial class FrmPelea : Form
    {
        public FrmPelea()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            //hacer cronometro de 1,10 min tiene que cambiar los lbl contando de 1,10 hacia 0
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTiempo.Text += 1;
            if (lblTiempo.Text == "60")
            {
                lblTiempo2.Text += 1;
                lblTiempo.Text = "00";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //configurar en la clase cuanto resta el ataque de cada personaje
        }

        private void FrmPelea_Load(object sender, EventArgs e)
        {
            //bloquear los botones hasta desbloquearlos con boton iniciar
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //este boton debe cederle el turno al rival 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // //configurar en la clase cuanto resta el ataque de cada personaje
        }
    }
}
