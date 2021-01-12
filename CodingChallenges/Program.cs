using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********** C O D I N G   C H A L L E N G E S *********\n");

            //MONDAY
            long theSum = 0;
            int whileLoopInt = 1;

            while (whileLoopInt < 1000)
            {
                if (whileLoopInt % 3 == 0 || whileLoopInt % 5 == 0)
                {
                    theSum = theSum + whileLoopInt;
                }

                whileLoopInt++;
            }

            Console.WriteLine("The answer to Monday's problem is: " + theSum);
            //I got 233168

            Console.WriteLine("");

            //TUESDAY

            //WEDNESDAY

            //THURSDAY
        }
    }
}
