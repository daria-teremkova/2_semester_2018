using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter_17._4
{
    class Interprete
    {
        public static ExpressionNode ParseExpression(string expression)
        {
            int pos = 0;
            ExpressionNode root = ParseExpression(expression, ref pos);

            if (pos < expression.Length)
                throw new ArgumentException();

            return root;
        }

        private static ExpressionNode ParseExpression(string expression, ref int pos)
        {
            if (char.IsDigit(expression[pos]))
                return new ExpressionNode(expression[pos++] - '0');

            if (expression[pos++] != '(')
                throw new ArgumentException();

            ExpressionNode left = ParseExpression(expression, ref pos);

            char operation = expression[pos++];

            if (operation != '+' && operation != '-' && operation != '*')
                throw new ArgumentException();

            ExpressionNode right = ParseExpression(expression, ref pos);

            if (expression[pos++] != ')')
                throw new ArgumentException();

            return new ExpressionNode(left, right, operation);
        }
    }
}
