using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            csMyDictionary<int, string> csmyDictionary = new csMyDictionary<int, string>();
            csmyDictionary.Add(1, "Mandalina");
            csmyDictionary.Add(2, "Karpuz");
            csmyDictionary.Add(3, "Portakal");
            Console.WriteLine(csmyDictionary.GetValue(1));
            Console.WriteLine(csmyDictionary.GetKey("Karpuz"));
            Console.WriteLine(csmyDictionary.Length());
        }
    }
    
    class csMyDictionary<K,V>
    {
        K[] cKey;
        V[] cValue;
        K[] tempKey;
        V[] tempValue;
        public csMyDictionary()
        {
            cKey = new K[0];
            cValue = new V[0];
        }

        public void Add(K key, V value)
        {

            for (int i = 0; i < cKey.Length; i++)
            {
                if (cKey[i].Equals(key))
                {
                    throw new ArgumentException("Ayni key'e sahip urun onceden eklenmis."); // Ayni key'e sahip onceden eklenmis eleman varsa hata don.
                }
            }

            tempKey = cKey;
            tempValue = cValue;

            cKey = new K[cKey.Length + 1];
            cValue = new V[cValue.Length + 1];

            for (int i = 0; i < tempKey.Length; i++)
            {
                cKey[i] = tempKey[i];
                cValue[i] = tempValue[i];
            }

            cKey[cKey.Length - 1] = key;
            cValue[cValue.Length - 1] = value;

        }

        public K GetKey(V value)
        {
            int index = Array.IndexOf(cValue, value);
            return cKey[index];
        }
        
        public V GetValue(K key)
        {
            int index = Array.IndexOf(cKey, key);
            return cValue[index];
        }

        public int Length()
        {
            return cKey.Length;
        }


    }
    
}
