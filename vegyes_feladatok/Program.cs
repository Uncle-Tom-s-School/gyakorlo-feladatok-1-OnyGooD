﻿namespace vegyes_feladatok
{
    internal class Program
    {
        static void feladat1()
        {
            double n = 0;
            double p = 0;
            Console.WriteLine("Mennyien értékelték?");
            n = double.Parse(Console.ReadLine());
            Console.WriteLine("Mennyien értékelték pozitívra?");
            p = double.Parse(Console.ReadLine());
            double overall = (p / n) * 100;
            if (overall >= 90)
            {
                Console.WriteLine($"Nagyon pozitív {overall}%!");
            }
            else if (overall <= 89 & overall >= 75){
                Console.WriteLine($"Pozitív {overall}%!");
            }
            else if (overall <= 74 & overall >= 55)
            {
                Console.WriteLine($"Többnyire pozitív {overall}%!");
            }
            else if (overall <= 54 & overall >= 45)
            {
                Console.WriteLine($"Vegyes {overall}%!");
            }
            else if (overall <= 44 & overall >= 25)
            {
                Console.WriteLine($"Többnyire negatív {overall}%!");
            }
            else if (overall <= 24 & overall >= 10)
            {
                Console.WriteLine($"Negatív {overall}%!");
            }
            else if (overall <= 9 & overall >= 0)
            {
                Console.WriteLine($"Nagyon negatív {overall}%!");
            }

        }

        static void feladat2() { }

        static void feladat3()
        {
            Random rnd = new Random();
            double ev = 0;
            double g = 0;
            double s = 0;
            while (ev <= 365)
            {
                if (ev <= 30)
                {
                    g = rnd.Next(80, 100);
                    s = rnd.Next(60, 80);
                }
                else if (ev >= 31 & ev <= 130)
                {
                    g = rnd.Next(60, 80);
                    s = rnd.Next(40, 60);
                }
                else if (ev >= 140 & ev <= 160)
                {
                    g = rnd.Next(80, 100);
                    s = rnd.Next(60, 80);
                }
                else if (ev >=160 & ev <= 365)
                {
                    g = rnd.Next(60, 80);
                    s = rnd.Next(40, 60);
                }
                Console.WriteLine($"{ev}.nap: {g} guggolás, {s} súlyemelés");
                ev++;
            }
        }


        static void feladat4() { }

        static void Main(string[] args)
        {
            feladat1();
            feladat3();
        }
    }
}
