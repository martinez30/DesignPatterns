namespace Strategy.TiposFrete
{
    public class FreteComum : ITipoFrete
    {
        public float calcula(float valor) => (float)(valor * 0.05);
    }
}

