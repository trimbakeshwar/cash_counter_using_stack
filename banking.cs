using System;
using System.Collections.Generic;
using System.Text;

namespace cash_counter_using_stack
{
    class banking:bank
    {/// <summary>
    /// deposit cash in account
    /// </summary>
    /// <param name="cash">take user cash he want to deposit</param>
    /// <param name="ubalance">before deposit account balance</param>
    /// <returns>total balnce after deposit </returns>
        public int depositCash(int cash, int ubalance)//user deposit cash
        {

            ubalance += cash;
            return ubalance;
        }
        /// <summary>
        /// withdraw cash
        /// </summary>
        /// <param name="cash">take user cash he want to withdraw</param>
        /// <param name="ubalance">before withdraw account balance</param>
        /// <returns>total balnce after deposit</returns>
        public int withdrawCash(int cash, int ubalance)//user withdraw cash
        {
            if (ubalance <= 0)
            {
                Console.WriteLine("cash is not available");
                return 0;
            }
            else
            {
                ubalance -= cash;
                return ubalance;
            }
        }
    }
}
