using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Tablice
    {
         
        public void Powitanie()
        {
            Console.WriteLine("Witaj w pliku tablice");
        }

        public int[] Stworz_tablice()
        {
            Console.WriteLine("ile elementów ma mieć tablica? ");
            int dl = int.Parse(Console.ReadLine());

            int[] ints = new int[dl];
            for (int i = 0; i < ints.Length; i++)
            {
                Console.WriteLine("Podaj kolejny element tablicy");
                ints[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            return ints;

        }

        public void Wyswietl_Tablice(int[] tab)
        {
            
            foreach (int i in tab)
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine();
        }
    }
}
