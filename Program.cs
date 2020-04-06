using System;

namespace cash_counter_using_stack
{
    class main
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("no of people in queue");
            int noOfPeopleInQue = Convert.ToInt32(Console.ReadLine());
            stack list = new stack(noOfPeopleInQue);
            int count = 0;
            banking bank = new banking();
            do
            {
                int userBalance = 5000;
                int ubalance = userBalance;
                int totalBalanceOfUser = 0;
                Console.WriteLine("enter cash ");
                int cash = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("please enter 1 for deposit 2 for withdraw");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        totalBalanceOfUser = bank.depositCash(cash, ubalance);
                        list.push(totalBalanceOfUser);
                        Console.WriteLine("available balance .." + totalBalanceOfUser);
                        list.pop();
                        cash = 0;
                        break;

                    case 2:
                        if (ubalance < cash)
                        {
                            Console.WriteLine("not ifficient cash");
                        }
                        else
                        {
                            totalBalanceOfUser = bank.withdrawCash(cash, ubalance);
                            list.push(totalBalanceOfUser);
                            Console.WriteLine("available balance .." + totalBalanceOfUser);
                            list.pop();
                            cash = 0;
                        }
                        break;

                }
                count++;
            } while (count < noOfPeopleInQue);
            list.display();

        }
    }
}
