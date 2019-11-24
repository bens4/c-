using System;

namespace Bank
{
    class Customer
    {
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string gender { get; set; }
        public string account_num { get; set; }
        public string account_type { get; set; }
        public string currency { get; set; }
        public double i_balance { get; set; }
        public double balance { get; set; }

        public Customer()
        {
            Console.WriteLine("First Name: ");
            this.first_name = Console.ReadLine();
            Console.WriteLine("Last Name: ");
            this.last_name = Console.ReadLine();
            Console.WriteLine("Gender: Male|Female");
            this.gender = Console.ReadLine();
            Console.WriteLine("Account Number: ");
            this.account_num = Console.ReadLine();
            Console.WriteLine("Account Type: ");
            this.account_type = Console.ReadLine();
            Console.WriteLine("Choose Account Currency: frw|US dollar|EURO");
            this.currency = Console.ReadLine();
            

            if (currency == "FRW")
            {
                this.i_balance = 50000;
            }
            else if ((currency == "US dollar")|| (currency == "EURO"))
            {
                this.i_balance = 50;
            }
            this.balance = 0;
        }

        public Customer(string first_name, string last_name, string gender, string account_num, string account_type, string currency, double i_balance, double balance)
        {
            this.first_name = first_name;
            this.last_name = last_name;
            this.gender = gender;
            this.account_num = account_num;
            this.account_type = account_type;
            this.currency = currency;
            this.i_balance = i_balance;
            this.balance = balance;
        }

        public string displayInfo()
        {
            return string.Format(
                "First Name: {0} \nLast Name: {1} \nGender: {2} \nAccount Number: {3} \nAccount Type: {4} \nAccoount Currency: {5} \nInitial Balance: {6}",
                first_name, last_name, gender, account_num, account_type, currency, i_balance);
        }

        public double depositOperation(double depositAmount)
        {
            balance = i_balance + depositAmount;
            return balance;
        }

        public double withdrawOperation(double withdrawAmount)
        {
            balance = i_balance - withdrawAmount;
            return balance;
        }
        
        static void Main(string[] args)
        {
            Customer cust01 = new Customer();
            Console.WriteLine("Review Information: Y|N ");
            string check = Console.ReadLine();
            if (check == "Y")
            {
                Console.WriteLine(cust01.displayInfo());
            }
            else
            {
                Console.WriteLine("OKAY");
            }
            Console.WriteLine("Perform Operation: 1->Deposit|2->Withdraw");
            string op = Console.ReadLine();
            if (op == "1")
            {
                Console.WriteLine("Amount to Deposit: ");
                double amt = Convert.ToDouble(Console.ReadLine());
                cust01.depositOperation(amt);
            }
            else if (op == "2")
            {
                Console.WriteLine("Amount to Withdraw: ");
                double amt = Convert.ToDouble(Console.ReadLine());
                cust01.withdrawOperation(amt);
            }

        }
    }
}