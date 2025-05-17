//Longest Collatz sequence
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace euler_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long number;
            int chainnumber, longestchain = 1, longestnum=1 ;
            for(int i=999999;i>0;i--)
            {
                number = i;
                chainnumber = 1;
                do
                {
                    if (number % 2 == 0)
                    {
                        number = number / 2;
                        chainnumber++;
                    }
                    else
                    {
                        number = (number * 3) + 1;
                        chainnumber++;
                    }
                } while (number != 1);
                
                if (chainnumber > longestchain)
                {
                    longestchain = chainnumber;
                    longestnum = i;
                }
            }
            Console.WriteLine("The longest number     :"+longestnum);
            Console.WriteLine("The length of the chain:"+longestchain);
            Console.ReadLine();
        }

    }
}
