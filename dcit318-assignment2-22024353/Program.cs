using System;

class Program
{
    static void Main(string[] args)
    {
        // Task 1: Inheritance and Method Overriding
        Console.WriteLine("Task 1: Inheritance and Method Overriding");

        Animal animal = new Animal();
        Animal dog = new Dog();
        Animal cat = new Cat();

        animal.MakeSound();
        dog.MakeSound();
        cat.MakeSound();

        Console.WriteLine();

        // Task 2: Abstract Classes and Methods
        Console.WriteLine("Task 2: Abstract Classes and Methods");

        Shape circle = new Circle(5);
        Shape rectangle = new Rectangle(4, 6);

        Console.WriteLine($"Circle Area: {circle.GetArea():F2}");
        Console.WriteLine($"Rectangle Area: {rectangle.GetArea()}");

        Console.WriteLine();

        // Task 3: Interfaces
        Console.WriteLine("Task 3: Interfaces");

        IMovable car = new Car();
        IMovable bicycle = new Bicycle();

        car.Move();
        bicycle.Move();
    }
}
