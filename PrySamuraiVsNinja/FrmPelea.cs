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
            DBA =new conexionDBA ();    
        }
        //
        private clsNINJA ninja;
        private clsSAMURAI samurai;
        private bool TURNO;
        private Timer timer1;
        private int duration;
        private conexionDBA DBA;


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

        private void btnAtaqueSimple_Click(object sender, EventArgs e)
        {
            //btnataque simple: 
            if (TURNO==true)
            {
                samurai.RecibirDanio(ninja.AtaqueSimple());
                lstConsola.Items.Add($"NINJA ataca y SAMURAI tiene {samurai.VIDA} de vida restante.");
            }
            else //si es false
            {
                ninja.RecibirDanio(samurai.AtaqueSimple());
                lstConsola.Items.Add($"SAMURAI ataca y NINJA tiene {ninja.VIDA} de vida restante.");
            }

            if (samurai.VIDA <= 0)
            {
                MessageBox.Show("NINJA gana!");
                DBA.ActualizarVictorias(ninja.ID);  //ERROR ACA  _+
                DBA.ActualizarDerrotas(samurai.ID);
                ResetGame();
            }
            else
            if (ninja.VIDA <= 0)
            {
                MessageBox.Show("SAMURAI gana!");
                DBA.ActualizarVictorias(samurai.ID);
                DBA.ActualizarDerrotas(ninja.ID);
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

            if (TURNO)
            {
                lblPersonaje.Text = "NINJA";
            }
            else
            {
                lblPersonaje.Text = "SAMURAI";
            }

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

        private void btnDescansar_Click(object sender, EventArgs e) //btnDecansar
        {
            //este boton debe cederle el turno al rival 
            //recordar si es true es ninja si es false samurai

            string jugadorActual;
            string rival;

            if (TURNO)
            {
                jugadorActual = "NINJA";
                rival = "SAMURAI";
                TURNO = false; // Ceder turno al SAMURAI
            }
            else
            {
                jugadorActual = "SAMURAI";
                rival = "NINJA";
                TURNO = true; // Ceder turno al NINJA
                if (TURNO)
                {
                    lblPersonaje.Text = "NINJA";
                }
                else
                {
                    lblPersonaje.Text = "SAMURAI";
                }

            }

            lstConsola.Items.Add($"{jugadorActual} le cede su turno a {rival}");

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

        private void btnAtaqueEspecial_Click(object sender, EventArgs e) //btnAtaqueEspecial   
        {
            if (TURNO)
            {
                if (ninja.MANA >= 30)
                {
                    samurai.RecibirDanio(ninja.AtaqueEspecial());
                    ninja.ConsumirMana(30);
                    lstConsola.Items.Add($"NINJA usa ataque especial y SAMURAI tiene {samurai.VIDA} de vida restante." +
                        $" NINJA tiene {ninja.MANA} de mana restante.");
                }
                else
                {
                    lstConsola.Items.Add("NINJA no tiene suficiente mana para usar el ataque especial.");
                    return;
                }
            }
            else
            {
                if (samurai.MANA >= 30)
                {
                    ninja.RecibirDanio(samurai.AtaqueEspecial());
                    samurai.ConsumirMana(30);
                    lstConsola.Items.Add($"SAMURAI usa ataque especial y NINJA tiene {ninja.VIDA}" +
                        $" de vida restante. SAMURAI tiene {samurai.MANA} de mana restante.");
                }
                else
                {
                    lstConsola.Items.Add("SAMURAI no tiene suficiente mana para usar el ataque especial.");
                    return;
                }
            }

            if (samurai.VIDA <= 0)
            {
                MessageBox.Show("NINJA gana!");
                DBA.ActualizarVictorias(ninja.ID);
                DBA.ActualizarDerrotas(samurai.ID);
                ResetGame();
            }
            else
            if (ninja.VIDA <= 0)
            {
                MessageBox.Show("SAMURAI gana!");
                DBA.ActualizarVictorias(samurai.ID);
                DBA.ActualizarDerrotas(ninja.ID);
                ResetGame();
            }
            else
            {
                ControlDeTurno(); // Cambiar de turno después de un ataque
            }

        }
    }
}
