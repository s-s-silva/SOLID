using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._04___I.Má_prática
{
    public class Pinguim :IAve
    {
        public void bicar()
        {
            //Intruções para bicar
        }

        public void voar()
        {
            //Pinguim é ave mas não voa
            throw new NotImplementedException();
        }
    }
}
