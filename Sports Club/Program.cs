using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports_Club
{
    class Program
    {
        static void Main(string[] args)
        {
            Cricketer cricketer = new Cricketer(1, "Virat", 100000, new JoiningDate(1, 1, 2023), 1000, 50);
            Footballer footballer = new Footballer(2, "Ronaldo", 50000, new JoiningDate(2, 2, 2023), 10, 5);

            cricketer.ShowInfo();
            footballer.ShowInfo();

            Console.ReadLine();
        }
    }
}
