using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
    }
}
