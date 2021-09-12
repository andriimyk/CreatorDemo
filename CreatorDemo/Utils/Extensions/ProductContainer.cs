using CreatorDemo.Builders.Base.Interfaces;

namespace CreatorDemo.Utils
{
    public class ProductContainer
    {
        public IProduct Car => Of<Car>();
        public IProduct Helicopter => Of<Helicopter>();
        public IProduct Bicycle => Of<Bicycle>();
        private T Of<T>() where T : new() => new T();
    }
}
