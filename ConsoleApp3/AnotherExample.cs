using System;

namespace ConsoleApp3
{
    public abstract class ISavingAccount
    {
        public decimal Balance { get; set; }
    }

    public class CitiSavingAccount : ISavingAccount
    {
        public CitiSavingAccount()
        {
            Balance = 1000;
        }
    }

    public class NationalSavingAccount : ISavingAccount
    {
        public NationalSavingAccount()
        {
            Balance = 2000;
        }
    }

    interface ICreditUnionFactory
    {
        ISavingAccount GetSavingAccount(string accountNumber);
    }

    public class SavingAccountFactory : ICreditUnionFactory
    {
        public ISavingAccount GetSavingAccount(string accountNumber)
        {
            if (accountNumber.Contains("CITI"))
                return new CitiSavingAccount();
            else if (accountNumber.Contains("NATIONAL"))
                return new NationalSavingAccount();
            else
                throw new ArgumentException("Invalid Account Number");
        }
    }
}