using System;

namespace Calculator
{
    class Expression
    {
        public static int ParseExpr(ref string expr)
        {
            int op, op1;
            op = Expression.ParseFactor(ref expr);
            if (expr.Length != 0)
            {
                if (expr[0] == '+')
                {
                    expr = expr.Substring(1, expr.Length - 1);
                    op1 = Expression.ParseExpr(ref expr);
                    op += op1;
                }
                else if (expr[0] == '-')
                {
                    expr = expr.Substring(1, expr.Length - 1);
                    op1 = Expression.ParseExpr(ref expr);
                    op -= op1;
                }
            }
            return op;
        }
        public static int ParseFactor(ref string expr)
        {
            int op, op1;
            op = Expression.ParseTerm(ref expr);
            if (expr.Length != 0)
            {
                if (expr[0] == '*')
                {
                    expr = expr.Substring(1, expr.Length - 1);
                    op1 = Expression.ParseFactor(ref expr);
                    op *= op1;
                }
                else if (expr[0] == '/')
                {
                    expr = expr.Substring(1, expr.Length - 1);
                    op1 = Expression.ParseFactor(ref expr);
                    op /= op1;
                }
            }
            return op;
        }
        public static int ParseTerm(ref string expr)
        {
            int returnValue = 0;
            if (expr.Length != 0)
            {
                if (char.IsDigit(expr[0]))
                {
                    returnValue = Expression.ParseNumber(ref expr);
                    return returnValue;
                }
                else if (expr[0] == '(')
                {
                    expr = expr.Substring(1, expr.Length - 1);
                    returnValue = Expression.ParseExpr(ref expr);
                    return returnValue;
                }
                else if (expr[0] == ')')
                    expr = expr.Substring(1, expr.Length - 1);
            }
            return returnValue;
        }
        public static int ParseNumber(ref string expr)
        {
            string numberTemp = "";
            int initialLength = expr.Length;
            for (int i = 0; i < initialLength; i++)
            {
                if (char.IsDigit(expr[0]))
                {
                    numberTemp += expr[0];
                    expr = expr.Substring(1, expr.Length - 1);
                }
                else
                {
                    break;
                }
            }

            return SevenConverter.ToDec(numberTemp);
        }
    }

}