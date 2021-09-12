namespace CreatorDemo.Builders.Base.Interfaces
{
    public interface IFactory : IConstructable
    {
        IProduct Produce();
    }
}