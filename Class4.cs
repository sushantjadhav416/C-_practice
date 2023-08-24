using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    internal class proper
    {
        private string empname;

        private int empid;

        private static int count = 0;

        public proper()

        {

            count++;

        }

        public static int counter

        {

            get

            {

                return count;

            }

        }
        public string ename

        {

            set

            {

                empname = value;

            }



            get

            {

                return empname;

            }

        }
        public int eid

        {

            set

            {

                empid = value;

            }

            get

            {

                return empid;

            }

        }





    }
}
