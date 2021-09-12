using CreatorDemo.Builders.Base.Interfaces;
using CreatorDemo.Builders.Base.Types;
using System;

namespace CreatorDemo.Builders.PartBuilder.Parts
{
    public class DoorPart : Part, IPart
    {
        private const PartTypes type = PartTypes.Door;
        private static int idCounter = 0;
        public DoorPart() : 
            base(type, $" : #DOR-{idCounter} : Created : {DateTime.Now.ToUniversalTime()} ") 
                => idCounter++;
    }
}
