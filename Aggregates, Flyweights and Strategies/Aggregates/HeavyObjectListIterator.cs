using System;
using System.Collections.Generic;
using System.Text;

namespace Assi1.Aggregates
{
    public class HeavyObjectListIterator : IIterator
    {
        //Declaring variables
        protected HeavyObjectList heavyObjectList;
        protected int index;

        //One argument constructor
        public HeavyObjectListIterator(HeavyObjectList objectList)
        {
            this.heavyObjectList = objectList;
            index = 0;
        }

        //Returns the current item in the list
        public HeavyObject CurrentItem()
        {
            return heavyObjectList.Get(index);
        }

        //Returns the previous item in the list relative to the index
        //A safety "if" is added to prevent the passing of negative index
        public HeavyObject GetPreviousItem()
        {
            if (index > 0)
                return heavyObjectList.Get(index - 1);
            else
                return heavyObjectList.Get(0);
        }

        //Returns the first item in the list
        public HeavyObject First()
        {
            return heavyObjectList.Get(0);
        }

        //Indicates whether we reached the end of our list or not
        public bool ISDone()
        {
            return index >= heavyObjectList.Length();
        }

        //Increment the index to move onto the next item in the list
        public void Next()
        {
            ++index;
        }
    }
}
