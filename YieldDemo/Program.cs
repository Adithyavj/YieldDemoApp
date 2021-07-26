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
            List<PersonModel> output = new();

            output.Add(new PersonModel("Adithya", "Vijay"));
            output.Add(new PersonModel("Arjun", "Narayanan"));
            output.Add(new PersonModel("Jetlin", "Yeldo"));

            return output;
        }
    }
}
