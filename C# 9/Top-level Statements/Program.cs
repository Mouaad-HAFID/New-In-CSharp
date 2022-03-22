//Starting in C# 9, you don't have to explicitly include a Main method in a console application project
//Instead, you can use the top-level statements feature to minimize the code you have to write. In this case, the compiler generates a class and Main method entry point for the application.
//Top-level statements let you write simple programs for small utilities such as Azure Functions and GitHub Actions. They also make it simpler for new C# programmers to get started learning and writing code.
//An application must have only one entry point. A project can have only one file with top-level statements.
//Having more than one file containing top-level statements results in a compoiler error
//We can write a Main method explicitly, but it can't function as an entry point. The compiler issues a warning
//In a project with top-level statements, we can't use the -main compiler option to select the entry point, even if the project has one or more Main methods.
//using directives must come first in the file
//Top level statements are implicitly in the global namespace

//Example Program
using System.Text;

StringBuilder builder = new();
builder.AppendLine("Hello");
builder.AppendLine("World!");

Console.WriteLine(builder.ToString());

//Top-level statements can reference the args variable to access any command-line arguments that were entered.
//The args variable is never null but its Length is zero if no command-line arguments were provided

if (args.Length > 0)
{
    foreach (var arg in args)
    {
        Console.WriteLine($"Argument={arg}");
    }
}
else
{
    Console.WriteLine("No arguments");
}

//Type definitions and namespaces must come after a top-level statement
MyClass.TestMethod();
MyNamespace.MyClass.MyMethod();

public class MyClass
{
    public static void TestMethod()
    {
        Console.WriteLine("Hello World!");
    }

}

namespace MyNamespace
{
    class MyClass
    {
        public static void MyMethod()
        {
            Console.WriteLine("Hello World from MyNamespace.MyClass.MyMethod!");
        }
    }
}


