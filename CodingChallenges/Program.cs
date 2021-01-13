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
            long tuesdaySum = 2;
            long x = 1; //This will be the first number in the sequence
            long y = 2; //This will be the second;

            while (y <= 4000000)
            {
                long nextNumber = x + y;
                if (nextNumber % 2 == 0)
                {
                    tuesdaySum = tuesdaySum + nextNumber;
                }
                x = y;
                y = nextNumber;

                //tuesdayCount++;
            }

            Console.WriteLine("The answer to Tuesday's problem is " + tuesdaySum);
            //I got 4613732
            Console.WriteLine("");
            //WEDNESDAY

            //THURSDAY
        }
    }
}
