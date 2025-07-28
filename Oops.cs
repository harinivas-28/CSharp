using System;

namespace Basics
{
    interface AquaticAnimal
    {
        void swim();
    }
    class Fish : AquaticAnimal
    {
        public void swim()
        {
            Console.WriteLine("Fish Swiming");
        }
    }
    abstract class Animal
    {
        public abstract void animalSound();
        public void sleep()
        {
            Console.WriteLine("Zzz");
        }
    }
    class Pig : Animal
    {
        public override void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }
    sealed class RootClass
    {
        public RootClass()
        {
            Console.WriteLine("No other class can Inherit this Root class");
        }
    }
    public class Vehicle
    {
        public virtual void honk()
        {
            Console.WriteLine("Peep Peep!");
        }
    }

    public class Car : Vehicle
    {
        public string color = "red";
        public int maxSpeed = 200;
        public string model;
        public int year;
        public string brand;
        public Car(string brandName = "No Brand")
        {
            Console.WriteLine("Car object created!");
            year = 0;
            brand = brandName;
        }
        public override void honk()
        {
            Console.WriteLine("Mustang peep peep!");
        }
        public void fullThrotle()
        {
            Console.WriteLine("The car is going as fast as it can!");
        }
    }

    // Encapsulation
    public class Person
    {
        private string name;
        // getters and setters
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get; set;
        }
    }

    public class Oops
    {
        public Oops()
        {
            Console.WriteLine("Oops object created!");
        }
    }
    // An enum is a special "class" that represents a group of constants (unchangeable/read-only variables).
    enum Level
    {
        Low, Medium, High
    }
    enum Days
    {
        Monday,
        Tuesday,
        Friday = 5,
        Saturday,
        Sunday
    }
}