using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cs_Calculator
{
    public partial class formCalculator : Form
    {
        string op1 = string.Empty;
        string op2 = string.Empty;
        string result;
        char operation;

        public formCalculator()
        {
            InitializeComponent();
        }

        private void frmCalculator_Load(object sender, EventArgs e)
        {
            btnOne.Click += new EventHandler(btn_Click);
            btnTwo.Click += new EventHandler(btn_Click);
            btnThree.Click += new EventHandler(btn_Click);
            btnFour.Click += new EventHandler(btn_Click);
            btnFive.Click += new EventHandler(btn_Click);
            btnSix.Click += new EventHandler(btn_Click);
            btnSeven.Click += new EventHandler(btn_Click);
            btnEight.Click += new EventHandler(btn_Click);
            btnNine.Click += new EventHandler(btn_Click);
            btnZero.Click += new EventHandler(btn_Click);
            btnDot.Click += new EventHandler(btn_Click);
        }

        void btn_Click(object sender, EventArgs e)
        {
           
                Button btn = sender as Button;

                switch (btn.Name)
                {
                    case "btnOne":
                        txtInput.Text += "1";
                        break;
                    case "btnTwo":
                        txtInput.Text += "2";
                        break;
                    case "btnThree":
                        txtInput.Text += "3";
                        break;
                    case "btnFour":
                        txtInput.Text += "4";
                        break;
                    case "btnFive":
                        txtInput.Text += "5";
                        break;
                    case "btnSix":
                        txtInput.Text += "6";
                        break;
                    case "btnSeven":
                        txtInput.Text += "7";
                        break;
                    case "btnEight":
                        txtInput.Text += "8";
                        break;
                    case "btnNine":
                        txtInput.Text += "9";
                        break;
                    case "btnZero":
                        txtInput.Text += "0";
                        break;
                    case "btnDot":
                        if(!txtInput.Text.Contains("."))
                            txtInput.Text += ".";
                        break;

                }
            
           
        }

        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '0':
               
                    break;
                default:
                    e.Handled = true;
                    MessageBox.Show("Only numbers, +, -, ., *, / are allowed");
                    break;
            }           
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            op1 = txtInput.Text;
            operation = '+';
            txtInput.Text = string.Empty;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            op1 = txtInput.Text;
            operation = '-';
            txtInput.Text = string.Empty;
        }

        private void btnMulitply_Click(object sender, EventArgs e)
        {
            op1 = txtInput.Text;
            operation = '*';
            txtInput.Text = string.Empty;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            op1 = txtInput.Text;
            operation = '/';
            txtInput.Text = string.Empty;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            op2 = txtInput.Text;

            double opr1, opr2;
            double.TryParse(op1, out opr1);
            double.TryParse(op2, out opr2);

            switch (operation)
            {
                case '+':
                    result = (opr1 + opr2).ToString();
                    break;

                case '-':
                    result = (opr1 - opr2).ToString();
                    break;

                case '*':
                    result = (opr1 * opr2).ToString();
                    break;

                case '/':
                    if (opr2 != 0)
                    {
                        result = (opr1 / opr2).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Cannot divide by zero");
                    }
                    break;
            }

            txtInput.Text = result.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Text = string.Empty;
            op1 = string.Empty;
            op2 = string.Empty;
        }

        private void btnSqrRoot_Click(object sender, EventArgs e)
        {
            double opr1;
            if (double.TryParse(txtInput.Text, out opr1))
            {
                txtInput.Text = (Math.Sqrt(opr1)).ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
