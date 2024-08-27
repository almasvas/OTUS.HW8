namespace OTUS.HW8
{
    public class Bike : Vehicle
    {
        public string Type { get; set; }

        public Bike(string brand, string model, string type)
            : base(brand, model)
        {
            Type = type;
        }

        public override object Clone()
        {
            return new Bike(Brand, Model, Type);
        }

        public override Vehicle MyClone()
        {
            return new Bike(Brand, Model, Type);
        }
    }
}
