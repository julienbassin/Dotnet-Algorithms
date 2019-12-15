using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarrackerankCsharp
{
    public class Array
    {
        private int[] items;
        private int count;

        public Array(int Length)
        {
            items = new int[Length];
        }

        public void Insert(int item)
        {
            if(items.Length == count)
            {
                int[] newArray = new int[count * 2];

                for (int i = 0; i < count; i++)
                {
                    newArray[i] = items[i];
                }

                items = newArray;
            }
            
            items[count] = item;
            count++;          
            
        }

        public void removeAt(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException();
            }

            for (int i = index; i < count; i++)
            {
                items[i] = items[i + 1];
            }
            count--;
        }

        public int indexOf(int item)
        {
            for (int i = 0; i < count; i++)
            {
                if (items[i] == item)
                {
                    return i;
                }                
            }

            return -1;            
        }

        public void Print()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(items[i]);
            }
        }
    }
}
