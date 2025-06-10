using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace csharp_targv24.Kangelane
{
    class Program
    {
        static List<Kangelane> kangelased = new List<Kangelane>();

        static void LoeKangelasedFailist(string failinimi)
        {
            try
            {
                foreach (string rida in File.ReadAllLines(failinimi))
                {
                    string[] andmed = rida.Split('/');
                    string nimi = andmed[0];
                    string asukoht = andmed[1];

                    if (nimi.Contains("*"))
                    {
                        nimi = nimi.Replace("*", "");
                        kangelased.Add(new superkangelane(nimi, asukoht));
                    }
                    else
                    {
                        kangelased.Add(new Kangelane(nimi, asukoht));
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Mingi viga failiga, ei saa faili lugeda");
            }
        }

        static void Main(string[] args)
        {
            string path = @"..\..\..\Kangelane\andmed.txt";
            LoeKangelasedFailist(path);

            foreach (Kangelane kangelane in kangelased)
            {
                if (kangelane is superkangelane superkangelane)
                {
                    Console.WriteLine("\n--- Superkangelane ---");
                    Console.WriteLine(superkangelane.ToString());
                    Console.WriteLine("Päästetud (1000): " + superkangelane.Paasta(1000));
                    Console.WriteLine("Riietus: " + superkangelane.Vormiriietus());
                    Console.WriteLine("Tervitus: " + superkangelane.Tervitus());
                    Console.WriteLine("Staatus: " + superkangelane.MissiooniStaatus());
                }
                else
                {
                    Console.WriteLine("\n--- Tavakangelane ---");
                    Console.WriteLine(kangelane.ToString());
                    Console.WriteLine("Päästetud (1000): " + kangelane.Paasta(1000));
                    Console.WriteLine("Riietus: " + kangelane.Vormiriietus());
                    Console.WriteLine("Tervitus: " + kangelane.Tervitus());
                    Console.WriteLine("Staatus: " + kangelane.MissiooniStaatus());
                }
            }

            Console.ReadKey();
        }

    }
}
