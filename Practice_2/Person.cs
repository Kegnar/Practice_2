using Practice_2;

public class Person : IPerson
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public ContactInfo Contact { get; set; }
    
    public string Role { get; set; }
    public void DisplayInfo()
    {
        Console.WriteLine($"{FirstName} {LastName}");
        Console.WriteLine($"{Contact}");
    }
// вот роли лучше переделать в enum - позволит избежать установки некорректных данных тут
// TODO: переделать роли под отдельную структуру
    public string GetRole()
    {
        return Role;
    }
}