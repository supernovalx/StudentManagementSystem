using System;

namespace StudentManagementSystem.Object
{
    public abstract class Person
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public DateTime DoB { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }

        protected Person()
        {

        }

        protected Person(string iD, string name, DateTime doB, string address, string email)
        {
            ID = iD;
            Name = name;
            DoB = doB;
            Address = address;
            Email = email;
        }
    }
}
