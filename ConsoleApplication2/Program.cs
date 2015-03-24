using System;
using System.Collections;
using System.Globalization;
using System.Linq;

class Funct_F
{
    public static int F(int[] array_M)
    {
        
       
        int count_one = 0;
        int i;
        int max_count;
        int min_count;
        int next_index_array;
        int next_val_array;
        int remainder=0;
        int mark_last = 0;

        Array.Sort(array_M);  
        int[] SortM = array_M.Distinct().ToArray();

        int[] array_prev = new int[SortM[SortM.Length-1]+3];
        


        max_count = SortM[SortM.Length - 1];
        min_count=SortM[0];
        next_index_array = 1;
        next_val_array = SortM[1];

        for (i = min_count; i <= max_count+2; i++)
        {
            if (i == next_val_array && mark_last==0)
            {
                array_prev[i] = 1;
                next_index_array++;
                if (SortM.Length > next_index_array)
                    next_val_array = SortM[next_index_array];
                else
                    mark_last = 1;
            }
            else
            {
                if (i == min_count)
                    array_prev[i] = 1;
                else
                    array_prev[i] = 0;
            }
            
            if (array_prev[i] == 1 && array_prev[i - 1] == 1)
            {
                if (remainder == 1)
                    count_one++;
                
                remainder = 1;
            }

            if ((array_prev[i] == 1 && array_prev[i - 1] == 0)
                || (array_prev[i] == 0 && array_prev[i - 1] == 1))
            {
                if (remainder == 0)
                   count_one++;
            }

            if (array_prev[i] == 0 && array_prev[i - 1] == 0)
            {
                if (remainder == 1)
                {
                    count_one++;
                    remainder = 0;
                }
            }
        }

        return count_one;
    }
}
    class Program
    {
        static void Main()
        {
            int[] array = { 2, 4, 6, 7, 10, 11, 12, 13, 14, 15, 16, 20, 100023 };   //  //if array value>=1
            Console.WriteLine("count one: " + Funct_F.F(array));
        }
    }
