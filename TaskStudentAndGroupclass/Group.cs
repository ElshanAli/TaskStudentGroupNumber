using System;
using System.Collections.Generic;
using System.Text;

namespace TaskStudentAndGroupclass
{
    class Group
    {
        public string GroupNo;
        public byte GroupLimit;
        Student[] _students;
        public Group(string grno,byte limit)
        {
            GroupNo = grno;
            GroupLimit = limit;
            _students = new Student[0];
        }
        public bool AddStudent(Student student)
        {
            if (GroupLimit > _students.Length ) 
            {
                Array.Resize(ref _students, _students.Length + 1);
                _students[_students.Length - 1] = student;

                return true;

            }
            else
            {
                Console.WriteLine("This group is full");
                return false;
            }
        }
        public void GetStudent()
        {
            foreach (var student in _students)
            {
                Console.WriteLine($"Name: {student.Name} Surname: {student.Surname} Group Number: {GroupNo}");
            }
        }
    }
}
