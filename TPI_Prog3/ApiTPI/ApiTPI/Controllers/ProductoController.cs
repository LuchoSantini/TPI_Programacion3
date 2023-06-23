using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model.ViewModel;
using Models.DTO;

namespace ApiTPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        
        [HttpGet("GetListadoProductos")]
        public ActionResult<List<ProductoDTO>> GetListadoProductos()
        {
            return new List<ProductoDTO>
            {
                new ProductoDTO {IdProducto=1, Nombre="Remera", PrecioUnitario=2000},
                new ProductoDTO {IdProducto=2, Nombre="Pantalon",  PrecioUnitario=15000}
            };
        }

        [HttpGet("GetProductos/{id}")]
        public ActionResult<ProductoDTO> GetProductoById(int id)
        { 
            // falta agregar la response y el servicio
            return Ok();
        }

        [HttpPost("PostProducto")]
        public ActionResult<ProductoDTO> PostProducto([FromBody] ProductoViewModel producto)
        {
            return Ok(); // agregar logica de la database
        }

        [HttpPut("PutProducto/{id}")]
        public ActionResult<ProductoDTO> PutProducto(int id, [FromBody] ProductoViewModel producto)
        {
            return Ok();
        }


        [HttpDelete("DeleteProducto/{id}")]
        public ActionResult<ProductoDTO> DeleteProducto(int id)
        {
            return Ok();
        }

    }
}
