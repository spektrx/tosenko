// student.cs
class Student : Person
{
    public double GPA { get; set; }

    public Student(string name, int age, double gpa) : base(name, age)
    {
        GPA = gpa;
    }

    public override string ToCsv()
    {
        return $"{base.ToCsv()},{GPA}";
    }

    public override string Print()
    {
        return $"{base.Print()}, GPA: {GPA}";
    }
}
