using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._03___L.Má_prática
{
    public class Pinguim : Ave
    {
        public override void bicar()
        {
            //Intruções para bicar
            base.bicar();
        }

        public override void voar()
        {
            /*
            Pinguim não voa, logo a classe pai teria que ser modificada
            para outra forma de locomoção, andar.

            Por conseguinte, caso a classe pai seja excluída e a classe 
            Pinguim seja escolhida como classe pai, a classe Passaro quebra
            e infringe o Princípio da Substituição de Liskov. 
            */

            base.voar();
        }
    }
}
