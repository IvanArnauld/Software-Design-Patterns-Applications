using System;
using System.Collections.Generic;
using System.Text;

namespace Assi1.Aggregates
{
    //Public Aggregate Interface to be implemented by the HeavyObjectList
    public interface IAggregate
    {
        IIterator CreateIterator();
    }
}
