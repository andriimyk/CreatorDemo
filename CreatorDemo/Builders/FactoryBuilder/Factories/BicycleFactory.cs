using CreatorDemo.Builders.Base;
using CreatorDemo.Builders.Base.Interfaces;
using CreatorDemo.Builders.Base.Types;
using System;
using static CreatorDemo.Utils.Helper;
using static CreatorDemo.Builders.Base.NotificationHandler;

namespace CreatorDemo.Builders.FactoryBuilder.Factories
{
    public class BicycleFactory : Factory, IFactory, IConstructable
    {
        private static int counter = 0;
        private const FactoryTypes type = FactoryTypes.Bicycle;
        public BicycleFactory() : base(type, $" #C-FCT-{counter}: Created {DateTime.Now}")
        {
            counter++;
        }

        public override IProduct Produce()
        {
            var Bicycle = ToProduct<Bicycle>();
            //ProductionEvent += Handle;
            ProductionEvent.Invoke(this, FormatEventMessage(FACTORY_STARTED, Description));
            ProductionEvent.Invoke(this, FormatEventMessage(ORDER_RECEIVED, Bicycle.Description));
            Bicycle = (Bicycle)Bicycle.Build();
            ProductionEvent.Invoke(this, FormatEventMessage(PRODUCT_COMPLETE, Bicycle.Description));
            //ProductionEvent -= Handle;
            return Bicycle;
        }
    }
}
