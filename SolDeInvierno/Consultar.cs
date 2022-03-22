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
    public partial class Consultar : Form
    {
        public Consultar()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 frm = new Form1();
            frm.Show();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
           dataGridView1.DataSource= ProductosDAL.BuscarProducto(Convert.ToInt32(txtid.Text));

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void Consultar_Load(object sender, EventArgs e)
        {
     

        }
    }
}

