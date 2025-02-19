﻿namespace practise_13_01;
using System;

public abstract class Shape{
    public abstract double GetArea();
    public abstract double GetPerimeter();

}

public class Rectangle : Shape {
    public int Wight {get; set;}
    public int Height {get; set;}

    public Rectangle (int wight, int height) {
        Wight = wight;
        Height = height;
    }

    public override double GetArea()
    {
        return Wight*Height;
    }
    public override double GetPerimeter()
    {
        return (Wight+Height)*2;
    }
}
public class Circle : Shape {
    public int Radius {get; set;}

    public Circle (int radius) {
        Radius = radius;
    }
    public override double GetArea()
    {
        return 3.14*Radius*Radius;
    }
    public override double GetPerimeter()
    {
        return 2*3.14*Radius;
        
    }
}

class Animal {
    public string Breed {get; set;}
    public int Age {get; set;}
    public Animal(string breed, int age){
        Breed = breed;
        Age = age;
    }
    public string GetSetBreed{
        get{return Breed;}
        set{Breed = value;}
    }
    public int GetSetAge{
        get{return Age;}
        set{Age = value;}
    }

    
}
class Person {
    public string Name {get; set;}
    public int Age {get; set;}

    public Person(string name, int age){
        Name = name;
        Age = age;
    }

    public void Intradition(){
        Console.WriteLine($"Моё имя - {Name}.");
    }
    public virtual void Work(){
        Console.WriteLine($"{Name} работает");
    }
    public int Agess {
        get{return Age;}
        private set{
            if (Age<0){
                Console.WriteLine("Возраст не может быть меньше нуля!");
            }
            else {Age=value;}
        }
    }
    public void Wr_Age(){
        Console.WriteLine($"Мне {Age} лет.");
    }
}
// Создайте класс Employee, который наследуется от Person и добавляет поле position.
class Employee : Person{
    public string Position {get ; set ;}
    public Employee( string position, string name, int age) : base(name, age)
    {
        Position = position;
    }

    public override void Work(){
        Console.WriteLine($"{Name} работает на профессии - {Position}");
    }
}
class Program
{
    static void Main()
    {
        /*
        Person[]people = {new Person("Tom", 23), new Person("Allan", 31), new Person("Ann", 16)};

        foreach(var i in people){
            i.Intradition();
        }

        Employee worker = new Employee("cook","Richard", 19 );
        worker.Intradition();
        worker.Work();

        Animal Dog = new Animal("lablador", 3);
        */

        Shape[] massiv = {new Circle(3) , new Circle(12), new Rectangle(12, 5) };
        foreach (var i in massiv ){
            Console.WriteLine(i.GetArea);
            Console.WriteLine(i.GetPerimeter);
        }

    }
}
