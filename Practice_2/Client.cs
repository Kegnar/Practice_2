namespace Practice_2;

public class Client : Person
{
    MembershipType Membership { get; set; }

    public Client() : base()
    {
        Membership = MembershipType.DropIn;
    }

    public Client(string name, string lastName, ContactInfo contact, MembershipType membership) : base(name, lastName,
        contact)
    {
        Membership = membership;
    }

    public Client(string name, string lastName) : base(name, lastName)
    {
        Membership = MembershipType.DropIn;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Тип абонемента:{Membership}");
    }

    public void SetMembership(MembershipType membership)
    {
        Membership = membership;
    }
}