using System;

class Person
{

    public string name { get; set; }
    public int age { get; set; }

    public Person(string Name, int Age)
    {
        this.name = Name;
        this.age = Age;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {this.name}, Age: {this.age}");
    }
    public Person GetPerson()
    {
        return this;
    }


}

class Program
{
    static void Main(string[] args)
    {

        Person person = new Person("Sanskruti", 21);
        person.DisplayInfo();

        Person currentPerson = person.GetPerson();
        Console.WriteLine($"Current Person: {currentPerson.name}");


    }
}