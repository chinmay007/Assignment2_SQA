using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2_SQA
{
    public class TriangleSolver
    {
        public static string Analyze(int a,int b,int c)
        {
            if(a+b<=c || a+c<=b || b+c<=a)
            {
                return "Triangle is not Valid";
            }
            else if (a == b && b == c)
            {     
                return "This is Equilateral Triangle";
            }
            else if (a == b || b == c || a == c)
            {
                return "This is Isosceles Triangle";
            }
            else
            {
                return "This is Scalene Triangle";
            }
        }
    }
}
