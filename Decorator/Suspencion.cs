namespace Decorator
{
    internal class Suspencion : IComponente
    {
        private IComponente tuneamos;
        public Suspencion(IComponente _Componente)
        {
            tuneamos = _Componente;
        }

        public override string ToString()
        {
            return "Suspencion deportiva\r\n" + tuneamos.ToString();
        }

        public double Costo()
        {
            return tuneamos.Costo() + 4000;
        }

        public string Funciona()
        {
            return tuneamos.Funciona() + ", Bajando Suspencion";
        }

       
    }
}
