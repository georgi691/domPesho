using System;
using System.Collections.Generic;
using System.Linq;

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
        return string.Compare(Name, other.Name, StringComparison.Ordinal);
    }
}
