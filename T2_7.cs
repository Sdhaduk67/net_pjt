using System;

namespace StudentApp
{
    class Student
    {
        private string enrollmentNo;
        private string name;

        public string EnrollmentNo
        {
            get { return enrollmentNo; }
            set { enrollmentNo = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Student()
        {
            enrollmentNo = "";
            name = "";
        }

        public Student(string enrollmentNo, string name)
        {
            this.enrollmentNo = enrollmentNo;
            this.name = name;
        }

        public void ShowDetails()
        {
            Console.WriteLine("Enrollment No: " + enrollmentNo);
            Console.WriteLine("Name: " + name);
        }
    }

    class Demo
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.EnrollmentNo = "23SOECE11013";
            s1.Name = "Shreya";
            s1.ShowDetails();

            Console.WriteLine();
        }
    }
}
