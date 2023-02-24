namespace Strategy.SetoresPedido
{
    abstract public class Pedido
    {
        public ITipoFrete TipoFrete { get; set; }
        protected string Setor { get; set; }

        public float calculaFrete(float valor) => TipoFrete.calcula(valor);

        public Pedido(string setor, ITipoFrete tipoFrete)
        {
            TipoFrete = tipoFrete;
            Setor = setor;
        }
    }
}

