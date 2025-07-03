using System;

namespace Aula09;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("====Operadores Lógicos====");

        bool isLoggedIn = true;
        bool isAdmin = false;

        Console.WriteLine("\nInformações do Usuário");
        Console.WriteLine($"Usuário está logado: {isLoggedIn}");
        Console.WriteLine("Acesso ao  painel de administração: " + isLoggedIn);
        Console.WriteLine("\nPermissoes");

        //Operador (||) - OR lógico
        if(isLoggedIn || isAdmin)
        {
            Console.WriteLine("Usuário tem acesso ao painel de administração ou está logado.");
        }
        else
        {
            Console.WriteLine("Usuário não tem acesso ao painel de administração e não está logado.");
        }

        //Operador (&&) - AND lógico
        if (isLoggedIn && isAdmin)
        {
            Console.WriteLine("Usuário tem acesso ao painel de administração.");
        }
        else
        {
            Console.WriteLine("Usuário não tem acesso ao painel de administração.");
        }

        //Operador (!) - NOT lógico
        if (!isAdmin)
        {
            Console.WriteLine("Usuário não é um administrador.");
        }
        else
        {
            Console.WriteLine("Usuário é um administrador.");
        }



    }
}


