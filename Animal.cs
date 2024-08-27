namespace OTUS.HW8
{
    public class Animal : ICloneable, IMyCloneable<Animal>
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual Animal Clone()
        {
            return new Animal(Name, Age);
        }

        object ICloneable.Clone()
        {
            return Clone();
        }
    }
}
