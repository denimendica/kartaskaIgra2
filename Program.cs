﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kartaška_Igra
{
    class Program
    {
        static void Main(string[] args)
        {
            int karte;
            int brojacBodova = 0;

            while (karte < 31)
            {
                Console.Write("Unesite kartu:");
                karte = Convert.ToInt32(Console.ReadLine());


                if (karte < 1 && karte > 13)
                {
                    Console.WriteLine("ponovite upis karte od 1 do 13!");
                    continue;
                }
                brojacBodova += karte;
            }
            if (brojacBodova == 31)
            {
                Console.WriteLine("Pobijedili ste!");
            }
            else
            {
                Console.WriteLine("Izgubili ste!");
            }
            Console.ReadLine();
        }
    }
}