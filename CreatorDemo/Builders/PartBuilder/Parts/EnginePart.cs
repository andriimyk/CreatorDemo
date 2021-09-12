using CreatorDemo.Builders.Base.Interfaces;
using CreatorDemo.Builders.Base.Types;
using System;

namespace CreatorDemo.Builders.PartBuilder.Parts
{
    public class EnginePart : Part, IPart
    {
        private const PartTypes type = PartTypes.Engine;
        private static int idCounter = 0;
        public EnginePart() :
            base(type, $" : #ENG-{idCounter} : Created : {DateTime.Now.ToUniversalTime()} ")
                => idCounter++;

        
    }
}