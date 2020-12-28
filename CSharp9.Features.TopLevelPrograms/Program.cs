
// Writing a simple program in C# requires a remarkable amount of boilerplate code:
/*

using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Hello World!");
    }
}

*/


// In C# 9.0 you can just choose to write your main program at the top level instead:
using System;
using System.Threading.Tasks;

Console.WriteLine("Hello World!");

// Any statement is allowed. The program has to occur after the 'using's and before any 
// type or namespace declarations in the file, and you can only do this in one file, 
// just as you can have only one 'Main' method today.


// If you want to 'await' things you can do that.
int result = await Task.FromResult(0);

// If you want to access command line arguments, 'args' is available as a "magic" parameter.
if(args.Length > 0)
{
    Console.WriteLine(string.Join("\r\n", args));
}

// Local functions are a form of statement and are also allowed in the top level program. 
// It is an error to call them from anywhere outside of the top level statement section.

int LocalFunction()
{
    return new Random().Next();
}

// If you want to return a status code you can do that. 
return LocalFunction();








