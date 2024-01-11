
using SOLID._02___O.Boa_prática;


#region Open/Closed
var taxaEUR = new Taxa(new TaxaEUR());
taxaEUR.moeda = "EUR";
taxaEUR.valor = 50;
taxaEUR.CalcularTarifa();
#endregion



