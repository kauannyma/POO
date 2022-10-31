using Models;

namespace Oficina
{
    internal class Program
    {
       private static void Main(string[] args)
        {
            Carro poxer = new Carro("Ferrari", "Esportivo");

            poxer.LigarDesligar();
            poxer.Abastecer(100);

            poxer.Exibir();
        }
    }
}
