using System;
using Namespace;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // Malabarista
            Malabarista malabarista = new Malabarista("Wendell", 15, DateTime.Parse("2023-10-09"), DateTime.Parse("2023-10-15"), 4);
            malabarista.ExibirInformacoes();
            Console.WriteLine();  // Adiciona linha em branco

            // Equilibrista
            Equilibrista equilibrista = new Equilibrista("Aline", 20, DateTime.Parse("2023-10-12"), DateTime.Parse("2023-10-20"), 5.0);
            equilibrista.ExibirInformacoes();
            Console.WriteLine();  // Adiciona linha em branco

            // Palhaço
            Palhaco palhaco = new Palhaco("Vagner", 10, DateTime.Parse("2023-10-10"), null, 5);
            palhaco.ExibirInformacoes();
        }
        catch (Exception e)
        {
            Console.WriteLine($"Ocorreu um erro: {e.Message}");
        }
    }
}



