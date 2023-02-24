namespace Strategy.SetoresPedido
{
    public class PedidoEletronico : Pedido
    {
        public PedidoEletronico(ITipoFrete tipoFrete) : base("Eletrônicos", tipoFrete) { }
    }
}

