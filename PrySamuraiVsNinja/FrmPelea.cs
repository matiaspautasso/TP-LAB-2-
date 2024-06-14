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
            ninja = new clsNINJA();
            samurai = new clsSAMURAI();
        }
        //
        private clsNINJA ninja;
        private clsSAMURAI samurai;
        private bool TURNO;
        private Timer timer1;
        private int duration;


        private void btnIniciar_Click(object sender, EventArgs e)
        {
            duration = 40;
            timer1 = new Timer();
            timer1.Tick += new EventHandler(Contador);
            timer1.Interval = 1000;
            timer1.Start();
            ControlDeTurno();
            btnAtaqueSimple.Enabled = true;
            btnDescansar.Enabled = true;



        }
        //

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

        clsNINJA NINJA;
        clsSAMURAI SAMURAI; 

        private void button1_Click(object sender, EventArgs e)
        {
            //btnataque simple: 
            if (TURNO)
            {
                samurai.RecibirDanio(ninja.AtaqueSimple());
                MessageBox.Show($"NINJA ataca y SAMURAI tiene {samurai.VIDA} de vida restante.");
            }
            else
            {
                ninja.RecibirDanio(samurai.AtaqueSimple());
                MessageBox.Show($"SAMURAI ataca y NINJA tiene {ninja.VIDA} de vida restante.");
            }

            if (samurai.VIDA <= 0)
            {
                MessageBox.Show("NINJA gana!");
                ResetGame();
            }
            else if (ninja.VIDA <= 0)
            {
                MessageBox.Show("SAMURAI gana!");
                ResetGame();
            }
            else
            {
                ControlDeTurno(); // Cambiar de turno después de un ataque
            }

        }
      
     

        public void ControlDeTurno()
        {
            TURNO = GetRandomBool();
            lblPersonaje.Text = TURNO ? "NINJA" : "SAMURAI";  //CAMBIAR
        }

        
        public static bool GetRandomBool()
        {
            Random rand = new Random();
            return rand.Next(2) == 0;
        }

        private void FrmPelea_Load(object sender, EventArgs e)
        {
            //bloquear los botones hasta desbloquearlos con boton iniciar
            lblTiempo2.Text = "00";
            btnAtaqueSimple.Enabled = false;
            btnDescansar.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e) //btnDecansar
        {
            //este boton debe cederle el turno al rival 
            ControlDeTurno();
        }
        private void ResetGame()
        {
            ninja.VIDA = 100;
            samurai.VIDA = 100;
            lblTiempo2.Text = "00";
            btnAtaqueSimple.Enabled = false;
            btnDescansar.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e) //btnAtaqueEspecial
        {
            if (TURNO)
            {
                if (ninja.MANA >= 30)
                {
                    samurai.RecibirDanio(ninja.AtaqueEspecial());
                    ninja.ConsumirMana(30);
                    MessageBox.Show($"NINJA usa ataque especial y SAMURAI tiene {samurai.VIDA} de vida restante. NINJA tiene {ninja.MANA} de mana restante.");
                }
                else
                {
                    MessageBox.Show("NINJA no tiene suficiente mana para usar el ataque especial.");
                }
            }
            else
            {
                if (samurai.MANA >= 30)
                {
                    ninja.RecibirDanio(samurai.AtaqueEspecial());
                    samurai.ConsumirMana(30);
                    MessageBox.Show($"SAMURAI usa ataque especial y NINJA tiene {ninja.VIDA} de vida restante. SAMURAI tiene {samurai.MANA} de mana restante.");
                }
                else
                {
                    MessageBox.Show("SAMURAI no tiene suficiente mana para usar el ataque especial.");
                }
            }

            if (samurai.VIDA <= 0)
            {
                MessageBox.Show("NINJA gana!");
                ResetGame();
            }
            else if (ninja.VIDA <= 0)
            {
                MessageBox.Show("SAMURAI gana!");
                ResetGame();
            }
            else
            {
                ControlDeTurno();
            }

        }
    }
}
