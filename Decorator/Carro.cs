namespace Decorator
{
    internal class Carro : IComponente
    {
        private string modelo;
        private string caracteristicas;
        public double costo;

        public Carro(string _modelo, string _caracteristicas, double _costo)
        {
            modelo = _modelo;
            caracteristicas = _caracteristicas;
            costo = _costo;

        }

        public void Puertas(bool _estado)
        {
            if(_estado)
                Console.WriteLine("Puertas cerradas");
            else
                Console.WriteLine("Puertas abiertas");
        }

        public override string ToString()
        {
            return string.Format("Modelo {0}, {1} \r\n", modelo, caracteristicas);
        }

        public double Costo()
        {
            return costo;
        }

        public string Funciona()
        {
            return "Encendido";
        }
    }
    
    
}
