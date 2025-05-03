namespace Practice_2;

public class Trainer: Person
{
    public List<string> Specialization {get; set;}

    public Trainer(string name, string lastName, ContactInfo contactInfo, List<string> specialization) : base(name,
        lastName, contactInfo)
    {
        Role.SetRole(RoleInfo.Role.Trainer); 
        Specialization = specialization;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.Write($"Специализация: ");
        foreach (var item in Specialization)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine("");
    }
}