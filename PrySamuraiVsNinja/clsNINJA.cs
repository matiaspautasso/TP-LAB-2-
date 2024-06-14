using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrySamuraiVsNinja
{
    internal class clsNINJA :clsPersonaje
    {
         
        public int AtaqueS {  get; set; }   
        public int AtaqueE {  get; set; }   

        public clsNINJA() 
        {
        AtaqueS = 20;
        AtaqueE = 30;
        }   
        //aca debe tener el ataque espcial y simple de ninja
      


    }
}
