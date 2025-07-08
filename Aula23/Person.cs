
namespace Aula23
{
    internal class Person
    {
        //1 Atributos
        public String Name;
        public int Age;


        //2 Metodos
       public bool ifLegalAge(int age)
        {
            if (age >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string canDrink(int age)
        {
            string response = string.Empty;
            if (age >= 18)
            {
                response = "Pode beber";
                return response;
            }
            else
            {
                response = "Não pode beber";
                return response;
            }
        }

        public string canDrink2(int age, string name)
        {
            string response = string.Empty;
            if (age >= 18)
            {
                response = $"A pessoa {name} pode beber";
                return response;
            }
            else
            {
                response = $"A pessoa {name} não pode beber";
                return response;
            }
        }





    }
}
