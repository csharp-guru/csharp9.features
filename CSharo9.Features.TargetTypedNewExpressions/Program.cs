using System;
using System.Collections.Generic;

namespace CSharo9.Features.TargetTypedNewExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            // In C# 9.0, you can omit the type in a new expression when 
            // the created object's type is already known. The most common 
            // use is in field declarations:

            // initializing object
            ExampleObject exampleObject1 = new();

            // combining initializing with properties 
            ExampleObject exampleObject2 = new() { PropertyString = "bla bla bla" };

            Dictionary<string, string> dictionary = new()
            {
                ["key1"] = "value1",
                ["key2"] = "value2",
            };

            ExampleObject exampleObject3 = new()
            {
                PropertyString = "bla bla bla",
                Dictionary = new()
            };

            // initializing generic types
            List<ExampleObject> _listOfExampleObject = new();

            // initializing tuples
            (int a, int b) tuple1 = new(1, 2); // but "new" is redundant
            // or delegates
            Action action1 = new(() => { }); // but "new" is redundant

            // initializing tuples with default values 
            (int a, int b) tuple2 = new();

            // BUT!!!
            Action action2 = new(); // => Error CS1729. no constructor found

            // 
            // Error CS1729 'Action' does not contain a constructor 
            // that takes 0 arguments.
            // 

        }
    }
}

