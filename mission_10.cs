//find the sum of all the primes below two million
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mission_10
{
    internal class Program
    {
        static int prime(long number)
        {
            if (number == 1) return 0;
            else if (number == 2) return 1;
            else
            {
                for (int i = 2; i <=number/2; i++)  // number/2 to earn time half of the number can divide
                {                                   // with out remainder because of this we must use <=
                    if (number % i == 0)
                    {
                        return 0;
                    }
                }
                return 1;
            }
        }
        static void Main(string[] args)
        {
            long sum = 0, number=1;
            while(number<2000000) 
            {

                if (prime(number)==1)
                {
                    sum = sum+ number;
                }
                number++;
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
