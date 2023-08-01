namespace State.impl;

public class AguardandoPagamentoState : State
{
    private Pedido _pedido;

    public AguardandoPagamentoState(Pedido pedido)
    {
        _pedido = pedido;
    }

    public void sucessoAoPagar()
    {
        _pedido.setEstadoAtual(_pedido.getPago());
    }

    public void despacharPedido()
    {
        throw new InvalidOperationException("Operação não suportada, o pedido ainda não foi pago.");
    }

    public void cancelarPedido()
    {
        _pedido.setEstadoAtual(_pedido.getCancelado());
    }
}