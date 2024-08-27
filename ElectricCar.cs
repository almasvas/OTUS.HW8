namespace OTUS.HW8
{
    public class ElectricCar : Car
    {
        public int BatteryCapacity { get; set; }

        public ElectricCar(string brand, string model, int numberOfDoors, int batteryCapacity)
            : base(brand, model, numberOfDoors)
        {
            BatteryCapacity = batteryCapacity;
        }

        public override object Clone()
        {
            return new ElectricCar(Brand, Model, NumberOfDoors, BatteryCapacity);
        }

        public override Vehicle MyClone()
        {
            return new ElectricCar(Brand, Model, NumberOfDoors, BatteryCapacity);
        }
    }

}
