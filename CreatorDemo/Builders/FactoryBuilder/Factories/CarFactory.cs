using CreatorDemo.Builders.Base;
using CreatorDemo.Builders.Base.Interfaces;
using CreatorDemo.Builders.Base.Types;
using System;
using static CreatorDemo.Builders.Base.NotificationHandler;
using static CreatorDemo.Utils.Helper;

namespace CreatorDemo.Builders.FactoryBuilder.Factories
{
    public class CarFactory : Factory, IFactory, IConstructable
    {
        private static int counter = 0;
        private const FactoryTypes type = FactoryTypes.Car;
        public CarFactory() : base(type, $" #C-FCT-{counter}: Created {DateTime.Now}")
        {
            counter++;
        }

        public override IProduct Produce()
        {

            var car = ToProduct<Car>();
            //ProductionEvent += Handle;
            ProductionEvent.Invoke(this, FormatEventMessage(FACTORY_STARTED, Description));
            ProductionEvent.Invoke(this, FormatEventMessage(ORDER_RECEIVED, car.Description));
            car = (Car)car.Build();
            ProductionEvent.Invoke(this, FormatEventMessage(PRODUCT_COMPLETE, car.Description));
            //ProductionEvent -= Handle;
            return car;
        }
    }
}
