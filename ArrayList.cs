using System;

namespace Lab_list
{
    public class ArrayList<T> where T: IEquatable<T>
    {
        private struct List
        {
            public T[] Items;
            public int last;
        }
        private List L;
        public ArrayList()
        {
            L = new List();
            L.Items = new T[100];
            L.last = 0;
        }
        public void Insert(int n, T NewItem)
        {
            if (L.last >= 100) Console.WriteLine("Список полон!");
            else
            {
                if (n < 0) Console.WriteLine("Такой позиции нет!");
                else
                {
                    for (int i = L.last; i >= n; i--)
                    {
                        L.Items[i + 1] = L.Items[i];
                    }
                    L.last++;
                    L.Items[n] = NewItem;
                }
            }
        }
        public void Remove(int n)
        {
            if (n > L.last || n < 0) Console.WriteLine("Такой позиции нет!");
            else
            {
                L.last--;
                for (int i = n; i <= L.last; i++) L.Items[i] = L.Items[i + 1];
            }
        }
        public int Find(T x)
        {
            for (int i = 0; i <= L.last; i++)
            {
                if (L.Items[i].Equals(x)) return i;
            }
            return 101;
        }
    }
}

