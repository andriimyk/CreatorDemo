using CreatorDemo.Builders.Base.Interfaces;
using CreatorDemo.Builders.Base.Types;
using System;

namespace CreatorDemo.Builders.PartBuilder.Parts
{
    public class BumperPart : Part, IPart
    {
        private const PartTypes type = PartTypes.Bumper;
        private static int idCounter=0;
        public BumperPart() :
            base(type, $" : #BMP-{idCounter} : Created : {DateTime.Now.ToUniversalTime()} ")
                => idCounter++;
    }
}
