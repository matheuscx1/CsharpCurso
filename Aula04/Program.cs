namespace Aula04;

public class Program
{
    public static void Main()
        {
        Console.WriteLine("-----CADASTRO DE USUÁRIO-----");

        //Solicita o nome do usuário
        Console.Write("Digite seu nome: ");
        string name = Console.ReadLine();// Solicita o nome do usuário

        //Solicitar idade
        Console.WriteLine("Digite sua idade");
        int age =  Convert.ToInt32(Console.ReadLine());//converte pra int


        Console.WriteLine("----------------------------");
         
        Console.WriteLine("Nome do Usuario: " + name);
        Console.WriteLine("Idade do usuario: " + age);


    }

}
