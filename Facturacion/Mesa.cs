using System;
using System.Collections.Generic;

namespace Facturacion
{
    public class Mesa
    {
<<<<<<< HEAD
        // Propiedades privadas de la clase Mesa
        private int Numero { get; set; } // Número de la mesa (propiedad privada)
        private List<Producto> Productos { get; set; } = new List<Producto>(); // Lista de productos en la mesa (inicializada como una lista vacía)

        // Método para obtener el número de la mesa
        public int GetNumero() => Numero;

        // Método para establecer el número de la mesa
        public void SetNumero(int numero) => Numero = numero;

        // Método para agregar un producto a la lista de productos de la mesa
        public void AgregarProducto(Producto producto) => Productos.Add(producto);

        // Método para eliminar un producto de la lista de productos de la mesa por su ID
        public void EliminarProducto(int idProducto)
        {
            // Busca el producto en la lista usando el ID
            Producto? producto = Productos.Find(p => p.GetId() == idProducto);
            
            // Si el producto es encontrado, lo elimina de la lista y muestra un mensaje
=======
        private int Numero { get; set; }
        private List<Producto> Productos { get; set; } = new List<Producto>();

        public int GetNumero() => Numero;
        public void SetNumero(int numero) => Numero = numero;

        public void AgregarProducto(Producto producto) => Productos.Add(producto);

        public void EliminarProducto(int idProducto)
        {
            Producto? producto = Productos.Find(p => p.GetId() == idProducto);
>>>>>>> bd75e6fbb514c55cb43ba695d9542b3fef315c6f
            if (producto != null)
            {
                Productos.Remove(producto);
                Console.WriteLine("Producto eliminado de la mesa.");
            }
            else
            {
<<<<<<< HEAD
                // Si el producto no es encontrado, muestra un mensaje de error
=======
>>>>>>> bd75e6fbb514c55cb43ba695d9542b3fef315c6f
                Console.WriteLine("Producto no encontrado en la mesa.");
            }
        }

        public decimal ObtenerTotal()
        {
<<<<<<< HEAD
            decimal total = 0; // Inicializa el total en 0
            
            // Recorre cada producto en la lista y suma su precio al total
=======
            decimal total = 0;
>>>>>>> bd75e6fbb514c55cb43ba695d9542b3fef315c6f
            foreach (var producto in Productos)
            {
                total += producto.GetPrecio();
            }
<<<<<<< HEAD
            
            // Devuelve el total calculado
=======
>>>>>>> bd75e6fbb514c55cb43ba695d9542b3fef315c6f
            return total;
        }

        public void ImprimirCuenta()
        {
            Console.WriteLine($"Cuenta para la mesa {Numero}:");
<<<<<<< HEAD
            
            // Recorre la lista de productos y los imprime
=======
>>>>>>> bd75e6fbb514c55cb43ba695d9542b3fef315c6f
            foreach (var producto in Productos)
            {
                Console.WriteLine(producto.ToString());
            }
<<<<<<< HEAD
            
            // Imprime el total final de la cuenta
=======
>>>>>>> bd75e6fbb514c55cb43ba695d9542b3fef315c6f
            Console.WriteLine($"Total: ${ObtenerTotal()}");
        }
    }
}