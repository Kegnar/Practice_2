namespace Practice_2.Interfaces;

public abstract class Person:IPerson
{
    public string Name{get;set;}
    public string LastName{get;set;}
    public ContactInfo Contact{get;set;}
    public RoleInfo Role;

    public Person(string name, string lastName, ContactInfo contact, RoleInfo role)
    {
        Name = name;
        LastName = lastName;
        Contact = contact;
        Role = role;
    }

    public Person()
    {
        Name = string.Empty;
        LastName = string.Empty;
        Contact = new ContactInfo();
        Role = new RoleInfo();
    }

    public void SetRole(RoleInfo role)
    {
        Role=role;
    }
    
    
    public void DisplayInfo()
    {
        Console.WriteLine($"Имя: {Name}\nФамилия: {LastName}\n{Contact}");
    }

    public string GetRole()
    {
        return Role.ToString();
    }

    public void SetRole(Role role)
    {
        Role = role;
    }
}