namespace TemplateMethod.TiposPagamento
{
    public class PagamentoDinheiro : Pagamento
    {
        public PagamentoDinheiro(Gateway gateway, float valor) : base(gateway, valor)
        {
        }

        protected override float calculaDesconto()
        {
            return (float)(Valor * 0.1);
        }
    }
}

