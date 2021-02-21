using System;

namespace Assignment2_SQA
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            int ch;
            do
            {
                Console.WriteLine("Enter Your Choice\n 1.Enter Triagnle Dimensions\n 2.Exit");
                ch = Int32.Parse(Console.ReadLine());
                switch(ch)
                {
                    case 1:
                        Console.WriteLine("Enter The Dimension of the First Side");
                        a = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Enter The Dimension of the Second Side");
                        b = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Enter The Dimension of the Third Side");
                        c = Int32.Parse(Console.ReadLine());
                        Console.WriteLine(TriangleSolver.Analyze(a, b, c));
                        break;
                    case 2:
                        Console.WriteLine("Thank you for using the application");
                        break;
                    default:
                        Console.WriteLine("Wrong Choice Enter Again");
                        break;
                }
            } while (ch != 2);
        }
    }
}
