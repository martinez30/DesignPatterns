namespace State.impl;

public class CanceladoState : State
{
    private Pedido _pedido;
    
    public CanceladoState(Pedido pedido)
    {
        _pedido = pedido;
    }

    public void sucessoAoPagar()
    {
        throw new InvalidOperationException("Operação não suportada, o pedido foi cancelado.");
    }

    public void despacharPedido()
    {
        throw new InvalidOperationException("Operação não suportada, o pedido foi cancelado.");
    }

    public void cancelarPedido()
    {
        throw new InvalidOperationException("Operação não suportada, o pedido já foi cancelado.");
    }
}