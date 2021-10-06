using System;

namespace HOLCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            string helloWorld = "Hello World!".ToLower();
            int counterH = 0;
            int counterO = 0;
            int counterL = 0;

            for (int i = 0; i < helloWorld.Length; i++)
            {
                if (helloWorld[i] == 'h')
                {
                    counterH++;
                }
                else if (helloWorld[i] == 'o')
                {
                    counterO++;
                }
                else if (helloWorld[i] == 'l')
                {
                    counterL++;
                }
                else
                {
                    continue;
                }

                Console.WriteLine($"Sõnas {helloWorld} on {counterH} 'h', {counterO} 'o' ja {counterL} 'l' sümbolit. ");

            }

            








        }
    }
}
