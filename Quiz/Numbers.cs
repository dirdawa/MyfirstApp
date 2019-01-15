using System;
namespace Quiz
{
    public class Numbers
    {
        public void Numbers0()
        {
            {
            for (int i = 0; i < 50; i++) 
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            }
        }

        public void Numbers1()
        {

            int i = 0;
            while (i < 50)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }

        }
        public void Numbers2()
        {
                    {
                        int i = 0;
                        do
                        {
                            if (i % 3 == 0)
                            {
                                Console.WriteLine(i);
                            }
                            i++;
                        } while (i < 50);
                    }
        }
        public void Numbers3()
        {
                    {
                        int[] values = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };
                        foreach (int item in values)
                        {
                            if (item % 3 == 0)
                            {
                                Console.WriteLine(item);
                            }
                        }
                    }
        }
        public void Numbers4()
        {
                    {
                        int[] values = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };
                        for (int i = 0; i < values.Length; i++)
                        {
                            if (values[i] % 3 == 0)
                            {
                                Console.WriteLine(values[i]);
                            }
                        }
                    }
        }
               
    }
}
