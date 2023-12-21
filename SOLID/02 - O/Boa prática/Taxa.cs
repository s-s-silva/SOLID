using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SOLID._02___O.Boa_prática
{
    public class Taxa
    {
        #region * Propriedades e dependências *
        public decimal valor {  get; set; }
        public string moeda { get; set; }

        private readonly ITaxaStrategy _taxaStrategy;

        public Taxa(ITaxaStrategy taxaStrategy)
        {
            _taxaStrategy = taxaStrategy;
        }
        #endregion

        #region * Métodos *
        public string CalcularTarifa()
        { 
            _taxaStrategy.CalcularTarifa(valor, moeda);
            return "Ok";
        }
        #endregion
    }
}
