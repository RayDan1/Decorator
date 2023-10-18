namespace Decorator
{
    internal class SistemaSonido : IComponente
    {
        private IComponente tuneamos;
        public SistemaSonido(IComponente _Componente)
        {
            tuneamos = _Componente;
        }

        public override string ToString()
        {
            return "Estereo mamalon\r\n" + tuneamos.ToString();
        }

        public double Costo()
        {
            return tuneamos.Costo() + 2000;
        }

        public string Funciona()
        {
            return tuneamos.Funciona() + ", Estereo encendido";
        }

        public void Usan()
        {
              Console.WriteLine("Sonido en uso");
        }
    }
}
