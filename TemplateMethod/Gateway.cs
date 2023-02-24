namespace TemplateMethod
{
    public class Gateway
    {
        public bool cobrar(float valor)
        {
            Console.WriteLine(valor + "\n");
            return true | false;
        }
    }
}

