using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    internal class AddValue<TK, TV>
    {
        public TK[] Key;
        public TV[] Value;
        public TK[] TempKey;
        public TV[] TempValue;
        public AddValue()
        {
            Key = new TK[0];
            Value = new TV[0];
        }
        public void Add(TK key, TV value)
        {
            TempKey = Key;
            TempValue = Value;
            Key = new TK[Key.Length + 1];
            Value = new TV[Value.Length + 1];
            for (int i = 0; i < TempKey.Length; i++)
            {
                Key[i] = TempKey[i];
                Value[i] = TempValue[i];

            }
            Key[Key.Length - 1] = key;
            Value[Value.Length - 1] = value;
        }
        public void List()
        {
            for (int i = 0; i < TempKey.Length; i++)
            {
                Console.WriteLine($"{Key[i]} {Value[i]}");


            }
        }
    }
}
