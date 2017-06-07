using StackApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostFix
{
    public class Calculator
    {
        public string Calculate(string[] input)
        {
            var myStack = new MyLLStack<int>();

            foreach (var t in input)
            {
                int variable;
                if (int.TryParse(t, out variable))
                {
                    myStack.Push(variable);
                }
                else
                {
                    var r = myStack.Pop();
                    var l = myStack.Pop();

                    switch (t)
                    {
                        case "+":
                            myStack.Push(l + r);
                            break;
                        case "-":
                            myStack.Push(l - r);
                            break;
                        case "*":
                            myStack.Push(l*r);
                            break;
                        case "/":
                            myStack.Push(l/r);
                            break;
                        case "%":
                            myStack.Push(l%r);
                            break;
                        default:
                            throw new NotSupportedException("This operation is not supported");
                    }
                }
            }

            return myStack.Pop().ToString();
        }
    }
}
