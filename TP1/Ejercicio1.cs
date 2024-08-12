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
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            string nuevoNombre = txtNombre.Text.ToLower().Trim();


            foreach (string nombre in lbNombres1.Items)
            {
                if (nombre.ToLower().Trim() == nuevoNombre)
                {
                    MessageBox.Show("No se pueden ingresar nombres repetidos");
                    return;
                }
            }

            if (txtNombre.Text == "")
            {
                MessageBox.Show("Debe ingresar un nombre");
            }
            else
            {
                lbNombres1.Items.Add(txtNombre.Text);
                txtNombre.Text = "";
            }
        }

        private void lbNombres1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (lbNombres1.SelectedItems.Count > 0)
            {
                // Crea una lista temporal para almacenar los elementos seleccionados
                List<object> itemsToMove = new List<object>();

                // Agrega los elementos seleccionados a la lista temporal
                foreach (var item in lbNombres1.SelectedItems)
                {
                    itemsToMove.Add(item);
                }

                // Mueve los elementos de la lista temporal a listBox2
                foreach (var item in itemsToMove)
                {
                    lbNombres2.Items.Add(item);
                    lbNombres1.Items.Remove(item);
                }
            }
            else
            {
                MessageBox.Show("Selecciona al menos un elemento para mover.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (lbNombres1.Items.Count > 0)
            {
                // Crea una lista temporal para almacenar todos los elementos
                List<object> itemsToMove = new List<object>();

                // Agrega todos los elementos de listBox1 a la lista temporal
                foreach (var item in lbNombres1.Items)
                {
                    itemsToMove.Add(item);
                }

                // Mueve los elementos de la lista temporal a listBox2
                foreach (var item in itemsToMove)
                {
                    lbNombres2.Items.Add(item);
                    lbNombres1.Items.Remove(item);
                }
            }
            else
            {
                MessageBox.Show("No hay elementos para mover.");
            }
        }
    }
}
