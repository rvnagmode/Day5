using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    public class Bank
    {
        private double totalbalance=10000;
        public event ErrorDelegate WithdrawnEvent1;
        public event ErrorDelegate WithdrawnEvent2;
        public event ErrorDelegate WithdrawnEvent3;
        public void Deposit(double depositedmoney)
        {
            totalbalance = totalbalance + depositedmoney;
            Console.WriteLine("after deposite balance : " + totalbalance);
        }
        public double Withdraw(double withdrawmoney)
        {
            if(withdrawmoney>totalbalance)
            {
                Console.WriteLine("you cannot withdraw balance");
            }
            
            else if(totalbalance<3500)
            {
                WithdrawnEvent1();
            }

            else if (totalbalance <= 100)
            {
                WithdrawnEvent1();
            }

            if (totalbalance < withdrawmoney)
            {
                WithdrawnEvent3();
            }
            return totalbalance-withdrawmoney;        
        }

    }
}
