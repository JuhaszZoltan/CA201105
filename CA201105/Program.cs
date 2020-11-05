using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace CA201105
{
    class Program
    {
        static void Main()
        {
            //F01("Juhász Zoltán");
            //F02("Juhász Zoltán");
            //F03("Juhász Zoltán");
            //F04();
            //F05();
            //F06();
            //F07();
            //F10();
            //F11();
            //F12();
            //F13();
            F14();
            Console.ReadKey();
        }

        private static void F14()
        {
            var magyar = "áÁéÉíÍóÓöÖőŐúÚüÜűŰ";
            var angol =   "aAeEiIoOoOoOuUuUuU";

            var szo = Beker();
            var uj = "";
            for (int i = 0; i < szo.Length; i++)
            {
                if (magyar.Contains(szo[i]))
                    uj += angol[magyar.IndexOf(szo[i])];
                else uj += szo[i];
            }

            Console.WriteLine(uj);
        }

        private static void F13()
        {
            var maganh = "aáeéiíoóöőuúüű";
            var szo = Beker().ToLower();
            var c = 0;
            for (int i = 0; i < szo.Length; i++)
                if (maganh.Contains(szo[i])) c++;
            Console.WriteLine($"ebben a szoban {c} maganhangzo van");
        }

        private static void F12()
        {
            var szo = Beker();
            Console.WriteLine(
                szo.Contains("ly") ? "van benne" : "nincs benne");
        }

        private static void F11()
        {
            var szo = Beker();
            //int i = 0;
            //while (i < szo.Length && szo[i] != 'j') i++;
            //if (i < szo.Length) Console.WriteLine("Van benne j");
            //else Console.WriteLine("Nincs benne j");
            Console.WriteLine(
                szo.Contains('j') ? "van benne" : "nincs benne");
        }

        private static void F10()
        {
            var szo = Beker();
            string nagybetus = szo[0].ToString().ToUpper();
            for (int i = 1; i < szo.Length; i++)
                nagybetus += szo[i];
            Console.WriteLine(nagybetus);
        }

        private static void F07()
        {
            string szo = Beker().Trim();
            //Console.WriteLine($"Ebben a mondatban {szo.Split(' ').Length} szó van");
            if (szo.Length == 0) Console.WriteLine("o szó");
            else if (!szo.Contains(' ')) Console.WriteLine("1 szo");
            else
            {
                var c = 1;
                for (int i = 0; i < szo.Length - 1; i++)
                {
                    if (szo[i] == ' ' && szo[i + 1] != ' ')
                        c++;
                }
                Console.WriteLine($"{c} szó");
            }
        }

        private static string Beker()
        {
            Console.Write("írj be egy szót: ");
            return Console.ReadLine();
        }
        private static void F06()
        {
            var szo = Beker().ToLower();
            var c = 0;
            for (int i = 0; i < szo.Length; i++)
                if(szo[i] == 'e') c++;
            Console.WriteLine($"Ebben a szóban {c} db e betű van");
        }
        private static void F05()
        {
            var szo = Beker();
            for (int i = szo.Length - 1; i >= 0; i--)
                Console.Write(szo[i]);
        }
        private static void F04()
        {
            var szo = Beker();
            for (int i = 0; i < szo.Length + 2; i++)
                Console.Write("*");
            Console.WriteLine($"\n*{szo}*");
            for (int i = 0; i < szo.Length + 2; i++)
                Console.Write("*");
        }
        private static void F03(string nev)
        {
            for (int i = 0; i < nev.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(nev[i]);
            }
        }
        private static void F01(string nev)
        {
            foreach (var c in nev)
            {
                Console.Write(c + " ");
            }
        }
        private static void F02(string nev)
        {
            foreach (var c in nev)
            {
                Console.WriteLine(c);
            }
        }
    }
}
