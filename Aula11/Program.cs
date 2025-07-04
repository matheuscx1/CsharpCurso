namespace Aula11;

public class Program
{
    public static void Main()
    {
        //int number = 1;

        //switch(number)
        //{
        //    case 1:
        //        Console.WriteLine("Number is one");
        //        break;
        //    case 2:
        //        Console.WriteLine("Number is two");
        //        break;
        //    case 3:
        //        Console.WriteLine("Number is three");
        //        break;
        //    default:
        //        Console.WriteLine("Number is something else");
        //        break;
        //}

        Console.WriteLine("=====Dia da semana=====");
        Console.WriteLine("Digite um número de 1 a 7:");
        int dayofWeek = Convert.ToInt32(Console.ReadLine());
        switch(dayofWeek)
        {
            case 1:
                Console.WriteLine("Domingo");
                break;
            case 2:
                Console.WriteLine("Segunda-feira");
                break;
            case 3:
                Console.WriteLine("Terça-feira");
                break;
            case 4:
                Console.WriteLine("Quarta-feira");
                break;
            case 5:
                Console.WriteLine("Quinta-feira");
                break;
            case 6:
                Console.WriteLine("Sexta-feira");
                break;
            case 7:
                Console.WriteLine("Sábado");
                break;
            default:
                Console.WriteLine("Número inválido. Por favor, digite um número de 1 a 7.");
                break;
        }



    }
}
