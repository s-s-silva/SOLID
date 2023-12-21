using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID._02___O.Má_prática
{
    public class Taxa
    {
        public required string moeda {  get; set; }
        public string CalcularTarifa()
        {
            if (moeda == "BRL")
            {
                //Operações para a moeda brasileira
            }

            if (moeda == "EUR")
            {
                //Operações para o euro
            }

            if (moeda == "AUD")
            {
                //Operações para o dólar australiano 
            }
            return "OK";
        }
    }
}
