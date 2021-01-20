using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class Mylist<T>
    {
        T[] items;
        //constructor
        public Mylist()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items;  // Önceki elemanlar silinmesin diye geçici bir dizide tutar.
            items = new T[items.Length + 1]; //dizinin elemanını 1 arttırır. Öncekileri siler.
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
           
        }
    }
}
