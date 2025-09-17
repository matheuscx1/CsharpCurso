namespace Aula02;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Qual é o seu nome?");
        string nome = Console.ReadLine();
        
        Console.WriteLine($"Prazer em te conhecer, {nome}!");
    }
}
