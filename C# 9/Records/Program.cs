//C# 9.0 introduces record types. You use the record keyword to define a reference type that provides built-in functionality for encapsulating data
//You can create record types with immutable properties by using positional parameters or standard property syntax
namespace Program
{
    public record PersonPositionalParams(string FirstName, string LastName);
    public record PersonStrandardPropertySyntax
    {
        public string FirstName { get; init; } = default!;
        public string LastName { get; init; } = default!;
    };
    //We can create records with mutable properties and fields
    public record PersonMutable
    {
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
    };
    //While records can be mutable, they are primarily intended for supporting immutable data models. 
    /*
    The record type offers the following features:

        Concise syntax for creating a reference type with immutable properties
        Behavior useful for a data-centric reference type:
            Value equality
            Concise syntax for nondestructive mutation
            Built-in formatting for display
        Support for inheritance hierarchies
    */

    //Value equality means that two variables of a record type are equal if the types match and all property and field values match.

    public record Person(string FirstName, string LastName, string[] PhoneNumbers);

    class Program
    {
        public static void Main()
        {
            var phoneNumbers = new string[2];
            Person person1 = new("Nancy", "Davolio", phoneNumbers);
            Person person2 = new("Nancy", "Davolio", phoneNumbers);
            Console.WriteLine(person1 == person2); // output: True

            person1.PhoneNumbers[0] = "555-1234";
            Console.WriteLine(person1 == person2); // output: True

            Console.WriteLine(ReferenceEquals(person1, person2)); // output: False
        }
    }

    //Record types have a compiler-generated ToString method that displays the names and values of public properties and fields. The ToString method returns a string of the following format:
    //<record type name> { <property name> = <value>, <property name> = <value>, ...}

    //A record can inherit from another record. However, a record can't inherit from a class, and a class can't inherit from a record.

    //For two record variables to be equal, the run-time type must be equal. The types of the containing variables might be different.

}