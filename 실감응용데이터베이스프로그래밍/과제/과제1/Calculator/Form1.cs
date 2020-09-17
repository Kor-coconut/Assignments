using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            InitVariables();
        }

        public void InitVariables()
        {
            comboBoxComboCalc_Operater.Items.Clear();
            comboBoxComboCalc_Operater.Items.Add("+");
            comboBoxComboCalc_Operater.Items.Add("-");
            comboBoxComboCalc_Operater.Items.Add("*");
            comboBoxComboCalc_Operater.Items.Add("/");
            comboBoxComboCalc_Operater.Items.Add("^");
            comboBoxComboCalc_Operater.SelectedIndex = 0;
        }

        static Double Calculator(Double num1, Double num2, string oper)
        {
            Double result = 1;
            switch (oper)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
                case "^":
                    for (int i = 0; i < num2; i++)
                    {
                        result = num1 * result;
                    }
                    break;
            }
            return result;
        }
        private void buttonComboBoxCalculator_Click(object sender, EventArgs e)
        {
            String oper1 = textBoxComboCalc_Oper1.Text;
            String oper2 = textBoxComboCalc_Oper2.Text;
            String oper = "";
            Double num_oper1 = System.Convert.ToDouble(oper1);
            Double num_oper2 = System.Convert.ToDouble(oper2);

            switch (comboBoxComboCalc_Operater.SelectedIndex)
            {
                case 0: // +
                    oper = "+";
                    break;
                case 1: // -
                    oper = "-";
                    break;
                case 2: // *
                    oper = "*";
                    break;
                case 3: // /
                    oper = "/";
                    break;
                case 4: // ^
                    oper = "^";
                    break;
            }
            textBoxComboCalc_Result.Text = System.Convert.ToString(Calculator(num_oper1, num_oper2, oper));
        }

        private void radioButtonCalculator_Click(object sender, EventArgs e)
        {
            String oper1 = radioButtonCalc_Oper1.Text;
            String oper2 = radioButtonCalc_Oper2.Text;
            String oper = "";
            Double num_oper1 = System.Convert.ToDouble(oper1);
            Double num_oper2 = System.Convert.ToDouble(oper2);

            if (RadioButtonCalc_Operater_1.Checked)
            {
                oper = "+";
            }
            else if (RadioButtonCalc_Operater_2.Checked)
            {
                oper = "-";
            }
            else if (RadioButtonCalc_Operater_3.Checked)
            {
                oper = "*";
            }
            else if (RadioButtonCalc_Operater_4.Checked)
            {
                oper = "/";
            }
            else if (RadioButtonCalc_Operater_5.Checked)
            {
                oper = "^";
            }
            radioButtonCalc_Result.Text = System.Convert.ToString(Calculator(num_oper1, num_oper2, oper));
        }
    }
}
