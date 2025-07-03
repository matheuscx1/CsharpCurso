namespace Aula03;

    public class Program
    {
        public static void Main()
        {
          
        int number = 10;
        number = 20;
        number = 10; //A ultima declaracao é a que vale
        Console.WriteLine("O valor da variável é:" + number); // Saída: 10

        const int numberConst = 30;// Constante, não pode ser alterada
        // numberConst = 40; // Isso causaria um erro de compilação, pois não é possível alterar uma constante
        var variable = 50; // Variável implícita, tipo inferido pelo compilador, pode ser qualquer tipo


    }
}
