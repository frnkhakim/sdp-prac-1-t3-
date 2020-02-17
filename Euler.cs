using System;

namespace euler
{
    class Program
    {
        class Sya {

            const long givenNum = 600851475143;
        long largestFactor = 0;
        
        for (long i = 2; i < givenNum; i++) {
            if (givenNum % i == 0) { 
                bool isPrime = true;
                for (long j = 2; j < i; j++) {
                    if (i % j == 0) {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime) {
                    largestFactor = i;
                }
            }
        }
        }
        
       
        static void Main(string[] args)
        {

            int x  = 0;
		
		        for( int i = 1; i < 1000;i++)
	        	{
		        	if (( (i % 3) == 0) || ((i % 5) == 0))
		        	{
			        	x = x+i;
			        }
			
		        }
		 Console.WriteLine(x);
		
           
        }
<<<<<<< HEAD
        

	public static void Main()
	{
		int[] ar = new int[101];
		for (int i = 0; i <= 100; i++)
		{
			ar[i] = i;
		}

		squareofthesum(ar);
		sumofthesquares(ar);
		double d = squareofthesum(ar) - sumofthesquares(ar);
		Console.WriteLine(squareofthesum(ar));
		
		Console.WriteLine(sumofthesquares(ar));
		
		Console.WriteLine(d);
		
		
	}

	public static double squareofthesum(int[] n)
	{
		int sum = 0;
		for (int h = 0; h <= 100; h++)
		{
			sum = sum + n[h];
		}

		double sqosums = Math.Pow(sum, 2);
		return sqosums;
	}

	public static double sumofthesquares(int[] y)
	{
		double sq = 0;
		for (int p = 0; p <= 100; p++)
		{
			sq = sq + Math.Pow(p, 2);
		
		}
		
        
		return sq;
	}


=======

int i = 1;
 
while (i %  2 != 0 || i %  3 != 0 || i %  4 != 0 || i %  5 != 0 ||
         i %  6 != 0 || i %  7 != 0 || i %  8 != 0 || i %  9 != 0 ||
         i % 10 != 0 || i % 11 != 0 || i % 12 != 0 || i % 13 != 0 ||
         i % 14 != 0 || i % 15 != 0 || i % 16 != 0 || i % 17 != 0 ||
         i % 18 != 0 || i % 19 != 0 || i % 20 != 0 ){
    i++;
}
>>>>>>> 91626222c542caa78257618d9f1927491b1e828e
    }
}

