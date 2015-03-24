using System;
using System.Collections;
using System.Globalization;
using System.Linq;

class Funct_F
{
    public static int F(int[] array_M)
    {
        int count_one = 0;
        int remainder=0;
        int val = 0;
        int prev_val = 0;
        int prev_x = 0;
        int mark_first = 1;

        Array.Resize(ref array_M, array_M.Length + 2);  //для обчислень останіх розряду враховуючи остачу 
       
        foreach (int x in array_M)
        {
            val = 1;

            if(x==0)
                val=0;
            
            if ((x - prev_x>1) && mark_first==0 )
            {
                if(x-prev_x>1 && remainder==0)
                   count_one++;
                
                if (x - prev_x > 2 && remainder == 1)
                {
                    count_one++;
                    remainder = 0;
                }

                prev_val = 0;
            }
            
            if (val == 1 && prev_val == 1)
            {
                if (remainder == 1)
                    count_one++;
                
                remainder = 1;
            }

            if ((val == 1 && prev_val == 0)
                || (val == 0 && prev_val == 1))
            {
                if (remainder == 0)
                   count_one++;
            }

            if (val == 0 && prev_val == 0)
            {
                if (remainder == 1)
                {
                    count_one++;
                    remainder = 0;
                }
            }

            prev_val = val;
            prev_x = x;

            if (mark_first==1)
                mark_first = 0;
           
        }

        return count_one;
    }
}
    class Program
    {
        static void Main()
        {
            int[] array = { 2, 4, 6, 7, 10, 11, 12, 13, 14, 15, 16, 20 }; // //if array value>=1
            Console.WriteLine("count one: " + Funct_F.F(array));
        }
    }
