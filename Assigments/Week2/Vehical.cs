using System;
using System.Collections.Generic;
using System.Text;

namespace Assigments.Week2
{
    /*
     Create a Car class with properties like Make, Model, Year, and Speed. 
     Add methods to accelerate, decelerate, and display the current speed.
     */
    class Car
    {
        public string Model { get; set; }
        public int Year { get; set; }
        public double Speed { get; set; }

        public Car(string model, int year) {
            Model = model;
            Year = year;
            Speed = 0;
        }

        public override string ToString()
        {
            return $"Model : {Model}, Year : {Year}, Speed : {Speed}kmph";
        }

        public void Accelerate(double speed)
        {
            Speed += speed;
            Console.WriteLine("Car speed incresed by "+speed+"kmph");
        }
        public void Decelerate(double speed)
        {
            Speed -= speed;
            Console.WriteLine("Cat speed decreased by "+speed+"kmph");
        }
        public double CurrentSpeed()
        {
            return Speed;
        }
    }
    internal class Vehical
    {
        public static void CarInstance()
        {
            Car car = new Car("Audi",2024);
            Console.WriteLine(car.ToString());

            car.Accelerate(120);

            car.Decelerate(50);

            Console.WriteLine("Car current Speed is "+car.CurrentSpeed());

        }
    }
}
