// Namespace que agrupa todas las clases relacionadas con la facturación
namespace Facturacion
{
    // Importamos las bibliotecas necesarias
    using System;
    using System.Collections.Generic;

    // Definimos la clase Mesa, que representa una mesa en un restaurante u otro negocio similar
    public class Mesa
    {
        // Propiedad privada para almacenar el número de la mesa
        private int Numero { get; set; }

        // Lista privada para almacenar los productos asociados a la mesa
        private List<Producto> Productos { get; set; } = new List<Producto>();

        // Método para agregar un producto a la lista de productos de la mesa
        public void AgregarProducto(Producto producto)
        {
            Productos.Add(producto);  // Agrega el producto a la lista
        }
        
        // Método para obtener el número de la mesa
        public int GetNumero()
        {
            return Numero;  // Devuelve el número de la mesa
        }
        
        // Método para establecer el número de la mesa
        public void SetNumero(int numero)
        {
            Numero = numero;  // Asigna el número de la mesa
        }

        // Método para eliminar un producto de la mesa usando su ID
        public void EliminarProducto(int idProducto)
        {
            // Busca el producto en la lista de productos de la mesa por su ID
            Producto? producto = Productos.Find(p => p.GetId() == idProducto);

            // Si el producto existe, lo elimina de la lista
            if (producto != null)
            {
                Productos.Remove(producto);
                Console.WriteLine("Producto eliminado de la mesa.");  // Mensaje de confirmación
            }
            else
            {
                // Si no se encuentra el producto, se muestra un mensaje de error
                Console.WriteLine("Producto no encontrado en la mesa.");
            }
        }

        // Método para calcular el total de los precios de los productos en la mesa
        public decimal ObtenerTotal()
        {
            decimal total = 0;  // Variable para almacenar el total

            // Recorre cada producto en la lista y suma su precio al total
            foreach (var producto in Productos)
            {
                total += producto.GetPrecio();  // Suma el precio del producto
            }

            // Devuelve el total de la cuenta
            return total;
        }

        // Método para imprimir la cuenta de la mesa
        public void ImprimirCuenta()
        {
            // Imprime el encabezado con el número de la mesa
            Console.WriteLine($"Cuenta para la mesa {Numero}:");

            // Recorre la lista de productos y los imprime uno por uno
            foreach (var producto in Productos)
            {
                Console.WriteLine(producto.ToString());  // Llama al método ToString() de Producto
            }

            // Imprime el total final de la cuenta
            Console.WriteLine($"Total: ${ObtenerTotal()}");
        }
    }
}
