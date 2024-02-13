using Assi1.Aggregates;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assi1.Strategies
{
    public class Pyramid : StackingStrategy
    {
        public float EvaluateStack(HeavyObjectList input)
        {
            //variables declarations
            float pyramidScore = 0f;
            float sumOfCurrentDimensions;
            float sumOfPreviousDimensions;

            //For loop to parse through the  HeavyObjectList
            //With the use of its respective iterator
            for (IIterator i = input.CreateIterator(); !i.ISDone(); i.Next())
            {
                sumOfCurrentDimensions = i.CurrentItem().Width + i.CurrentItem().Height + i.CurrentItem().Length;
                sumOfPreviousDimensions = i.GetPreviousItem().Width + i.GetPreviousItem().Height + i.GetPreviousItem().Length;

                //Modify the topple score according to the following logic of objects
                //a heavier previous item indicate a +1 score
                if (sumOfCurrentDimensions > sumOfPreviousDimensions)
                {
                    pyramidScore--;
                }
                else if(sumOfPreviousDimensions > sumOfCurrentDimensions)
                {
                    pyramidScore++;
                }
                else
                {
                    pyramidScore += 0;
                }
                
            }

            return pyramidScore;
        }
    }
}
