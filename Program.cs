using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.WriteLine("Escolha uma opção:");
        Console.WriteLine("1 - Contagem Progressiva");
        Console.WriteLine("2 - Contagem Regressiva");
        Console.Write("Opção: ");
        string opcao = Console.ReadLine();

        Console.WriteLine();

        Console.WriteLine("Digite o número inicial:");
        int inicio = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o número final:");
        int fim = int.Parse(Console.ReadLine());

        Console.WriteLine("\nContando...\n");
        Thread.Sleep(500);

        if (opcao == "1")
        {
            if (inicio <= fim)
            {
                for (int i = inicio; i <= fim; i++)
                {
                    Console.WriteLine(i);
                    Thread.Sleep(200);
                }
            }
            else
            {
                Console.WriteLine("Erro: Para contagem progressiva, o número inicial deve ser menor que o final.");
            }
        }
        else if (opcao == "2")
        {
            if (inicio >= fim)
            {
                for (int i = inicio; i >= fim; i--)
                {
                    Console.WriteLine(i);
                    Thread.Sleep(200);
                }
            }
            else
            {
                Console.WriteLine("Erro: Para contagem regressiva, o número inicial deve ser maior que o final.");
            }
        }
        else
        {
            Console.WriteLine("Opção inválida.");
        }

        Console.WriteLine("\nFim da contagem!");
    }
}
