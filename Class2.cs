using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    internal   class Call_b_value
    {
        public static void call_add(int n)
        {
            n = n * 5;
        }
        //public static void main(string[] args)
        //{
       //     int n = 50;
         //   add(n);
           // Console.WriteLine(n);
        //}
    }

    internal  class Ref_b_value
    {
        public static void ref_add(ref int n)
        {
            n = n * 5;
        }
        public static void sMain(string[] args)
        {

            int n = 50;
           // Call_b_value.call_add(n);
            ref_add(ref n);
            Console.WriteLine(n);
        }

    }
}
