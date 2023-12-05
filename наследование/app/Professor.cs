// professor.cs
class Professor : Person
{
    public string Course { get; set; }

    public Professor(string name, int age, string course) : base(name, age)
    {
        Course = course;
    }

    public override string ToCsv()
    {
        return $"{base.ToCsv()};{Course}";
    }

    public override string Print()
    {
        return $"{base.Print()}, Course: {Course}";
    }
}
