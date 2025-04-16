namespace Practice_2;

public struct ContactInfo
{
    public string Email;
    public string PhoneNumber;

    public override string ToString()
    {
        return "Почта: " + Email + "\nТелефон: " + PhoneNumber;
    }
}