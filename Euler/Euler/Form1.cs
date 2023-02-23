using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Euler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Salir()
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
            else
            {
                this.pictureBox1.Focus();
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Salir();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Salir();
        }
        private void clearFuntions()
        {
            //Los texbox al limpiar
            txtValorVerd.Clear();
            txtNumeroEuler.Clear();
            txt1.Clear();
            txtFact1.Clear();
            txt2.Clear();
            txtFact2.Clear();
            txt3.Clear();
            txtFact3.Clear();
            txt4.Clear();
            txtFact4.Clear();
            txt5.Clear();
            txtFact5.Clear();
            txt6.Clear();
            txtFact6.Clear();
            txt7.Clear();
            txtFact7.Clear();
            txt8.Clear();
            txtFact8.Clear();
            txt9.Clear();
            txtFact9.Clear();
        }

      private void BloquearlineasDiv()
        {
            ptbDivision1.Visible = false;
            ptb2.Visible = false;
            ptb3.Visible = false;
            ptb4.Visible = false;
            ptb5.Visible = false;
            ptb6.Visible = false;
            ptb7.Visible = false;
            ptb8.Visible = false;
            ptb9.Visible = false;
            ptbSuma1.Visible = false;
            ptbSuma2.Visible = false;
            ptbSuma3.Visible = false;
            ptbSuma4.Visible = false;
            ptbSuma5.Visible = false;
            ptbSuma6.Visible = false;
            ptbSuma7.Visible = false;
            ptbSuma8.Visible = false;
            //x²
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            BloquearlineasDiv();
            clearFuntions();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void nudCifras_ValueChanged(object sender, EventArgs e)
        {
            Calcular();

        }

        private void Calcular()
        {
            txtResultado.Text = CalculoE((int)nudCifras.Value).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  txtResultado.Text = CalculoE((int)nudCifras.Value).ToString();
            double eu = Convert.ToDouble(nudCifras);
           
        }

        private double CalculoE(int n)
        {
            double s = 0;
            for (int i = 0; i < 0; i++)
            {
                s += 1 / Facto(i);
            }
            return s;
        }
        private double Facto(int n)
        {
            double aux = 1;

            for (int i = 2; i <=n; i++)
            {
                aux *= i;
            }
            return aux;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Calcular();
        }
    }
}
