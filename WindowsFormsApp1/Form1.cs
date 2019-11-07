using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        double acumula = 0;
        string operacao = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            label1.Text += "1";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            label1.Text += "2";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            label1.Text += "3";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            label1.Text += "4";
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            label1.Text += "5";
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            label1.Text += "6";
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            label1.Text += "7";
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            label1.Text += "8";
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            label1.Text += "9";
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            label1.Text += "0";
        }

        private void Virgula_Click(object sender, EventArgs e)
        {
            label1.Text += ",";
            if (!label1.Text.Contains(",")) label1.Text += ",";
        }

        private void Soma_Click(object sender, EventArgs e)
        {
            if (operacao == "*" || operacao == "-" || operacao == "/")
            {
                operacao = "+";
            }
            else
            {
                acumula += double.Parse(label1.Text);
                label1.Text = "";
                operacao = "+";
            }
        }

        private void Menos_Click(object sender, EventArgs e)
        {
            if (operacao == "*" || operacao == "+" || operacao == "/")
            {
                operacao = "-";
            }
            else
            {
                acumula = double.Parse(label1.Text);
                label1.Text = "";
                operacao = "-";
            }
        }

        private void Multiplicar_Click(object sender, EventArgs e)
        {
            if (operacao == "-" || operacao == "+" || operacao == "/")
            {
                operacao = "*";
            }
            else
            {
                acumula = double.Parse(label1.Text);
                label1.Text = "";
                operacao = "*";
            }
        }

        private void Dividir_Click(object sender, EventArgs e)
        {
            if (operacao == "*" || operacao == "+" || operacao == "-")
            {
                operacao = "/";
            }
            else
            {
                acumula = double.Parse(label1.Text);
                label1.Text = "";
                operacao = "/";
            }
        }

        private void Raiz_Click(object sender, EventArgs e)
        {
            
            double x = double.Parse(label1.Text);
            if (x < 0)
            {
                label1.Text = "Este valor não é valido.";
                label1.Text += "√";
            }
            else
            {
                x = Math.Sqrt(x);
                label1.Text = x.ToString();
                label1.Text += "√";
            }
        }

        private void Igual_Click(object sender, EventArgs e)
        {
            if (operacao == "+")
            {
                acumula += double.Parse(label1.Text);
                label1.Text = acumula.ToString();
            }
            else if (operacao == "-")
            {
                acumula -= double.Parse(label1.Text);
                label1.Text = acumula.ToString();
            }
            else if (operacao == "*")
            {
                acumula *= double.Parse(label1.Text);
                label1.Text = acumula.ToString();
            }
            else if (operacao == "/")
            {
                if (double.Parse(label1.Text) != 0)
                {
                    acumula /= double.Parse(label1.Text);
                    label1.Text = acumula.ToString();
                }
                else
                {
                    label1.Text = "Dividindo por zero";
                }
            }
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            operacao = "";
        }

        private void Desligar_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            operacao = "";
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            int x = label1.Text.Length - 1;
            if (x >= 0)
            {
                label1.Text = label1.Text.Substring(0, x);
            }
        }
    }
}
