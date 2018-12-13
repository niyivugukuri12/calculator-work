using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Treeview
{
    public partial class Form2 : Form
    {
        private double number1, number2, result;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(txtNum1.Text);
            number2 = Convert.ToDouble(txtNum2.Text);
            result = number1 + number2;
            txtResult.Text = result.ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(txtNum1.Text);
            number2 = Convert.ToDouble(txtNum2.Text);
            result = number1 - number2;
            txtResult.Text = result.ToString();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(txtNum1.Text);
            number2 = Convert.ToDouble(txtNum2.Text);
            result = number1 * number2;
            txtResult.Text = result.ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            number1 = Convert.ToDouble(txtNum1.Text);
            number2 = Convert.ToDouble(txtNum2.Text);
            result = number1 / number2;
            txtResult.Text = result.ToString();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            txtResult.Clear();
        }

        public Form2()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
