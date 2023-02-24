namespace TemplateMethod.TiposPagamento
{
    public class PagamentoCredito : Pagamento
    {
        public PagamentoCredito(Gateway gateway, float valor) : base(gateway, valor)
        {
        }

        protected override float calculaTaxa()
        {
            return (float)(Valor * 0.05);
        }

        protected override float calculaDesconto()
        {
            if (Valor > 300) return (float)(Valor * 0.02);

            return 0;
        }
    }
}

