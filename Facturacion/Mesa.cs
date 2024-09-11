using System;
using System.Collections.Generic;

namespace Facturacion
{
    public class Mesa
    {
        private int Numero { get; set; }
        private List<Producto> Productos { get; set; } = new List<Producto>();

        public int GetNumero() => Numero;
        public void SetNumero(int numero) => Numero = numero;

        public void AgregarProducto(Producto producto) => Productos.Add(producto);

        public void EliminarProducto(int idProducto)
        {
            Producto? producto = Productos.Find(p => p.GetId() == idProducto);
            if (producto != null)
            {
                Productos.Remove(producto);
                Console.WriteLine("Producto eliminado de la mesa.");
            }
            else
            {
                Console.WriteLine("Producto no encontrado en la mesa.");
            }
        }

        public decimal ObtenerTotal()
        {
            decimal total = 0;
            foreach (var producto in Productos)
            {
                total += producto.GetPrecio();
            }
            return total;
        }

        public void ImprimirCuenta()
        {
            Console.WriteLine($"Cuenta para la mesa {Numero}:");
            foreach (var producto in Productos)
            {
                Console.WriteLine(producto.ToString());
            }
            Console.WriteLine($"Total: ${ObtenerTotal()}");
        }
    }
}