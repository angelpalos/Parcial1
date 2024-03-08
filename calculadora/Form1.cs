using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        double resul;
        char oper;

            if (double.TryParse(Dato1.Text, out double n1) && double.TryParse(Dato2.Text, out double n2))
            {
                oper = Ope.Text[0];

                switch (oper)
                {
                    case '+':
                        resul = n1 + n2;
                        res.Text = resul.ToString();
                        break;
                    case '-':
                        resul = n1 - n2;
                        res.Text = resul.ToString();

                        break;
                    case '*':
                        resul = n1* n2;
                        res.Text = resul.ToString();

                        break;
                    case '/':
                        if (n2 == 0)
                        {
                            MessageBox.Show("No se puede realizar la operacion");
                        }
                        else
                        {
                            resul = n1 / n2;
                            res.Text = resul.ToString();

                        }
                        break;
                    default:
                        MessageBox.Show("Operacion no valida");
                        break;
                     }
                
            }else
            {
                MessageBox.Show("Operacion no valida");
            }
        }
    }
}
