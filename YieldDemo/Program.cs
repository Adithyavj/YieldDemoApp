using System;
using System.Collections.Generic;
using System.Linq;

namespace YieldDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start of the App");

            //var people = DataAccess.GetPeople().Take(2);
            //foreach (var p in people)
            //{
            //    Console.WriteLine($"Read {p.FirstName} {p.LastName}");
            //}
            var primeNumbers = Generators.GetPrimeNumbers();

            // for iterating through the primeNumbers , we need to call this method of IEnumberable with returns an iterator that iterates through the collection
            var iterator = primeNumbers.GetEnumerator();

            for (int i = 0; i < 10; i++)
            {
                // if there is a value next,
                if (iterator.MoveNext())
                {
                    Console.WriteLine(iterator.Current);
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("End of first section");
            Console.ReadLine();

            for (int i = 0; i < 15; i++)
            {
                // if there is a value next,
                if (iterator.MoveNext())
                {
                    Console.WriteLine(iterator.Current);
                }
                else
                {
                    break;
                }
            }

            //foreach (var prime in primeNumbers)
            //{
            //    Console.WriteLine($"{prime}");
            //}

            Console.WriteLine("End of the App");
        }
    }

    public class Generators
    {
        public static IEnumerable<int> GetPrimeNumbers()
        {
            int counter = 1;
            while (true)
            {
                if (IsPrimeNumber(counter))
                {
                    yield return counter;
                }
                counter++;
            }

        }

        private static bool IsPrimeNumber(int value)
        {
            bool output = true;
            for (int i = 2; i < value / 2; i++)
            {
                if (value % i == 0)
                {
                    output = false;
                    break;
                }
            }
            return output;
        }

    }
}
