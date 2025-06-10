using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_targv24.targv_csharp_fourth_part
{
    internal class mainclass4
    {
        public static void Main(string[] args)
        {
            string path;

            // ------- Faili kirjutamine(StreamWriter) -------
            try
            {
                path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"C:\\Kasutajad\\opilane\\source\\repos\\Kolesnikova_TARgv24\\targv_csharp_fourth_part\\kuud.txt"); //@"..\..\..\kuud.txt"
                using (StreamWriter text = new StreamWriter(path, true))  // Fail suletakse automaatselt siin
                {
                    Console.WriteLine("Sisesta mingi tekst: ");
                    string lause = Console.ReadLine();
                    text.WriteLine(lause);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Mingi viga failiga");
            }


            // ------ Faili lugemine (StreamReader) --------
            try
            {
                path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"C:\\Kasutajad\\opilane\\source\\repos\\Kolesnikova_TARgv24\\targv_csharp_fourth_part\\kuud.txt");
                StreamReader text = new StreamReader(path);
                string laused = text.ReadToEnd();
                text.Close();
                Console.WriteLine(laused);
            }
            catch (Exception)
            {
                Console.WriteLine("Mingi viga failiga, ei saa faili lugeda");
            }


            // ------ Ridade lugemine List<string> abil -------
            List<string> kuude_list = new List<string>();
            try
            {
                path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"C:\\Kasutajad\\opilane\\source\\repos\\Kolesnikova_TARgv24\\targv_csharp_fourth_part\\kuud.txt");
                foreach (string rida in File.ReadAllLines(path))
                {
                    kuude_list.Add(rida);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Viga failiga!");
            }


            // ------ Listi muutmine ja kuvamine -------
            foreach (string kuu in kuude_list)
            {
                Console.WriteLine(kuu);
            }

            // Eemalda "Juuni"
            kuude_list.Remove("Juuli");

            // Muuda esimest elementi
            if (kuude_list.Count > 0)
                kuude_list[0] = "Veel kuu";

            Console.WriteLine("--------------Kustutasime juuli-----------");

            foreach (string kuu in kuude_list)
            {
                Console.WriteLine(kuu);
            }


            // ------ Otsing nimekirjast -------
            Console.WriteLine("Sisesta kuu nimi, mida otsida:");
            string otsitav = Console.ReadLine();

            if (kuude_list.Contains(otsitav))
                Console.WriteLine("Kuu " + otsitav + " on olemas.");
            else
                Console.WriteLine("Sellist kuud pole.");


            // -----  Listi salvestamine tagasi faili ------
            path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "kuud.txt");
            File.WriteAllLines(path, kuude_list);
            Console.WriteLine("Andmed on salvestatud.");
        }
    }
}
