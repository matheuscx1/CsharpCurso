namespace Aula17;

public class Program
{
    public static void Main()
    {
       //1. Declaração comm inicialização de valores
       List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };


        Console.WriteLine("--------------------------");


        //2 Acessar os valores
        Console.WriteLine(numeros[2]);

        Console.WriteLine("--------------------------");

        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }

        //3. Adicionar valores
        numeros.Add(6);
        numeros.Add(7);
        Console.WriteLine("--------------------------");
        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }

        //4. Remover valores
        numeros.Remove(7);
        Console.WriteLine("--------------------------");
        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }

        //5 Contar valores
        Console.WriteLine($"Total de valores: {numeros.Count}");

        //6 Modificar valores
        numeros[0] = 10;
        Console.WriteLine("--------------------------");
        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }

        //7 Limpar a lista
        numeros.Clear();
        foreach (int numero in numeros)
        {
            Console.WriteLine(numero);
        }

        Console.WriteLine("--------------------------");

        //8 Declarar sem inicialização
        List<int> numeros2 = new List<int>();
        numeros2.Add(20);
        numeros2.Add(35);

        foreach (int numero in numeros2)
        {
            Console.WriteLine(numero);
        }

    }
}