using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrySamuraiVsNinja
{
    internal class clsSAMURAI :clsPersonaje
    {
        public int AtaqueS { get; set; } = 20;
        public int AtaqueE { get; set; } = 30;

        public clsSAMURAI()
        {
            NOMBRE = "SAMURAI";
            VIDA = 100; // Asumiendo una vida inicial
            MANA = 100;
        }

        public int AtaqueSimple()
        {
            return AtaqueS;
        }

        public int AtaqueEspecial()
        {
            return AtaqueE;
        }

    }
}
