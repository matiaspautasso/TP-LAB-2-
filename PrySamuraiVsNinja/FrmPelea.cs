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
            //hacer cronometro 
            //aca quede  MessageBox.Show($"{randomBool}");  comprobar si anda o no el random
            timer1 = new Timer();
            timer1.Tick += new EventHandler(Contador);
            timer1.Interval = 1000;
            timer1.Start();

            if (randomBool == false)
            {
                lblPersonaje.Text = " SAMURAI"; //ACA QUEDO 
            }
            if (!randomBool == false)
            {
                lblPersonaje.Text = " NINJA";
            }
         
        }
        public int duration = 40;

        private void Contador(object sender, EventArgs e)
        {
            if (duration == 0)
            {
                timer1.Stop();

            }
            else if (duration > 0)
            {
                duration--;
                lblTiempo2.Text = duration.ToString();
            }
        }



        
        private void timer1_Tick(object sender, EventArgs e)
        {
          
        }
        clsNINJA NINJA = new clsNINJA();

        

        private void button1_Click(object sender, EventArgs e)
        {
            //btnataque simple: 
            
           int ataqueS = NINJA.AtaqueS;



            //configurar en la clase cuanto resta el ataque de cada personaje
            
        }
        clsPersonaje Ninja = new clsPersonaje();
        clsPersonaje Samurai = new clsPersonaje();
     

        public void ControlDeTurno()
        {
            string turno = "";
            if (Ninja.TURNO)
            {
                turno = " NINJA";
            }
            else
            {
                turno = "SAMURAI ";
            }
            lblPersonaje.Text = turno;
        }

        bool randomBool = GetRandomBool();
        public static bool GetRandomBool()
        {
            Random rand = new Random();
            return rand.Next(2) == 0;
        }

        private void FrmPelea_Load(object sender, EventArgs e)
        {
            //bloquear los botones hasta desbloquearlos con boton iniciar
            lblTiempo2.Text = "00";
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
