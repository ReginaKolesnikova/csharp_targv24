using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace targv_csharp_third_part
{
    internal class arvutootlus
    {
        public static (int[], int[]) GenereeriRuudud(int min, int max)
        {
          
            Random rnd = new Random();
            int N = rnd.Next(min, max);
            int M = rnd.Next(min, max);

            int väiksem, suurem;

            if (N < M)
            {
                väiksem = N;
                suurem = M;
            }
            else
            {
                väiksem = M;
                suurem = N;
            }

            int[] arvud = new int[suurem - väiksem - 1];
            int[] ruudud = new int[suurem - väiksem - 1];

            for (int i = 0; i < ruudud.Length; i++)
            {
                arvud[i] = väiksem + i + 1; 
                ruudud[i] = arvud[i] * arvud[i]; 
            }

            return (ruudud, arvud);
        }
    }
}