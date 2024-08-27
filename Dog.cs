namespace OTUS.HW8
{
    public class Dog : Mammal
    {
        public string Breed { get; set; }

        public Dog(string name, int age, bool isDomestic, string breed)
            : base(name, age, isDomestic)
        {
            Breed = breed;
        }

        public override Animal Clone()
        {
            return new Dog(Name, Age, IsDomestic, Breed);
        }
    }
}
