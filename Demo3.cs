using System;

namespace net_pjt
{
    class Student
    {
        private string firstName;
        private string lastName;

        // 1st way
        public string getFirstName()
        {
            return firstName;
        }

        public void setFirstName(string firstName)
        {
            this.firstName = firstName;
        }

        // 2nd way
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
    }

    internal class Demo3
    {
        static void Main(string[] args)
        {
            Student obj = new Student();

            // 1st way
            obj.setFirstName("Shreya");
            Console.WriteLine(obj.getFirstName());

            // 2nd way
            obj.FirstName = "Shreya";
            Console.WriteLine(obj.FirstName);

            string t = obj.FirstName;
        }
    }
}
