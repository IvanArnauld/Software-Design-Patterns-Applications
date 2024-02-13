using Assi1.Aggregates;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assi1.Strategies
{
    public class BottomWeight : StackingStrategy
    {
        public float EvaluateStack(HeavyObjectList input)
        {
            //variables declarations
            float bottomWeightScore;
            float massByIndex;
            float sumOfMasses = 0f;
            int listLength = input.Length();

            //For loop to parse through the  HeavyObjectList
            //With the use of its respective iterator
            for (IIterator i = input.CreateIterator(); !i.ISDone(); i.Next())
            {
                //The lower the object in the stack, the greater its mass is going to be multiplied,
                //relative to the total number of objects in the stack
                massByIndex = i.CurrentItem().Mass * listLength--;
                sumOfMasses += massByIndex;
            }


            bottomWeightScore = sumOfMasses / input.Length();

            return bottomWeightScore;
        }
    }
}
