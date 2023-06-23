using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO
{
    public class PedidoDTO
    {
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public decimal Precio { get; set; }
        public int IdProducto { get; set; }


    }
}
