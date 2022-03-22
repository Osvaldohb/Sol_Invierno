using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolDeInvierno
{
    public class Productos
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string catego { get; set; }
        public string color { get; set; }
        public string tama { get; set; }
        public float precio { get; set; }

        public Productos() { }
        public Productos(int pId, string pNombre, string pCatego, string pColor, string pTama, float pPrecio)
        {
           this.Id = pId;
            this.Name = pNombre;
             this.catego = pCatego;
            this.color = pColor;
            this.tama = pTama;
            this.precio = pPrecio;
        }
    }
}
