
namespace CSharp9.Features.Records
{
    public record Person
    {
        public string FirstName
        {
            get;
            init; //[x] only init-setter
        }

        public string LastName
        {
            get;
            init; //[x]only init-setter
        }
    }

    public record Student : Person
    {
        public int ID { get; set; }
    }
}


























