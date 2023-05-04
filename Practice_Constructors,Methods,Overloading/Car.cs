using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Constructors_Methods_Overloading
{
    internal class Car
    {
        string _make;
        string _model;
        string _year;
        int _mileage;

        public string Make { get => _make; set => _make = value; }
        public string Model { get => _model; set => _model = value; }
        public string Year { get => _year; set => _year = value; }
        public int Mileage { get => _mileage; set => _mileage = value; }

        public Car()
        {
            _make = "Unassigned";
            _model = "Unassigned";
            _year = "0";
            _mileage = 0; 
        }

        public Car(string make, string model)
        {
            _make = make;
            _model= model;
            _year = "0";
            _mileage=0;
        }

        public Car(string make, string model, string year, int mileage)
        {
            _make = make;
            _model = model;
            _year = year;
            _mileage = mileage;
        }

        public override string ToString()
        {
            return $" {_year} {_make} {_model} - Mileage {_mileage}";
        }


    }
}
