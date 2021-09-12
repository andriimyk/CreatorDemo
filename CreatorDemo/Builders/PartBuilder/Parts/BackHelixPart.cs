using CreatorDemo.Builders.Base.Interfaces;
using CreatorDemo.Builders.Base.Types;
using System;

namespace CreatorDemo.Builders.PartBuilder.Parts
{
    public class BackHelixPart : Part, IPart
    {
        private const PartTypes type = PartTypes.BackHelix;
        private static int idCounter = 0;
        public BackHelixPart() :
            base(type, $" : #BHE-{idCounter} : Created : {DateTime.Now} ")
                => idCounter++;
    }
}