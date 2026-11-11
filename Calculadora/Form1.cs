using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        double num1 = 0;
        double num2 = 0;
        string operacion = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "0")
            {
                txtPantalla.Text = "1";
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "0")
                txtPantalla.Text = "2";
            else
                txtPantalla.Text = txtPantalla.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "0")
                txtPantalla.Text = "3";
            else
                txtPantalla.Text = txtPantalla.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "0")
                txtPantalla.Text = "4";
            else
                txtPantalla.Text = txtPantalla.Text + "4";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "0")
                txtPantalla.Text = "5";
            else
                txtPantalla.Text = txtPantalla.Text + "5";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "0")
                txtPantalla.Text = "6";
            else
                txtPantalla.Text = txtPantalla.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "0")
                txtPantalla.Text = "7";
            else
                txtPantalla.Text = txtPantalla.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "0")
                txtPantalla.Text = "8";
            else
                txtPantalla.Text = txtPantalla.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "0")
                txtPantalla.Text = "9";
            else
                txtPantalla.Text = txtPantalla.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "0")
                txtPantalla.Text = "0";
            else
                txtPantalla.Text = txtPantalla.Text + "0";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = "0";
            num1 = 0;
            num2 = 0;
            operacion = "";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            if (!txtPantalla.Text.Contains("."))
            {
                txtPantalla.Text = txtPantalla.Text + ".";
            }
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtPantalla.Text);
            operacion = "+";
            txtPantalla.Text = "0";
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtPantalla.Text);
            operacion = "-";
            txtPantalla.Text = "0";
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtPantalla.Text);
            operacion = "/";
            txtPantalla.Text = "0";
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtPantalla.Text);
            operacion = "*";
            txtPantalla.Text = "0";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(txtPantalla.Text);

            if (operacion == "+")
            {
                txtPantalla.Text = (num1 + num2).ToString();
            }
            else if (operacion == "-")
            {
                txtPantalla.Text = (num1 - num2).ToString();
            }
            else if (operacion == "*")
            {
                txtPantalla.Text = (num1 * num2).ToString();
            }
            else if (operacion == "/")
            {
                if (num2 == 0)
                {
                    txtPantalla.Text = "Error: División por cero";
                }
                else
                {
                    txtPantalla.Text = (num1 / num2).ToString();
                }
            }
        }
    }
}
