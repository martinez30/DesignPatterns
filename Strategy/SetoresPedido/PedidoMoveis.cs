namespace Strategy.SetoresPedido
{
    public class PedidoMoveis : Pedido
    {
        public PedidoMoveis(ITipoFrete tipoFrete) : base("Móveis", tipoFrete) { }
    }
}

