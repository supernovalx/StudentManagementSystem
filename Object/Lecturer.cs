using System;

namespace StudentManagementSystem.Object
{
    public class Lecturer : Person
    {
        public string Dept { get; set; }
        public Lecturer(string iD, string name, DateTime doB, string address, string email, string dept) : base(iD, name, doB, address, email)
        {
            Dept = dept;
        }


        public override string ToString()
        {
            return $"{ID} {Name} {DoB.ToShortDateString()} {Address} {Email} {Dept}";
        }
    }
}
