namespace State.impl;

public class EnviadoState : State
{
    private Pedido _pedido;
    
    public EnviadoState(Pedido pedido)
    {
        _pedido = pedido;
    }

    public void sucessoAoPagar()
    {
        throw new InvalidOperationException("Operação não suportada, o pedido já foi pago e enviado.");
    }

    public void despacharPedido()
    {
        throw new InvalidOperationException("Operação não suportada, o pedido já foi enviado.");
    }

    public void cancelarPedido()
    {
        throw new InvalidOperationException("Operação não suportada, o pedido já foi enviado.");
    }
}