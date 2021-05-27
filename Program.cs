using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_list
{
    class Program
    {
        static void Main()
        {
            /*ArrayList<int> arrayList = new ArrayList<int>();
            arrayList.Insert(0, 1); arrayList.Insert(1, 2); arrayList.Insert(2, 3);
            arrayList.Remove(1);
            Console.WriteLine(arrayList.Find(1));*/

            StackArray<string> stack = new StackArray<string>();
            string input = "232+*52*8-622*-+*";
            foreach(char c in input)
            {
                if (c != '+' && c != '-' && c != '*' && c != '/') stack.push(Convert.ToString(c));
                else
                {
                    string op2 = stack.getTop();
                    stack.pop();
                    string op1 = stack.getTop();
                    stack.pop();
                    stack.push(Convert.ToString(Result(op1, op2, c)));
                }
            }
            Console.WriteLine(stack.getTop());
        }
        static int Result(string op1, string op2, char sign)
        {
            int o1 = Convert.ToInt32(op1);
            int o2 = Convert.ToInt32(op2);
            switch (sign)
            {
                case '+':
                    return o1 + o2;
                case '-':
                    return o1 - o2;
                case '*':
                    return o1 * o2;
                case '/':
                    return o1 / o2;
                default:
                    return 1000000000;
            }
        }
    }
}
