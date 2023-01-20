using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomQueueWorkshop
{
    public class CustomQueue
    {
        private const int InitialCapacity = 4;
        private const int FirstElementIndex = 0;
        private int[] items;
        private int count;

        public CustomQueue() 
        {
            this.count = 0;
            this.items = new int[InitialCapacity];
        }

        public int Count 
        { 
            get 
            { 
                return this.count; 
            } 
        }

        public void Enqueue(int item)
        {
            if (items.Length == count)
            {
                this.IncreaseSize();
            }
            items[this.count] = item;
            this.count++;
        }

        private void IncreaseSize()
        {
            int[] copy = new int[this.items.Length * 2];
            for (int i = 0; i < this.items.Length; i++)
            {
                copy[i] = this.items[i];
            }
            this.items = copy;
        }

        public int Dequeue()
        {
            if (this.count == 0)
            {
                throw new InvalidOperationException("The queue is empty");
            }
            var firstElement = this.items[FirstElementIndex];
            this.Switch();
            this.count--;
            return firstElement;
        }

        private void Switch()
        {
            for (int i = 0; i < this.count; i++)
            {
                this.items[i] = this.items[i+1];
            }

        }

        public int Peek()
        {
            if (this.count == 0)
            {
                throw new InvalidOperationException("The queue is empty");
            }
            int first = this.items[FirstElementIndex];
            return first;
        }

        public void Clear()
        {
            this.items = new int[InitialCapacity];
            this.count = 0;
        }

        public void ForEach(Action<object> action)
        {
            for (int i = 0; i < this.count; i++)
            {
                action(this.items[i]);
            }
        }
    }
}
