using Practice_2.Interfaces;

namespace Practice_2;

public class FitnessCenter
{
    public string Name { get; set; }
    public List<Client> Clients { get; set; }
    public List<Trainer> Trainers { get; set; }

    public FitnessCenter(string name)
    {
        Name = name;
        Clients = new List<Client>();
        Trainers = new List<Trainer>();
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Фитнесс-центр {Name}");
        Console.WriteLine("Тренерский состав:");
        foreach (var trainer in Trainers)
        {
            trainer.DisplayInfo();
            Console.WriteLine("---------------");
        }

        Console.WriteLine("\nСписок клиентов:");
        foreach (var client in Clients)
        {
            client.DisplayInfo();
            Console.WriteLine("---------------");
        }
    }

    public void AddPerson(Person person) // метод сам рассовывает людей в нужные списки
    {
        Type personType = person.GetType();
        if (personType == typeof(Client))
        {
            Clients.Add((Client)person);
            Console.WriteLine("Добавлен клиент");
        }

        
        if (personType == typeof(Trainer))
        {
            Trainers.Add((Trainer)person);
            Console.WriteLine("Добавлен тренер");
        }
    } 
    
}