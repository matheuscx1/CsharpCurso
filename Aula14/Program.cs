namespace Aula14;

public class Program
{
    public static void Main()
    {
        for (int i = 0; i < 10; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine($"{i} é par");
            }
            else
            {
                Console.WriteLine($"{i} é ímpar");
            }
        }

        for (int i = 0; i <=3; i++)
        {
            for (int j = 0; j <=3; j++)
            {
                Console.WriteLine($"i: {i}, j: {j}");
            }
            Console.WriteLine("Fim do loop interno");
        }

    }
}

