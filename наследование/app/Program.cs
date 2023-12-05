using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите число студентов:");
        int numStudents = int.Parse(Console.ReadLine());

        List<Student> students = new List<Student>();
        for (int i = 0; i < numStudents; i++)
        {
            Student student = GetStudentDetails();
            students.Add(student);
        }

        students.Sort(); // Сортировка студентов

        WriteToCsv(students, "students.csv");

        Console.WriteLine("Введите число преподавателей:");
        int numProfessors = int.Parse(Console.ReadLine());

        List<Professor> professors = new List<Professor>();
        for (int i = 0; i < numProfessors; i++)
        {
            Professor professor = GetProfessorDetails();
            professors.Add(professor);
        }

        professors.Sort(); // Сортировка преподавателей

        WriteToCsv(professors, "professors.csv");

        Console.WriteLine("Данные записаны в файлы students.csv и professors.csv.");
        Console.WriteLine("\nИнформация о студентах:");
        foreach (var student in students)
        {
            Console.WriteLine(student.Print());
        }

        Console.WriteLine("\nИнформация о преподавателях:");
        foreach (var professor in professors)
        {
            Console.WriteLine(professor.Print());
        }

        Console.ReadLine();
    }

    static Student GetStudentDetails()
    {
        Console.WriteLine("Введите данные студента:");
        Console.Write("Имя: ");
        string name = Console.ReadLine();
        Console.Write("Возраст: ");
        int age = int.Parse(Console.ReadLine());
        Console.Write("Средний балл: ");
        double gpa = double.Parse(Console.ReadLine());

        return new Student(name, age, gpa);
    }

    static Professor GetProfessorDetails()
    {
        Console.WriteLine("Введите данные преподавателя:");
        Console.Write("Имя: ");
        string name = Console.ReadLine();
        Console.Write("Возраст: ");
        int age = int.Parse(Console.ReadLine());
        Console.Write("Курс: ");
        string course = Console.ReadLine();

        return new Professor(name, age, course);
    }

    static void WriteToCsv<T>(List<T> data, string fileName) where T : Person
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (var item in data)
            {
                writer.WriteLine(item.ToCsv());
            }
        }
    }
}



