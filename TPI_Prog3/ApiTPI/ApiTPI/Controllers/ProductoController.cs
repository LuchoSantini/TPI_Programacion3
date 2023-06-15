using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.DTO;
using Service.Services;

namespace ApiTPI.Controllers
{
    // Si dejamos por defecto [controller] lo que va a hacer es tomar por defecto el nombre de ProductoController sin Controller
    
    [Route("api/[controller]")]
    [ApiController]
    // ControladorProducto/GetListadoProductos, asi se accede al metodo
    // La capa API hace referencia a la capa modelo porque necesito poner el tipo de producto que voy a devolver

    public class ProductoController : ControllerBase
    {
        // readonly es de solo lectura, es decir se puede modificar su valor al momento de declararlas o dentro del constructor.
        // Inyeccion de dependencias.
        // Tomamos productoService y se la asignamos a nuestro servicio _productoService
        // Esto se hace para no instanciar un objeto de tipo producto cada vez que lo necesitemos

        // Se hace con un framework la inyeccion de dependencias

        //private readonly ProductoService _productoService;

        //public ProductoController(ProductoService productoService)
        //{
        //    _productoService = productoService;
        //}

        // Se hace con un framework la inyeccion de dependencias


        private readonly ProductoService _productoService = new ProductoService();

        public ProductoController()
        {
            
        }

        [HttpGet("GetListadoProductos")]
        // Geteamos el listado de productos

        // Creamos instancia de la clase Producto service para acceder al metodo GetListadoProductos
        // Siempre tiene que haber referencia de uno a otro, sino hay referencia circular
        public ActionResult<List<ProductoDTO>> GetProductos()
        {
            //var producto = new ProductoService();
            var response = _productoService.GetListadoProductos();
            
            // Ok = statuscode 200
            return Ok(response);
        }

        [HttpGet("GetProductoById/{id}")]
        public ActionResult<ProductoDTO> GetProductoById(int id)
        {
            //var producto = new ProductoService();
            var response = _productoService.GetProductoById(id);

            return Ok(response);
        }

        [HttpPost("PostProducto")]
        public ActionResult<ProductoDTO> CreateProducto([FromBody] ProductoDTO producto) // Por body (chequear postman) enviamos un producto que va a tener sus atributos.
        {
            //var producto = new ProductoService();
            var response = _productoService.CreateProducto(producto);
            return Ok(response);
        }

        [HttpPut("PutProducto/{id}")] // Recibimos el id por Header y por body el producto que vamos a modificar. Se puede pasar mas de un atributo por header.
        public ActionResult<List<ProductoDTO>> ModifyProducto(int id, [FromBody] ProductoDTO producto) // Por body (chequear postman) enviamos un producto que va a tener sus atributos.
        {
            //var producto = new ProductoService();
            var response = _productoService.ModifyProducto(id, producto);
            return Ok(response);
        }

        [HttpDelete("DeleteProducto/{id}")] // Recibimos el id por Header.
        public ActionResult<ProductoDTO> DeleteProducto(int id)
        {
            //var producto = new ProductoService();
            var response = _productoService.DeleteProducto(id);
            return Ok(response);
        }

    }
}
