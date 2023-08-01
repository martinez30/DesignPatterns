using State.impl;

namespace State;

public class Pedido
{
    private State _aguardandoPagamento;
    private State _pago;
    private State _cancelado;
    private State _enviado;
    
    private State _state;

    public Pedido()
    {
        _aguardandoPagamento = new AguardandoPagamentoState(this);
        _pago = new PagoState(this);
        _cancelado = new CanceladoState(this);
        _enviado = new EnviadoState(this);
        
        _state = _aguardandoPagamento;
    }
    
    public void realizarPagamento()
    {
        try
        {
            _state.sucessoAoPagar();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void cancelarPedido()
    {
        try
        {
            _state.cancelarPedido();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void despacharPedido()
    {
        try
        {
            _state.despacharPedido();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public void setEstadoAtual(State state)
    {
        _state = state;
    }
    
    public State getAguardandoPagamento() => _aguardandoPagamento;
    public State getPago() => _pago;
    public State getCancelado() => _cancelado;
    public State getEnviado() => _enviado;
}