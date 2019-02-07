using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class FormCalc : Form
    {
        enum calcOperators { coAdd, coSubstract, coMultiply, coDivide};
        calcOperators calcOperator;
        float a, b;
        bool br;

        public FormCalc()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnNum1_Click(object sender, EventArgs e)
        {
            tbxResult.Text = tbxResult.Text + "1";
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            tbxResult.Text = tbxResult.Text + "2";
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            tbxResult.Text = tbxResult.Text + "3";
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            tbxResult.Text = tbxResult.Text + "4";
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            tbxResult.Text = tbxResult.Text + "5";
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            tbxResult.Text = tbxResult.Text + "6";
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            tbxResult.Text = tbxResult.Text + "7";
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            tbxResult.Text = tbxResult.Text + "8";
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            tbxResult.Text = tbxResult.Text + "9";
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            tbxResult.Text = tbxResult.Text + "0";
        }

        private void btnSeparator_Click(object sender, EventArgs e)
        {
            tbxResult.Text = tbxResult.Text + ",";
        }

        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            if (tbxResult.Text[0] == '-')
              tbxResult.Text = tbxResult.Text.Remove(0, 1);
            else
              tbxResult.Text = "-" + tbxResult.Text;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            a = Convert.ToSingle(tbxResult.Text);
            calcOperator = calcOperators.coAdd;
            tbxResult.Clear();
            br = false;
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            a = Convert.ToSingle(tbxResult.Text);
            calcOperator = calcOperators.coSubstract;
            tbxResult.Clear();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            a = Convert.ToSingle(tbxResult.Text);
            calcOperator = calcOperators.coMultiply;
            tbxResult.Clear();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            a = Convert.ToSingle(tbxResult.Text);
            calcOperator = calcOperators.coDivide;
            tbxResult.Clear();
        }

        private void btnFesult_Click(object sender, EventArgs e)
        {
            if (!br)
                b = Convert.ToSingle(tbxResult.Text);

            if (calcOperator == calcOperators.coAdd)
            {
                a = a + b;
            }
            else if (calcOperator == calcOperators.coSubstract)
            {
                a = a - b; 
            }
            else if (calcOperator == calcOperators.coMultiply)
            {
                a = a * b;
            }
            else if (calcOperator == calcOperators.coDivide)
            {
                a = a / b;
            }
            tbxResult.Text = Convert.ToString(a);
            br = true;
        }
    }
}
