using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_2
{
    class Student
    {
        private int stId;
        private string stName;

        public int ID///Property
        {
            set
            {
                if(value<=0)
                {
                    Console.WriteLine("Invalild ID");
                }
                else
                {
                    this.stId = value;
                }
                
            }
            get
            {
                return this.stId;
            }
        }
        public string NAME///Property
        {

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Please set/add your name.");
                }
                else
                {
                    this.stName = value;
                }
               
                this.stName = value;
            }
            get
            {
                return this.stName;
            }
        }
       
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            
            s.ID=55;
            s.NAME="Yash";
            Console.WriteLine(s.ID);
            Console.WriteLine(s.NAME);
     
            Console.Read();
        }
    }
}
