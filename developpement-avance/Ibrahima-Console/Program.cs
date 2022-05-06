using System;

namespace Ibrahima_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[9];
            tab[0] = 1;
            tab[1] = 3;
            tab[2] = 2;
            tab[3] = 5;
            tab[4] = 7;
            tab[5] = 8;
            tab[6] = 9;
            tab[7] = 4;
            for (int i = 0; i < tab.Length; i++)
            {
                
                Console.WriteLine("Tab : " + tab[i]);
            }
           
        }
    }
}
