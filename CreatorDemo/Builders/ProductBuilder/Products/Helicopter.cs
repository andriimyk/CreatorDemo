using CreatorDemo.Builders.Base;
using CreatorDemo.Builders.Base.Interfaces;
using CreatorDemo.Builders.PartBuilder.Parts;
using System;
using CreatorDemo.Builders.Base.Types;

namespace CreatorDemo
{
    public class Helicopter : Product, IProduct
    {
        private const FactoryTypes type = FactoryTypes.Helicopter;
        private static int idCounter = 0;
        public Helicopter() : base(type, new FactoryList<EnginePart>()
                .With<EnginePart>(1)
                .With<WheelPart>(2)
                .With<DoorPart>(2)
                .With<HelixPart>(1)
                .With<BackHelixPart>(1)
            , $" : #PR-HEL-{idCounter} : {DateTime.Now.ToUniversalTime()} ") => idCounter++;

        public override IProduct Build() => Build<Helicopter>();

    }
}