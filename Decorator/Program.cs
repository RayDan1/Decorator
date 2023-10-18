//El patron Decorator permite agregar funcionalidades a un objeto de forma dinamica(En tiempo de ejecucion)
//sin afectar a otros objetos de la misma clase.  

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            IComponente miCarro = new Carro("2017", "2 puertas", 200000);

            Console.WriteLine(miCarro);

            ((Carro)miCarro).Puertas(true);

            Console.WriteLine("-------------------------");

            miCarro = new SistemaSonido(miCarro);
            Console.WriteLine(miCarro.Costo());
            Console.WriteLine(miCarro.Funciona());
            Console.WriteLine(miCarro);
            ((SistemaSonido)miCarro).Usan();

            Console.WriteLine("-------------------------");


            miCarro = new Nitro(miCarro);

            Console.WriteLine(miCarro.Costo());
            Console.WriteLine(miCarro.Funciona());
            Console.WriteLine(miCarro);
            ((Nitro)miCarro).Usan();

            Console.WriteLine("-------------------------");

            miCarro = new Suspencion(miCarro);
            Console.WriteLine(miCarro.Costo());
            Console.WriteLine(miCarro.Funciona());
            Console.WriteLine(miCarro);

            Console.WriteLine("-------------------------");

            miCarro = new Blindaje(miCarro);
            Console.WriteLine(miCarro.Costo());
            Console.WriteLine(miCarro.Funciona());
            Console.WriteLine(miCarro);

            Console.WriteLine("-------------------------");


        }
    }
}