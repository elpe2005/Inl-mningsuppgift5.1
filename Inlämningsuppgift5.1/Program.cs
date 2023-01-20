using System;

namespace uppgift51
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] meningar = { "Hej jag heter Elliot", "Jag bor i Växjö", "Jag går på teknikum" };

            for (int i = 0; i < meningar.Length; i++)
            {
                Console.WriteLine();
                Console.WriteLine(meningar[i]);
            }
        }
    }
}