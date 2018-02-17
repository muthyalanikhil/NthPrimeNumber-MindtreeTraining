using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading;

namespace NthPrime
{
    public class PrimeNumbers
    {
        long LIMIT = 2000000, PRIMES = 0;
        int i, j, n;
        long sum = 0;

        public void calc()
        {
            try
            {
                Console.WriteLine("Enter number of prime: ");
                n = Convert.ToInt32(Console.ReadLine());

                LIMIT = LIMIT - 1;
                PRIMES = LIMIT / 2;
                int[] numbers = new int[LIMIT];
                int[] primes = new int[PRIMES];

                for (i = 0; i < LIMIT; i++)
                {
                    numbers[i] = i + 2;
                }

                for (i = 0; i < LIMIT; i++)
                {
                    if (numbers[i] != -1)
                    {
                        for (j = 2 * numbers[i] - 2; j < LIMIT; j += numbers[i])
                        {
                            numbers[j] = -1;
                        }
                    }
                }

                j = 0;
                for (i = 0; i < LIMIT && j < PRIMES; i++)
                    if (numbers[i] != -1)
                    {

                        primes[j++] = numbers[i];
                    }

                Console.WriteLine(primes[n - 1]);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.Read();
            }
        }
    }
}

