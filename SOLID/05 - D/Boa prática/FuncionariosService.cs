using SOLID._01___S.Má_prática;

namespace SOLID._05___D.Boa_prática
{
    public class FuncionariosService
    {
        private IFuncionarioRepository _funcionarioRepository;

        public FuncionariosService(IFuncionarioRepository funcionarioRepository)
        {
            _funcionarioRepository = funcionarioRepository;
        }
        public string AddFuncionario(Funcionario funcionario, Funcao cargo)
        {
            if(!funcionario.validarFuncionario(cargo))
            {
                return "Funcionário Inválido";
            }

            _funcionarioRepository.registraFuncionario(funcionario);

            return "Funcionário adicionado"; 
        }
    }
}
