using System;
using System.Collections.Generic;

namespace Facturacion
{
    public class Menu
    {
<<<<<<< HEAD
        // Lista pública que almacena los productos del menú
        public List<Producto> Productos { get; set; } = new List<Producto>();

        // Método para imprimir todos los productos del menú
        public void ImprimirMenu()
        {
            Console.WriteLine("Menú del restaurante:");
            
            // Recorre la lista de productos y los imprime uno por uno
=======
        public List<Producto> Productos { get; set; } = new List<Producto>();

        public void ImprimirMenu()
        {
            Console.WriteLine("Menú del restaurante:");
>>>>>>> bd75e6fbb514c55cb43ba695d9542b3fef315c6f
            foreach (var producto in Productos)
            {
                Console.WriteLine(producto.ToString());
            }
        }

<<<<<<< HEAD
        // Método para agregar un nuevo producto al menú
        public void AgregarProducto(Producto producto, bool mostrarMensaje = true)
        {
            // Verifica si ya existe un producto con el mismo ID
=======
        public void AgregarProducto(Producto producto, bool mostrarMensaje = true)
        {
>>>>>>> bd75e6fbb514c55cb43ba695d9542b3fef315c6f
            if (Productos.Exists(p => p.GetId() == producto.GetId()))
            {
                Console.WriteLine("El ID ya está en uso, elija otro.");
            }
            else
            {
<<<<<<< HEAD
                // Agrega el nuevo producto a la lista
=======
>>>>>>> bd75e6fbb514c55cb43ba695d9542b3fef315c6f
                Productos.Add(producto);
                if (mostrarMensaje)
                {
                    Console.WriteLine("Producto agregado al menú.");
                }
            }
        }

<<<<<<< HEAD
        // Método para editar un producto existente en el menú
        public void EditarProducto(int id, string nuevoNombre, decimal nuevoPrecio)
        {
            // Busca el producto en la lista por su ID
            Producto? producto = Productos.Find(p => p.GetId() == id);
            
            if (producto != null)
            {
                // Si el producto es encontrado, actualiza su nombre y precio
                // (actualización no implementada en el código actual)
=======
        public void EditarProducto(int id, string nuevoNombre, decimal nuevoPrecio)
        {
            Producto? producto = Productos.Find(p => p.GetId() == id);
            if (producto != null)
            {
>>>>>>> bd75e6fbb514c55cb43ba695d9542b3fef315c6f
                Console.WriteLine("Producto editado en el menú.");
            }
            else
            {
<<<<<<< HEAD
                // Si el producto no es encontrado, muestra un mensaje de error
=======
>>>>>>> bd75e6fbb514c55cb43ba695d9542b3fef315c6f
                Console.WriteLine("Producto no encontrado.");
            }
        }

<<<<<<< HEAD
        // Método para buscar un producto en el menú por su ID
=======
>>>>>>> bd75e6fbb514c55cb43ba695d9542b3fef315c6f
        public Producto? BuscarProductoPorId(int id) => Productos.Find(p => p.GetId() == id);
    }
}