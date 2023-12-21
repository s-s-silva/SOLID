using SOLID._01___S.Má_prática; 

namespace SOLID._01___S.Boa_prática
{
    public class FuncionariosService
    {
        public string AddFuncionario(Funcionario funcionario, Funcao cargo)
        {
            if(!funcionario.validarFuncionario(cargo))
            {
                return "Funcionário Inválido";
            }

            var _funcionariosRepository = new FuncionariosRepository();
            _funcionariosRepository.registraFuncionario(funcionario);

            return "Funcionário adicionado"; 
        }
    }
}
