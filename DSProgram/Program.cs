﻿using System;

namespace DSProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data Structure Programs!");
            Console.WriteLine("1.Unordered List");
            Console.WriteLine("2.ordered List");
            Console.WriteLine("3.Balanced Paranthesis");
            Console.WriteLine("4.Banking Cash Counter");
            int check = Convert.ToInt32(Console.ReadLine());
            switch (check)
            {
                case 1:
                    UnorderedList.Unordered();
                    break;
                case 2:
                    OrderedList.Ordered();
                    break;
                case 3:
                    char[] expression = "(5+6)∗(7+8)/(4+3)(5+6)∗(7+8)/(4+3)".ToCharArray();
                    BalancingParantheses.StackOperations stackOperations = new BalancingParantheses.StackOperations();
                    bool result = stackOperations.Isbalanced(expression);
                    if (result)
                    {
                        Console.WriteLine("Parantheses Balanced");
                    }
                    else
                    {
                        Console.WriteLine("Parantheses not Balanced");
                    }
                    break;
                case 4:
                    BankingCashCounter banking = new BankingCashCounter();
                    banking.MaintainQueue();
                    break;

            }

        }
    }
}
