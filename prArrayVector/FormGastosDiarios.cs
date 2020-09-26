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
    public partial class FormGastosDiarios : Form
    {
        public FormGastosDiarios()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            double[] vGastos;
            double gasto, totalGasto, diaMayor, gastoMayor;
            int cantDias;

            totalGasto = 0;
            diaMayor = 1;
            gastoMayor = 0;

            cantDias = Convert.ToInt32(txtCdDias.Text);
            vGastos = new double[cantDias];

            for (int dia = 1; dia <= cantDias; dia++)
            {
                gasto = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Ingrese el gasto del dia " + dia, "Gastos"));
                vGastos[dia - 1] = gasto;

            }
            for (int i = 0; i < cantDias; i++)
            {
                if(vGastos[i]>gastoMayor)
                {
                    gastoMayor = vGastos[i];
                    diaMayor = i + 1;
                }
                totalGasto = totalGasto + vGastos[i];

                cobGastos.Items.Add("Dia " + (i + 1) + " Total:" + vGastos[i]);
            }

            txtgastoMayor.Text = Convert.ToString(gastoMayor);
            txtDiaMayor.Text = Convert.ToString(diaMayor);
            txtTotaldGastos.Text = Convert.ToString(totalGasto);
                
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtTotaldGastos.Clear();
            txtgastoMayor.Clear();
            txtDiaMayor.Clear();
            txtCdDias.Clear();
            cobGastos.Items.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
