using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_list
{
    class StackArray<T>
    {
        private const int Max_size = 100;
        T[] Stack;
        public int top;
        public StackArray()
        {
            Stack = new T[Max_size];
            top = 0;
        }
        public void pop()
        {
            if (top == 0) Console.WriteLine("Стек пуст");
            else --top;
        }
        public void push(T NewItem)
        {
            if (top >= Max_size) Console.WriteLine("Стек полон");
            else Stack[++top] = NewItem;
        }
        public T getTop()
        {
            if (top == 0)
            {
                Console.WriteLine("Стек пуст");
                return default(T);
            }
            else return Stack[top];
        }
        public bool isEmpty()
        {
            return (top == 0);
        }
        public void DestroyStack()
        {
            top = 0;
        }
    }
}
