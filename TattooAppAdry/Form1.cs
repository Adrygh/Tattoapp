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
    public partial class Form1 : Form
    {


        private ArrayList vendedores;

        public Form1()
        {
            InitializeComponent();
            vendedores = new ArrayList();
        }

        private void insertarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertarVendedor iv = new InsertarVendedor(vendedores);
            iv.ShowDialog();

           // foreach(Vendedor a in vendedores)
           // {
               // MessageBox.Show(a.obtenerNombre() + " " + a.obtenerApellidos()); muestra en un mensaje por pantalla los datos de los vendedores
          //  }

        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (vendedores.Count == 0)
            {
                MessageBox.Show("No hay vendedores para consultar. Debe insertarlos primero");
            }
            else
            {
                ConsultarVendedores cv = new ConsultarVendedores(vendedores);
                cv.ShowDialog();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void anilladorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarVendedor mv = new ModificarVendedor(vendedores);
            mv.ShowDialog();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarVendedor ev = new EliminarVendedor(vendedores);
            ev.ShowDialog();
        }
    }
}
