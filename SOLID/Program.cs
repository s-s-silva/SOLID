
using SOLID._02___O.Boa_prática;
using SOLID._01___S.Boa_prática;
using SOLID._01___S.Má_prática;

#region SingleResponsibilityPrinciple
var funcionario = new Funcionario();
funcionario.ehAtivo = true;
funcionario.CPF = "477.746.458-02";

var funcionario2 = new FuncionariosService();
funcionario2.AddFuncionario(funcionario, Funcao.Bartender);
#endregion

#region Open/Closed
var taxaEUR = new Taxa(new TaxaEUR());
taxaEUR.moeda = "EUR";
taxaEUR.valor = 50;
taxaEUR.CalcularTarifa();
#endregion



