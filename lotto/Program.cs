using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lotto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kerjuk adjon meg ot kulombozo szamot ");
            int[] nyeroszamok = new int[4];
            string[] file;
            List<int> szamok = new List<int>();
            while(szamok.Count<=4)
            {
                int szam = int.Parse(Console.ReadLine());
                if (szamok.Contains(szam))
                {
                    Console.WriteLine("Ezt a szamot mar megadta.Kerjuk adjon meg egy uj szamot");
                }
                szamok.Add(szam);
            }

            var path = @"otos.csv";
            using (StreamReader sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                   file = sr.ReadLine().Split(';');
                    int counter = 0;
                    for (int i = 11; i < 16; i++)
                    {
                        szamok.Contains(int.Parse(file[i]));
                        if (szamok.Contains(int.Parse(file[i])))
                        {
                            counter++;
                        }
                    }
                    if (counter >= 2)
                    {
                        nyeroszamok[counter - 2]++;
                    }
                }
               
            }
            Console.WriteLine("Kettes talalatok szama:" + nyeroszamok[0]);
            Console.WriteLine("Harmas talalatok szama:" + nyeroszamok[1]);
            Console.WriteLine("Negyes talalatok szama:" + nyeroszamok[2]);
            Console.WriteLine("Teli talalatok szama:" + nyeroszamok[3]);
            Console.ReadLine();
        }
    }
}
