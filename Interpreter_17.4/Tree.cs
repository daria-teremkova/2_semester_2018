using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter_17._4
{
    class Tree
    {
        private ExpressionNode root = null;
        private static Random rnd = new Random();

        public Tree()              // конструктор
        {
            root = null;
        }

        public ExpressionNode Root()
        {
            return root;
        }
    }
}
