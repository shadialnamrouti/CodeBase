using System;

namespace Codebase
{
    //Based on https://en.wikipedia.org/wiki/Queue_(abstract_data_type)
    public class QueueArray<T>
    {
        private readonly T[] Items;
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
                Items[QRear] = item;

            QRear++;
        }

        public T Dequeue()
        {
            T item;
            if (IsEmpty())
                throw new Exception("Underflow!");
            else
                item = Items[QFront];

            QFront++;

            return item;
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


    public class QueueArrayCircular<T>
    {
        private readonly T[] Items;
        private int QFront;
        private int QRear;
        private readonly int MaxSize;

        public QueueArrayCircular(int maxSize)
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
                Items[QRear] = item;


            if (QRear == MaxSize - 1)
                QRear = 0;
            else
                QRear++;
        }

        public T Dequeue()
        {
            T item;

            if (IsEmpty())
                throw new Exception("Underflow!");
            else
                item = Items[QFront];

            if(QFront == MaxSize - 1)
                QFront = 0;
            else
                QFront++;

            return item;
        }

        public bool IsEmpty()
        {
            return QRear == QFront;
        }

        public bool IsFull()
        {
            return (QFront == 0 && QRear == MaxSize - 1) || (QRear == QFront - 1);
        }

        public void Print()
        {
            int counter = QFront;

            while (counter == QRear)
            {
                Common.Print(Items[counter]);

                if (counter == MaxSize - 1)
                    counter = 0;
                else
                    counter++;
            }

        }

        public int Size()
        {
            return Math.Abs(QRear - QFront);        
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
