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
            int a = 0, b = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                for (int j = 1; j < tab.Length; j++)
                {
                  
                    if (tab[i] > tab[j]-1)
                    {
                        a = tab[i];
                        tab[i] = tab[j];
                        tab[j] = a;
                        
                    }
                    i++;


                }
                   
            }
               
        }
           
    }
}
