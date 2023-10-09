using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Object
{
    class Tutor
    {
        private int TutorID;
        private string TutorName;

        public void SetTutor(int id, string name)
        {
            TutorID = id;
            TutorName = name;
        }
        public int GetTutorID()
        {
            return TutorID;
        }
        public string GetTutorName()
        {
            return TutorName;
        }
        static void Main(string[] args)
        {
            Tutor t = new Tutor();
            t.SetTutor(101, "K.B.M");
            
            Console.WriteLine(t.GetTutorID());
            Console.WriteLine(t.GetTutorName());
            Console.ReadKey();
        }

        /*
        static void Main(string[] args)
        {
            Tutor t = new Tutor(101, "K.B.M");

            int tutorID = t.GetTutorID();
            string tutorName = t.GetTutorName();

            Console.WriteLine("Tutor ID: " + tutorID);
            Console.WriteLine("Tutor Name: " + tutorName);

            Console.ReadKey();
        }
         */
    }
}
