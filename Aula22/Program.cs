namespace Aula22;

public class Program
{
    public static void Main()
    {
        //1 criar a sintancia bank
        var bankpraia = new Bank();
        //2 atribuir valores aos atributos
        bankpraia.Name = "Bank Praia";

        bankpraia.OpenAccount();
    }
}
