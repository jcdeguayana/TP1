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
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombreCompleto = $"{txtNombre.Text.Trim()} {txtApellido.Text.Trim()}".ToLower();

            foreach (string nombre in lbElementos.Items)
            {
                if (nombre.ToLower().Trim() == nombreCompleto)
                {
                    MessageBox.Show("No se pueden ingresar nombres repetidos");
                    return;
                }
            }

            if (txtNombre.Text == "" || txtApellido.Text == "")
            {
                MessageBox.Show("Debe completar los campos");
            }
            else
            {
                lbElementos.Items.Add($"{txtNombre.Text.Trim()} {txtApellido.Text.Trim()}");
                OrdenarListBox(lbElementos);
                txtNombre.Text = "";
                txtApellido.Text = "";
            }
        }

        private void OrdenarListBox(ListBox listBox)
        {
            List<string> items = listBox.Items.Cast<string>().ToList();
            items.Sort();
            listBox.Items.Clear();
            foreach (string item in items)
            {
                listBox.Items.Add(item);
            }
        }

        private void lbElementos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (lbElementos.SelectedItem != null)
            {
                lbElementos.Items.Remove(lbElementos.SelectedItem);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un elemento para borrar.");
            }
        }
    }
}
