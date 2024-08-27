namespace OTUS.HW8
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Тузик", 5, true, "Немецкая овчарка");
            Cat cat = new Cat("Пушок", 3, true, "Серый");

            Dog clonedDog = (Dog)dog.Clone();
            Cat clonedCat = (Cat)cat.Clone();

            Console.WriteLine($"Оригинальная собака: {dog.Name}, Порода: {dog.Breed}");
            Console.WriteLine($"Клонированная собака: {clonedDog.Name}, Порода: {clonedDog.Breed}");

            Console.WriteLine($"Оригинальный Кот: {cat.Name}, Цвет: {cat.Color}");
            Console.WriteLine($"Клонированный Кот: {clonedCat.Name}, Цвет: {clonedCat.Color}");
        }
    }
}
