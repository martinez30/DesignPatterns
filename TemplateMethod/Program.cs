using TemplateMethod;
using TemplateMethod.TiposPagamento;

Gateway gateway = new();
float valor = 1000;

var credito = new PagamentoCredito(gateway, valor);
var debito = new PagamentoDebito(gateway, valor);
var dinheiro = new PagamentoDinheiro(gateway, valor);

credito.realizaCobranca();
debito.realizaCobranca();
dinheiro.realizaCobranca();

Console.ReadKey();