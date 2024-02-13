using System;
using System.Collections.Generic;
using System.Text;

namespace Assi1.Aggregates
{
    //Public Iterator Interface
    public interface IIterator
    {
        HeavyObject First();
        void Next();
        bool ISDone();
        HeavyObject CurrentItem();
        HeavyObject GetPreviousItem();
    }
}
