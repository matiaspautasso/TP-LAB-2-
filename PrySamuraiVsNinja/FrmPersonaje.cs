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
    public partial class FrmPersonaje : Form
    {
        public FrmPersonaje()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FrmPersonaje_Load(object sender, EventArgs e)
        {

        }

        private void btnVS_Click(object sender, EventArgs e)
        {
            if (txtNombreNinja.Text != "" && txtNomSamurai.Text != "")
            {
                Form Pelear = new FrmPelea();
                Pelear.Show();
            }
            else MessageBox.Show("completar campos"); btnNinja.Enabled = false; btnSamurai.Enabled = false;
            
        }
        clsPersonaje samurai = new clsPersonaje();

        private void btnSamurai_Click(object sender, EventArgs e)
        {
            
           

            if (string.IsNullOrWhiteSpace(txtNomSamurai.Text))
            {
                MessageBox.Show("Por favor, ingresa un nombre.");
            }
            else
            {
                btnSamurai.Text = "Personaje creado";
                samurai.NOMBRE = txtNomSamurai.Text;
                samurai.TIPO = "SAMURAI";
                conexionDBA DBA = new conexionDBA();
                DBA.insertarUsuario(samurai);
            }

        }
        clsPersonaje ninja = new clsPersonaje();

        private void btnNinja_Click(object sender, EventArgs e)
        {
            
            if (txtNombreNinja.Text == "")
            {
                MessageBox.Show("poner nombre");
            }
            else
            {
                btnNinja.Text = "personaje creado";
                ninja.NOMBRE = txtNombreNinja.Text;
                ninja.TIPO = "NINJA";
                conexionDBA DBA = new conexionDBA();
                DBA.insertarUsuario(ninja);
            }
           
        }
    }
}
