using System;
using System.Collections.Generic;
using System.Linq;

namespace RandomNumberGenerator
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Random random_ = new Random();

            // Advanced Shuffle

            for (int i = 0; i < 10; i++)
            {
                //Console.WriteLine(random_.Next(5,11));
                //SimpleMethod(random_);

                // Console.WriteLine(random_.NextDouble()*10);
            }
           
                List<Person> people = new List<Person>
                {
                    new Person {FirstName = "Rami"},
                     new Person {FirstName = "Terry"},
                      new Person {FirstName = "Zhou"},
                       new Person {FirstName = "Will"},
                        new Person {FirstName = "Kyo"},
                         new Person {FirstName = "Caron"}
                };

          var sortedPeople - people.OrderBy(x -> random_.Next());

            foreach (var p in sortedPeople)
            {
                Console.WriteLine(p.FirstName);
            }
            Console.ReadLine();
        }

        private static void SimpleMethod(Random rand)
        {
            Console.WriteLine(rand.Next());
        }
    }
    public class Person
    {
        public string FirstName { get; set; }
    }
}
