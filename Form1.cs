using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class CalculatorForm : Form
    {
        int a, b;
        bool positive = true;
        enum Oper { Plus, Minus, Mult, Div };
        Oper oper;


        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void Button12_Click(object sender, EventArgs e)
        {

            a = SevenConverter.ToDec(textBox1.Text);
            textBox1.Clear();
            oper = Oper.Minus;
            label.Text = SevenConverter.FromDec(a) + "-";
            positive = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            a = SevenConverter.ToDec(textBox1.Text);
            textBox1.Clear();
            oper = Oper.Plus;
            label.Text = SevenConverter.FromDec(a) + "+";
            positive = true;
        }

        private void OneButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void ThreeBotton_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void FiveBotton_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void MultButton_Click(object sender, EventArgs e)
        {
            a = SevenConverter.ToDec(textBox1.Text);
            textBox1.Clear();
            oper = Oper.Mult;
            label.Text = SevenConverter.FromDec(a) + "×";
            positive = true;
        }

        private void DivButton_Click(object sender, EventArgs e)
        {
            a = SevenConverter.ToDec(textBox1.Text);
            textBox1.Clear();
            oper = Oper.Div;
            label.Text = SevenConverter.FromDec(a) + "/";
            positive = true;
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            calculate();
            label.Text = "";
        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void CButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label.Text = "";
        }

        private void ArrowButton_Click(object sender, EventArgs e)
        {
            int length = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < length; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
        }

        private void calculate()
        {
            switch (oper)
            {
                case Oper.Plus:
                    b = a + SevenConverter.ToDec(textBox1.Text);
                    textBox1.Text = SevenConverter.FromDec(b);
                    break;
                case Oper.Minus:
                    b = a - SevenConverter.ToDec(textBox1.Text);
                    textBox1.Text = SevenConverter.FromDec(b);
                    break;
                case Oper.Mult:
                    b = a * SevenConverter.ToDec(textBox1.Text);
                    textBox1.Text = SevenConverter.FromDec(b);
                    break;
                case Oper.Div:
                    b = a / SevenConverter.ToDec(textBox1.Text);
                    textBox1.Text = SevenConverter.FromDec(b);
                    break;

                default:
                    break;
            }

        }
    }
}
