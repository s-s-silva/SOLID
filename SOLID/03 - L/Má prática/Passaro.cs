using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._03___L.Má_prática
{
    public class Passaro : Ave
    {
        public override void bicar()
        {
            //Intruções para bicar
            base.bicar();
        }

        public override void voar()
        {
            //Intruções para voar
            base.voar();
        }
    }
}
