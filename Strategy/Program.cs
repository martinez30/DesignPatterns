using Strategy.SetoresPedido;
using Strategy.TiposFrete;

var freteComum = new FreteComum();
var freteExpresso = new FreteExpresso();

var setorEletronico = new PedidoEletronico(freteComum);
var setorMovel = new PedidoMoveis(freteExpresso);

Console.WriteLine($"{nameof(setorEletronico)}: {setorEletronico.calculaFrete(100)}");
Console.WriteLine($"{nameof(setorMovel)}: {setorMovel.calculaFrete(100)}");

Console.ReadKey();