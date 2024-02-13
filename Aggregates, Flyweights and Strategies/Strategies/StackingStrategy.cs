using Assi1.Aggregates;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assi1.Strategies
{
    //Interface to be implemented by the different strategies
    public interface StackingStrategy
    {
        float EvaluateStack(HeavyObjectList input);
    }
}
