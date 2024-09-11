using System;

namespace Facturacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Restaurante restaurante = new Restaurante();
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("\n===== Menú del Programa =====");
                Console.WriteLine("1. Imprimir menú del restaurante");
                Console.WriteLine("2. Agregar nuevo producto al menú del restaurante");
                Console.WriteLine("3. Agregar producto a una mesa");
                Console.WriteLine("4. Editar productos de una mesa");
                Console.WriteLine("5. Imprimir cuenta de una mesa");
                Console.WriteLine("6. Buscar producto por ID");
                Console.WriteLine("0. Salir");
                Console.WriteLine("=============================");
                Console.Write("Seleccione una opción: ");

                string? opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        restaurante.ImprimirMenu();
                        break;

                    case "2":
                        Console.Write("Ingrese el ID del producto: ");
                        int nuevoId = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese el nombre del producto: ");
                        string? nuevoNombre = Console.ReadLine();
                        Console.Write("Ingrese el precio del producto: ");
                        decimal nuevoPrecio = decimal.Parse(Console.ReadLine());
                        restaurante.EditarMenu(nuevoId, nuevoNombre, nuevoPrecio, true);
                        break;

                    case "3":
                        Console.Write("Ingrese el número de la mesa: ");
                        int numMesaAgregar = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese el ID del producto que desea agregar: ");
                        int idProductoAgregar = int.Parse(Console.ReadLine());
                        restaurante.AgregarProductoAMesa(numMesaAgregar, idProductoAgregar);
                        break;

                    case "4":
                        Console.Write("Ingrese el número de la mesa: ");
                        int numMesaEditar = int.Parse(Console.ReadLine());
                        Console.Write("¿Qué desea hacer? (1-Agregar, 2-Eliminar): ");
                        int opcionEdicion = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese el ID del producto: ");
                        int idProductoEditar = int.Parse(Console.ReadLine());
                        restaurante.EditarProductosMesa(numMesaEditar, opcionEdicion, idProductoEditar);
                        break;

                    case "5":
                        Console.Write("Ingrese el número de la mesa: ");
                        int numMesaCuenta = int.Parse(Console.ReadLine());
                        restaurante.ImprimirCuentaMesa(numMesaCuenta);
                        break;

                    case "6":
                        Console.Write("Ingrese el ID del producto: ");
                        int idProductoBuscar = int.Parse(Console.ReadLine());
                        Producto? producto = restaurante.BuscarProductoPorId(idProductoBuscar);
                        if (producto != null)
                        {
                            Console.WriteLine(producto.ToString());
                        }
                        else
                        {
                            Console.WriteLine("Producto no encontrado.");
                        }
                        break;

                    case "0":
                        continuar = false;
                        break;

                    default:
                        Console.WriteLine("Opción inválida. Inténtelo de nuevo.");
                        break;
                }
            }
        }
    }
}