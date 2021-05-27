using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_list
{
    unsafe class DoublyLinkedList<T> where T: unmanaged, IEquatable<T>
    {
        public struct _Node
        {
            public T Item;
            public _Node* next;
            public _Node* previous;
        }
        public void CreateList(_Node* S)
        {
            _Node temp = new _Node();
            S = &temp;
            S->next = null;
            S->previous = null;
        }
        public void Insert(T x, int n, _Node* S)
        {
            _Node* temp, current;
            current = S->next;
            int i = 1;
            while (current != null)
            {
                if (i == n)
                {
                    _Node _temp = new _Node();
                    temp = &_temp;
                    temp->next = current->next;
                    temp->previous = current->previous;
                    temp->Item = x;
                    current->next = temp;
                    break;
                }
                i++;
                current = current->next;
            }
        }
        public void Remove(int n, _Node* S)
        {
            _Node* current = S->next, temp;
            int i = 1;
            while (current != null && i < n)
            {
                current = current->next;
                i++;
            }
            if (i == n)
            {
                temp = current->next;
                current->next = current->next->next;
                current->next->previous = current;
                temp = null;
            }
        }
        public int Find(T x, _Node* S)
        {
            _Node* current = S->next;
            int i = 1;
            if (S->next == null) Console.WriteLine("Список пуст!");
            else
            {
                while (current->next != null)
                {
                    if (current->Item.Equals(x)) return i;
                    current = current->next;
                    i++;
                }
            }
            return 0;
        }
        public T Retrieve(int n, _Node* S)
        {
            _Node* current = S->next;
            int i = 1;
            if (S->next == null) Console.WriteLine("Список пуст!");
            else
            {
                while (current->next != null)
                {
                    if (i == n) return (current->Item);
                    current = current->next;
                    i++;
                }
            }
            return default(T);
        }
    }
}
