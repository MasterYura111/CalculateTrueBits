using System;
using System.Collections;
using System.Globalization;
using System.Linq;

class Funct_F
{
    public static int F(int[] array_M)
    {
        
       
        int count_one = 0;
        int i,j;
        

        Array.Sort(array_M);  
        int[] SortM = array_M.Distinct().ToArray();
        int[] array_prev = new int[SortM[SortM.Length-1]+1];

        foreach (int val in SortM)
        {
            i = val;
            Console.WriteLine(i);
            array_prev[i] = 1;
            count_one += 2;
            for(j=i-1;j>=0;j--)
            {
                if (array_prev[j] ==1)
                {
                    count_one -= 2;
                }
                else
                    break;
                
            }

        }


        return count_one;
    }
}
    class Program
    {
        static void Main()
        {
            int[] array = {1,3,5};   //  test
            Console.WriteLine("count one: " + Funct_F.F(array));

        }
    }
