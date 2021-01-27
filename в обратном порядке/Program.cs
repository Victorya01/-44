using System;

namespace в_обратном_порядке
{
    class Program
    {
        

        static void Main(string[] args)
        {
            string[] array=new string[5];
            array[0] = "H";
            array[1] = "e";
            array[2] = "l";
            array[3] = "l";
            array[4] = "o";
            Console.WriteLine("Вывод массива");

            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write(array[i]);
            }
            Console.ReadLine();


        }
    }
}
