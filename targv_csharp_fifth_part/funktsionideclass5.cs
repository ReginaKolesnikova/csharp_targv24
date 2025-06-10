using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace targv_csharp_fifth_part
{
    internal class funktsionideclass5
    {
        private static Dictionary<string, string> maakonnad = new Dictionary<string, string>()
        {
            { "Harjumaa", "Tallinn" },
            { "Tartumaa", "Tartu" },
            { "Pärnumaa", "Pärnu" }
        };

        public static void OtsiMaakondLinn()
        {
            Console.WriteLine("Sisesta maakonna või linna nimi:");
            string sisend = Console.ReadLine();

            if (maakonnad.ContainsKey(sisend))
            {
                Console.WriteLine($"Maakonna {sisend} pealinn on {maakonnad[sisend]}.");
            }
            else if (maakonnad.ContainsValue(sisend))
            {
                foreach (var paar in maakonnad)
                {
                    if (paar.Value == sisend)
                    {
                        Console.WriteLine($"Linn {sisend} asub maakonnas {paar.Key}.");
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Andmeid ei leitud");
            }
        }

        public static void LisaUusMaakond()
        {
            Console.WriteLine("Sisesta uue maakonna nimi:");
            string uusMaakond = Console.ReadLine();
            Console.WriteLine("Sisesta selle maakonna pealinn:");
            string uusLinn = Console.ReadLine();

            if (maakonnad.ContainsKey(uusMaakond))
            {
                Console.WriteLine("See maakond on juba olemas.");
            }
            else
            {
                maakonnad.Add(uusMaakond, uusLinn);
                Console.WriteLine("Uus maakond on lisatud.");
            }
        }

        public static void ManguReziim()
        {
            Random rnd = new Random();
            List<string> maakonnaNimed = new List<string>(maakonnad.Keys);

            int kokkuKysimusi = 5;
            int õigedVastused = 0;

            for (int i = 0; i < kokkuKysimusi; i++)
            {
                string juhuslikMaakond = maakonnaNimed[rnd.Next(maakonnaNimed.Count)];
                string oigeVastus = maakonnad[juhuslikMaakond];


                Console.WriteLine($"Mis on maakonna {juhuslikMaakond} pealinn?");
                string kasutajaVastus = Console.ReadLine();

                if (kasutajaVastus == oigeVastus || kasutajaVastus.ToLower() == oigeVastus.ToLower())
                {
                    Console.WriteLine("Õige vastus!\n");
                    õigedVastused = õigedVastused + 1;
                }
                else
                {
                    Console.WriteLine($"Vale vastus! Õige vastus oli: {oigeVastus}\n");
                }
            }

          
            double protsent = Math.Round((double)õigedVastused / kokkuKysimusi * 100); 
            Console.WriteLine($"Mäng lõppes! Sa said {õigedVastused} õiget vastust {kokkuKysimusi}st.");
            Console.WriteLine($"Sinu tulemus on {protsent}%.");
        }

        // kuva kõik maakonnad ja nende pealinnad
        public static void KuvaKoik()
        {
            Console.WriteLine("\nKõik maakonnad ja nende pealinnad:");
            foreach (var paar in maakonnad)
            {
                Console.WriteLine($"{paar.Key} - {paar.Value}");
            }
        }
    }
}
