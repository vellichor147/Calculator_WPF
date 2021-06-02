using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalkulatorWF
{
    public partial class mainWindow : Form
    {
        public mainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Label screen = new Label();
            //screen.Size = new Size(50, 50);
            calculatorScreen.ReadOnly = true;
            this.KeyPreview = true;

        }

        #region Utility Buttons
        private void enter_button_Click(object sender, EventArgs e)
        {
            double newNum = Program.operationFunction(Program.num1, Program.num2, Program.op);
            Program.num1 = Convert.ToString(newNum);
            calculatorScreen.Text = Program.temp1 + " " + Program.op + " " + Program.num2 + " = " + Program.num1;
            Program.isOperator = false;
            Program.isPrefix = false;
            Program.num2 = null;
            Program.op = null;
        }
        private void com_button_Click(object sender, EventArgs e)
        {
            if (Program.isOperator == false)
            {
                Program.num1 += ",";
                calculatorScreen.Text = Program.num1;

            }
            else
            {
                Program.num2 += ",";
                calculatorScreen.Text = Program.num1 + " " + Program.op + " " + Program.num2;
            }
        }
        private void del_button_Click(object sender, EventArgs e)
        {
            //briše vrijednosti svih varijabli
            calculatorScreen.Text = null;
            Program.num2 = null;
            Program.op = null;
            Program.nullVar();
        }
        
        #endregion
               

        #region Number Buttons
        private void b1_Click(object sender, EventArgs e)
        {
            if (Program.isFirst == true && Program.isOperator == false)
            {
                Program.isPrefix = false;
                Program.num1 += "1";
                calculatorScreen.Text = Program.num1;
            }
            else
            {

                Program.num2 += "1";
                calculatorScreen.Text = Program.num1 + " " + Program.op + " " + Program.num2;
            }
        }

        private void b2_Click(object sender, EventArgs e)
        {
            if (Program.isOperator == false)
            {
                Program.num1 += "2";
                Program.isPrefix = false;
                calculatorScreen.Text = Program.num1;
            }
            else
            {
                Program.num2 += "2";
                calculatorScreen.Text = Program.num1 + " " + Program.op + "  " + Program.num2;
            }

        }

        private void b3_Click(object sender, EventArgs e)
        {
            if (Program.isOperator == false)
            {
                Program.num1 += "3";
                Program.isPrefix = false;
                calculatorScreen.Text = Program.num1;
            }
            else
            {
                Program.num2 += "3"; 
                calculatorScreen.Text = Program.num1 + " " + Program.op + "  " + Program.num2;
            }
        }

        private void b4_Click(object sender, EventArgs e)
        {
            if (Program.isOperator == false)
            {
                Program.num1 += "4";
                Program.isPrefix = false;
                calculatorScreen.Text = Program.num1;
            }
            else
            {
                Program.num2 += "4";
                calculatorScreen.Text = Program.num1 + " " + Program.op + "  " + Program.num2;
            }
        }

        private void b5_Click(object sender, EventArgs e)
        {
            if (Program.isOperator == false)
            {
                Program.num1 += "5";
                Program.isPrefix = false;
                calculatorScreen.Text = Program.num1;
            }
            else
            {
                Program.num2 += "5";
                calculatorScreen.Text = Program.num1 + " " + Program.op + "  " + Program.num2;
            }
        }

        private void b6_Click(object sender, EventArgs e)
        {
            if (Program.isOperator == false)
            {
                Program.num1 += "6";
                Program.isPrefix = false;
                calculatorScreen.Text = Program.num1;
            }
            else
            {
                Program.num2 += "6";
                calculatorScreen.Text = Program.num1 + " " + Program.op + "  " + Program.num2;
            }
        }

        private void b7_Click(object sender, EventArgs e)
        {
            if (Program.isOperator == false)
            {
                Program.num1 += "7";
                Program.isPrefix = false;
                calculatorScreen.Text = Program.num1;
            }
            else
            {
                Program.num2 += "7";
                calculatorScreen.Text = Program.num1 + " " + Program.op + "  " + Program.num2;
            }
        }

        private void b8_Click(object sender, EventArgs e)
        {
            if (Program.isOperator == false)
            {
                Program.num1 += "8";
                Program.isPrefix = false;
                calculatorScreen.Text = Program.num1;
            }
            else
            {
                Program.num2 += "8";
                calculatorScreen.Text = Program.num1 + " " + Program.op + "  " + Program.num2;
            }
        }

        private void b9_Click(object sender, EventArgs e)
        {
            if (Program.isOperator == false)
            {
                Program.num1 += "9";
                Program.isPrefix = false;
                calculatorScreen.Text = Program.num1;
            }
            else
            {
                Program.num2 += "9";
                calculatorScreen.Text = Program.num1 + " " + Program.op + "  " + Program.num2;
            }
        }

        private void b0_Click(object sender, EventArgs e)
        {
            if (Program.isOperator == false)
            {
                Program.num1 += "0";
                Program.isPrefix = false;
                calculatorScreen.Text = Program.num1;
            }
            else
            {
                Program.num2 += "0";
                calculatorScreen.Text = Program.num1 + " " + Program.op + "  " + Program.num2;
            }
        }

        #endregion

        #region Operator Buttons
        private void add_button_Click(object sender, EventArgs e)
        {
            Program.op = "+";
            Program.isOperator = true;
            Program.isFirst = false;
            calculatorScreen.Text = Program.num1 + " " + Program.op;

        }
        private void sub_button_Click(object sender, EventArgs e)
        {
            //ako je prefix true a operator false to znači da niti jedan broj nije unesen i radi se o prefiksu prvog broja
            if(Program.isPrefix == true && Program.isOperator == false)
            {
                Program.num1 += "-";
                calculatorScreen.Text = Program.num1;
            }
            //kada kliknem minus prvo mora provjeriti da li sam prije toga kliknuo neki broj, jer ako jesam
            //onda se radi o operatoru
            else if(Program.isPrefix == false && Program.isOperator == false)
            {
                Program.op = "-";
                calculatorScreen.Text = Program.num1 + " " + Program.op;
                Program.isOperator = true;
            }
            //ako je operator true znači da je operator unesen i da se sljedeći minus unosi kao predznak drugog broja
            else if (Program.isSecondPrefix == true && Program.isOperator == true)
            {
                Program.num2 += "-";
                calculatorScreen.Text = Program.num1 + " " + Program.op + "   " + Program.num2;
            }
        }
        private void multi_button_Click(object sender, EventArgs e)
        {
            Program.op = "*";
            Program.isOperator = true;
            calculatorScreen.Text = Program.num1 + " " + Program.op;
        }
        private void div_button_Click(object sender, EventArgs e)
        {
            Program.op = "/";
            Program.isOperator = true;
            calculatorScreen.Text = Program.num1 + " " + Program.op;
        }
        #endregion

        private void testButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("num1: " + Program.num1 + 
                Environment.NewLine + "num2: " + Program.num2 +
                Environment.NewLine + "op: " + Program.op);
        }

        private void textBox1(object sender, EventArgs e)
        {

        }

        #region Keys events

        //ovo bi trebalo optimizirati!!! - pritiskom na tipku pozvati click funkciju
        private void mainWindow_KeyPress(object sender, KeyPressEventArgs e)
        {
            #region Numpad events
            if (e.KeyChar == '0')
            {
                if (Program.isOperator == false)
                {
                    Program.num1 += "0";
                    Program.isPrefix = false;
                    calculatorScreen.Text = Program.num1;
                }
                else
                {
                    Program.num2 += "0";
                    calculatorScreen.Text = Program.num1 + " " + Program.op + "  " + Program.num2;
                }
            }
            else if (e.KeyChar == '1')
            {
                if (Program.isFirst == true && Program.isOperator == false)
                {
                    Program.isPrefix = false;
                    Program.num1 += "1";
                    calculatorScreen.Text = Program.num1;
                }
                else
                {

                    Program.num2 += "1";
                    calculatorScreen.Text = Program.num1 + " " + Program.op + " " + Program.num2;
                }
            }
            else if (e.KeyChar == '2')
            {
                if (Program.isOperator == false)
                {
                    Program.num1 += "2";
                    Program.isPrefix = false;
                    calculatorScreen.Text = Program.num1;
                }
                else
                {
                    Program.num2 += "2";
                    calculatorScreen.Text = Program.num1 + " " + Program.op + "  " + Program.num2;
                }
            }
            else if (e.KeyChar == '3')
            {
                if (Program.isOperator == false)
                {
                    Program.num1 += "3";
                    Program.isPrefix = false;
                    calculatorScreen.Text = Program.num1;
                }
                else
                {
                    Program.num2 += "3";
                    calculatorScreen.Text = Program.num1 + " " + Program.op + "  " + Program.num2;
                }
            }
            else if (e.KeyChar == '4')
            {
                if (Program.isOperator == false)
                {
                    Program.num1 += "4";
                    Program.isPrefix = false;
                    calculatorScreen.Text = Program.num1;
                }
                else
                {
                    Program.num2 += "4";
                    calculatorScreen.Text = Program.num1 + " " + Program.op + "  " + Program.num2;
                }
            }
            else if (e.KeyChar == '5')
            {
                if (Program.isOperator == false)
                {
                    Program.num1 += "5";
                    Program.isPrefix = false;
                    calculatorScreen.Text = Program.num1;
                }
                else
                {
                    Program.num2 += "5";
                    calculatorScreen.Text = Program.num1 + " " + Program.op + "  " + Program.num2;
                }
            }
            else if (e.KeyChar == '6')
            {
                if (Program.isOperator == false)
                {
                    Program.num1 += "6";
                    Program.isPrefix = false;
                    calculatorScreen.Text = Program.num1;
                }
                else
                {
                    Program.num2 += "6";
                    calculatorScreen.Text = Program.num1 + " " + Program.op + "  " + Program.num2;
                }
            }
            else if (e.KeyChar == '7')
            {
                if (Program.isOperator == false)
                {
                    Program.num1 += "7";
                    Program.isPrefix = false;
                    calculatorScreen.Text = Program.num1;
                }
                else
                {
                    Program.num2 += "7";
                    calculatorScreen.Text = Program.num1 + " " + Program.op + "  " + Program.num2;
                }
            }
            else if (e.KeyChar == '8')
            {
                if (Program.isOperator == false)
                {
                    Program.num1 += "8";
                    Program.isPrefix = false;
                    calculatorScreen.Text = Program.num1;
                }
                else
                {
                    Program.num2 += "8";
                    calculatorScreen.Text = Program.num1 + " " + Program.op + "  " + Program.num2;
                }
            }
            else if (e.KeyChar == '9')
            {
                if (Program.isOperator == false)
                {
                    Program.num1 += "9";
                    Program.isPrefix = false;
                    calculatorScreen.Text = Program.num1;
                }
                else
                {
                    Program.num2 += "9";
                    calculatorScreen.Text = Program.num1 + " " + Program.op + "  " + Program.num2;
                }
            }



            #endregion

            #region Operator events
            if (e.KeyChar == '+')
            {
                e.Handled = true;
                Program.op = "+";
                Program.isOperator = true;
                Program.isFirst = false;
                calculatorScreen.Text = Program.num1 + " " + Program.op;
            }
            else if (e.KeyChar == '-')
            {
                //ako je prefix true a operator false to znači da niti jedan broj nije unesen i radi se o prefiksu prvog broja
                if (Program.isPrefix == true && Program.isOperator == false)
                {
                    Program.num1 += "-";
                    calculatorScreen.Text = Program.num1;
                }
                //kada kliknem minus prvo mora provjeriti da li sam prije toga kliknuo neki broj, jer ako jesam
                //onda se radi o operatoru
                else if (Program.isPrefix == false && Program.isOperator == false)
                {
                    Program.op = "-";
                    calculatorScreen.Text = Program.num1 + " " + Program.op;
                    Program.isOperator = true;
                }
                //ako je operator true znači da je operator unesen i da se sljedeći minus unosi kao predznak drugog broja
                else if (Program.isSecondPrefix == true && Program.isOperator == true)
                {
                    Program.num2 += "-";
                    calculatorScreen.Text = Program.num1 + " " + Program.op + "   " + Program.num2;
                }
            }
            else if (e.KeyChar == '*')
            {
                Program.op = "*";
                Program.isOperator = true;
                calculatorScreen.Text = Program.num1 + " " + Program.op;
            }
            else if (e.KeyChar == '/')
            {
                Program.op = "/";
                Program.isOperator = true;
                calculatorScreen.Text = Program.num1 + " " + Program.op;
            }



            #endregion

            #region Utility events
            if (e.KeyChar == '=')
            {
                double newNum = Program.operationFunction(Program.num1, Program.num2, Program.op);
                Program.num1 = Convert.ToString(newNum);
                calculatorScreen.Text = Program.temp1 + " " + Program.op + " " + Program.num2 + " = " + Program.num1;
                Program.isOperator = false;
                Program.isPrefix = false;
                Program.num2 = null;
                Program.op = null;
            }
            if (e.KeyChar == ',')
            {
                if (Program.isOperator == false)
                {
                    Program.num1 += ",";
                    calculatorScreen.Text = Program.num1;

                }
                else
                {
                    Program.num2 += ",";
                    calculatorScreen.Text = Program.num1 + " " + Program.op + " " + Program.num2;
                }
            }


            #endregion
        }

        private void mainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                calculatorScreen.Text = null;
                Program.num2 = null;
                Program.op = null;
                Program.nullVar();
            }
        }
        //

        #endregion
    }
}
