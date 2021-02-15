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
    public partial class ConsultarVendedores : Form
    {
        private ArrayList los_vendedores;
        private int contador;

        public ConsultarVendedores()
        {
            InitializeComponent();
        }

        public ConsultarVendedores(ArrayList v)
        {
            InitializeComponent();
            los_vendedores = v;
            contador = 0;
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConsultarVendedores_Load(object sender, EventArgs e)
        {
            Vendedor v;
            v = (Vendedor)los_vendedores[contador];
            textBox1.Text = v.obtenerNombre();
            textBox2.Text = v.obtenerApellidos();
            textBox3.Text = v.obtenerDNI().ToString();
            textBox4.Text = v.obtenerDisponibilidad();

            if (v.obtenerFinesDeSemana())
            {
                //Si entro aqui es porque dicha variable es true
                checkfinesdesemana.Checked = true; // Para indicar que tiene eso a true;
            }
            else
            {
                //Si entro aqui es porque la variable es false
                checkfinesdesemana.Checked = false; //Para indicar que no tiene fines de semana
            }

            if (v.obtenerFestivos())
            {
                checkfestivos.Checked = true;
            }
            else
            {
                checkfestivos.Checked = false;
            }

            if (v.obtenerVacaciones())
            {
                checkvacaciones.Checked = true;
            }
            else
            {
                checkvacaciones.Checked = false;
            }
            pictureBox1.Image = v.obtenerImagen();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            

        }

        private void btnsiguiente_Click(object sender, EventArgs e)
        {
            contador++;
            if(contador < los_vendedores.Count) //////IMPORTANTE///////// Te sobra el igual recuerda que va siempre 1 por delante y tu te quedas 1 por detras
            {
                Vendedor v;
                v = (Vendedor)los_vendedores[contador];
                textBox1.Text = v.obtenerNombre();
                textBox2.Text = v.obtenerApellidos();
                textBox3.Text = v.obtenerDNI();
                textBox4.Text = v.obtenerDisponibilidad();
                pictureBox1.Image = v.obtenerImagen();

               if(v.obtenerFinesDeSemana() == true)
                {
                    checkfinesdesemana.Checked = true;
                }

               if(v.obtenerFestivos() == true)
                {
                    checkfestivos.Checked = true;
                }

               if (v.obtenerVacaciones() == true)
                {
                    checkfestivos.Checked = true;
                }
            }
            else
            {
                MessageBox.Show("Ha llegado al final de los vendedores");
            }



        }

        private void btnanterior_Click(object sender, EventArgs e)
        {
            contador--;
            if (contador >= 0) // NO SE Q PASA  <//////////////////////////////////////////////
            {
                Vendedor v;
                v = (Vendedor)los_vendedores[contador];
                textBox1.Text = v.obtenerNombre();
                textBox2.Text = v.obtenerApellidos();
                textBox3.Text = v.obtenerDNI();
                textBox4.Text = v.obtenerDisponibilidad();
                pictureBox1.Image = v.obtenerImagen();

                if (v.obtenerFinesDeSemana() == true)
                {
                    checkfinesdesemana.Checked = true;
                }

                if (v.obtenerFestivos() == true)
                {
                    checkfestivos.Checked = true;
                }

                if (v.obtenerVacaciones() == true)
                {
                    checkfestivos.Checked = true;
                }
            }
            else
            {
                MessageBox.Show("Ha llegado al inicio de los vendedores");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
