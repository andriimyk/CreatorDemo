using CreatorDemo.Builders.Base.Interfaces;

namespace CreatorDemo.Utils
{
    public class Helper
    {
        public static Container To => new Container();

        public static IProduct ToProduct<T>() where T : IProduct, new() => new T();
        public static IPart ToPart<T>() where T : IPart, new() => new T();
        public static IFactory ToFactory<T>() where T : IFactory, new() => new T();
    }
}