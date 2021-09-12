using CreatorDemo.Builders.Base.Interfaces;
using CreatorDemo.Builders.Base.Types;
using System.Collections.Generic;
using static CreatorDemo.Builders.Base.NotificationHandler; 

namespace CreatorDemo.Builders.Base
{
	public abstract class Product : Constructable<FactoryTypes>, IProduct
	{
		public List<IPart> Parts { get; set; }
		public Product(FactoryTypes type, List<IPart> parts, string description):base(type,description)
		{
			Parts = parts;
		}

		public T Build<T>() where T : IProduct, new()
		{
			var product = new T() { Parts = Parts };
			Parts.ForEach(x => ProductionEvent.Invoke(x, FormatEventMessage(BUILD_STARTED,x.Description)));
			return product;
		}

		public abstract IProduct Build();
	}
}