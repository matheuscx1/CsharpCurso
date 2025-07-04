namespace Aula16;

public class Program
{
    public static void Main()
    {
        //1. Declaracao de array
        string[] fruits = { "Morango", "Uva", "Pera", "Maracuja" };

        //2 Acessar os elementos do array
        Console.WriteLine(fruits[3]);

        Console.WriteLine("-------------------------");


        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
        Console.WriteLine("-------------------------");

        //3 Quantidade de elementos no array
        Console.WriteLine($"Quantidade de elementos no array: {fruits.Length}");


        Console.WriteLine("-------------------------");

        //4 Alterar o valor de um elemento do array
        fruits[0] = "Abacaxi";
        Console.WriteLine($"Novo valor do primeiro elemento: {fruits[0]}");

        Console.WriteLine("-------------------------");

        //5 Declaração sem inicialização
        int[] numbers = new int[3];

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

    }
}