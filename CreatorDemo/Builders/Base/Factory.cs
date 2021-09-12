using CreatorDemo.Builders.Base.Interfaces;
using CreatorDemo.Builders.Base.Types;
using System;

namespace CreatorDemo.Builders.Base
{
    public abstract class Factory : Constructable<FactoryTypes>, IFactory
    {
        public Factory(FactoryTypes type, string description) : base(type, description)
        {
        }

        public IProduct Produce(Func<IProduct> factoryMethod)
        {
            return factoryMethod();
        }

        public abstract IProduct Produce();
    }
}