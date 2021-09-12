using CreatorDemo.Builders.Base.Interfaces;
using System;
using CreatorDemo.Builders.Base.Types;

namespace CreatorDemo.Builders.PartBuilder.Parts
{
    public class HelixPart : Part, IPart
    {
        private const PartTypes type = PartTypes.Helix;
        private static int idCounter = 0;
        public HelixPart() :
            base(type, $" : #HEL-{idCounter} : Created : {DateTime.Now} ")
                => idCounter++;
    }
}