using CreatorDemo.Builders.Base.Interfaces;
using CreatorDemo.Builders.FactoryBuilder.Factories;

namespace CreatorDemo.Utils
{
    public class FactoryContainer
    {
        public CarFactory Car => Of<CarFactory>();
        public HelicopterFactory Helicopter => Of<HelicopterFactory>();
        public IFactory Bicycle => Of<BicycleFactory>();
        private T Of<T>() where T : new() => new T();
    }
}