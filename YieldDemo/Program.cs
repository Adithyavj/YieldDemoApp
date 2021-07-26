using System;
using System.Collections.Generic;

namespace YieldDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start of the App");

            var people = DataAccess.GetPeople();
            foreach (var p in people)
            {
                Console.WriteLine($"Read {p.FirstName} {p.LastName}");
            }

            Console.WriteLine("End of the App");
        }
    }



    public static class DataAccess
    {
        public static IEnumerable<PersonModel> GetPeople()
        {
            // using yield keyword we can return multiple objects

            yield return new PersonModel("Adithya", "Vijay");
            yield return new PersonModel("Arjun", "Narayanan");
            yield return new PersonModel("Jetlin", "Yeldo");

        }
    }
}
