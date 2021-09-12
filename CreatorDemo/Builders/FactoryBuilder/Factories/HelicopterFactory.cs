using CreatorDemo.Builders.Base;
using CreatorDemo.Builders.Base.Interfaces;
using CreatorDemo.Builders.Base.Types;
using System;
using static CreatorDemo.Builders.Base.NotificationHandler;
using static CreatorDemo.Utils.Helper;

namespace CreatorDemo.Builders.FactoryBuilder.Factories
{
    public class HelicopterFactory : Factory, IFactory, IConstructable
    {
        private static int counter = 0;
        private const FactoryTypes type = FactoryTypes.Helicopter;
        public HelicopterFactory() : base(type, $" #H-FCT-{counter} : Created {DateTime.Now}")
        {
            counter++;
        }

        public override IProduct Produce()
        {
            IProduct helic = ToProduct<Helicopter>();
            //ProductionEvent += Handle;
            ProductionEvent.Invoke(this, FormatEventMessage(FACTORY_STARTED, Description));
            ProductionEvent.Invoke(this, FormatEventMessage(ORDER_RECEIVED, helic.Description));
            helic = (Helicopter)helic.Build();
            ProductionEvent.Invoke(this, FormatEventMessage(PRODUCT_COMPLETE, helic.Description));
            //ProductionEvent -= Handle;
            return helic;
        }
    }
}
