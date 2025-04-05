using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleInfo
{
    public abstract class Vehicle
    {
        private string brand;
        private int year;

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public abstract string[] DisplayInfo();
    }

    public class Car : Vehicle
    {
        public Car()
        {
            Brand = "Honda";
            Year = 2020;
        }
        public override string[] DisplayInfo()
        {
            return new string[] { Brand, Year.ToString() };
        }
    }

    public class Truck : Vehicle
    {
        public Truck()
        {
            Brand = "Mitsubishi";
            Year = 2012;
        }
        public override string[] DisplayInfo()
        {
            return new string[] { Brand, Year.ToString() };
        }
    }

    public class Motorcycle : Vehicle
    {
        public Motorcycle()
        {
            Brand = "Yamaha";
            Year = 2023;
        }
        public override string[] DisplayInfo()
        {
            return new string[] { Brand, Year.ToString() };
        }
    }
}
