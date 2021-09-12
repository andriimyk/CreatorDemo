using CreatorDemo.Builders.Base.Types;
using System.Collections.Generic;

namespace CreatorDemo.Builders.Base.Interfaces
{
    public interface IProduct : IConstructable
    {
        List<IPart> Parts { get; set; }
        //T Build<T>() where T : IProduct, new();
        IProduct Build();
    }
}