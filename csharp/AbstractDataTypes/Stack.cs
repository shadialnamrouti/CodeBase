using System;

namespace Codebase
{
    //Based https://en.wikipedia.org/wiki/Stack_(abstract_data_type)
    public class StackArray<T>
    {
        private readonly T[] Items;
        private int StackTop;
        private readonly int MaxSize;

        public StackArray(int maxSize)
        {
            MaxSize = maxSize;
            Items = new T[maxSize];
            StackTop = 0;
        }

        public void Push(T item)
        {
            if (IsFull())
                throw new Exception("Overflow!");
            else
                Items[StackTop] = item;

            StackTop++;
        }

        public T Pop()
        {
            T item;

            if (IsEmpty())
                throw new Exception("Underflow!");
            else
            {
                --StackTop;
                item = Items[StackTop];
            }

            return item;

        }

        public bool IsEmpty()
        {
            return StackTop == 0;
        }

        public bool IsFull()
        {
            return StackTop == MaxSize;
        }

        public void Print()
        {
            Items.Print();
        }

        public int Size()
        {
            return StackTop + 1;
        }

        public T OnTop()
        {
            return Items[StackTop];
        }

    }
}
