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

    public partial class EliminarVendedor : Form
    {
        private ArrayList mis_vendedores;


        public EliminarVendedor()
        {
            InitializeComponent();
        }
        public EliminarVendedor(ArrayList v)
        {
            InitializeComponent();
            mis_vendedores = v;
        }

        private void EliminarVendedor_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox4.Enabled = false;
            checkfinesdesemana.Enabled = false;
            checkfestivos.Enabled = false;
            checkvacaciones.Enabled = false;
            pictureBox1.Enabled = false;
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            bool encontrado = false;
            int contador = 0;
            int indice = 0;
            if (textBox3DNI.Text.Length != 0)    // significa que el usuario metio algun dato
            {
            foreach (Vendedor v in mis_vendedores)
                {
                    if(v.obtenerDNI() == textBox3DNI.Text)
                    {
                        encontrado = true;
                        indice = contador;
                    }
                    else
                    {
                        contador++;
                    }
                }
                if (encontrado)
                {
                    Vendedor v = (Vendedor)mis_vendedores[indice];
                    textBox1.Text = v.obtenerNombre();
                    textBox2.Text = v.obtenerApellidos();
                    textBox4.Text = v.obtenerDisponibilidad();
                    pictureBox1.Image = v.obtenerImagen();
                    checkfinesdesemana.Checked = v.obtenerFinesDeSemana();
                    checkfestivos.Checked = v.obtenerFestivos();
                    checkvacaciones.Checked = v.obtenerVacaciones();

                }
                else
                {
                    MessageBox.Show("El DNI del vendedor no existe");
                }

            }
            else
            {
                MessageBox.Show("Debes introducir el DNI en el campo correspondiente");
            }
               
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea eliminar el vendedor?", "Mensaje de Advertencia", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int contador = 0;
                int indice = 0;
                foreach( Vendedor v in mis_vendedores)
                {
                    if(v.obtenerDNI() == textBox3DNI.Text)
                    {
                        indice = contador;
                    }
                    else
                    {
                        contador++;
                    }
                }
                mis_vendedores.RemoveAt(indice);
                MessageBox.Show("Vendedor eliminado con exito");
                this.Close();

            }
        }
    }
}
