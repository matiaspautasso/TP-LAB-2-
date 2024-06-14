using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrySamuraiVsNinja
{
    internal class clsPersonaje
    {
        public int ID { get; set; }
        public string NOMBRE { get; set; }
        public string TIPO { get; set; }
        public int VIDA { get; set; }
        public int DAÑO { get; set; }
        public bool TURNO { get; set; }
        public int MANA { get; set; }   

        public void RecibirDanio(int danio)
        {
            VIDA -= danio;
            if (VIDA < 0) VIDA = 0;
        }
        public void ConsumirMana(int cantidad)
        {
            MANA -= cantidad;
            if (MANA < 0) MANA = 0;
        }



    }
}
