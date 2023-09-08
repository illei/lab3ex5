using System;

namespace lab3ex5
{
    class Program
    {
        static void Main(string[] args)
        {
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
