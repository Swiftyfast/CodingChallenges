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
            long z = 0;
            long xy = 1;
            long incriminter = 1;
            long numberToLookAt = 0;

            while (numberToLookAt < 1000000000)
            {
                long nextNumber = z + xy;
                z = xy;
                xy = nextNumber;
                numberToLookAt = nextNumber;
                incriminter++;

            }
            Console.WriteLine("The answer to Wednesday's problem is " + incriminter);
            //I got 45
            Console.WriteLine("");
            //THURSDAY
            int thursLoop = 1;
            
            int longestChain = 0;
            while (thursLoop < 1000)
            {
                int subLoop = thursLoop;
                int interChain = 0;

                while (subLoop != 1)
                {
                    if (subLoop % 2 == 0)
                    {
                        subLoop = subLoop / 2;
                        interChain++;
                    }
                    else if (subLoop % 2 == 1)
                    {
                        subLoop = (3 * subLoop) + 1;
                        interChain++;
                    }
                }

                if (interChain + 1 > longestChain)
                {
                    longestChain = interChain + 1;
                }
                thursLoop++;
            }


            Console.WriteLine("The answer for Thursday is " + longestChain);

        }
    }
}
