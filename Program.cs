using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace project_euler_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> totalchar = new List<string>();
            int number = 1;
            for (number = 1; number <= 1000; number++)
            {
                totalchar.Add(getString(number));
            }
            Console.WriteLine(totalchar.Sum(s => s.Length));



            Console.ReadLine();
        }
        static string[] underTwenty = new[] {"" ,"one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
        static string[] tens = new[] { "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
        static string[] hundred = new[] { "onehundredand", "twohundredand", "threehundredand", "fourhundredand", "fivehundredand", "sixhundredand", "sevenhundredand", "eighthundredand", "ninehundredand" };
        static string getString(int number){
            if (number == 0) return "";
            else if (number < 20) return underTwenty[number ];
            else if (number >= 20 & number < 100) return underTwenty[number%10]+ tens[(number/10)-2];
            else if (number >= 100 & number < 1000) return underTwenty[number % 10] + tens[(number / 10) - 2] ;
            else  return "onethousand"; //1000     
        }
    }
}
