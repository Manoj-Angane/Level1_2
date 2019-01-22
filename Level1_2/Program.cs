using System;

namespace Level1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Side 1");
            string input1 = Console.ReadLine();
            Console.WriteLine("Enter Side 2");
            string input2 = Console.ReadLine();
            Console.WriteLine("Enter Side 3");
            string input3 = Console.ReadLine();
            try
            {
                double a = Double.Parse(input1);
                double b = Double.Parse(input2);
                double c = Double.Parse(input3);
                double s = (a + b + c) / 2;
                double area = Math.Sqrt(s*(s - a)*(s - b)*(s - c));
                Console.WriteLine("Area = "+area);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Thank You!!..Hit any key to exit");
            Console.ReadKey(true);
        }
    }
}
