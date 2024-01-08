using System;

public class Footballer : Player
{
    public int TotalGoal { get; set; }
    public int TotalAssist { get; set; }

    public Footballer(int id, string name, decimal salary, JoiningDate joiningDate, int totalGoal, int totalAssist) : base(id, name, salary, joiningDate)
    {
        TotalGoal = totalGoal;
        TotalAssist = totalAssist;
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Footballer Information");
        Console.WriteLine($"Id: {Id}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Salary: {Salary}");
        Console.WriteLine($"Joining Date: {JoiningDate}");
        Console.WriteLine($"Total Goal: {TotalGoal}");
        Console.WriteLine($"Total Assist: {TotalAssist}");
    }
}
