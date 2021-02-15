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
    public partial class ModificarVendedor : Form
    {

        private ArrayList lista_vendedores;
        private bool modificado = false;


        public ModificarVendedor()
        {
            InitializeComponent();
        }
        public ModificarVendedor(ArrayList v)
        {
            InitializeComponent();
            lista_vendedores = v;
            bool modificado = false;

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void ModificarVendedor_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
           /// textBox3.Enabled = false; este es por el que queremos que busquen por el dni
            textBox4.Enabled = false;
            checkfinesdesemana.Enabled = false;
            checkfestivos.Enabled = false;
            checkvacaciones.Enabled = false;
            pictureBox1.Visible = false;
            btncargarImagen.Enabled = false;

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            bool encontrado = false;
            int contador = 0;
            int indice = 0;

            if (textBox3.Text.Length != 0)
            {
                foreach(Vendedor v in lista_vendedores)
                {
                    if (v.obtenerDNI() == (textBox3.Text))
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
                    textBox1.Enabled = true;
                    textBox2.Enabled = true;
                    textBox3.Enabled = false; 
                    textBox4.Enabled = true;
                    checkfinesdesemana.Enabled = true;
                    checkfestivos.Enabled = true;
                    checkvacaciones.Enabled = true;
                    pictureBox1.Visible = true;
                    btncargarImagen.Enabled = true;
                    btnbuscar.Visible = false;

                    Vendedor v;
                    v = (Vendedor)lista_vendedores[indice];
                    textBox3.Enabled = false;
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
                    MessageBox.Show("El DNI ingresado no existe.");
                }

            }
            else
            {
                MessageBox.Show("Primero debe introducir el DNI");
            }

        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            if (!modificado)
            {
                this.Close();
            }
            else
            {
                int contador = 0;
                int indice = 0;
                foreach(Vendedor v in lista_vendedores)
                {
                    if(v.obtenerDNI() == textBox3.Text)
                    {
                        indice = contador;
                    }
                    else
                    {
                        contador++;
                    }
                }
                lista_vendedores.RemoveAt(indice);
                Vendedor un_vendedor_modificado = new Vendedor(0,textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, pictureBox1.Image, checkfinesdesemana.Checked, checkfestivos.Checked, checkvacaciones.Checked);
                lista_vendedores.Insert(indice, un_vendedor_modificado);
                MessageBox.Show(" Vendedor modificado correctamente");
                this.Close();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            modificado = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            modificado = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            modificado = true;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            modificado = true;
        }

        private void checkfinesdesemana_CheckedChanged(object sender, EventArgs e)
        {
            modificado = true;
        }

        private void checkfestivos_CheckedChanged(object sender, EventArgs e)
        {
            modificado = true;
        }

        private void checkvacaciones_CheckedChanged(object sender, EventArgs e)
        {
            modificado = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
