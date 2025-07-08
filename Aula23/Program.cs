namespace Aula23
{
    public class Program
    {
        static void Main(string[] args)
        {
            //1. Criar instância da classe Person
            Person person = new Person();
            //2. Metodos
            Console.WriteLine("Digite o nome da pessoa:");
            person.Name = Console.ReadLine();


            Console.WriteLine("Digite a idade da pessoa:");
            int age = Convert.ToInt32(Console.ReadLine());
            //person.ifLegalAge(age);

            //bool ifLegal = person.ifLegalAge(age);

            //if (ifLegal)
            //{
            //    Console.WriteLine($"A pessoa {person.Name} é maior de idade.");
            //}
            //else
            //{
            //    Console.WriteLine($"A pessoa {person.Name} é menor de idade.");
            //}

            //Chamando o método canDrink e guardando a resposta na variável response
            string response = person.canDrink2(age, person.Name);
            Console.WriteLine($"Resposta: {response}");



        }
    }
}
