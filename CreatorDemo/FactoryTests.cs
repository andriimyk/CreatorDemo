using static CreatorDemo.Builders.Base.NotificationHandler;
using CreatorDemo.Builders.FactoryBuilder.Factories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using CreatorDemo.Builders.Base.Types;
using CreatorDemo.Builders.Base;
using CreatorDemo.Builders.Base.Interfaces;
using CreatorDemo.Builders.PartBuilder.Parts;
using static CreatorDemo.Utils.Helper;

namespace CreatorDemo
{
    

    [TestClass]
    public class FactoryTests
    {
        public IFactory Factory;
        public IProduct Car;
        public IProduct Helicopter;

        [TestInitialize]
        public void Init()
        {
            ProductionEvent += Handler;
            Factory = To.Factory.Car;
        }

        [TestMethod]
        public void ShortExtensionTest()
        {
            Assert.IsInstanceOfType(To.Factory.Car, typeof(CarFactory));
            Assert.IsInstanceOfType(To.Factory.Helicopter, typeof(HelicopterFactory));
            Assert.IsInstanceOfType(To.Factory.Bicycle, typeof(BicycleFactory));
            Assert.IsInstanceOfType(To.Product.Car, typeof(Car));
            Assert.IsInstanceOfType(To.Product.Helicopter, typeof(Helicopter));
            Assert.IsInstanceOfType(To.Product.Bicycle, typeof(Bicycle));
            Assert.IsInstanceOfType(To.Part.Wheel, typeof(WheelPart));
            Assert.IsInstanceOfType(To.Part.Pedal, typeof(PedalPart));
            Assert.IsInstanceOfType(To.Part.Helix, typeof(HelixPart));
            Assert.IsInstanceOfType(To.Part.BackHelix, typeof(BackHelixPart));
            Assert.IsInstanceOfType(To.Part.Engine, typeof(EnginePart));
            Assert.IsInstanceOfType(To.Part.Door, typeof(DoorPart));
            Assert.IsInstanceOfType(To.Part.Bumper, typeof(BumperPart));
        }

        [TestMethod]
        public void ExtensionTest()
        {
            Assert.IsInstanceOfType(ToFactory<CarFactory>(), typeof(CarFactory));
            Assert.IsInstanceOfType(ToFactory<HelicopterFactory>(), typeof(HelicopterFactory));
            Assert.IsInstanceOfType(ToFactory<BicycleFactory>(), typeof(BicycleFactory));
            Assert.IsInstanceOfType(ToProduct<Car>(), typeof(Car));
            Assert.IsInstanceOfType(ToProduct<Helicopter>(), typeof(Helicopter));
            Assert.IsInstanceOfType(ToProduct<Bicycle>(), typeof(Bicycle));
            Assert.IsInstanceOfType(ToPart<WheelPart>(), typeof(WheelPart));
            Assert.IsInstanceOfType(ToPart<PedalPart>(), typeof(PedalPart));
            Assert.IsInstanceOfType(ToPart<HelixPart>(), typeof(HelixPart));
            Assert.IsInstanceOfType(ToPart<BackHelixPart>(), typeof(BackHelixPart));
            Assert.IsInstanceOfType(ToPart<EnginePart>(), typeof(EnginePart));
            Assert.IsInstanceOfType(ToPart<DoorPart>(), typeof(DoorPart));
            Assert.IsInstanceOfType(ToPart<BumperPart>(), typeof(BumperPart));
        }

        [TestMethod]
        public void CarFactoryTest()
        {   
            Car = Factory.Produce();
            Assert.AreEqual(Car.Parts.Count, 11);
            Assert.AreEqual(Car.Parts.Count(x
                =>((Constructable<PartTypes>)x).Type==PartTypes.Wheel), 4);
        }

        [TestMethod]
        public void HelicopterFactoryTest()
        {
            Factory = To.Factory.Helicopter;
            Helicopter = Factory.Produce();
            Assert.AreEqual(Helicopter.Parts.Count, 7);
            Assert.AreEqual(Helicopter.Parts.Count(x
                => ((Constructable<PartTypes>)x).Type == PartTypes.Door), 2);
        }

        [TestCleanup]
        public void Cleanup()
        {
            ProductionEvent -= Handler;
        }
    }
}
