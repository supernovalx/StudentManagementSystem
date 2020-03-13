using System;

namespace StudentManagementSystem.Object
{
    public class Student : Person
    {
        public string Batch { get; set; }
        public Student(string iD, string name, DateTime doB, string address, string email, string batch) : base(iD, name, doB, address, email)
        {
            Batch = batch;
        }

        public override string ToString()
        {
            return $"{ID} {Name} {DoB.ToShortDateString()} {Address} {Email} {Batch}";
        }
    }
}
