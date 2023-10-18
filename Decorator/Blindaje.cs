namespace Decorator
{
    internal class Blindaje : IComponente
    {
        private IComponente tuneamos;
        public Blindaje(IComponente _Componente)
        {
            tuneamos = _Componente;
        }

        public override string ToString()
        {
            return "Blindaje\r\n" + tuneamos.ToString();
        }

        public double Costo()
        {
            return tuneamos.Costo() + 10000;
        }

        public string Funciona()
        {
            return tuneamos.Funciona() + ", Blindaje listo";
        }

    }
}
