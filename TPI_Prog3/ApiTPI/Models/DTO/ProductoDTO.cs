using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DTO
{
    public class ProductoDTO
    {
        public int IdProducto { get; set; }
        public string TituloProducto { get; set; } = string.Empty;
        public int PrecioProducto { get; set;}
        public string TalleProducto { get; set; }
    }
}
