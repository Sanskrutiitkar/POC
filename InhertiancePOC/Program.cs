using System;


class Animal
{

    public string Name;


    public Animal(string name)
    {
        Name = name;
    }


    public virtual void Speak()
    {
        Console.WriteLine($"{Name} makes a sound.");
    }
}


class Dog : Animal
{

    public Dog(string name) : base(name)
    {
    }


    public override void Speak()
    {
        Console.WriteLine($"{Name} says Woof");
    }
}

class Cat : Animal
{
 
    public Cat(string name) : base(name)
    {
    }

 
    public override void Speak()
    {
        Console.WriteLine($"{Name} says Meow");
    }
}

class Inheritance
{
    static void Main(string[] args)
    {

        Animal myDog = new Dog("Rocky");
        Animal myCat = new Cat("Chloe");

        myDog.Speak();
        myCat.Speak(); 
    }
}