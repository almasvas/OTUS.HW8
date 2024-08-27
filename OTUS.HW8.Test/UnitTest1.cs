using OTUS.HW8;

namespace Test
{
    [TestFixture]
    public class CloningTests
    {
        [Test]
        public void TestVehicleClone()
        {
            var vehicle = new Vehicle("Toyota", "Corolla");
            var clonedVehicle = (Vehicle)vehicle.Clone();
            var myClonedVehicle = vehicle.MyClone();

            Assert.AreNotSame(vehicle, clonedVehicle);
            Assert.AreNotSame(vehicle, myClonedVehicle);

            Assert.AreEqual(vehicle.Brand, clonedVehicle.Brand);
            Assert.AreEqual(vehicle.Model, clonedVehicle.Model);

            Assert.AreEqual(vehicle.Brand, myClonedVehicle.Brand);
            Assert.AreEqual(vehicle.Model, myClonedVehicle.Model);
        }

        [Test]
        public void TestCarClone()
        {
            var car = new Car("Honda", "Civic", 4);
            var clonedCar = (Car)car.Clone();
            var myClonedCar = (Car)car.MyClone();

            Assert.AreNotSame(car, clonedCar);
            Assert.AreNotSame(car, myClonedCar);

            Assert.AreEqual(car.Brand, clonedCar.Brand);
            Assert.AreEqual(car.Model, clonedCar.Model);
            Assert.AreEqual(car.NumberOfDoors, clonedCar.NumberOfDoors);

            Assert.AreEqual(car.Brand, myClonedCar.Brand);
            Assert.AreEqual(car.Model, myClonedCar.Model);
            Assert.AreEqual(car.NumberOfDoors, myClonedCar.NumberOfDoors);
        }

        [Test]
        public void TestElectricCarClone()
        {
            var electricCar = new ElectricCar("Tesla", "Model 3", 4, 75);
            var clonedElectricCar = (ElectricCar)electricCar.Clone();
            var myClonedElectricCar = (ElectricCar)electricCar.MyClone();

            Assert.AreNotSame(electricCar, clonedElectricCar);
            Assert.AreNotSame(electricCar, myClonedElectricCar);

            Assert.AreEqual(electricCar.Brand, clonedElectricCar.Brand);
            Assert.AreEqual(electricCar.Model, clonedElectricCar.Model);
            Assert.AreEqual(electricCar.NumberOfDoors, clonedElectricCar.NumberOfDoors);
            Assert.AreEqual(electricCar.BatteryCapacity, clonedElectricCar.BatteryCapacity);

            Assert.AreEqual(electricCar.Brand, myClonedElectricCar.Brand);
            Assert.AreEqual(electricCar.Model, myClonedElectricCar.Model);
            Assert.AreEqual(electricCar.NumberOfDoors, myClonedElectricCar.NumberOfDoors);
            Assert.AreEqual(electricCar.BatteryCapacity, myClonedElectricCar.BatteryCapacity);
        }

        [Test]
        public void TestBikeClone()
        {
            var bike = new Bike("Giant", "Escape 3", "Road");
            var clonedBike = (Bike)bike.Clone();
            var myClonedBike = (Bike)bike.MyClone();

            Assert.AreNotSame(bike, clonedBike);
            Assert.AreNotSame(bike, myClonedBike);

            Assert.AreEqual(bike.Brand, clonedBike.Brand);
            Assert.AreEqual(bike.Model, clonedBike.Model);
            Assert.AreEqual(bike.Type, clonedBike.Type);

            Assert.AreEqual(bike.Brand, myClonedBike.Brand);
            Assert.AreEqual(bike.Model, myClonedBike.Model);
            Assert.AreEqual(bike.Type, myClonedBike.Type);
        }
    }
}