﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloGitApp {
    class Program {
        static void Main(string[] args) {
            //0.feladat

            Console.WriteLine("My first git project!");
            Console.WriteLine("Press enter to EXIT");
            Console.ReadLine();
            //1.feladat
            Console.WriteLine("Adja meg hogy hány számból álljon egy tömb, ahova számokat kérünk majd be: ");
            int meretSzam = Convert.ToInt32(Console.ReadLine());
            int[] bekertSzamok = new int[meretSzam];
            int i = 0;
            while(i<10) {
                Console.WriteLine("Kérem ajdon meg egy számot: ");
                bekertSzamok[i] = Convert.ToInt32(Console.ReadLine());
                i++;
            }

            int legnagyobb = 0;
            while(i<bekertSzamok.Length) {
                if (bekertSzamok[i] > legnagyobb) {
                    legnagyobb = bekertSzamok[i];
                }
            }
            Console.WriteLine("A legnagyobb megadott szám: {0}", legnagyobb);

            Console.ReadLine();
        }
    }
}
