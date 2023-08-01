namespace State.impl;

public class PagoState : State
{
    private Pedido _pedido;
    
    public PagoState(Pedido pedido)
    {
        _pedido = pedido;
    }

    public void sucessoAoPagar()
    {
        throw new InvalidOperationException("Operação não suportada, o pedido já foi pago.");
    }

    public void despacharPedido()
    {
        _pedido.setEstadoAtual(_pedido.getEnviado());
    }

    public void cancelarPedido()
    {
        _pedido.setEstadoAtual(_pedido.getCancelado());
    }
}