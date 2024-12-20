public class Insuree
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public int Age { get; set; }
    public int CarYear { get; set; }
    public string CarMake { get; set; }
    public string CarModel { get; set; }
    public int SpeedingTickets { get; set; }
    public bool DUI { get; set; }
    public bool FullCoverage { get; set; }
    public double Quote { get; set; } // Store calculated quote
}