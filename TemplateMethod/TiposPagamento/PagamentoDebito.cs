namespace TemplateMethod.TiposPagamento
{
    public class PagamentoDebito : Pagamento
    {
        public PagamentoDebito(Gateway gateway, float valor) : base(gateway, valor)
        {
        }

        protected override float calculaTaxa()
        {
            return 4;
        }

        protected override float calculaDesconto()
        {
            return (float)(Valor * 0.05);
        }
    }
}

