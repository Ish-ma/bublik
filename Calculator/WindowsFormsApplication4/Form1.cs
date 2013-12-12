using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{ 
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string Num1, Num2;
        bool point = false; 
        bool deistvie = false;
        string znak = "";

        void AddNum(string x)
        {
            if (label1.Text == "0")
                label1.Text = x;
            else
                label1.Text += x;
            if (deistvie == false)
            {
                if (Num1 == "0")
                    Num1 = x;
                else
                    Num1 += x;
            }
            else
            {
                if (Num2 == "0")
                    Num2 = x;
                else
                    Num2 += x;
            }
        }

        void AddZnak(string x)
        {
            if (deistvie == false)
            {
                znak = x;
                deistvie = true;
                label1.Text += x;
                point = false;
            }
            else
            {
                Answer(x);
                AddZnak(znak);
            }
        }

        void Answer(string x)
        {
            if (x == "+")
            {
                label1.Text = Convert.ToString(Convert.ToDouble(Num1) + Convert.ToDouble(Num2));
                Num1 = Convert.ToString(Convert.ToDouble(Num1) + Convert.ToDouble(Num2));
            }
            if (x == "-")
            {
                label1.Text = Convert.ToString(Convert.ToDouble(Num1) - Convert.ToDouble(Num2));
                Num1 = Convert.ToString(Convert.ToDouble(Num1) - Convert.ToDouble(Num2));
            }
            if (x == "*")
            {
                label1.Text = Convert.ToString(Convert.ToDouble(Num1) * Convert.ToDouble(Num2));
                Num1 = Convert.ToString(Convert.ToDouble(Num1) * Convert.ToDouble(Num2));
            }
            if (x == "/")
            {
                label1.Text = Convert.ToString(Convert.ToDouble(Num1) / Convert.ToDouble(Num2));
                Num1 = Convert.ToString(Convert.ToDouble(Num1) / Convert.ToDouble(Num2));
            }
            Num2 = "0";
            deistvie = false;
        }
        private void buttonNull_Click(object sender, EventArgs e)
        {
            AddNum("0");
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            if (point == false) 
            {
                if (deistvie == false)
                {
                    if (Num1 == ",") ;
                    else
                    {
                        Num1 += ",";
                        label1.Text += ",";
                    }
                    point = true;
                }
                else
                {
                    if (Num2 == ",") ;
                    else
                    {
                        Num2 += ",";
                        label1.Text += ",";
                    }
                    point = true;
                }
            }
        }

        private void buttonPlusMinus_Click(object sender, EventArgs e)
        {
            if(deistvie == false)
            {
                if (Num1 == "0") ;
                else
                {
                    Num1 = Convert.ToString(Convert.ToDouble(Num1) * (-1));
                    label1.Text = Num1;
                }

            }
            else
            {
                 if (Num2 == "0") ;
                else
                {
                    Num2 = Convert.ToString(Convert.ToDouble(Num2) * (-1));
                    if (Convert.ToDouble(Num2) > 0)
                    {
                        label1.Text = Num1 + znak + Num2;
                    }
                    else
                    {
                        label1.Text = Num1 + znak + "(" + Num2 + ")";
                    }
                }
            }

        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            AddZnak("-");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AddNum("1");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            AddNum("2");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            AddNum("3");
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            AddZnak("+");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddNum("4");
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            AddNum("5");
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            AddNum("6");
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            AddZnak("/");
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            AddNum("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AddNum("8");
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            AddNum("9");
        }

        private void buttonMultiplie_Click(object sender, EventArgs e)
        {
            AddZnak("*");
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            Answer(znak);
        }

    }
}
