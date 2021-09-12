using CreatorDemo.Builders.Base;
using CreatorDemo.Builders.Base.Interfaces;
using System;
using System.Collections.Generic;
using CreatorDemo.Builders.Base.Types;

namespace CreatorDemo
{
	public class Bicycle : Product, IProduct
	{
		private const FactoryTypes type = FactoryTypes.Bicycle;
		private static int idCounter = 0;
		public Bicycle() : base(type, new List<IPart>() {
			//To.Part.As<EnginePart>(),
			//To.Part.As<WheelPart>(), To.Part.As<WheelPart>(),
			//To.Part.As<DoorPart>(), To.Part.As<DoorPart>(),
			//To.Part.As<HelixPart>(),
			//To.Part.As<BackHelixPart>()
		}, $" : #PR-BIC-{idCounter} : {DateTime.Now.ToUniversalTime()} ") => idCounter++;

		public override IProduct Build() => Build<Bicycle>();
	}
}