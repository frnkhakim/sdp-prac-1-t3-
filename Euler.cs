using System;

namespace euler
{
    class Program
    {
       
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
