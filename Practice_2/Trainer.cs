public class Trainer:Person
{
    
    public string TrainerId { get; set; }
    //TODO: Лучше переделатть Специализации во что-то отличное от string
    public List<string> Specializations { get; set; }

    public void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"ID: {TrainerId}");
        Console.WriteLine($"{Specializations}");
    }
    
}