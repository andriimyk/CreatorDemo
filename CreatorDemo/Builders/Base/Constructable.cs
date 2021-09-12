using CreatorDemo.Builders.Base.Interfaces;

namespace CreatorDemo.Builders.Base
{
    public abstract class Constructable<T> : IConstructable
    {
        public T Type { get; internal set; }
        public string Description { get; }
        public Constructable(T type, string description)
        {
            Description = description;
            Type = type;
        }
        public override string ToString() => $"{Type}:{Description}";
    }
}