﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TouchCamLibrary
{
    public static class CustomExtensions
    {
        private static Dictionary<int, Random> randoms = new Dictionary<int, Random>();
        
        private static Random GetRandom(int seed)
        {
            if (!randoms.ContainsKey(seed)) randoms.Add(seed, seed > 0 ? new Random(seed) : new Random());
            return randoms[seed];
        }

        public static void Shuffle<T>(this IList<T> list, int seed = -1)
        {
            Random rng = new Random(seed);

            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        public static void ShuffleAfterFirst<T>(this IList<T> list, int seed = -1)
        {
            Random rng = new Random(seed);

            int n = list.Count - 1;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1) + 1;
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        public static string TrimNumbers(this string text)
        {
            return text.Trim('0', '1', '2', '3', '4', '5', '6', '7', '8', '9');
        }

        public static List<float> ToFloatArray(this List<string> array)
        {
            List<float> fArray = new List<float>();
            foreach (string text in array)
            {
                if (text.ToLower() == "nan")
                {
                    //fArray.Add(float.NaN);
                    fArray.Add(0);
                }
                else
                {
                    float f = float.Parse(text);
                    fArray.Add(f);
                }
            }
            return fArray;
        }

        public static List<float> Multiply(this List<float> array, float multiplier)
        {
            List<float> newArray = new List<float>();
            foreach (float value in array) newArray.Add(value * multiplier);
            return newArray;
        }

        public static IEnumerable<IEnumerable<T>> Combinations<T>(this IEnumerable<T> elements, int k)
        {
            return k == 0 ? new[] { new T[0] } :
              elements.SelectMany((e, i) =>
                elements.Skip(i + 1).Combinations(k - 1).Select(c => (new[] { e }).Concat(c)));
        }
    }
}
