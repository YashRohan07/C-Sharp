using System;

public class Cricketer : Player
{
    public int TotalRun { get; set; }
    public int TotalWicket { get; set; }

    public Cricketer(int id, string name, decimal salary, JoiningDate joiningDate, int totalRun, int totalWicket) : base(id, name, salary, joiningDate)
    {
        TotalRun = totalRun;
        TotalWicket = totalWicket;
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Cricketer Information");
        Console.WriteLine($"Id: {Id}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Salary: {Salary}");
        Console.WriteLine($"Joining Date: {JoiningDate}");
        Console.WriteLine($"Total Run: {TotalRun}");
        Console.WriteLine($"Total Wicket: {TotalWicket}");
    }
}
