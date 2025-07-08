namespace Aula26;

public class Program
{

    public static void Main()

    {
        //Instancia da classe Cake
        Cake cakeChocolate = new Cake("Chocolate", "Brigadeiro", 3, "Grande");
        Cake cakeChocolate2 = new Cake("Morango", "Baunilha", 2, "Medio");


        Console.WriteLine("Detalhes do Bolo 1:");
        Console.WriteLine($"Sabor: {cakeChocolate.Flavor}");
        Console.WriteLine($"Recheio: {cakeChocolate.Filling}");
        Console.WriteLine($"Tamanho: {cakeChocolate.Size}");
        Console.WriteLine($"Camadas: {cakeChocolate.Layers}");

        Console.WriteLine("\nDetalhes do Bolo 2:");
        Console.WriteLine($"Sabor: {cakeChocolate2.Flavor}");
        Console.WriteLine($"Recheio: {cakeChocolate2.Filling}");
        Console.WriteLine($"Tamanho: {cakeChocolate2.Size}");
        Console.WriteLine($"Camadas: {cakeChocolate2.Layers}");

        Console.ReadLine();
    }


}



