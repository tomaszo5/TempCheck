namespace AmplituderChecker.Entities;
 
    public class Manager : EntityBase
{
    public string? FirstName { get; set; }

    public string? LastName { get; set; }
    public override string ToString() => base.ToString() + " (Manager)";

}

