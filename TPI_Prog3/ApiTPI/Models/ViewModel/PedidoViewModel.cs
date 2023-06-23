using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ViewModel
{
    public class PedidoViewModel
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public decimal Precio { get; set; }
        public int IdProducto { get; set; }
    }
}
