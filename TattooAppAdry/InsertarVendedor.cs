using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TattooAppAdry
{
    public partial class InsertarVendedor : Form
    {
        private ArrayList los_vendedores;

        public InsertarVendedor(ArrayList v)
        {
            InitializeComponent();
            los_vendedores = v;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            Vendedor un_vendedor = new Vendedor();
            un_vendedor.asignarNombre(textBox1.Text);
            un_vendedor.asignarApellidos(textBox2.Text);
            un_vendedor.asignarDNI(textBox3.Text);
            un_vendedor.asignarDisponibilidad(textBox4.Text);
            un_vendedor.asignarImagen(pictureBox1.Image);
            if (checkfindesemana.Checked == true)
            {
                un_vendedor.asignarFinesDeSemana(true);
            }
            if (checkfestivos.Checked == true)
            {
                un_vendedor.asignarFestivos(true);
            }
            if (checkvacaciones.Checked == true)
            {
                un_vendedor.asignarVacaciones(true);
            }
           
            if (los_vendedores.Count != 0)
            {
                bool encontrado = false;
                int contador = 0;
                Vendedor uno;
                while (!encontrado && contador < los_vendedores.Count)
                {
                    uno = (Vendedor)los_vendedores[contador];
                    if (uno.obtenerDNI().ToString() == textBox1.Text)
                    {
                        //Ya esta insertado.
                        encontrado = true;
                    }
                    else
                    {
                        contador++;
                    }
                }
                if (!encontrado)
                {
                    los_vendedores.Add(un_vendedor);
                    MessageBox.Show("Vendedor insertado con exito");
                }
                else
                {
                    MessageBox.Show("Vendedor ya insertador");
                }
            }
            else
            {
                //Como no hay datos en el array directamente lo almaceno sin consultar.
                los_vendedores.Add(un_vendedor);
                MessageBox.Show("Vendedor insertado con exito");
            }

            this.Close();
        }

        private void cargarImagen_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName.Length != 0)
            {
                //Significa que el usuario a introducido un nombre de  UN fichero
                pictureBox1.ImageLocation = openFileDialog1.FileName;
            }
        }
    }
}
