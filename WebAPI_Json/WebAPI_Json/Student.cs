using System;
using System.Collections.Generic;
using System.Linq;
namespace WebAPI_Json
{
    public class Student: Person, IUpdatable
    {
        // properties
        public Dictionary<string,bool> Skillset { get; set; }
        public string Program { get; set; }
        public DateTime Start_Date { get; set; }
        public DateTime Update_Date { get; set; }

        // default constructor
        public Student() : base()
        {
            this.Skillset = new Dictionary<string, bool>();
            this.Program = "unknown";
            this.Start_Date = DateTime.Now;
            this.Update_Date = DateTime.Now;
        }

        // overload constructor
        public Student(string Name, string Last_Name, string Email, Dictionary<string, bool> Skillset, string Program, DateTime Update_Date, DateTime Start_Date) : base(Name, Last_Name, Email)
        {
            this.Skillset = Skillset;
            this.Program = Program;
            this.Start_Date = Start_Date;
            this.Update_Date = Update_Date;
        }

        public override void Greeting()
        {
            Console.WriteLine(string.Concat(Enumerable.Repeat("#", 70)));
            base.Greeting();
            string res = "";
            res += $" I have started {Program} at {Start_Date.ToString("MMMM dd, yyyy")} in ITD Canada\n";
            res += $" I am able to develop code in the following programming languages\n";
            for (int i = 0; i < Skillset.Count; i+=1)
            {
                if (Skillset.ElementAt(i).Value == true)
                {
                    res += $" {Skillset.ElementAt(i).Key}";
                }
            }
            res += "\n";
            res += $"\nUpdated : {Update_Date.ToString("MMMM dd, yyyy")}";
            Console.WriteLine(res);
            Console.WriteLine(string.Concat(Enumerable.Repeat("#", 70)));
        }
    }
}
