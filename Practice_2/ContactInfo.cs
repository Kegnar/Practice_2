namespace Practice_2;

public struct ContactInfo
{
    public string Email{get;set;}
    public string PhoneNumber{get;set;}

    public ContactInfo()
    {
        Email = "Нет данных";
        PhoneNumber = "Нет данных";
    }
   
    public override string ToString()
    {
        return $"Контактный телефон: {PhoneNumber},\nПочта: {Email}";
    }
}