using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prMatrizMultidimencional
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnVender.Enabled = false;
            txtPrecio.Enabled = false;
            txtDisponible.Enabled = false;
        }

        private String[,] mPlatos;
        private int cantPlatos;
        private int index;
        private int encuentra = 0;
        private void btnCargar_Click(object sender, EventArgs e)
        {
            cantPlatos = Convert.ToInt32(txtCP.Text);

            mPlatos = new string[cantPlatos, 3];

            for(int i = 0; i < cantPlatos; i++)
            {
                mPlatos[i, 0] = Microsoft.VisualBasic.Interaction.InputBox("Ingrese nombre del plato" + (i+1), "RESTAURANTE");
                mPlatos[i, 1] = Microsoft.VisualBasic.Interaction.InputBox("Ingrese precio del plato" + (i + 1), "RESTAURANTE");
                mPlatos[i, 2] = Microsoft.VisualBasic.Interaction.InputBox("Ingrese stock del plato" + (i + 1), "RESTAURANTE");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string plato;

            plato = txtPlato.Text;

            for(int i = 0; i < cantPlatos; i++)
            {
                if(mPlatos[i,0].Equals(plato))
                {
                    txtPrecio.Text = mPlatos[i, 1];
                    txtDisponible.Text = mPlatos[i, 2];
                    index = i;
                    btnVender.Enabled = true;
                    encuentra = 1;
                }
            }
            if (encuentra == 0)
            {
                MessageBox.Show("No existe el plato", "Restaurante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnVender.Enabled = false;
            }
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            int cant, stock;

            cant = Convert.ToInt32(txtCantidad.Text);
            stock = Convert.ToInt32(txtDisponible.Text);
            if (cant <= stock)
            {
                mPlatos[index,2]= Convert.ToString(stock-cant);   
            }
            else
            {
                MessageBox.Show("No hay suficiente stock", "Restaurante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
