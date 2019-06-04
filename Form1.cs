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
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "-";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "+";
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
            textBox1.Text = textBox1.Text + "*";
        }

        private void DivButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "/";
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            calculate();
        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void CButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void ArrowButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "(";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ")";
        }

        private void calculate()
        {
            String expr = textBox1.Text;
            textBox1.Clear();
            textBox1.Text = SevenConverter.FromDec(Expression.ParseExpr(ref expr));
        }
    }
}
