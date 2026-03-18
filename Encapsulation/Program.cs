namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student.SchoolName = "Science School";

            Student s = new Student(101);

            s.Name = "Ali";
            s.Grade = 90;

            // Using Indexer
            s[0] = 80;
            s[1] = 85;
            s[2] = 90;

            Console.WriteLine("Name: " + s.Name);
            Console.WriteLine("ID: " + s.Id);
            Console.WriteLine("Grade: " + s.Grade);
            Console.WriteLine("Average: " + s.Average);
            Console.WriteLine("School: " + Student.SchoolName);
        }
    }
}
