//We can omit the type in a new expression when the created object's type is already known or can be inferred.
class Program
{
    private List<WeatherObservation> _observations = new();
    //We can combine it with init only properties (see ~/C# 9/Init Only Setters)
    WeatherStation station = new() { Location = "Seattle, WA" };

    //Target-typed new can also be used when you need to create a new object to pass as an argument to a method.
    public static void SayHello(Person p)
    {
        System.Console.WriteLine(p.Name + " says hello!");
    }

    //The target-typed new approach allows us to omit the Person class since it’s automatically inferred.
    public static void Main(string[] args)
    {
        SayHello(new() { Name = "Hello" });
    }
}
//Test classes
public class Person
{
    public string Name { get; set; }
}
class WeatherObservation
{
}
class WeatherStation
{
    public string Location { get; init; }
}