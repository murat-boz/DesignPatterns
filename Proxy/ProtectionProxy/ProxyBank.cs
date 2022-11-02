using System;

namespace ProtectionProxy
{
    public sealed class ProxyBank : IBank
    {
        private readonly string userName;
        private readonly string userPassword;
        private Bank bank;

        public ProxyBank(string userName, string userPassword)
        {
            this.userName     = userName;
            this.userPassword = userPassword;
        }

        public bool Pay(decimal amount)
        {
            if (this.Login())
            {
                this.bank.Pay(amount);

                return true;
            }

            return false;
        }

        private bool Login()
        {
            if (this.userName == "murat" && this.userPassword == "1234")
            {
                this.bank = new Bank();
                Console.WriteLine("The account has been logged.");

                return true;
            }

            Console.WriteLine("Please make sure you have entered your username or password correctly.");

            return false;
        }
    }
}
