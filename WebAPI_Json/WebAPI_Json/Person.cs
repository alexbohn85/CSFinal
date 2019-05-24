using System;
namespace WebAPI_Json
{
    public abstract class Person
    {
        // properties
        public string Name { get; set; }
        public string Last_Name { get; set; }
        public string Email { get; set; }

        // methods
        public virtual void Greeting()
        {
            string res = "";
            res += $"\n Hello, I am {Name} {Last_Name},\n";
            res += $" My email is {Email}";
            Console.WriteLine(res);
        }

        // default constructor
        public Person()
        {
            this.Name = "unknown";
            this.Last_Name = "unknown";
            this.Email = "unknown";
        }

        // overload constructor
        public Person(string Name, string Last_Name, string Email)
        {
            this.Name = Name;
            this.Last_Name = Last_Name;
            this.Email = Email;
        }
    }
}
