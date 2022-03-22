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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Agregar agregar1=new Agregar();
            agregar1.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Modificar modificar1=new Modificar();
            modificar1.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Eliminar eliminar1=new Eliminar();
            eliminar1.Show();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Consultar consultar1=new Consultar();
                consultar1.Show();
        }
    }
}
