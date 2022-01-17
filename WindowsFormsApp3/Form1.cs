using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int A = 0;
                if (checkBox1.Checked == true || checkBox2.Checked == false)
                {
                    A = int.Parse(textBox1.Text);
                }
                int N = int.Parse(textBox2.Text);
                int faktorial = N, mocnina = A;
                if (N < 0)
                {
                    MessageBox.Show("Při výpočtu faktoriálu musí být N větší nebo rovno 0.", "Chyba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (N == 0)
                    {
                        faktorial = 1;
                    }
                    else
                    {
                        int pomocna = N;
                        while (pomocna > 1)
                        {
                            faktorial *= pomocna - 1;
                            pomocna--;
                        }
                    }
                }
                if (N == 0)
                {
                    if (A == 0)
                    {
                        MessageBox.Show("0 na 0 není definovaný výraz.", "Chyba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        mocnina = 1;
                    }
                }
                else
                {
                    int pomocna2 = N;
                    while (pomocna2 > 1)
                    {
                        mocnina *= A;
                        pomocna2--;
                    }
                }
                if (checkBox1.Checked == false && checkBox2.Checked == false)
                {
                    MessageBox.Show("Nebylo zaškrtnuto žádné políčko.", "Chyba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (checkBox1.Checked == true)
                {
                    label4.Text = "Mocnina " + A + " na " + N + " je " + mocnina;
                    label4.Visible = true;
                }
                else
                {
                    label4.Visible = false;
                }
                if (checkBox2.Checked == true)
                {
                    label5.Text = "N! = " + faktorial;
                    label5.Visible = true;
                }
                else
                {
                    label5.Visible = false;
                }
            }
            catch
            {
                MessageBox.Show("Nebyla zadána všechna čísla.", "Chyba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
