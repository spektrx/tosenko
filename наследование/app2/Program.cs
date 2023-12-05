internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int studentsAmount = int.pars(Console.ReadLine());

        List<Student> students = new List<Student>();
        for (int i = 0; i < numStudents; i++)
        {
            Student student = GetStudentDetails();
            students.Add(student);
        }
        students.Sort();

    }
    static Student GetStudentDetails()
    {
        Console.WriteLine("Введите данные студента:");
        Console.Write("Имя: ");
        string name = Console.ReadLine();
        Console.Write("phone number: ");
        int phone = int.Parse(Console.ReadLine());
        Console.Write("Email: ");
        double email = double.Parse(Console.ReadLine());
        Console.Write("std-number: ");
        double email = double.Parse(Console.ReadLine());

        return new Student(name, age, gpa);
    }
}