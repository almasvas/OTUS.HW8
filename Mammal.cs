namespace OTUS.HW8
{
    public class Mammal : Animal
    {
        public bool IsDomestic { get; set; }

        public Mammal(string name, int age, bool isDomestic) : base(name, age)
        {
            IsDomestic = isDomestic;
        }

        public override Animal Clone()
        {
            return new Mammal(Name, Age, IsDomestic);
        }
    }
}
