using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationCWebForm.App_Code
{
    public class Vehicle
    {
        public double distance = 0.0;
        public double hour = 0.0;
        public double fuel = 0.0;

        public Vehicle(double distance, double hour, double fuel)
        {
            this.distance = distance;
            this.hour = hour;
            this.fuel = fuel;
        }
        public string Average()
        {
            double average = 0.0;
            average = distance / fuel;
            return string.Format($"Vehicle average is {average} (Base Class)");
        }
        //virtual can be override by derived class
        public virtual string Speed()
        {
            double speed = 0.0;
            speed = distance / hour;
            return string.Format($"Vehicle speed is {speed} (Base Class virtual method)");
        }
    }

    class Car: Vehicle
    {
        public Car(double distance, double hour, double fuel) : base(distance, hour, fuel ) { }
        public string Average() //Car.Average hide inherited member Vehicle.Average
        {
            double average = 0.0;
            average = distance / fuel;
            return string.Format($"Car average is {average} (Derived Class)");
        }
        public override string Speed() //Base class virtual, derived class override
        {
            double speed = 0.0;
            speed = distance / hour;
            return string.Format($"Car speed is {speed} (Derived Class override Bass Class virtual method)");

        }

    }
}