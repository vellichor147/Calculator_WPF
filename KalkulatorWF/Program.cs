using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalkulatorWF
{
    static class Program
    {
        static public string num1;
        static public string num2;
        static public string op;
        static public bool isOperator = false;
        static public bool isPrefix = true;
        static public bool isSecondPrefix = true;
        static public bool isFirst = true;
        static public string temp1;
        [STAThread]
               

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new mainWindow());
        }

        public static double operationFunction(string num1, string num2, string op)
        {
            temp1 = num1;
            double res, n1, n2;
            n1 = Convert.ToDouble(num1);
            n2 = Convert.ToDouble(num2);
            if (op == "+")
            {
                res = n1 + n2;
            }
            else if(op == "-")
            {
                res = n1 - n2;
            }
            else if(op == "*")
            {
                res = n1 * n2;
            }
            else
            {
                res = n1 / n2;
            }
            return res;
        }

        public static void nullVar()
        {
            num1 = null;
            num2 = null;
            op = null;
            isOperator = false;
        }

        public static void test()
        {
            MessageBox.Show("test");
        }

    }
}
