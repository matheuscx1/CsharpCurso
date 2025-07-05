namespace Aula18;
using System.IO; //

public class Program
{
    public static void Main()
    {

        //1. Criar um arquivo

        System.IO.File.WriteAllText("file.txt", "Hello World!");

        Console.WriteLine("Arquivo criado com sucesso!");

        //2. Criar arquivo em um diretório específico

        //string directoryPath = "D:\\Users\\mathe\\CsharpCurso\\Aula18\\fileName.txt";
        //string content = "Hello World";

        //File.WriteAllText(directoryPath, content);
        //Console.WriteLine("Arquivo criado com sucesso!");

        //3. Criar arquivo word

        //string directoryPath = "D:\\Users\\mathe\\CsharpCurso\\Aula18\\";
        //string fileName = "myDocument.Doc";
        //string filePath = directoryPath + fileName;

        //string content = "Hello World";

        //File.WriteAllText(filePath, content);
        //Console.WriteLine("Arquivo Word criado com sucesso!");

        //4 Inserir um paragrafo em um arquivo existente

        //string directoryPath = "D:\\Users\\mathe\\CsharpCurso\\Aula18\\";
        //string fileName = "myDocument.Doc";
        //string filePath = directoryPath + fileName;

        //string additionalContent = "\nCurso C# e .NET";

        //File.AppendAllText(filePath, additionalContent);

        //Console.WriteLine("Arquivo atualizado com sucesso");

        //5. Ler o arquivo
        string directoryPath = "D:\\Users\\mathe\\CsharpCurso\\Aula18\\";
        string fileName = "myDocument.Doc";
        string filePath = directoryPath + fileName;

        string fileContent = File.ReadAllText(filePath);
        Console.WriteLine(fileContent);




    }
}
