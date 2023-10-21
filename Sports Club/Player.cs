public abstract class Player
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Salary { get; set; }
    public JoiningDate JoiningDate { get; set; }

    public Player(int id, string name, decimal salary, JoiningDate joiningDate)
    {
        Id = id;
        Name = name;
        Salary = salary;
        JoiningDate = joiningDate;
    }

    public abstract void ShowInfo();
}
