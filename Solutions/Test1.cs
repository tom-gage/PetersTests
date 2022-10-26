using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetersTests.Solutions
{
    internal class Test1
    {
        public static int Solution(int[] A)
        {
            if(A.Length == 0)
            {
                return 1;
            }

            Array.Sort(A);

            int currentValue = -1;
            int nextValue = 2;
            int lowestValueNotInUse = A[A.Length - 1] + 1;

            for (int i = A.Length - 1; i > 0; i--)
            {
                
                currentValue = A[i];
                if (i - 1 == -1)
                {
                    continue;
                } else
                {
                    nextValue = A[i - 1];
                }

                //skip value if its zero or negative
                if(currentValue <= 0)
                {
                    continue;
                }

                if(currentValue - nextValue != 1)
                {
                    lowestValueNotInUse = nextValue + 1;
                }
            }

            //if final value is greater than one, lowestValueNotInUse is 1
            if (nextValue > 1)
            {
                lowestValueNotInUse = 1;
            }

            return lowestValueNotInUse;

        }

        public static long Solution(long[] A)
        {
            if (A.Length == 0)
            {
                return 1;
            }

            Array.Sort(A);

            long currentValue = 0;
            long nextValue = 2;
            long lowestValueNotInUse = A[A.Length - 1] + 1;

            for (long i = A.Length - 1; i > 0; i--)
            {

                currentValue = A[i];
                if (i - 1 == -1)
                {
                    continue;
                }
                else
                {
                    nextValue = A[i - 1];
                }

                //skip value if its negative
                if (currentValue < 0 || nextValue < 0)
                {
                    continue;
                }

                if (currentValue - nextValue != 1)
                {
                    lowestValueNotInUse = nextValue + 1;
                }
            }

            //if final value is not one, one is not in use, so lowestValueNotInUse is 1
            if (nextValue != 1)
            {
                lowestValueNotInUse = 1;
            }

            return lowestValueNotInUse;
        }
    }
}
