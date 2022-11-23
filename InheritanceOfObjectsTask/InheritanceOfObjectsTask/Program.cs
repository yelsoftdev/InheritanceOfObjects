using System;

namespace InheritanceOfObjectsTask
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            Person[] persons = new Person[n];
            string[] digitName = { "First", "Second", "Third" };

            Console.WriteLine("*******Input*******");
            Console.WriteLine("You can enter the three names:-");
            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    Console.Write(String.Format($"Enter {digitName[i]} name:"));
                    persons[i] = new Teacher(Console.ReadLine());
                }
                else
                {
                    Console.Write(String.Format($"Enter {digitName[i]} name:"));
                    persons[i] = new Student(Console.ReadLine());
                }
            }

            Console.WriteLine("*******Output*******");
            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    ((Teacher)persons[i]).Explain();
                }
                else
                {
                    ((Student)persons[i]).Study();
                }
            }
        }
    }
    public class Person
    {
        public string name { get; set; }

        public Person(string _name)
        {
            name = _name;
        }

        public override string ToString()
        {
            return String.Format($" {name}");
        }

        ~Person()
        {
            name = string.Empty;
        }
    }
    public class Teacher : Person
    {
        public Teacher(string _name) : base(_name)
        {
            name = _name;
        }

        public void Explain()
        {
            Console.WriteLine("The teacher is explaining");
        }
    }

    public class Student : Person
    {
        public Student(string _name) : base(_name)
        {
            name = _name;
        }

        public void Study()
        {
            Console.WriteLine("The student is studying");
        }
    }

}
