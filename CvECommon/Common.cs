using System;
using System.IO;
using System.Text.RegularExpressions;

namespace CvECommon
{
    public static class Common
    {
        public static void Shuffle<T> (this Random rng, T[] array)
        {
            int n = array.Length;
            while (n > 1) 
            {
                int k = rng.Next(n--);
                T temp = array[n];
                array[n] = array[k];
                array[k] = temp;
            }
        }

        public static string[] LineToArray(this string item)
        {
            string[] delimiters = { ", " };
            StringSplitOptions options = StringSplitOptions.RemoveEmptyEntries;
            var items = item.Split(delimiters, options);
            for (int i = 0; i < items.Length; i++)
                items[i] = items[i].Trim();
            return items;
        }



    }
}
