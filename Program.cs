namespace BankingSystem
{
    public enum MenuOption
    {
        Withdraw = 1,
        Deposit,
        Print,
        Quit
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter The Name of the Account : ");
            var acc = new Account(Console.ReadLine());
            var option = new MenuOption();
            while(true)
            {
                option = ReadUserOption();
                switch (option)
                {
                    case MenuOption.Withdraw:
                        DoWithdraw(acc);
                        break;
                    case MenuOption.Deposit:
                        DoDeposit(acc);
                        break;
                    case MenuOption.Print:
                        DoPrint(acc);
                        break;
                }
                if(option == MenuOption.Quit)
                    break;
            } 
        }
        public static MenuOption ReadUserOption()
        {
            int option = int.MaxValue;
            do
            {
                if(option != int.MaxValue)
                    Console.WriteLine("\nInvild Option!!!\tTry Agin\n");
                Console.WriteLine("1)Withdraw\n2)Deposit\n3)Print\n4)Quit");               
            } while (!int.TryParse(Console.ReadLine(), out option) || option < (int)MenuOption.Withdraw || option > (int)MenuOption.Quit);
            return (MenuOption)option;
        }
        public static void DoWithdraw(Account account)
        {
            Console.Write("Enter the Amount = ");
            decimal amount;
            bool successful = decimal.TryParse(Console.ReadLine(),out amount);
            if (successful)
            {
                successful = account.WithDraw(amount);
                if (!successful) 
                    Console.WriteLine("UnSuccessful Operation!!");
            }
            else
                Console.WriteLine("Invaild Entery!!\n");            
        }
        public static void DoDeposit(Account account)
        {
            Console.Write("Enter the Amount = ");
            decimal amount;
            bool successful = decimal.TryParse(Console.ReadLine(), out amount);
            if (successful)
            {
                successful = account.Deposit(amount);
                if (!successful)
                    Console.WriteLine("UnSuccessful Operation!!");
            }
            else
                Console.WriteLine("Invaild Entery!!\n");
        }
        public static void DoPrint(Account account)
        {
            account.Print();
        }
    }
}
