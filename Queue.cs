using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_list
{
    public struct Queue<T>
    {
        public T[] Items;
        public int front, rear, count, max;
        public Queue(int max)
        {
            this.Items = new T[max];
            this.front = 0;
            this.rear = 0;
            this.count = 0;
            this.max = max;
        }
        public bool IsEmpty()
        {
            if (count == 0) return true;
            return false;
        }
    }
    public class _Queue
    {
        public void CreateQueue<T>(Queue<T> Q)
        {
            Q.front = 0;
            Q.rear = 1;
        }
        public void EnQueue<T>(Queue<T> Q, T NewItem)
        {
            if (Q.count == Q.max) { Console.WriteLine("Очередь заполнена"); }
            else
            {
                Q.rear = (Q.rear + 1) % Q.max;
                Q.Items[Q.rear] = NewItem;
                ++Q.count;
            }
        }
        public void DeQueue<T>(Queue<T> Q)
        {
            if (Q.IsEmpty())
            {
                Console.WriteLine("Очередь пуста");
            }
            else
            {
                Q.front = (Q.front + 1) % Q.max;
                --Q.count;
            }
        }
        public T GetFront<T>(Queue<T> Q)
        {
            if (Q.IsEmpty())
            {
                Console.WriteLine("Очередь пуста");
                return default(T);
            }
            else
            {
                return Q.Items[Q.front];
            }
        }

    }
}
