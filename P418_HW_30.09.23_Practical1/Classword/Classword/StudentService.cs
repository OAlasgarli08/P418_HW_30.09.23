using Classwork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Classwork
{
    internal class StudentService
    {    

        Student[] Students()
        {
            Student student1 = new()
            {
                name = "Student Name A",
                surname = "Student Surname A",
                email = "nameAsurnameA@gmail.com",
                birthday = new DateTime(2007,10,18)
            };

            Student student2 = new()
            {
                name = "Student Name B",
                surname = "Student Surname B",
                email = "nameBsurnameB@gmail.com",
                birthday = new DateTime(2008, 10, 18)
            };

            Student student3 = new()
            {
                name = "Student Name C",
                surname = "Student Surname C",
                email = "nameCsurnameC@gmail.com",
                birthday = new DateTime(2009, 10, 18)
            };

            Student[] allStudents = {student1, student2, student3};
            
            return allStudents;
        }

        public void ShowStudents(DateTime a, DateTime b)
        {
            Student[] allStudents = Students();
            foreach (Student student in allStudents)
            {
                if (student.birthday >= a && student.birthday <= b)
                {
                    Console.WriteLine($"{student.name} --- {student.surname} --- {student.email} --- {student.birthday}");
                }
            }
            
        }
        
    }
}
