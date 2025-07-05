namespace Aula19;
using System.IO;


public class Program
{
    public static void Main()
    {

        //1 Estrutura de diretórios
        string path = @"D:\Users\mathe\CsharpCurso\Aula19";
        string fileName = "lista_de_compras.txt";
        string filePath = path + fileName;

        List<string> shoppingList = new List<string>();

        //Logica para ler o arquivo
        if (File.Exists(filePath))
        {
            shoppingList.AddRange(File.ReadAllLines(filePath));


        }
        while (true)
        {
            Console.WriteLine("\n=== Lista de compras ===");
            Console.WriteLine("1. Adicionar item");
            Console.WriteLine("2. Remover item");
            Console.WriteLine("3. Listar itens");
            Console.WriteLine("4. Limpar lista");
            Console.WriteLine("5. Sair");

            string choiceUser = Console.ReadLine();

            switch (choiceUser)
            {

                case "1":
                    Console.Write("Digite o item a ser adicionado: ");
                    string itemToAdd = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(itemToAdd))
                    {
                        Console.WriteLine("O item não pode ser vazio. Tente novamente.");
                        continue;
                    }
                    shoppingList.Add(itemToAdd);
                    File.WriteAllLines(filePath, shoppingList);
                    Console.WriteLine($"Item '{itemToAdd}' adicionado com sucesso!");
                    break;

                case "2":
                    Console.Write("Digite o item a ser removido: ");
                    string itemToRemove = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(itemToRemove))
                    {
                        Console.WriteLine("O item não pode ser vazio. Tente novamente.");
                        continue;
                    }
                    if (shoppingList.Remove(itemToRemove))
                    {
                        File.WriteAllLines(filePath, shoppingList);
                        Console.WriteLine($"Item '{itemToRemove}' removido com sucesso!");
                    }
                    else
                    {
                        Console.WriteLine($"Item '{itemToRemove}' não encontrado na lista.");
                    }
                    break;

                case "3":
                    Console.WriteLine("Itens na lista de compras:");
                    if (shoppingList.Count == 0)
                    {
                        Console.WriteLine("A lista de compras está vazia.");
                    }
                    else
                    {
                        foreach (string item in shoppingList)
                        {
                            Console.WriteLine($"- {item}");
                        }
                    }
                    break;

                case "4":
                    shoppingList.Clear();
                    File.WriteAllLines(filePath, shoppingList);
                    Console.WriteLine("Lista de compras limpa com sucesso!");
                    break;

                case "5":
                    Console.WriteLine("Saindo do programa...");
                    return;
                default:
                    Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
                    break;

            }
        }

    }
}