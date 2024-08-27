using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTUS.HW8
{
    public class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }

        public Car(string brand, string model, int numberOfDoors)
            : base(brand, model)
        {
            NumberOfDoors = numberOfDoors;
        }

        public override object Clone()
        {
            return new Car(Brand, Model, NumberOfDoors);
        }

        public override Vehicle MyClone()
        {
            return new Car(Brand, Model, NumberOfDoors);
        }
    }

}
