public struct ContactInfo
{
    string Email;
    string PhoneNumber;

    public ContactInfo(string email, string phoneNumber)
    {
        Email = email;
        PhoneNumber = phoneNumber;
    }
    public ContactInfo()
    {
        Email = "Не заполнено";
        PhoneNumber = "Ре заполнено";
    }

    public override string ToString()
    {
        return $"Email: {Email}\nНомер телефона: {PhoneNumber}";
    }
}