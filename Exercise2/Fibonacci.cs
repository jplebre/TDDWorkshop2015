using System;

namespace Exercise2
{
    public class Fibonacci
    {
        public int[] SequenceGenerator(int length)
        {
            int[] sequence = new int[length];

            for (int i = 0; i < sequence.Length; i++)
            {
                if (i < 2)
                    sequence[i] = i;
                else
                    sequence[i] = (i - 1) + (i - 2);
            }
            return sequence;   
        }
    }
}

