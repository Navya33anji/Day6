using System;

namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num, Rev = 0, flag;
            Console.WriteLine("Enter a number to reverse");
            Num = int.Parse(Console.ReadLine());
            while (Num != 0)
            {
                flag = Num % 10;
                Rev = Rev * 10 + flag;
                Num /=10;

            }
            Console.WriteLine("Reversed number: {0}", Rev);
        }
    }
}
