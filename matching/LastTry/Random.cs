using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LastTry
{
    class Random
    {

        public static void Shuffle<T>(IList<T> list)
        {
            System.Random rnd = new System.Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rnd.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
            List<int> mylist = new List<int>(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
            List<int> mylist2 = new List<int>(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
        }
    }
}
