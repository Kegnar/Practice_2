namespace Practice_2;

public class Person : IPerson
{
    public enum Role
    {
        Trainer,
        Client
    }

    private static Dictionary<Role, string> _roles = new()
    {
        { Role.Trainer, "Тренер" },
        { Role.Client, "Клиент" }
    };
    
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public ContactInfo Contact { get; set; }
    private Role _role;
    
    
    public void DisplayInfo()
    {
        Console.Write(Contact);
    }

    public string GetRole()
    {
        return _roles[_role];
    }

    public void SetRole(Role role)
    {
        _role = role;
    }
}