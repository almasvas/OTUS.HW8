namespace OTUS.HW8
{
    public class Cat : Mammal
    {
        public string Color { get; set; }

        public Cat(string name, int age, bool isDomestic, string color)
            : base(name, age, isDomestic)
        {
            Color = color;
        }

        public override Animal Clone()
        {
            return new Cat(Name, Age, IsDomestic, Color);
        }
    }
}
