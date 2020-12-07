
namespace CSharp9.Features.InitOnlySetters
{
    // An interface declaration can also participate in init 
    // style initialization via the following pattern:
    public interface IPerson
    {
        public string Name { get; init; }
    }

    public class Init
    {
        void M<T>() where T : IPerson, new()
        {
            var local = new T() { Name = "Jared" };
            local.Name = "John"; // => Error CS8852
        }
    }
}















