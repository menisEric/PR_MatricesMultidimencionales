using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prArrayVector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCargarVector_Click(object sender, EventArgs e)
        {
            int[] notas = new int[5];

            notas[0] = 15;
            notas[1] = 18;
            notas[2] = 13;
            notas[3] = 16;
            notas[4] = 11;

            int suma = 0;
            double promedio;

            cboNotas.Items.Clear();
            for(int i=0; i<=4; i++)
            {
                cboNotas.Items.Add(notas[i]);
                suma += notas[i];
            }
            promedio = suma / 5;

            txtPormedio.Text = Convert.ToString(promedio);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtPormedio.Clear();
            cboNotas.Items.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
