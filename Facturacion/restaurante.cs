using System;
using System.Collections.Generic;

namespace Facturacion
{
    public class Restaurante
    {
<<<<<<< HEAD
        private Menu menu; // Instancia de la clase Menu que representa el menú del restaurante
        private List<Mesa> mesas; // Lista de instancias de la clase Mesa, representa todas las mesas en el restaurante
=======
        private Menu menu;
        private List<Mesa> mesas;
>>>>>>> bd75e6fbb514c55cb43ba695d9542b3fef315c6f

        public Restaurante()
        {
<<<<<<< HEAD
            // Inicializa el menú y las mesas
            menu = new Menu();
            mesas = new List<Mesa>();

            // Agrega productos iniciales al menú
=======
            menu = new Menu();
            mesas = new List<Mesa>();

>>>>>>> bd75e6fbb514c55cb43ba695d9542b3fef315c6f
            menu.AgregarProducto(new Producto(1, "Hamburguesa", 8.99m), false);
            menu.AgregarProducto(new Producto(2, "Pizza", 12.99m), false);
            menu.AgregarProducto(new Producto(3, "Ensalada", 6.50m), false);
            menu.AgregarProducto(new Producto(4, "Soda", 2.00m), false);

<<<<<<< HEAD
            // Inicializa las mesas numeradas del 1 al 10
            for (int i = 1; i <= 10; i++)
            {
                Mesa mesa = new Mesa();
                mesa.SetNumero(i); // Establece el número de la mesa
                mesas.Add(mesa); // Agrega la mesa a la lista de mesas
            }
        }

        // Método para imprimir el menú del restaurante
        public void ImprimirMenu() => menu.ImprimirMenu();

        // Método para agregar un producto a una mesa específica
=======
            for (int i = 1; i <= 10; i++)
            {
                Mesa mesa = new Mesa();
                mesa.SetNumero(i);
                mesas.Add(mesa);
            }
        }

        public void ImprimirMenu() => menu.ImprimirMenu();

>>>>>>> bd75e6fbb514c55cb43ba695d9542b3fef315c6f
        public void AgregarProductoAMesa(int numeroMesa, int idProducto)
        {
            Mesa? mesa = mesas.Find(m => m.GetNumero() == numeroMesa);
            Producto? producto = menu.BuscarProductoPorId(idProducto);

            if (mesa != null && producto != null)
            {
<<<<<<< HEAD
                // Si se encuentran tanto la mesa como el producto, agrega el producto a la mesa
=======
>>>>>>> bd75e6fbb514c55cb43ba695d9542b3fef315c6f
                mesa.AgregarProducto(producto);
                Console.WriteLine("Producto agregado a la mesa.");
            }
            else
            {
<<<<<<< HEAD
                // Muestra un mensaje de error si no se encuentra la mesa o el producto
=======
>>>>>>> bd75e6fbb514c55cb43ba695d9542b3fef315c6f
                Console.WriteLine(mesa == null ? "Mesa no encontrada." : "Producto no encontrado.");
            }
        }

<<<<<<< HEAD
        // Método para editar los productos en una mesa
=======
>>>>>>> bd75e6fbb514c55cb43ba695d9542b3fef315c6f
        public void EditarProductosMesa(int numeroMesa, int opcion, int idProducto)
        {
            Mesa? mesa = mesas.Find(m => m.GetNumero() == numeroMesa);
            if (mesa != null)
            {
<<<<<<< HEAD
                // Si la opción es 1, agrega el producto a la mesa
=======
>>>>>>> bd75e6fbb514c55cb43ba695d9542b3fef315c6f
                if (opcion == 1)
                {
                    Producto? producto = menu.BuscarProductoPorId(idProducto);
                    if (producto != null)
                    {
                        mesa.AgregarProducto(producto);
                        Console.WriteLine("Producto agregado a la mesa.");
                    }
                    else
                    {
                        Console.WriteLine("Producto no encontrado.");
                    }
                }
<<<<<<< HEAD
                // Si la opción es 2, elimina el producto de la mesa
=======
>>>>>>> bd75e6fbb514c55cb43ba695d9542b3fef315c6f
                else if (opcion == 2)
                {
                    mesa.EliminarProducto(idProducto);
                }
            }
            else
            {
                Console.WriteLine("Mesa no encontrada.");
            }
        }

<<<<<<< HEAD
        // Método para agregar o editar un producto en el menú
=======
>>>>>>> bd75e6fbb514c55cb43ba695d9542b3fef315c6f
        public void EditarMenu(int id, string nombre, decimal precio, bool esNuevoProducto)
        {
            if (esNuevoProducto)
            {
                menu.AgregarProducto(new Producto(id, nombre, precio));
            }
            else
            {
<<<<<<< HEAD
                // Si es un producto existente, lo edita en el menú
=======
>>>>>>> bd75e6fbb514c55cb43ba695d9542b3fef315c6f
                menu.EditarProducto(id, nombre, precio);
            }
        }

        public void ImprimirCuentaMesa(int numeroMesa)
        {
            Mesa? mesa = mesas.Find(m => m.GetNumero() == numeroMesa);
            if (mesa != null)
            {
<<<<<<< HEAD
                // Imprime la cuenta de la mesa
=======
>>>>>>> bd75e6fbb514c55cb43ba695d9542b3fef315c6f
                mesa.ImprimirCuenta();
            }
            else
            {
                Console.WriteLine("Mesa no encontrada.");
            }
        }

<<<<<<< HEAD
        // Método para buscar un producto en el menú por su ID
=======
>>>>>>> bd75e6fbb514c55cb43ba695d9542b3fef315c6f
        public Producto? BuscarProductoPorId(int id) => menu.BuscarProductoPorId(id);
    }
}