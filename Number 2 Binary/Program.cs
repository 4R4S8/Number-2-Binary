using System;

namespace Number_2_Binary
{
    class Program
    {
        public static string ToBinary(int x)
        {
            char[] buff = new char[32];

            for (int i = 31; i >= 0; i--)
            {
                int mask = 1 << i;
                buff[31 - i] = (x & mask) != 0 ? '1' : '0';
            }

            return new string(buff);
        }
        static void Main(string[] args)
        {
            Console.Write("Enter an integer number : ");
            int number = Convert.ToInt32(Console.ReadLine());

            int val = number; 
            string binary = ToBinary(val);

            Console.WriteLine();

            Console.WriteLine(binary);

        }


    }
}
