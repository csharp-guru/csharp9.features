
using System;

namespace CSharp9.Features.InitOnlySetters
{
	// how you can initialize a read-only member in init-properties
	public class Person
	{
		private readonly string _name;
		
		public string Name
		{
			get => _name;
			init => _name = !string.IsNullOrEmpty(value) ? value : "unknown"; // <==
		}
	}
    
    public class Sample2
    {
        public void Main()
        {
			Person person = new Person { Name = string.Empty };
			Console.WriteLine(person.Name); // => "unknown"

			person.Name = "John"; // => Error CS8852.			
		}
    }
}











