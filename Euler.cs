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


    }
}

