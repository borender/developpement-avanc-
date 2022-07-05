using System;

namespace QuentinR_console
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
            int a = 0;
            int b = 0;
            int c = 0;
            for (int i = 0; i < tab.Length; i++)
            {

                for (int j = 0; j < tab.Length; j++)
                {
                    b = tab[j] - 1;
                    
                    if (tab[i] == (tab[j] - 1))
                    {
                        a = tab[j];
                        Console.WriteLine(a);
                        //Console.WriteLine("tab i "+tab[i]);
                        //Console.WriteLine("tab j "+b);
                        continue;
                    }
                    
                }

            }
            
        }
    }
}
