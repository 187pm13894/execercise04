using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace execercise04
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write(Ceil(-15));
            Console.WriteLine();
            Console.Write(Floor(15.6f));
            Console.WriteLine();
        }
        //idea:
        //input: float x
        //output: return the smallest integral value that is not less than x 
        //if x is negative number then x is unchanged
        //if x == a then a is unchange
        public static int Ceil(float x)
        {
            int n = (int)x;
            if(x > 0)
                if(x > n)
                    n = n + 1;
            return n;
        }

        //input: float x
        //output: largest integral value that is not greater than x
        //idea : a = (int) x
        //if x is negative then a = a-1
        //if x == a then a is unchange
        public static int Floor(float x)
        {
            int n = (int)x;
            if(x < 0)
                if(x != n)
                   n = n - 1;
            return n;
        }

       
               
        
    }
}

