
namespace CSharp9.Features.InitOnlySetters
{
    // The rules around when init accessors are settable extend 
    // across type hierarchies. If the member is accessible and 
    // the object is known to be in the construction phase then 
    // the member is settable. That specifically allows for the 
    // following:
    public class Base
    {
        public int Value { get; init; }
    }

    public class Derived : Base
    {
        public Derived()
        {
            Value = 1; // <= 1. 

            // d.Value == 1 is true
        }
    }

    public class Sample3
    {
        public void Main()
        {
            var d = new Derived() { Value = 2 }; // <= 2.

            // d.Value == 2 is true
        }
    }
}


