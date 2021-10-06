using System;

namespace DontPanicNCounter
{
    class Program
    {
        static void Main(string[] args)
        {



            string name = "Don't panic!";
            int counter = 0;

            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] == 'n')
                {
                    counter++;
                }
            }

            Console.WriteLine($"Sõnas Don't panic! on {counter} n-tähte.");







        }
    }
}
