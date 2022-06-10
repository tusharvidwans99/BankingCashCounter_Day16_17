using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingCashCounter_Day16_17
{
    public class BankingCashCountert
    {

        Queue<String> queue = new Queue<string>();
        public int amount = 125000;

        public void updateCash()
        {
            addPeople();
            while (queue.Count != 0)
            {
                Console.WriteLine($"Hello {queue.Peek()} please select a number: ");
                Console.WriteLine("Enter\n1.To Withdraw\n2.To Deposit");
                int option = Convert.ToInt32(Console.ReadLine());
                
                
                if (option == 1)
                {
                    bool isSufficientBalance = false;
                    while (!isSufficientBalance)
                    {
                        Console.Write("Enter amount to withdraw: ");
                        int withdraw = Convert.ToInt32(Console.ReadLine());
                        
                        if (amount - withdraw >= 0)
                        {
                            amount -= withdraw;
                            isSufficientBalance = true;
                        }
                        else
                        {
                            Console.WriteLine($"Insufficient balance, please enter amount less than or equal to {amount}");
                        }
                    }
                    queue.Dequeue();
                }
                else if (option == 2)
                {
                    Console.Write("Enter amount to deposit: ");
                    int deposit = Convert.ToInt32(Console.ReadLine());
                    amount += deposit;
                    queue.Dequeue();
                }
            }
            Console.WriteLine($"Balance left : {amount}");
        }
        public void addPeople()
        {
            queue.Enqueue("Tushar");
            queue.Enqueue("Yash");
            queue.Enqueue("Kshitij");
            queue.Enqueue("shubham");
        }

    }
}
