using System.ComponentModel.DataAnnotations;

public class Person
{
    [Key] public string Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
}