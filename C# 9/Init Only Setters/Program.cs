//Init only setters provide consistent syntax to initialize members of an object. Property initializers make it clear which value is setting which property
//The downside is that those properties must be settable.
//After initialization the properties become readonly and all eventual modifications are not permitted
//this gives us a window for setting our property values and that window is the object creation
//after an object is created we can no longer set values to our properties

//Example:


//Callers can use property initializer syntax to set the values, while still preserving the immutability:

var now = new WeatherObservation
{
    RecordedAt = DateTime.Now,
    TemperatureInCelsius = 20,
    PressureInMillibars = 998.0m
};

//An attempt to change an observation after initialization results in a compiler error
// Error! CS8852.
//now.TemperatureInCelsius = 18;

public struct WeatherObservation
{
    public DateTime RecordedAt { get; init; }
    public decimal TemperatureInCelsius { get; init; }
    public decimal PressureInMillibars { get; init; }

    public override string ToString() =>
        $"At {RecordedAt:h:mm tt} on {RecordedAt:M/d/yyyy}: " +
        $"Temp = {TemperatureInCelsius}, with {PressureInMillibars} pressure";
}