namespace Aula05
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("-----CALCULADORA-----");
            Console.WriteLine("Digite o primeiro número: ");
            int input1 = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int input2 = Convert.ToInt32 (Console.ReadLine());


            int sum = input1 + input2;
            int subtraction = input1 - input2;
            int multiplication = input1 * input2;
            int division = input1 / input2;
            int modulo = input1 % input2;
            Console.WriteLine("A soma é: " + sum);
            Console.WriteLine("A subtração é: " + subtraction);
            Console.WriteLine("A multiplicação é: " + multiplication);
            Console.WriteLine("A divisão é: " + division);
            Console.WriteLine("O módulo é: " + modulo);
        }
    }

}
