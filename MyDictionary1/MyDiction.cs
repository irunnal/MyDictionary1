using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary1
{
    public class MyDiction<TK, TV>
    {
        TK[] keys;
        TV[] values;
        public MyDiction()
        {
            keys = new TK[0];
            values = new TV[0];
            ;
        }

        public void Add(TK key, TV value)
        {
            TK[] tempKey = keys;
            TV[] tempValue = values;

            keys = new TK[keys.Length + 1];
            values = new TV[values.Length + 1];
            for (int i = 0; i < tempKey.Length; i++)
            {
                keys[i] = tempKey[i];

            }
            keys[keys.Length - 1] = key;

            for (int i = 0; i < tempValue.Length; i++)
            {
                values[i] = tempValue[i];

            }
            values[values.Length - 1] = value;
            Console.WriteLine("product id:" + key + "----" + "product name:" + value);
        }

    }
}
