namespace CreatorDemo.Utils
{
    public class Container
    {
        public ProductContainer Product => new ProductContainer();

        public PartContainer Part = new PartContainer();

        public FactoryContainer Factory = new FactoryContainer();
    }
}