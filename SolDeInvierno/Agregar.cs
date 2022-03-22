using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolDeInvierno
{
    public partial class Agregar : Form
    {
        public Agregar()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 frm = new Form1();
            frm.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Agregar_Load(object sender, EventArgs e)
        {
          
          
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            Productos productos = new Productos();
            productos.Name =txtnombre.Text;
            productos.catego= txtCatego.Text;
            productos.tama= txtTama.Text;
            productos.precio =float.Parse(txtprecio.Text);
            productos.color= txtColor.Text;

           int resultado=ProductosDAL.Agregar(productos);

            if(resultado>0)
            {
                MessageBox.Show("Datos Guardados Correctamente", "Datos Guardados",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Datos No Guardados", "Datos No Guardados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
