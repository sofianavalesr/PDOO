// Namespace que agrupa todas las clases relacionadas con la facturación
namespace Facturacion
{
    // Importamos las bibliotecas necesarias
    using System;
    using System.Collections.Generic;

    // Definimos la clase Restaurante, que gestiona las mesas y el menú de un restaurante
    public class Restaurante
    {
        // Propiedad privada que almacena el menú del restaurante
        private Menu menu;

        // Lista privada que contiene las mesas del restaurante
        private List<Mesa> mesas;

        // Constructor de la clase Restaurante
        public Restaurante()
        {
            // Inicializamos el menú y la lista de mesas
            menu = new Menu();
            mesas = new List<Mesa>();

            // Agregamos productos predeterminados al menú
            menu.AgregarProducto(new Producto(1, "Hamburguesa", 8.99m));
            menu.AgregarProducto(new Producto(2, "Pizza", 12.99m));
            menu.AgregarProducto(new Producto(3, "Ensalada", 6.50m));
            menu.AgregarProducto(new Producto(4, "Soda", 2.00m));

            // Inicializamos 10 mesas, asignando números consecutivos a cada una
            for (int i = 1; i <= 10; i++)
            {
                Mesa mesa = new Mesa();     // Creamos una nueva mesa
                mesa.SetNumero(i);          // Asignamos un número a la mesa
                mesas.Add(mesa);            // Añadimos la mesa a la lista de mesas
            }
        }

        // Método para imprimir el menú del restaurante
        public void ImprimirMenu()
        {
            menu.ImprimirMenu();  // Llama al método ImprimirMenu de la clase Menu
        }

        // Método para agregar un producto a una mesa
        public void AgregarProductoAMesa(int numeroMesa, int idProducto)
        {
            // Busca la mesa por su número
            Mesa? mesa = mesas.Find(m => m.GetNumero() == numeroMesa);
            // Busca el producto por su ID en el menú
            Producto? producto = menu.BuscarProductoPorId(idProducto);

            // Si la mesa y el producto existen, los agrega
            if (mesa != null && producto != null)
            {
                mesa.AgregarProducto(producto);  // Agrega el producto a la mesa
                Console.WriteLine("Producto agregado a la mesa.");  // Mensaje de confirmación
            }
            else
            {
                // Si no se encuentra la mesa o el producto, muestra el mensaje correspondiente
                Console.WriteLine(mesa == null ? "Mesa no encontrada." : "Producto no encontrado.");
            }
        }

        // Método para editar los productos de una mesa (agregar o eliminar)
        public void EditarProductosMesa(int numeroMesa, int opcion, int idProducto)
        {
            // Busca la mesa por su número
            Mesa? mesa = mesas.Find(m => m.GetNumero() == numeroMesa);

            if (mesa != null)
            {
                if (opcion == 1) // Agregar producto
                {
                    // Busca el producto en el menú
                    Producto? producto = menu.BuscarProductoPorId(idProducto);
                    if (producto != null)
                    {
                        mesa.AgregarProducto(producto);  // Agrega el producto a la mesa
                        Console.WriteLine("Producto agregado a la mesa.");
                    }
                    else
                    {
                        Console.WriteLine("Producto no encontrado.");
                    }
                }
                else if (opcion == 2) // Eliminar producto
                {
                    // Elimina el producto de la mesa
                    mesa.EliminarProducto(idProducto);
                }
            }
            else
            {
                Console.WriteLine("Mesa no encontrada.");  // Mensaje si no se encuentra la mesa
            }
        }

        // Método para editar el menú (agregar un producto nuevo o editar uno existente)
        public void EditarMenu(int id, string nombre, decimal precio, bool esNuevoProducto)
        {
            if (esNuevoProducto)
            {
                // Si es un nuevo producto, lo agrega al menú
                menu.AgregarProducto(new Producto(id, nombre, precio));
            }
            else
            {
                // Si no, edita un producto existente en el menú
                menu.EditarProducto(id, nombre, precio);
            }
        }

        // Método para imprimir la cuenta de una mesa específica
        public void ImprimirCuentaMesa(int numeroMesa)
        {
            // Busca la mesa por su número
            Mesa? mesa = mesas.Find(m => m.GetNumero() == numeroMesa);
            if (mesa != null)
            {
                mesa.ImprimirCuenta();  // Imprime la cuenta de la mesa
            }
            else
            {
                Console.WriteLine("Mesa no encontrada.");  // Mensaje si no se encuentra la mesa
            }
        }

        // Método para buscar un producto por su ID en el menú
        public Producto? BuscarProductoPorId(int id)
        {
            return menu.BuscarProductoPorId(id);  // Llama al método correspondiente en la clase Menu
        }
    }
}
