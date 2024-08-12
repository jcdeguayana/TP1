using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1
{
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbFemenino.Checked)
            {
                lblSexo.Text = "Femenino";
            }
            else
            {
                lblSexo.Text = "Masculino";
            }

            if (rbCasado.Checked)
            {
                lblEstadoCivil.Text = "Casado";
            }
            else
            {
                lblEstadoCivil.Text = "Soltero";
            }

            string oficiosSeleccionados = " ";

            // Recorrer los elementos seleccionados del CheckedListBox
            foreach (string item in cblOficios.CheckedItems)
            {
                oficiosSeleccionados += "- " + item + "\n ";
            }

            // Mostrar los oficios seleccionados en el Label
            lblOficios.Text = oficiosSeleccionados;
        }

        private void Ejercicio3_Load(object sender, EventArgs e)
        {

        }
    }
}
