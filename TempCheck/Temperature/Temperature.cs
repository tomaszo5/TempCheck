using AmplituderChecker;
 
public class Temperature : IEntity
{
    public int Id { get; set; }
    public string City { get; set; }
    public double Value { get; set; }

    public Temperature()
    {
    }

    public Temperature(string city, double value)
    {
        City = city;
        Value = value;
    }

    public override string ToString()
    {
        return $"Temperature(Id: {Id}, City: {City}, Value: {Value})";
    }
}
