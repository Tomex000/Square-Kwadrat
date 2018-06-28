using System;

namespace Kwadrat
{
    class Kwadrat
    {
        static void Main(string[] args)
        {
            int a, b = 0;
            for (a = 1; a <= 11; a++)
            {
                for (b = 1; b <= 11; b++)

                {
                    if (a == 1 || a == 11)
                    {

                        if (b >= 1 && b <= 11)
                        {
                            Console.Write("-");
                        }
                        else if (b == 1 || b == 11)
                        {
                            Console.Write("|");
                        }
                    }
                    else if (b == 1 || b == 11)
                    {
                        Console.Write("|");
                    }
                    else if (a == 6 && b == 6)
                        Console.Write("x");
                    else
                        Console.Write(" ");


                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
