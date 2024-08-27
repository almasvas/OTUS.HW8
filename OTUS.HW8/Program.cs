namespace OTUS.HW8
{
    class Program
    {
        static void Main(string[] args)
        {
            ElectricCar tesla = new ElectricCar("Tesla", "Model S", 4, 100);
            ElectricCar clonedTesla = (ElectricCar)tesla.Clone();
            ElectricCar myClonedTesla = (ElectricCar)tesla.MyClone();

            Console.WriteLine($"Оригинальный объект Tesla: {tesla.Brand}, {tesla.Model}, Дверей: {tesla.NumberOfDoors}, Батарея: {tesla.BatteryCapacity}");
            Console.WriteLine($"Клонированный ICloneable объект Tesla: {clonedTesla.Brand}, {clonedTesla.Model}, Дверей: {clonedTesla.NumberOfDoors}, Батарея: {clonedTesla.BatteryCapacity}");
            Console.WriteLine($"Клонированный IMyCloneable объект Tesla: {myClonedTesla.Brand}, {myClonedTesla.Model}, Дверей: {myClonedTesla.NumberOfDoors}, Батарея: {myClonedTesla.BatteryCapacity}");

            Bike mountainBike = new Bike("Giant", "Trance", "Mountain");
            Bike clonedBike = (Bike)mountainBike.Clone();
            Bike myClonedBike = (Bike)mountainBike.MyClone();

            Console.WriteLine($"Оригинальный объект Bike: {mountainBike.Brand}, {mountainBike.Model}, Тип: {mountainBike.Type}");
            Console.WriteLine($"Клонированный ICloneable объект Bike: {clonedBike.Brand}, {clonedBike.Model}, Тип: {clonedBike.Type}");
            Console.WriteLine($"Клонированный IMyCloneable объект Bike: {myClonedBike.Brand}, {myClonedBike.Model}, Тип: {myClonedBike.Type}");
        }
    }
}
