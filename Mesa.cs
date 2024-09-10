namespace Facturacion;
class Mesa
    {
        private int numero;
        private List<Producto> productos { get; set; } 
        public Mesa(){
           productos = new List<Producto>(); 
        }

        public void AgregarProducto(Producto producto)
        {
            productos.Add(producto);
        }

        public void EliminarProducto(int idProducto)
        {
            Producto producto = productos.Find(p => p.Id == idProducto);
            if (producto != null)
            {
                productos.Remove(producto);
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
            foreach (var producto in productos)
            {
                total += producto.Precio;
            }
            return total;
        }

        public void ImprimirCuenta()
        {
            Console.WriteLine($"Cuenta para la mesa {Numero}:");
            foreach (var producto in productos)
            {
                Console.WriteLine(producto.ToString());
            }
            Console.WriteLine($"Total: ${ObtenerTotal()}");
        }
    }