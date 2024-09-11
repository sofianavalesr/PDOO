namespace Facturacion;

// Program.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        Restaurante restaurante = new Restaurante();
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("1. Imprimir menú del restaurante");
            Console.WriteLine("2. Agregar productos a una mesa");
            Console.WriteLine("3. Editar productos de una mesa");
            Console.WriteLine("4. Editar el menú del restaurante");
            Console.WriteLine("5. Imprimir la cuenta de la mesa");
            Console.WriteLine("6. Buscar productos por ID");
            Console.WriteLine("7. Salir");
            Console.Write("Seleccione una opción: ");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    restaurante.ImprimirMenu();
                    break;

                case 2:
                    Console.Write("Ingrese el número de la mesa: ");
                    int numeroMesa = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese el ID del producto que desea agregar: ");
                    int idProducto = int.Parse(Console.ReadLine());
                    restaurante.AgregarProductoAMesa(numeroMesa, idProducto);
                    break;

                case 3:
                    Console.Write("Ingrese el número de la mesa: ");
                    numeroMesa = int.Parse(Console.ReadLine());
                    Console.WriteLine("1. Agregar producto");
                    Console.WriteLine("2. Eliminar producto");
                    int opcionEditarMesa = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese el ID del producto: ");
                    idProducto = int.Parse(Console.ReadLine());
                    restaurante.EditarProductosMesa(numeroMesa, opcionEditarMesa, idProducto);
                    break;

                case 4:
                    Console.WriteLine("1. Agregar nuevo producto");
                    Console.WriteLine("2. Editar producto existente");
                    int opcionEditarMenu = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese el ID del producto: ");
                    int idMenu = int.Parse(Console.ReadLine());
                    Console.Write("Ingrese el nombre del producto: ");
                    string nombre = Console.ReadLine();
                    Console.Write("Ingrese el precio del producto: ");
                    decimal precio = decimal.Parse(Console.ReadLine());
                    restaurante.EditarMenu(idMenu, nombre, precio, opcionEditarMenu == 1);
                    break;

                case 5:
                    Console.Write("Ingrese el número de la mesa: ");
                    numeroMesa = int.Parse(Console.ReadLine());
                    restaurante.ImprimirCuentaMesa(numeroMesa);
                    break;

                case 6:
                    Console.Write("Ingrese el ID del producto que desea buscar: ");
                    int idBuscar = int.Parse(Console.ReadLine());
                    Producto producto = restaurante.BuscarProductoPorId(idBuscar);
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

            Console.WriteLine();
        }
    }
}
