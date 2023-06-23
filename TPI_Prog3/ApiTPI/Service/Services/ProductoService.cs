using Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class ProductoService
    {
        // Get: Devolvemos una lista
        public List<ProductoDTO> GetListadoProductos()
        {
            var listadoProductos = new List<ProductoDTO>();

            for (int i = 0; i < 4; i++)
            {
                listadoProductos.Add(new ProductoDTO()
                {
                    IdProducto = i,
                    TituloProducto = "Remera",
                    PrecioProducto = 500,
                    TalleProducto = "M",
                });
            }
            return listadoProductos;
        }

        // Get: Devolvemos un objeto
        public ProductoDTO GetProductoById(int id)
        {
            var listadoProductos = new List<ProductoDTO>();

            for (int i = 0; i < 4; i++)
            {
                listadoProductos.Add(new ProductoDTO()
                {
                    IdProducto = i,
                    TituloProducto = "Remera",
                    PrecioProducto = 500,
                    TalleProducto = "M",
                });
            }

            ProductoDTO producto = listadoProductos.Where(x => x.IdProducto == id).First();
            return producto;
        }

        // Post:

        public ProductoDTO CreateProducto(ProductoDTO producto) // Recibe ProductoDTO porque vamos a necesitar los atributos para crear el nuevo objeto.
        {
            var listadoProductos = new List<ProductoDTO>();

            for (int i = 0; i < 4; i++)
            {
                listadoProductos.Add(new ProductoDTO()
                {
                    IdProducto = i,
                    TituloProducto = "Remera",
                    PrecioProducto = 500,
                    TalleProducto = "M",
                });
            }

            listadoProductos.Add(producto);

            return producto;
        }

        public List<ProductoDTO> ModifyProducto(int id, ProductoDTO producto) // Recibe ProductoDTO porque vamos a necesitar los atributos para crear el nuevo objeto.
        {
            var listadoProductos = new List<ProductoDTO>();

            for (int i = 0; i < 4; i++)
            {
                listadoProductos.Add(new ProductoDTO()
                {
                    IdProducto = i,
                    TituloProducto = "Remera",
                    PrecioProducto = 500,
                    TalleProducto = "M",
                });
            }

            // De mi "base de datos" hago un where, el id que le mando que coincida con el que esta en la db y a ese objeto le mando los nuevos valores.
            var productoAModificar = listadoProductos.Where(x => x.IdProducto == id).First();
            productoAModificar.IdProducto = producto.IdProducto;
            productoAModificar.TituloProducto = producto.TituloProducto;
            productoAModificar.PrecioProducto = producto.PrecioProducto;
            productoAModificar.TalleProducto = producto.TalleProducto;

            // Devuelvo una lista con los productos modificados. No creo un nuevo objeto, devuelvo la lista modificada
            return listadoProductos;
        }

        public List<ProductoDTO> DeleteProducto(int id) // Tomamos el id por header y lo borramos.
        {
            var listadoProductos = new List<ProductoDTO>();

            for (int i = 0; i < 4; i++)
            {
                listadoProductos.Add(new ProductoDTO()
                {
                    IdProducto = i,
                    TituloProducto = "Remera",
                    PrecioProducto = 500,
                    TalleProducto = "M",
                });
            }

            var productoAEliminar = listadoProductos.Where(x => x.IdProducto == id).First();
            listadoProductos.Remove(productoAEliminar);

            return listadoProductos;
        }
    }
}
