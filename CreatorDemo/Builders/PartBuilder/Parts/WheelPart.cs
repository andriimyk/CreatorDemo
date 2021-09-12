using CreatorDemo.Builders.Base.Interfaces;
using System;
using CreatorDemo.Builders.Base.Types;

namespace CreatorDemo.Builders.PartBuilder.Parts
{
    public class WheelPart : Part, IPart
    {
        private const PartTypes type = PartTypes.Wheel;
        private static int idCounter = 0;
        public WheelPart() : base(type, $" : #WHL-{idCounter} : Created : {DateTime.Now} ")
        {
            WheelPart.idCounter++;
        }
    }
}