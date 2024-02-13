using System;
using System.Collections.Generic;
using System.Text;

namespace Assi1.Aggregates
{
    public class HeavyObjectList : IAggregate
    {
        //Our template list from .net we use to store our objects
        protected List<HeavyObject> container = new List<HeavyObject>();

        //Create a respective iterator for this HeavyObjectList
        public IIterator CreateIterator()
        {
            return new HeavyObjectListIterator(this);
        }

        //Add an object to the list
        public void Add(HeavyObject item)
        {
            container.Add(item);
        }

        //Get an object from the list at a specific index
        public HeavyObject Get(int position)
        {
            return container[position];
        }

        //Return the length of the list, that is, how many element it currently has
        public int Length()
        {
            return container.Count;
        }

        //Print the list in a preferred format making use of the HeavyObject.Print() mehtod
        public void Print()
        {
            for (IIterator i = CreateIterator(); !i.ISDone(); i.Next())
            {
                i.CurrentItem().Print();
            }
        }
    }
}
