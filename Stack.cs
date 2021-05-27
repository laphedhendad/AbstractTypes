using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_list
{
    unsafe class Stack<T> where T: unmanaged
    {
        private struct StackNode
        {
            public T Item;
            public StackNode* next;
        }
        private StackNode* top;
        public Stack()
        {
            top = null;
        }
        public Stack(ref Stack<T> aStack)
        {
            if (aStack.top == null) { top = null; }
            else
            {
                StackNode temp = new StackNode();
                top = &temp;
                top->Item = aStack.top->Item;
            }
            StackNode* newPtr = top;
            for(StackNode* cur=aStack.top->next; cur!=null; cur = cur->next)
            {
                StackNode temp = new StackNode();
                newPtr->next = &temp;
                newPtr = newPtr->next;
                newPtr->Item = cur->Item;
            }
            newPtr->next = null;
        }
        bool isEmpty()
        {
            return (top == null);
        }
        public void pop(ref T stackTop)
        {
            if (isEmpty()) { Console.WriteLine("стек пуст"); }
            else
            {
                stackTop = top->Item;
                StackNode* temp = top;
                top = top->next;
                temp->next = null;
                temp = null;
            }
        }
        public void pop()
        {
            if (isEmpty()) { Console.WriteLine("стек пуст"); }
            else
            {
                StackNode* temp = top;
                top = top->next;
                temp->next = null;
                temp = null;
            }
        }
        public void push(T newItem)
        {
            StackNode t = new StackNode();
            StackNode* temp = &t;
            temp->Item = newItem;
            temp->next = top;
            top = temp;
        }
        public void getTop(ref T stackTop)
        {
            if (isEmpty()) Console.WriteLine("Стек пуст!");
            else
            {
                stackTop = top->Item;
            }
        }
        ~Stack()
        {
            while (!isEmpty()) pop();
        }
    }
}
