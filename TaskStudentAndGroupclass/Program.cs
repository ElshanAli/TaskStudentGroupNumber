using System;

namespace TaskStudentAndGroupclass
{
    class Program
    {
        static void Main(string[] args)
        {
            Group group = new Group("P324",4);
            Console.WriteLine("Enter the Fullname");
            Student student = new Student(Console.ReadLine(),Console.ReadLine());
            group.AddStudent(student);
            group.GetStudent();


        }
    }
}
