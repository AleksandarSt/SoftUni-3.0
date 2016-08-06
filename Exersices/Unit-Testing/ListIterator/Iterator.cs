using System;
using System.Collections.Generic;

namespace ListIterator
{
    public class Iterator
    {
        private List<string> collection;
        private int currentIndex = 0;

        public Iterator(List<string> collection)
        {
            this.Collection = collection;
        }

        public Iterator()
        {
            
        }

        public List<string> Collection
        {
            get
            {
                return collection;
            }

            set
            {
                if (value==null)
                {
                    throw new ArgumentNullException("Collection cannot be empty or null.");
                }
                collection = value;
            }
        }

        public int CurrentIndex
        {
            get
            {
                return currentIndex;
            }

            set
            {
                currentIndex = value;
            }
        }

        public bool Move()
        {
            if (this.currentIndex + 1 < collection.Count)
            {
                this.currentIndex++;
                return true;
            }

            return false;
        }

        public bool HasNext()
        {
            if (this.currentIndex + 1 < collection.Count)
            {
                return true;
            }

            return false;
        }

        public string Print()
        {
            if (this.collection.Count==0)
            {
             throw new InvalidOperationException("Invalid operation!");   
            }
            return this.collection[this.currentIndex];
        }
    }
}
