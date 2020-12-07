
namespace CSharp9.Features.InitOnlySetters
{
    public class Car
    {
        public string Brand { get; init; }
        public string Model { get; init; }
    }

    public class Sample1
    {
        public void Main()
        {
            // Example 1

            Car car1 = new Car { Brand = "BMW", Model = "X5" };
            car1.Model = "X3"; // => Error CS8852. Model is not settable

            // 
            // Error CS8852 Init - only property or indexer 'car1.Model' 
            // can only be assigned in an object initializer, or on 'this' 
            // or 'base' in an instance constructor or an 'init'
            // 


            // Example 2

            Car car2 = new Car();
            // car2.Brand is null and car2.Model is null 
            car2.Brand = "BMW"; // => Error CS8852.

        }
    }
}






