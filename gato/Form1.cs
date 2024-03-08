using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gato
{
    public partial class Form1 : Form
    {
        char turno='o';
        short move = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button bt = sender as Button;
            bt.Enabled = false;
            if (turno == 'o')
            {
                bt.Text = "o";
                j2.Text = " ";
                j1.Text = "😁";
                turno = 'x';
                if ((b1.Text == "o" && b2.Text == "o" && b3.Text == "o")||
                    (b2.Text == "o" && b5.Text == "o" && b8.Text == "o" )||
                    (b3.Text == "o" && b6.Text == "o" && b9.Text == "o" )||
                    (b4.Text == "o" && b5.Text == "o" && b6.Text == "o" ) ||
                    (b7.Text == "o" && b8.Text == "o" && b9.Text == "o" )||
                    (b1.Text == "o" && b5.Text == "o" && b9.Text == "o" )||
                    (b3.Text == "o" && b5.Text == "o" && b7.Text == "o" )||
                    (b1.Text == "o" && b4.Text == "o" && b7.Text == "o" ))
                {
                    MessageBox.Show("Gano O");
                    b1.Enabled = false;
                    b2.Enabled = false;
                    b3.Enabled = false;
                    b4.Enabled = false;
                    b5.Enabled = false;
                    b6.Enabled = false;
                    b7.Enabled = false;
                    b8.Enabled = false;
                    b9.Enabled = false;
                }
            }else
            {
                j2.Text = "😁";
                j1.Text = " ";
                bt.Text = "x";
                turno = 'o';
                if ((b1.Text == "x" && b2.Text == "x" && b3.Text == "x") ||
                    (b2.Text == "x" && b5.Text == "x" && b8.Text == "x") ||
                    (b3.Text == "x" && b6.Text == "x" && b9.Text == "x") ||
                    (b4.Text == "x" && b5.Text == "x" && b6.Text == "x") ||
                    (b7.Text == "x" && b8.Text == "x" && b9.Text == "x") ||
                    (b1.Text == "x" && b5.Text == "x" && b9.Text == "x") ||
                    (b3.Text == "x" && b5.Text == "x" && b7.Text == "x") ||
                    (b1.Text == "x" && b4.Text == "x" && b7.Text == "x"))
                {
                    MessageBox.Show("Gano X");
                    b1.Enabled = false;
                    b2.Enabled = false;
                    b3.Enabled = false;
                    b4.Enabled = false;
                    b5.Enabled = false;
                    b6.Enabled = false;
                    b7.Enabled = false;
                    b8.Enabled = false;
                    b9.Enabled = false;
                }
            }
        }
    }
}
