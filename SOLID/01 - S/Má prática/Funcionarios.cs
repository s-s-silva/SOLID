using SOLID._01___S.Má_prática; 

namespace SOLID._01___S.Má_pratica
{
    public class Funcionarios
    {
        #region * Propriedades *
        public Funcao cargo { get; set; }
        public bool ehAtivo { get; set; }
        public string? CPF { get; set; }
        #endregion

        #region * Métodos *

        public string AddFuncionario()
        {
            #region Validar funcionário
            if (!ehAtivo || !Enum.IsDefined(typeof(Funcao), cargo) || string.IsNullOrEmpty(CPF))
            {
                return "Funcionário inválido";
            }
            #endregion

            #region Registrar funcionário
            // Intruções para registrar funcionário no banco de dados
            #endregion

            return "Ok";
        }

        #endregion
    }
}
