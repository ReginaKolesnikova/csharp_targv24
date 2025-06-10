using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_targv24.targv_csharp_fourth_part
{
    internal class mainclass_task
    {
        public static void Main(string[] args)
        {
            // 1. Loo failinimi Kuud.txt
            string path = funktsioonideclass4.FailiPath(@"C:\\Kasutajad\\opilane\\source\\repos\\Kolesnikova_TARgv24\\targv_csharp_fourth_part\\kuud.txt");

            // 2. Kirjuta programmi abil 3 kuud faili
            funktsioonideclass4.FailiKirjutamine(path);

            // 3. Loe kuud List<string> sisse
            List<string> kuude_list = funktsioonideclass4.FailiLugemine(path);

            // 4. Eemalda „Juuni“, muuda esimene element
            funktsioonideclass4.EemaldamineMuutmine(path, kuude_list);

            // 5. Kuvada kõik kuud
            foreach (string kuu in kuude_list)
            {
                Console.WriteLine(kuu);
            }

            // 6. Luba kasutajal otsida kuud nime järgi
            Console.WriteLine("Sisesta kuu nimi, mida otsida:");
            string otsitav_kuu = Console.ReadLine();
            string vastus = funktsioonideclass4.Otsing(otsitav_kuu, kuude_list);
            Console.WriteLine(vastus);

            // 7. Salvesta muudatused faili tagasi
            funktsioonideclass4.Salvestamine(path, kuude_list);

        }
    }
}
