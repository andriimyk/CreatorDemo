using CreatorDemo.Builders.PartBuilder.Parts;
using System;
using CreatorDemo.Builders.Base.Interfaces;
using CreatorDemo.Builders.Base;
using CreatorDemo.Builders.Base.Types;
using static CreatorDemo.Builders.Base.NotificationHandler;

namespace CreatorDemo
{
    public class Car : Product, IProduct
    {
        private const FactoryTypes type = FactoryTypes.Car;
        private static int idCounter = 0;
        public Car() : base(type, 
            parts: new FactoryList<EnginePart>()
                .With<EnginePart>(1)
                .With<WheelPart>(4)
                .With<DoorPart>(4)
                .With<BumperPart>(2)
            , $" #PR-CAR-{idCounter} : Created : {DateTime.Now} ") 

            => idCounter++;

        public override IProduct Build()
        {
            ProductionEvent.Invoke(this, FormatEventMessage(BUILD_STARTED,Description));
            return Build<Car>();
        }
    }
}