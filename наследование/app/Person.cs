// person.cs
using System;

class Person : IComparable<Person>
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public int CompareTo(Person other)
    {
        return string.Compare(this.Name, other.Name, StringComparison.Ordinal);
    }

    public virtual string ToCsv()
    {
        return $"{Name};{Age}";
    }

    public virtual string Print()
    {
        return $"Name: {Name}, Age: {Age}";
    }
}
