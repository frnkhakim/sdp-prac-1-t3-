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
    }
}

