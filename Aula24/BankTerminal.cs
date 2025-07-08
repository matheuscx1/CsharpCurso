namespace Aula24
{
    internal class BankTerminal
    {

        BankOperation bank = new BankOperation();

        public void Run()
        {
            while (true)
            {
                DisplayMenu();
                Console.WriteLine("Escolha uma opção:");
                if (int.TryParse(Console.ReadLine(), out int option))
                {
                    switch (option)
                    {
                        case 1:
                            bank.checkBalance();
                            break;
                        case 2:
                            bank.Deposit();
                            break;
                        case 3:
                            bank.Withdraw();
                            break;
                        case 4:
                            Console.WriteLine("Saindo...");
                            return;
                        default:
                            Console.WriteLine("Opção inválida. Tente novamente.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, insira um número.");
                }
            }
        
        
        }

        public void DisplayMenu()
        {
            Console.WriteLine("=====BANK=====");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. WithDraw");
            Console.WriteLine("4. Exit");
        }

    }
}
