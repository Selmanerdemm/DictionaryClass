using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary<TKey, TValue>
    {
        TKey[] item;
        TValue[] items;

        public MyDictionary()
        {
            item = new TKey[0];
            items = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {
            TKey[] keys = item;
            TValue[] values = items;
            item = new TKey[item.Length + 1];
            items = new TValue[items.Length + 1];

            for (int i = 0; i < keys.Length; i++)
            {
                item[i] = keys[i];

            }
            for (int i = 0; i < values.Length; i++)
            {
                items[i] = values[i];
            }

            item[item.Length - 1] = key;
            items[items.Length - 1] = value;


        }

        public void Display()
        {

            for(int i = 0; i < item.Length; i++)
            {
                Console.WriteLine($" {item[i]} {items[i]}");
            }
        }

        
    }
}
