using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t2210a_c_.bank
{
    internal class BankAccount
    {
        
        public decimal Balance { get; private set; }

        
        public BankAccount(decimal initialBalance)
        {
            Balance = initialBalance;
        }

        
        public void Deposit(decimal amount)
        {
            Balance += amount;
            
            Console.WriteLine("Bạn đã gửi {0} vào tài khoản. Số dư hiện tại là {1}.", amount, Balance);
        }

        
        public void Withdraw(decimal amount)
        {
            if (amount > Balance)
            {
                
                Console.WriteLine("Số tiền rút vượt quá số dư. Không thể thực hiện giao dịch.");
            }
            else
            {
                Balance -= amount;
                
                Console.WriteLine("Bạn đã rút {0} từ tài khoản. Số dư hiện tại là {1}.", amount, Balance);
            }
        }
    }

}
