using System;
namespace Lessons
{
    public class Lessons11
    {
        public const int MY_VALUE = 25;

        /*
        Method to demonstrate a constant which cannot chang its value;
         */
        
        public void Samplelessons1()
        {
            string today = "Wednesday";
            // MY_VALUE = 35; //can not change the value
            //Can use it with other variablies
            int total = MY_VALUE * 2;
            Console.WriteLine(total);

            // cant change value of method level constant
            // today = "Friday";
        }
        public void useParams(params int[] items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                Console.Write(items[i] + " ");
            }      
            Console.WriteLine();   
        }
        public void useParams2(params object[] items)
        {                                   
            for (int i = 0; i < items.Length; i++)
            {
                Console.Write(items[i] + " ");
            }      
            Console.WriteLine();   
        }
        
    }
}