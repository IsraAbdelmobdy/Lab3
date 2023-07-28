using System;
using System.Security.Cryptography;

namespace Lab3Q2
{
    class Person
    {
        public string name;
        public int age;
        public Person()
        {
            name = "";
            age = 18;
        }
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public override string ToString()
        {
            return $"Name: {name}, Age: {age}";
        }

    }

    class Employee : Person
    {
        public string NID { get; set; }
        public double Salary { get; set; }
        public Employee()
        {
            NID = string.Empty;
            Salary = 0;
        }
        public Employee(string nID, double salary)
        {
            NID = nID;
            Salary = salary;
        }
        public Employee(string name, int age, string nID, double salary) : base(name, age)
        {
            NID = nID;
            Salary = salary;
        }
        public override string ToString()
        {
            return $"Name: {name}, Age: {age}, National ID: {NID}, Salary: {Salary}";
        }
    }

    class Trainee : Person
    {
        public string NID { get; set; }
        public int IntakeNumber { get; set; }
        public Trainee()
        {
            NID = string.Empty;
            IntakeNumber = 0;
        }
        public Trainee(string nID, int intakeNumber)
        {
            NID = nID;
            IntakeNumber = intakeNumber;
        }
        public Trainee(string name, int age, string nID, int intakeNumber) : base(name, age)
        {
            NID = nID;
            IntakeNumber = intakeNumber;
        }

        public override string ToString()
        {
            return $"Name: {name}, Age: {age}, National ID: {NID}, Intake number: {IntakeNumber}";
        }
    }

    internal class Program
    {
        public static string GetType(Person p)
        {
            return p.GetType().ToString();
        }

        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Person("Isra", 21),
                new Employee("Isra", 21, "747584325535", 12000),
                new Trainee("Momo", 4, "573746378382", 15),
            };

            for (int i = 0; i < persons.Length; i++)
            {
                Console.WriteLine(persons[i].ToString());
            }

            //using Type object.GetType()
            Person p1 = persons[1];
            Type t1 = p1.GetType();
            Console.WriteLine(t1);
            //using the overload function: public static string GetType(Person p)
            Person p2 = persons[2];
            Console.WriteLine(GetType(p2));

        }
        
    }
}