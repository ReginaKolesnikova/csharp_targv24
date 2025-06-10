using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace targv_csharp_fifth_part
{
    internal class Opilane
    {
        public string Nimi { get; set; }
        public List<int> Hinded { get; set; }

        public double ArvutaKeskmine()
        {
            double summa = 0;
            foreach (int hinne in Hinded)
            {
                summa = summa + hinne;
            }
            return Math.Round(summa / Hinded.Count, 2);
        }
    }
}