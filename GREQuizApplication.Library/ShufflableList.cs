﻿using System;
using System.Collections.Generic;
using System.Text;

namespace QuizApplicationLibrary
{
    public static class ShuffleList
    {
        private static Random random = new Random();

        public static void Shuffle<T>(IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
