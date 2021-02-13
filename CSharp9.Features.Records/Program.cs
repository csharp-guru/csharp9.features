using System;

namespace CSharp9.Features.Records
{
    class Program
    {
        static void Main(string[] args)
        {
            var johnSmith = new Person { FirstName = "John" };

            johnSmith.LastName = "Smith";// [x] => Error CS8852. Model is not settable

            // 
            // Error CS8852 Init - only property or indexer 'car1.Model' 
            // can only be assigned in an object initializer, or on 'this' 
            // or 'base' in an instance constructor or an 'init'
            // 

            var person = new Person { FirstName = "Lois", LastName = "Lane" };

            /* [1] With-expressions */
            var otherPerson = person with { LastName = "Kent" };
            // => {FirstName = "Lois", LastName = "Kent" }

            var originalPerson = otherPerson with { LastName = "Lane" };
            // => {FirstName = "Lois", LastName = "Lane" }
            
            Console.WriteLine(ReferenceEquals(person, originalPerson)); // => false (they are not the same object)

            Console.WriteLine(Equals(person, originalPerson));// => true (they have the same value)


            /* [2] Inheritance */

            Person student = new Student { FirstName = "Leonardo", LastName = "Di Caprio", ID = 1 };

            Person otherStudent = student with { LastName = "Messi" };
            Console.WriteLine(otherStudent is Student); // true

            Person similarStudent = new Student { FirstName = "Leonardo", LastName = "Di Caprio", ID = 2 };
            Console.WriteLine(student != similarStudent); //true, since ID's are different
        }
    }
}
