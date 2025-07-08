namespace Aula21;

public class Program
{

    //Aplicacao de console
    public static void Main()
    {
        //1. Instancia(objeto) a classe cake
        Cake strawberryCake = new Cake();

        //2. Atribui valores aos atributos
        strawberryCake.Id = 1;
        strawberryCake.Name = "Bolo de Morango";
        strawberryCake.Description = "Bolo de Morango com cobertura de chantilly";
        strawberryCake.Price = 25;
        strawberryCake.isfilled = true;

        //3. Imprime os valores dos atributos
        Console.WriteLine($"Id: {strawberryCake.Id}");
        Console.WriteLine($"Nome: {strawberryCake.Name}");
        Console.WriteLine($"Description: {strawberryCake.Description}");
        Console.WriteLine($"Price: {strawberryCake.Price}");
        Console.WriteLine($"isfilled: {strawberryCake.isfilled}");


        //---------------------------------
        //4. Instancia de bolo de chocolate
        Cake chocolateCake = new Cake();

        //5. Atribui valores aos atributos
        chocolateCake.Id = 2;
        chocolateCake.Name = "Bolo de Chocolate";
        chocolateCake.Description = "Bolo de Chocolate com cobertura de chocolate";
        chocolateCake.Price = 30;
        chocolateCake.isfilled = false;

        //6. Imprime os valores dos atributos
        Console.WriteLine($"Id: {chocolateCake.Id}");
        Console.WriteLine($"Nome: {chocolateCake.Name}");
        Console.WriteLine($"Description: {chocolateCake.Description}");
        Console.WriteLine($"Price: {chocolateCake.Price}");
        Console.WriteLine($"isfilled: {chocolateCake.isfilled}");

        //---------------------------------
        //7. Lista de bolos
        Console.WriteLine("\nLista de Bolos:");
        List<Cake> cakes = new List<Cake>();
        cakes.Add(strawberryCake);
        cakes.Add(chocolateCake);

        //8 Vizualiza a lista de bolos
        foreach (var cake in cakes)
        {
            Console.WriteLine($"Id: {cake.Id}, Nome: {cake.Name}, Description: {cake.Description}, Price: {cake.Price}, isfilled: {cake.isfilled}");
        }

        Console.ReadLine();
    }
}