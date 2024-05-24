// See https://aka.ms/new-console-template for more information

using ConsoleApp2;

Console.WriteLine("Hello, World!");
var test = (float)4;
var test2 = test + 3;
var test3 = test + 3;
var aa = new Dictionary<string, string>();
var a = new Test();
a.GetHashCode();
var b = 2;
var c = 4;

var person = new Person("f");
var person1 = new Person("d");
var person12 = new Person("e");
var person1232 = new Person("f");
person.ShowLastName();

foreach (var e in Person.Persons)
{
    e.ShowLastName();
}

class Person
{
    public static List<Person> Persons { get; set; } = new();
    
    public Person()
    {
        Persons.Add(this);
    }
    
    public Person(string lastName)
    {
        this.LastName = lastName;
        Persons.Add(this);
    }
    
    public string LastName { get; set; }

    public void ShowLastName()
    {
        Console.WriteLine(LastName);
    }
}