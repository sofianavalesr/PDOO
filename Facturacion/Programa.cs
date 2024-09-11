namespace Facturacion;
// Programa.cs
using System;

class Programa
{
    static void Main(string[] args)
    {
        Restaurante restaurante = new Restaurante();
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("1. Imprimir menú del restaurante");
            Console.WriteLine("2. Agregar producto a una mesa");
            Console.WriteLine("3. Editar productos de una mesa (agregar/eliminar)");
            Console.WriteLine("4. Editar menú del restaurante");
            Console.WriteLine("5. Imprimir cuenta de una mesa");
            Console.WriteLine("6. Buscar producto por ID");
            Console.WriteLine("7. Salir");
            Console.Write("Elija una opción: ");
            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    restaurante.ImprimirMenu();
                    break;

                case 2:
                    Console.Write("Número de mesa: ");
                    int numeroMesa = Convert.ToInt32(Console.ReadLine());
                    Console.Write("ID del producto: ");
                    int idProducto = Convert.ToInt32(Console.ReadLine());
                    restaurante.AgregarProductoAMesa(numeroMesa, idProducto);
                    break;

                case 3:
                    Console.Write("Número de mesa: ");
                    numeroMesa = Convert.ToInt32(Console.ReadLine());
                    Console.Write("¿Desea agregar o eliminar un producto? (1: Agregar, 2: Eliminar): ");
                    int opcionEditar = Convert.ToInt32(Console.ReadLine());
                    Console.Write("ID del producto: ");
                    idProducto = Convert.ToInt32(Console.ReadLine());
                    restaurante.EditarProductosMesa(numeroMesa, opcionEditar, idProducto);
                    break;

                case 4:
                    Console.Write("ID del producto en el menú: ");
                    int idMenu = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Nombre del producto: ");
                    string? nombre = Console.ReadLine();
                    Console.Write("Precio del producto: ");
                    decimal precio = Convert.ToDecimal(Console.ReadLine());
                    Console.Write("¿Desea agregar un nuevo producto o editar uno existente? (1: Agregar, 2: Editar): ");
                    int opcionEditarMenu = Convert.ToInt32(Console.ReadLine());

                    if (!string.IsNullOrEmpty(nombre))
                    {
                        restaurante.EditarMenu(idMenu, nombre, precio, opcionEditarMenu == 1);
                    }
                    else
                    {
                        Console.WriteLine("El nombre no puede ser nulo o vacío.");
                    }
                    break;

                case 5:
                    Console.Write("Número de mesa: ");
                    numeroMesa = Convert.ToInt32(Console.ReadLine());
                    restaurante.ImprimirCuentaMesa(numeroMesa);
                    break;

                case 6:
                    Console.Write("ID del producto a buscar: ");
                    int idBuscar = Convert.ToInt32(Console.ReadLine());
                    Producto? producto = restaurante.BuscarProductoPorId(idBuscar);

                    if (producto != null)
                    {
                        Console.WriteLine(producto.ToString());
                    }
                    else
                    {
                        Console.WriteLine("Producto no encontrado.");
                    }
                    break;

                case 7:
                    continuar = false;
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }
}