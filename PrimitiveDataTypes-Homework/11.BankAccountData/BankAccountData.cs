using System;

    class BankAccountData
    {
        static void Main()
        {
            //A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
            //Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.

            Console.WriteLine("Holder first name: ");
            string holderFirstName = Console.ReadLine();
            Console.WriteLine("Holder middle name: ");
            string holderMiddleName = Console.ReadLine();
            Console.WriteLine("Holder last name: ");
            string holderLastName = Console.ReadLine();


            Console.WriteLine("Holder amount money: ");
            decimal holderAmountMoney = decimal.Parse(Console.ReadLine());

            string bankIBAN = "AL47-2121-1009-0000-0002-3569-8741";
            string bankName = "American Express";

            long holderCreditCard1 = 376401164395622;
            long holderCreditCard2 = 378482978452351;
            long holderCreditCard3 = 376097472620725;

            Console.WriteLine("Checking information...");
            Console.WriteLine("Bank: {0}",bankName);
            Console.WriteLine("Bank IBAN {0} ", bankIBAN);
            Console.WriteLine("Your full name: {0} {1} {2}", holderFirstName, holderMiddleName, holderLastName);
            Console.WriteLine("Balance: {0}", holderAmountMoney);
            Console.WriteLine("Credit card 1: {0}", holderCreditCard1);
            Console.WriteLine("Credit card 2: {0}", holderCreditCard2);
            Console.WriteLine("Credit card 3: {0}", holderCreditCard3);


        }
    }

