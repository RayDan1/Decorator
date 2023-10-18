namespace Decorator
{
    internal class Nitro : IComponente
    {
        private IComponente tuneamos;
        public Nitro(IComponente _Componente)
        {
            tuneamos = _Componente;
        }

        public override string ToString()
        {
            return "Sistema de Nitro\r\n" + tuneamos.ToString();
        }

        public double Costo()
        {
            return tuneamos.Costo() + 5000;
        }

        public string Funciona()
        {
            return tuneamos.Funciona() + ", Nitro listo";
        }

        public void Usan()
        {
              Console.WriteLine("Nitro en uso");
        }
    }
}
