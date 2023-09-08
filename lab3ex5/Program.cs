using System;

namespace lab3ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Arpsod adoră două lucruri: matematica și clătitele bunicii sale. Într-o zi, aceasta s-a apucat să
prepare clătite. Arpsod mănâncă toate clătitele începând de la a N-a clătită preparată, până
la a M-a clătită preparată (inclusiv N și M). Pentru că el vrea să mănânce clătite cu diferite
umpluturi și-a făcut următoarea regulă:
 Dacă numărul de ordine al clătitei este prim atunci aceasta va fi cu ciocolată.
 Dacă numărul de ordine este pătrat perfect sau cub perfect aceasta va fi cu gem.
 Dacă suma divizorilor numărului este egală cu însuși numărul de ordine atunci aceasta va fi cu
înghețată. (se iau în considerare toți divizorii în afară de numărul în sine, inclusiv 1).
 Dacă niciuna dintre condițiile de mai sus nu este îndeplinită, pentru cele cu numărul de ordine
par, clătita va fi cu zahar, iar pentru numărul de ordine impar, clătita va fi simplă.”
• Cerința
 Cunoscându-se N și M, numere naturale, să se determine câte clătite a mâncat Arpsod în total și
numărul de clătite din fiecare tip. A*/
            Console.WriteLine("Cele doua  punce :");
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            NumaraClatite(n, m);
        }


        static void NumaraClatite(int x, int y)
        {
            int ciocilata = 0;
            int gem = 0;
            int inghetata = 0;
            int zahar = 0;
            int simple = 0;
            for (int i = x; i <= y; i++)
            {
                if (isPrim(i)) ciocilata++;
                else if (IsPerfectSquare(i) || IsPerfectCubeRoot(i)) gem++;
                else if (IsPerfectNumber(i)) inghetata++;
                else if (Par(i)) zahar++;
                else simple++;
           
            }
            Console.WriteLine("Avem " + (y - x + 1) + "Clatite din care :"+ciocilata+" cu ciocolata, " +gem+"cu gem, "+inghetata+ "cu inghetata, " +zahar+"cu zhar, "+ simple+"simple ");
        }


        static bool Par(int x)
        {
           
            {
                if (x%2 == 0)
                {
                    return true;
                }
               

            }
            return false;
          
        }

        static bool Impar (  int x )
        {
           
            
                if (x % 2 != 0)
                {
                    return true;
                }


            
            return  false;

        }
        static bool isPrim(int x)
        {

            
                int a = 0;
                for (int i = 1; i <= x; i++)
                   
                {
                    if (x == 1) a = 1;
                    if (x % i == 0) a++;

                }
                if (a == 2)
                {
                    return true;
                }      
            
            return false;
        }
        static bool IsPerfectSquare( int x)
        {
           
            
                Double result = Math.Sqrt(x);
                
                if (result % 1 == 0)
                {
                    return true;
                }
               
            
            return false;
        }

        static bool IsPerfectCubeRoot(int x)
        {
          
            
                int cubeRoot = (int)Math.Round(Math.Pow(x, 1.0 / 3.0));
                int cube = cubeRoot * cubeRoot * cubeRoot;

                if (cube == x) return true;
                
            
            return false;
        }

        static bool IsPerfectNumber(int x )
        {
            
            
                int sum = 0;
                for (int j = 1; j < x; j++)
                {
                    if (x % j == 0)
                    {
                        sum = sum+ j;
                    }

                }
                if (sum == x)
                {
                return true; ;
                }
            
            return false;
        }


       
    }
}
