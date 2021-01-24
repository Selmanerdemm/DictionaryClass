using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary<TKey, TValue>
    {
        TKey[] Keys;
        TValue[] Values;

        public MyDictionary()
        {
            Keys = new TKey[0];
            Values = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {
            TKey[] keys = Keys;
            TValue[] values = Values;
            Keys = new TKey[Keys.Length + 1];
            Values = new TValue[Values.Length + 1];

            for (int i = 0; i < keys.Length; i++)
            {
                Keys[i] = keys[i];

            }
            for (int i = 0; i < values.Length; i++)
            {
                Values[i] = values[i];
            }

            Keys[Keys.Length - 1] = key;
            Values[Keys.Length - 1] = value;


        }

        public void Display()
        {

            for(int i = 0; i < Keys.Length; i++)
            {
                Console.WriteLine($" {Keys[i]} : {Values[i]}");
            }
        }

        
    }
}
