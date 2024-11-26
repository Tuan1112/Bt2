using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentManagement
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Tao danh sach hoc sinh
            List<Student> students = new List<Student>
            {
                new Student { Id = 1, Name = "An", Age = 16 },
                new Student { Id = 2, Name = "Binh", Age = 17 },
                new Student { Id = 3, Name = "Cuong", Age = 18 },
                new Student { Id = 4, Name = "Dung", Age = 15 },
                new Student { Id = 5, Name = "Anh", Age = 19 }
            };

            // a. In danh sach toan bo hoc sinh
            Console.WriteLine("Danh sach toan bo hoc sinh:");
            var allStudents = students.Select(s => s);
            foreach (var student in allStudents)
            {
                Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
            }

            // b. Tim va in ra danh sach cac hoc sinh co tuoi tu 15 den 18
            var studentsAge15To18 = students.Where(s => s.Age >= 15 && s.Age <= 18);
            Console.WriteLine("\nDanh sach hoc sinh co tuoi tu 15 den 18:");
            foreach (var student in studentsAge15To18)
            {
                Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
            }

            // c. Tim va in ra hoc sinh co ten bat dau bang chu "A"
            var studentsNameStartsWithA = students.Where(s => s.Name.StartsWith("A"));
            Console.WriteLine("\nDanh sach hoc sinh co ten bat dau bang chu 'A':");
            foreach (var student in studentsNameStartsWithA)
            {
                Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
            }

            // d. Tinh tong tuoi cua tat ca hoc sinh trong danh sach
            var totalAge = students.Sum(s => s.Age);
            Console.WriteLine($"\nTong tuoi cua tat ca hoc sinh: {totalAge}");

            // e. Tim va in ra hoc sinh co tuoi lon nhat
            var oldestStudent = students.OrderByDescending(s => s.Age).FirstOrDefault();
            if (oldestStudent != null)
            {
                Console.WriteLine($"\nHoc sinh co tuoi lon nhat: Id: {oldestStudent.Id}, Name: {oldestStudent.Name}, Age: {oldestStudent.Age}");
            }

            // f. Sap xep danh sach hoc sinh theo tuoi tang dan va in ra danh sach sau khi sap xep
            var sortedStudents = students.OrderBy(s => s.Age);
            Console.WriteLine("\nDanh sach hoc sinh theo tuoi tang dan:");
            foreach (var student in sortedStudents)
            {
                Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
            }
        }
    }
}
