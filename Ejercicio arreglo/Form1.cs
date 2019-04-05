using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_arreglo
{
    public partial class Form1 : Form
    {
        CArreglo objarreglo = new CArreglo();
        CAlumno objalumno = null; 
        public Form1()
        {
            InitializeComponent();
        }

        private void lblCodigo_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            int ncursos = Convert.ToInt32(txtBoxCursos.Text);
            string carrera = comboBox1.Text;
            int cod = Convert.ToInt32(txtBoxCodigo.Text);
            string nom = txtBoxNombre.Text;
            objalumno = new CAlumno(ncursos, carrera, cod, nom);
            objarreglo.Insertar(objalumno);
            listBox1.Items.Add(objalumno.Informacion());
            txtBoxCodigo.Clear();
            txtBoxNombre.Clear();
            txtBoxCursos.Clear();
            comboBox1.SelectedIndex = -1;
            txtBoxCodigo.Focus();
        }

        private void btnCodigo_Click(object sender, EventArgs e)
        {
            if (txtBoxCodigo.Text != "")
            {
                objalumno = objarreglo.Buscar_por_codigo(Convert.ToInt32(txtBoxCodigo.Text));
                if (objalumno != null)
                    MessageBox.Show(objalumno.Nombre);
            }
        }

        private void btnCarrera_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            { int cantidadxcarrera = objarreglo.Contar_por_carrera(comboBox1.Text);
                MessageBox.Show(cantidadxcarrera.ToString());

                }
            
        }
    }
}
