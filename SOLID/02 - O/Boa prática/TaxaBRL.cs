using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._02___O.Boa_prática
{
    public class TaxaBRL : ITaxaStrategy
    {
        public string CalcularTarifa(decimal valor, string moeda)
        {
            //Operações para a moeda brasileira
            return "Ok";
        }
    }
}
