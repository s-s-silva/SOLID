using SOLID._01___S.Má_prática;

namespace SOLID._05___D.Boa_prática
{
    public class Funcionario
    {
        #region * Propriedades *
        public Funcao cargo { get; set; }
        public bool ehAtivo { get; set; }
        public string? CPF { get; set; }
        #endregion

        #region  * Métodos *
        public bool validarFuncionario(Funcao cargo)
        {
            if (!ehAtivo || !Enum.IsDefined(typeof(Funcao), cargo) || string.IsNullOrEmpty(CPF))
            {
                return false;
            }

            return true;
        }
        #endregion
    }
}
