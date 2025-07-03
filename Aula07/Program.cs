namespace Aula07;

public class Program
{ 
    public static void Main()
    {
        Console.WriteLine("=====Operadores de Atribuição=====");

        //Inicializando variáveis
        int a = 10;
        Console.WriteLine($"Valor inicial de a: {a}");

        // Atribuição simples (=)
        a = 20;
        Console.WriteLine($"Valor de a após atribuição simples: {a}");

        //Atribuição Composta (+=)
        a += 5; // Equivalente  a = a + 5

        //Atribuição Composta incremental (++)
        a++; // Equivalente a a = a + 1

        //Atribuição Composta decremental (-=)
        a -= 3; // Equivalente a = a - 3




    }

}
