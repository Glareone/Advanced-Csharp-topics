namespace Dynamic.Performance;

public class Person
{
    public string FullName { get; set; }

    public DateOnly DateOfBirth { get; set; }

    public int CalculateAge()
    {
        return DateTime.Now.Year - DateOfBirth.Year;
    }
}