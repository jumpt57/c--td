using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console
{
    class Program
    {
        static double[] T;
        static int TAILLE
            ;
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez rentrer un nombre afin d'initialiser le tableau.");
            try
            {
                TAILLE = Int32.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Entrée invalide, 10 par défaut.");
                TAILLE = 10;
            }
            
            T = new double[TAILLE];
            Random r = new Random((int)DateTime.Now.Ticks);
            for (int i = 0; i < TAILLE; i++)
            {
                T[i] = r.NextDouble() * 10;
            }
            Print(T);

            Console.WriteLine("Appuyez sur n'importe quelle touche du clavier pour voir la tableau trié.");
            Console.ReadLine();
            TriSelectionPermutation(T);
            Print(T);
            Console.ReadLine();
        }

        static void TriSelectionPermutation(double[] tableau)
        {
            int i, iRech, iMin;
            double tmp;
            int N = tableau.Length;
            for (i = 0; i < N; i++)
            {
                for (iRech = iMin = i; iRech < N; iRech++)
                {
                    if (tableau[iRech] < tableau[iMin])
                    {
                        iMin = iRech;
                    }                       
                }
                   
                if (iMin != i)
                {
                    tmp = tableau[iMin];
                    tableau[iMin] = tableau[i];
                    tableau[i] = tmp;
                }
            }
        }

        public static void Print(double[] tableau)
        {
            for (int i = 0; i < tableau.Length; i++)
            {
                Console.WriteLine("T Index => {0} = {1}", i, tableau[i]);
            }                
        }
    }
}
