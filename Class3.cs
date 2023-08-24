using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    internal class basic_algos
    {
      public static double Fact(int n)
       {
            int r= 1;
            while (n>0) {
                r = r * n;
                n = n - 1;
                    }
            return r;
           // return n*Fact(n - 1);
       }

      public static int sum_of_digits(int n)
        {
            int rem, sum = 0;
            while (n > 0)
            {
                rem = n % 10;
                sum = sum + rem;
                n /= 10;
            }
            return sum;
        }
      public static double sum_of_numbers(int n)
        {
            return sum_of_digits(n - 1) + n; 
        }

      public static void k_Main(string[] args)
        {
            int n = 5;
            Console.WriteLine(Fact(n));
            Console.WriteLine(sum_of_digits(n));
            Console.WriteLine(sum_of_numbers(n));

        }


    }
}

