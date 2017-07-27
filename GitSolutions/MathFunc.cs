using System;
using System.Collections.Generic;


namespace GitSolutions
{
    static class MathFunc
    {
        public static int Addition(double x, double y)
        {
            int sum = Convert.ToInt32(x + y);
            return sum;
        }
        public static int Subtraction(double x, double y)
        {
            int sum = Convert.ToInt32(x - y);
            return sum;
        }
        public static int Multiplication(double x, double y)
        {
            int sum = Convert.ToInt32(x * y);
            return sum;
        }
        public static int Division(double x, double y)
        {
            int sum = Convert.ToInt32(x / y);
            return sum;
        }
        public static long Exponents(double x, double y)
        {
            long number = Convert.ToInt64(Math.Pow(x, y));
            return number;
        }
        public static double QuadraticFormula(double a, double b, double c)
        {
            double minusfourAC = -4 * a * c;
            double bSquared = Math.Pow(b, 2);
            double sqaureRoot = Math.Sqrt(bSquared + minusfourAC);
            double minusB = -b + sqaureRoot;
            double divideTwoA = minusB / 2 * a;
            return divideTwoA;
        }


        public static int XEquals(string formula)
        {
            int answer = 0;
            List<string> expression = new List<string>();
            if (formula.Contains("(") && formula.Contains(")"))
            {
                expression.AddRange(formula.Split('(', ')'));
                foreach (string x in expression)
                {
                    answer += XEquals(x);
                }
            }
            if (formula.Contains("^"))
            {
                string[] num = formula.Split('^');
                answer += Convert.ToInt32(Exponents(int.Parse(num[1]), int.Parse(num[2])));
            }
            if (formula.Contains("*"))
            {
                string[] num = formula.Split('*');
                answer += Multiplication(int.Parse(num[1]), int.Parse(num[2]));
            }
            if (formula.Contains("/"))
            {
                string[] num = formula.Split('/');
                answer += Division(int.Parse(num[1]), int.Parse(num[2]));
            }
            if (formula.Contains("+"))
            {
                string[] num = formula.Split('+');
                answer += Addition(int.Parse(num[1]), int.Parse(num[2]));
            }
            if (formula.Contains("-"))
            {
                string[] num = formula.Split('^');
                answer += Subtraction(int.Parse(num[1]), int.Parse(num[2]));
            }
            return answer;
        }

    }
}
