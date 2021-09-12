using System;
using CreatorDemo.Builders.Base.Interfaces;
using CreatorDemo.Builders.Base.Types;

namespace CreatorDemo.Builders.PartBuilder.Parts
{
    public class PedalPart : Part, IPart
    {
        private const PartTypes type = PartTypes.Pedal;
        private static int idCounter = 0;
        public PedalPart() :
            base(type, $" : #PED-{idCounter} : Created : {DateTime.Now.ToUniversalTime()} ")
                => idCounter++;
    }
}