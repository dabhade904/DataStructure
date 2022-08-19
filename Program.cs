using System.Collections;

namespace DataStructure
{

    public class PrimeArray2D
    {
        public static void Main(string[] args)
        {
            ArrayList[] list = new ArrayList[10];
            int count = 0, i = 0, temp = 100;

            for (int j = 0; j < 10; j++)
            {
                list[j] = new ArrayList();
            }

            while (i < 10)
            {
                for (int num = 2; num <= 1000; num++)
                {
                    count = Utility.isPrime(num);

                    if (count == 0)
                    {
                        list[i].Add(num);
                    }
                    if (num == temp)
                    {
                        i++;
                        temp = temp + 100;
                    }
                }

            }
            /*  for (int j = 0; j < list.Length; j++)
              {
                  Console.WriteLine(list[j]);
              }*/
            foreach (var li in list)
            {
                Console.WriteLine("" + li);
            }
        }


    }

}