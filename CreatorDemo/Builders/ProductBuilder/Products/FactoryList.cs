using CreatorDemo.Builders.Base.Interfaces;
using System.Collections.Generic;
using static CreatorDemo.Utils.Helper;

namespace CreatorDemo
{
    public class FactoryList<T> : List<IPart> where T : IPart, new()
    {
        public FactoryList(IEnumerable<IPart> parts):base(parts)
        {

        }

        public FactoryList(int count=0):base()
        {
            AddRange(With<T>(count));
        }


        public FactoryList<T> With<T1>(int count) where T1 : IPart,new()
        {
            var list = this;
            for (int i = 0; i != count; i++)
                list.Add(To.Part.Of<T1>());
            return this;
        }
    }
}