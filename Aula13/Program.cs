namespace Aula13;

public class Program
{
    public static void Main(string[] args)
    {
        int i = 1; //Declara a variável i e inicializa com 1

        do
        {   //O codigo dentro do 'do' será executado pelo menos uma vez, sem checar a condição
            Console.WriteLine($"Valor de i: {i}");//Imprime o valor de i
            i++;//Incrementa o valor de i em 1
        } while (i <= 10);
        //Depois de executar o bloco do 'do', verifica i é menor ou igual a 10, se for, repete o bloco do 'do'
        //se for true, o bloco do 'do' é executado novamente, caso contrário, o loop termina.
    }
}
