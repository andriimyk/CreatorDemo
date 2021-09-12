using CreatorDemo.Builders.Base;
using CreatorDemo.Builders.Base.Interfaces;
using CreatorDemo.Builders.Base.Types;

namespace CreatorDemo.Builders.PartBuilder
{
    public abstract class Part : Constructable<PartTypes>, IPart
    {

        public Part(PartTypes partType, string description):base(partType,description){}
    }
}