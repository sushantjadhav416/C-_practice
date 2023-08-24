using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    internal partial  class Class1
    {

        public static int add(int x, int y)
        {
            return x + y;
        }

    }

    internal partial class Class1
    {
        public static void a_Main(string[] args)
        {

            int[,] arr = new int[3, 3];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                    
                }
            }

            int sum = arr[0, 0] + arr[1, 1] + arr[2, 2];
            Console.WriteLine(sum);
            Console.WriteLine(add(4, 5));

        }


    }
}
 