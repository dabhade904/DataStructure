using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class Utility
    {
        public static int isPrime(int num)
        {
            int cnt = 0;
            for (int i = 2; i < num / 2; i++)
            {
                if (num % i == 0)
                {
                    cnt++;
                    break;
                }
            }
            return cnt;
        }

    }
}
