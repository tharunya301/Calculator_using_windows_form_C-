using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_windows_form
{
    public partial class Form1 : Form
    {
        Double result = 0;
        String operationPerfomed = "";
        bool isOperationPerfomed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            if ((textBox.Text == "0") || isOperationPerfomed)
                textBox.Clear();

            isOperationPerfomed = false;
            Button Btn = (Button)sender;
            textBox.Text = textBox.Text + Btn.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button Btn = (Button)sender;
            operationPerfomed = Btn.Text;
            result = Double.Parse(textBox.Text);
            isOperationPerfomed = true;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
            result = 0;
        }

        private void BtnEqual_Click(object sender, EventArgs e)
        {
            switch(operationPerfomed)
            {
                case "+":
                    textBox.Text = (result + Double.Parse(textBox.Text)).ToString();
                    break;

                case "-":
                    textBox.Text = (result - Double.Parse(textBox.Text)).ToString();
                    break;

                case "x":
                    textBox.Text = (result * Double.Parse(textBox.Text)).ToString();
                    break;

                case "/":
                    textBox.Text = (result / Double.Parse(textBox.Text)).ToString();
                    break;

                case "%":
                    textBox.Text = (result % Double.Parse(textBox.Text)).ToString();
                    break;

                default:
                    break;
            }
        }
    }
}
