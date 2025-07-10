class BankProgram
{
    static void Main(string[] args)
    {
        BankAccount account = new BankAccount("Student");
        string option = "";

        while (option != "4")
        {
            Console.WriteLine("\n1. Deposit\n2. Withdraw\n3. Show Balance\n4. Exit");
            Console.Write("Choose an option: ");
            option = Console.ReadLine();

            if (option == "1")
            {
                Console.Write("Deposit amount: ");
                decimal amount = Convert.ToDecimal(Console.ReadLine());
                account.Deposit(amount);
            }
            else if (option == "2")
            {
                Console.Write("Withdraw amount: ");
                decimal amount = Convert.ToDecimal(Console.ReadLine());
                account.Withdraw(amount);
            }
            else if (option == "3")
            {
                account.ShowBalance();
            }
        }

        Console.WriteLine("Thank you for banking with us!");
    }
}
