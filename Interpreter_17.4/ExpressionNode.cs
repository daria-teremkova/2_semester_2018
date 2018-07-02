using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter_17._4
{
    class ExpressionNode
    {
        private ExpressionNode left;
        private ExpressionNode right;
        private char operation;

        private int value;

        public ExpressionNode(ExpressionNode left, ExpressionNode right, char operation)
        {
            this.left = left;
            this.right = right;
            this.operation = operation;
        }

        public ExpressionNode(int value)
        {
            left = right = null;
            this.value = value;
        }

        public int Calculate()
        {
            if (!IsComplexExpression())
                return value;
            
            switch (operation)
            {
                case '+':
                    return left.Calculate() + right.Calculate();
                case '-':
                    return left.Calculate() - right.Calculate();
                case '*':
                    return left.Calculate() * right.Calculate();
                default:
                    throw new InvalidOperationException("Wrong operation");
            }
        }

        private bool IsComplexExpression()
        {
            return left != null && right != null;
        }
    }
}
