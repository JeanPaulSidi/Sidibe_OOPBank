using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sidibe_OOPBank
{
    public class Bank
    {
        private decimal _balance;

        public Bank(decimal Balance) 
        {
            _balance = Balance;
        }

        public decimal Balance
        {
            get { return _balance; }  
        }

        public string CheckBalance() 
        {
            string Message;

            Message = ("The balance in your account is : " + _balance.ToString("C"));

            return Message;
        }

        public string MakeDeposit(decimal Amount) 
        {
            string Message;

            Message = ("The deposit of " + Amount.ToString("C") + " has been made succesfully. ");
            _balance += Amount;
            Message += ("The new balance in your account is: " + _balance.ToString("C"));

            return Message;
        }

        private string ValidateWithdrawal(decimal Amount) 
        {
            string Message;

            if (_balance >= Amount) 
            {
                Message = ("The withdrawal of " + Amount.ToString("C") + " has been accepted. ");
                _balance -= Amount;
                Message += ("The new balance in your account is: " + _balance.ToString("C"));
            }
            else 
            {
                Message = ("Sorry. The balance in your account is insufficient.");
            }

            return Message;
        }

        public string MakeWithdrawal(decimal Amount) 
        {
            string Message;

            if (Amount > 500) 
            {
                Amount = 500;
            }

            Message = ValidateWithdrawal(Amount);

            return Message;
        }

    }
}
