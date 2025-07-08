namespace Aula24
{
    internal class BankOperation
    {
        decimal balance = 5000;

        public void checkBalance()
        {
            Console.WriteLine($"Your balance is: {balance}");
        }

        public void Deposit()
        {
            Console.WriteLine("Digite o valor a ser depositado: R$");

            //converte o texto em decimal
            if (decimal.TryParse(Console.ReadLine(), out decimal depositAmount) && depositAmount > 0)
            {
                balance += depositAmount;
            }
            else
            {
                Console.WriteLine("Valor inválido. Tente novamente.");
                
            }

        }

        public void Withdraw()
        {
            Console.WriteLine("Informe o valor a ser retirado");

            if (decimal.TryParse(Console.ReadLine(), out decimal depositAmount) && depositAmount > 0)
            {
                if(depositAmount <= balance)
                {
                    balance -= depositAmount;
                    Console.WriteLine($"Você retirou: {depositAmount}. Seu novo saldo é: {balance}");
                }
                else
                {
                    Console.WriteLine("Saldo insuficiente.");
                }
            }
            else
            {
                Console.WriteLine("Valor inválido. Tente novamente.");

            }

        }

    }
}
