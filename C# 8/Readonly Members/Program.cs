namespace Program
{
    public struct Point
    {
        //The compiler doesn't assume get accessors don't modify state; you must declare readonly explicitly.
        //Auto-implemented properties are an exception; the compiler will treat all auto-implemented getters as readonly.

        public double X { get; set; }
        public double Y { get; set; }
        //Marking Distance as readonly removes the warning
        public readonly double Distance => Math.Sqrt(X * X + Y * Y);

        //Like most structs, the ToString() method doesn't modify state. You could indicate that by adding the readonly modifier to the declaration of ToString()
        //This generates a compiler warning because ToString accesses the Distance property, which isn't marked readonly
        public readonly override string ToString() =>
            $"({X}, {Y}) is {Distance} from the origin";
    }
}