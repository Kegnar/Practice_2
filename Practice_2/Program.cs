using Practice_2;
var person0 = new Client(); // проверка работы конструктора для персоны без данных
var person1 = new Client("Вася", "Пупкин",
    new ContactInfo("client@fitness.com", "+71234567890"),
    MembershipType.Monthly);

var person2 = new Trainer("Биба", "Бобов",
    new ContactInfo("trainer1@fitness.com", "+79876543210"),
    ["Кардио", "Силовые", "Аэробика"]); // применен модный способ инициализации коллекции

var person3 = new Client("Чувак", "Тестовый",
    new ContactInfo("test@qwe.com", "+722332223323"),
    MembershipType.Yearly);

var person4 = new Trainer("Петя", "Гопников", new ContactInfo("trainer2@fitenss.com", "+7282828282"),
    ["Литрбол", "Алкодебошинг"]);

var center = new FitnessCenter("куку");

center.AddPerson(person0);
center.AddPerson(person1);
center.AddPerson(person2);
center.AddPerson(person3);
center.AddPerson(person4);
center.ShowInfo();
Console.WriteLine("****Проверка изменения абонемента****");
person1.SetMembership(MembershipType.DropIn);
person1.DisplayInfo();
