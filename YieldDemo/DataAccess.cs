using System.Collections.Generic;

namespace YieldDemo
{
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
