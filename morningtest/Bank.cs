using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace BankAccountNS
{
    /// <summary>
    /// Bank account demo class.
    /// </summary>
    public class BankAccount
    {
        private string m_customerName = "Diego";
        private double m_balance;

        public BankAccount() 
        {
            
            m_balance = 100000.00;
        }

        public BankAccount(string customerName, double balance)
        {
            m_customerName = customerName;
            m_balance = balance;
        }

        public string CustomerName
        {
            get { return m_customerName; }
            set { m_customerName = value; }
        }

        public double Balance
        {
            get { return m_balance; }
            set { m_balance = value; }
        }

        public double Deposit(double amount)
        {
           
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }
           

            m_balance += amount; // intentionally incorrect code

            return m_balance;
        }

        public void Credit(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            m_balance += amount;
        }

        
    }
}