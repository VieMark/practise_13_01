namespace practise_13_01;
using System;
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
class Employee: Person{
    public string Position {get ; set ;}
    public Employee(string name, int age, string position){
        Name = name;
        Age = age;
        Position = position;
    }
}

class Program
{
    static void Main()
    {
        Person[]people = {new Person("Tom", 23), new Person("Allan", 31), new Person("Ann", 16)};

        foreach(var i in people){
            i.Intradition();
        }

        Employee worker = new Employee("Richard", 19, "cook");
        worker.Intradition();
    }
}
