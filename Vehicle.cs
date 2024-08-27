namespace OTUS.HW8
{
    public class Vehicle : ICloneable, IMyCloneable<Vehicle>
    {
        public string Brand { get; set; }
        public string Model { get; set; }

        public Vehicle(string brand, string model)
        {
            Brand = brand;
            Model = model;
        }

        public virtual object Clone()
        {
            return new Vehicle(Brand, Model);
        }

        public virtual Vehicle MyClone()
        {
            return new Vehicle(Brand, Model);
        }
    }
}
