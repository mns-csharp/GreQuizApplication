using System;
using System.Collections.Generic;
using System.Text;

namespace QuizApplicationLibrary
{
    public class URandom
    {
        private Random random = new Random();
        private List<int> randomList = new List<int>();

        public int Next(int min, int max)
        {
            int newInt = 0;

            while (true)
            {
                newInt = random.Next(min, max);

                if (!randomList.Contains(newInt))
                {
                    randomList.Add(newInt);
                    break;
                }
            }

            return newInt;
        }
    }
}
