using System.Security.Cryptography.X509Certificates;

namespace Aula06
{     class Program
    {
        public static void Main()
        {
            Console.WriteLine("====Verificador de numeros Pares ou Ímpares====");
            Console.Write("Digite um número: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("O número {0} é Par.", number);
            }
            else
            {
                Console.WriteLine("O número {0} é Ímpar.", number);
            }

        }
    }
}
