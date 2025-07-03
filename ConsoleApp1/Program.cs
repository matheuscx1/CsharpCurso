namespace Aula10;

public class Program
{
    public static void Main()
    {

        bool continuar = true;

        while (continuar)
        {

            Console.WriteLine("=====Calculadora Simples=====");
            Console.WriteLine("Digite o primeiro número:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo número:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            //Selecionar a operação
            Console.WriteLine("Selecione a operação:");
            Console.WriteLine("1 - Adição (+)");
            Console.WriteLine("2 - Subtração (-)");
            Console.WriteLine("3 - Multiplicação (*)");
            Console.WriteLine("4 - Divisão (/)");
            int operacao = Convert.ToInt32(Console.ReadLine());
            double resultado = 0;
            if (operacao == 1)
            {
                resultado = num1 + num2;
                Console.WriteLine($"Resultado: {num1} + {num2} = {resultado}");
            }
            else if (operacao == 2)
            {
                resultado = num1 - num2;
                Console.WriteLine($"Resultado: {num1} - {num2} = {resultado}");
            }
            else if (operacao == 3)
            {
                resultado = num1 * num2;
                Console.WriteLine($"Resultado: {num1} * {num2} = {resultado}");
            }
            else if (operacao == 4)
            {
                if (num2 != 0)
                {
                    resultado = num1 / num2;
                    Console.WriteLine($"Resultado: {num1} / {num2} = {resultado}");
                }
                else
                {
                    Console.WriteLine("Erro: Divisão por zero não é permitida.");
                }
            }
            else
            {
                Console.WriteLine("Operação inválida.");
            }


            //Perguntar se deseja continuar
            Console.WriteLine("Deseja realizar outra operação? (s/n)");
            string resposta = Console.ReadLine().ToLower();
            if (resposta == "s")
            {
                continuar = true;
            }
            else if (resposta == "n")
            {
                continuar = false;
            }
            else
            {
                Console.WriteLine("Resposta inválida. Encerrando o programa.");
                continuar = false;
            }

        }


    }
}
