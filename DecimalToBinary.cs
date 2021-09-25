using System;

namespace DecimaltoBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A Number : ");
            int n = int.Parse(Console.ReadLine());
            toBinary(n);
        }
        static void toBinary(int n)
        {
            int[] binary1 = new int[64];
            int i = 0;
            while(n>0)
            {
                binary1[i] = n % 2;
                n = n / 2;
                i++;
            }
            for(int num=i-1;num>=0;num--)
                Console.Write(binary1[num]);
        }
    }
}

