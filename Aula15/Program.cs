namespace Aula15;

public class Program
{
    public static void Main()
    {
        //Coleção (lista)
        List<string> nomes = new List<string>() {"Maca", "Banana", "Laranja"};

        //para cada elemento da coleção nomes guarde o elemento na variável nome
        foreach (var nome in nomes)
        {
            Console.WriteLine(nome);
        }

    }
}
