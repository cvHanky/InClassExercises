using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading;

namespace Pr52_producerconsumer
{
    class Buffer
    {
        private Queue<Car> bufferData;
        private int capacity;

        private object bufferLock = new object();

        public Buffer(int capacity)
        {
            this.capacity = capacity;
            bufferData = new Queue<Car>();
        }

        public void Put(Car car)
        {
            Monitor.Enter(bufferLock);
            try
            {
                bufferData.Enqueue(car);
            }
            finally
            {
                Monitor.Exit(bufferLock);
            }
            if (bufferData.Count > capacity)
            {
                throw new System.ArgumentException("Køen er fuld");
            }
        }

        public Car Get()
        {
            Car car;
            Monitor.Enter(bufferLock);
            try
            {
                car = bufferData.Dequeue();
            }
            finally
            {
                Monitor.Exit(bufferLock);
            }
            return car;
        }

        public bool IsEmpty()
        {
            bool isempty;
            lock (bufferLock)
            {
                isempty = bufferData.Count == 0;
            }
            return isempty;
        }

        public bool IsFull()
        {
            bool isfull;
            lock (bufferLock)
            {
                isfull = bufferData.Count == capacity;
            }
            return isfull;
        }
    }
}
