using System;
namespace TemplateMethod.TiposPagamento
{
    abstract public class Pagamento
    {
        protected float Valor { get; set; }
        protected Gateway Gateway { get; set; }

        protected Pagamento(Gateway gateway, float valor)
        {
            Gateway = gateway;
            Valor = valor;
        }

        abstract protected float calculaDesconto();

        protected virtual float calculaTaxa()
        {
            return 0;
        }

        public bool realizaCobranca()
        {
            float valorFinal = Valor + calculaTaxa() - calculaDesconto();
            Console.Write($"{GetType().Name}: ");
            return Gateway.cobrar(valorFinal);
        }
    }
}

