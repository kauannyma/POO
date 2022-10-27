using Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Caneta caneta = new Caneta("Azul", "Bic", "Plastico");

        caneta.Escrever("Lab 02");

        Lapis lapis = new Lapis("2B");
        lapis.QuebrarPonta();
        lapis.Apontar();
        lapis.Escrever("Teste");
    }
}