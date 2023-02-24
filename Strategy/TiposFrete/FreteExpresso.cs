namespace Strategy.TiposFrete
{
    public class FreteExpresso : ITipoFrete
    {
        public float calcula(float valor) => (float)(valor * 0.1);
    }
}

