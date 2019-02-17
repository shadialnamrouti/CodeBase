using System;

namespace Codebase
{
    //Based on https://en.wikipedia.org/wiki/Queue_(abstract_data_type)
    public class QueueArray<T>
    {
        private T[] Items;
        private int QFront;
        private int QRear;
        private readonly int MaxSize;

        public QueueArray(int maxSize)
        {
            MaxSize = maxSize;
            Items = new T[maxSize];
            QFront = 0;
            QRear = 0;
        }

        public void Enqueue(T item)
        {
            if (IsFull())
                throw new Exception("Overflow!");
            else
                Items[QRear++] = item;
        }

        public T Dequeue()
        {
            if (IsEmpty())
                throw new Exception("Underflow!");
            else
                return Items[QFront++];
        }

        public bool IsEmpty()
        {
            return QRear == QFront;
        }

        public bool IsFull()
        {
            return QRear == MaxSize;
        }

        public void Print()
        {
            Items.Print();
        }

        public int Size()
        {
            return QRear - QFront;
        }

        public T OnRear()
        {
            return Items[QRear];
        }

        public T OnFront()
        {
            return Items[QFront];
        }


    }
}
