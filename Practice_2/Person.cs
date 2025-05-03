using Practice_2.Interfaces;
namespace Practice_2;

public abstract class Person:IPerson
{
    public string Name{get;set;}
    public string LastName{get;set;}
    
    // вместо отдельных ID для клиента и тренера появилась идея введения уникального генерируемого ID,
    // который присваивается при создании персоны 
    public string PersonId
    {
        get;
    }

    public ContactInfo Contact{get;set;}
    public RoleInfo Role;
    
    public Person(string name, string lastName, ContactInfo contact, RoleInfo role)
    {
        Name = name;
        LastName = lastName;
        Contact = contact;
        Role = role;
        PersonId = GetHashCode().ToString(); // так мы получим уникальный неизменяемый id для любого человека
    }

    public Person(string name, string lastName, ContactInfo contact) : this(name,lastName,contact,new RoleInfo())
    {
    }

    public Person(string name, string lastName) : this(name, lastName, new ContactInfo())
    {
        
    }
    public Person():this("Нет данных","Нет данных",new ContactInfo(),new RoleInfo())
    {
    }

    public void SetRole(RoleInfo role)
    {
        Role=role;
    }
    
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Имя: {Name}\n" +
                          $"Фамилия: {LastName}\n" +
                          $"{Contact}\n" +
                          $"Тип аккаунта: {GetRole()}\n" +
                            $"ID: {PersonId}");

    }

    public string GetRole()
    {
        return Role.ToString();
    }

    public void SetRole(RoleInfo.Role role)
    {
        Role.SetRole(role);
    }
}