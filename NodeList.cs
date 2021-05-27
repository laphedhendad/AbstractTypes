using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_list
{
    public unsafe class NodeList<T> where T: unmanaged, IEquatable<T>
    {
        public struct Node
        {
            public T Item;
            public Node* next;
        }
        Node* S;
        public NodeList()
        {
            Node temp = new Node();
            S = &temp;
            S->next = null;
        }
        public void Insert(T x, int n)
        {
            Node* temp, current;
            current = S;
            int i = 1;
            while(current->next!=null)
            {
                if (i == n)
                {
                    Node _temp = new Node();
                    temp = &_temp;
                    temp->next = current->next;
                    temp->Item = x;
                    current->next = temp;
                    return;
                }
                i++;
                current = current->next;
            }
        }
        public void Remove(int n)
        {
            Node* current = S->next, temp;
            int i = 1;
            while (current!=null && i<n)
            {
                current = current->next;
                i++;
            }
            if (i == n)
            {
                temp = current->next;
                current->next = current->next->next;
                temp = null;
            }
        }
        public int Find(T x)
        {
            Node* current = S->next;
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
        public T Retrieve(int n)
        {
            Node* current = S->next;
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
