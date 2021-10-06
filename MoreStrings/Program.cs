using System;

namespace MoreStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta oma eesnimi:");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Sisesta oma perekonnanimi:");
            string LastName = Console.ReadLine();

            Console.WriteLine($"Tere tulemast, {FirstName[0]}. {LastName[0]}.");





        }
    }
}
